Imports unoidl.com.sun.star.uno
Imports unoidl.com.sun.star.bridge

Public Module LibreOfficeHelper

#Region " PInvoke for Terminate"

	Private Declare Function CreateToolhelp32Snapshot Lib "KERNEL32.DLL" _
	(ByVal dwFlags As Integer, ByVal th32ProcessID As Integer) As Integer

	Private Declare Function Process32First Lib "KERNEL32.DLL" _
	(ByVal hSnapshot As Integer, ByVal PE As Byte()) As Integer

	Private Declare Function Process32Next Lib "KERNEL32.DLL" _
	(ByVal hSnapshot As Integer, ByVal PE As Byte()) As Integer

	Private Declare Function CloseHandle Lib "KERNEL32.DLL" _
	(ByVal hObject As Integer) As Integer

	Const TH32CS_SNAPPROCESS As Integer = 2
	Const SIZEOF_PROCESSENTRY32 As Integer = 564
	Const SIZE_OFFSET = 0
	Const PROCESS_OFFSET = 8
	Const PARENT_OFFSET = 24

#End Region


	Public Function StartServer(ByVal sofficePath As String, ByVal pipeName As String) As Process
		Dim p As New Process

		With p
			.StartInfo.FileName = sofficePath
			.StartInfo.Arguments = String.Format("-env:UserInstallation=$SYSUSERCONFIG/LibreOfficeServer/pseudoUser1 -accept=""pipe,name={0};urp;StarOffice.ServiceManager"" -nofirststartwizard -norestore -nologo -nodefault -nolockcheck ", pipeName)

			.Start()
		End With

		Return p

	End Function

	Public Sub TerminateServer(ByRef server As Process)
		'@@@ the LibreOffice process also starts a second process, we have to kill them both
		For Each LOBin As Process In Process.GetProcessesByName("soffice.bin")
			If GetParentProcessID(LOBin.Id).Equals(server.Id) Then
				LOBin.Kill()
				server = Nothing
				Exit For
			End If
		Next

	End Sub

	Public Function CanGetRemoteContext(ByVal pipeName As String) As Boolean
		Dim xLocalContext As XComponentContext = uno.util.Bootstrap.defaultBootstrap_InitialComponentContext()
		Dim xURLResolver As XUnoUrlResolver = xLocalContext.getServiceManager().createInstanceWithContext("com.sun.star.bridge.UnoUrlResolver", xLocalContext)
		Dim xRemoteContext As XComponentContext = Nothing

		Try
			xRemoteContext = xURLResolver.resolve("uno:pipe,name=" & pipeName & ";urp;StarOffice.ComponentContext")

		Catch ex As Exception
			Throw

		End Try

		Return True

	End Function



	''' <summary>
	'''  this only works if the application is running in 32 bit mode.
	''' for 64 bit apps it always returns 0
	''' </summary>
	''' <param name="id"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Private Function GetParentProcessID(ByVal id As Integer) As Integer
		Dim b(564 - 1) As Byte
		'write the size into the structure
		BitConverter.GetBytes(SIZEOF_PROCESSENTRY32).CopyTo(b, SIZE_OFFSET)
		Dim h As Integer = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0)
		Try
			Dim rv As Integer = Process32First(h, b)
			If rv <> 1 Then
				Throw New System.Exception("Could not enumerte processes.")
			End If
			While rv = 1
				Dim pid As Integer = BitConverter.ToInt32(b, PROCESS_OFFSET)
				Dim parent As Integer = BitConverter.ToInt32(b, PARENT_OFFSET)
				If pid = id Then
					Return parent
				End If
				rv = Process32Next(h, b)
			End While
		Finally
			CloseHandle(h)
		End Try

		Return -1

	End Function

End Module
