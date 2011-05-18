Public Class frmMain

	Private _LOServer As Process

	Public Property LOServer() As Process
		Get
			Return _LOServer
		End Get
		Set(ByVal value As Process)
			_LOServer = value
		End Set
	End Property



	Private Sub SetServerStarted()
		lblStatus.Text = "Server Started"
		lblStatus.BackColor = Color.Green

		btnStop.Enabled = True
		btnStartServer.Enabled = False
	End Sub

	Private Sub SetServerStopped()
		lblStatus.Text = "Server Stopped"
		lblStatus.BackColor = Color.IndianRed

		btnStop.Enabled = False
		btnStartServer.Enabled = True
	End Sub


	Private Sub btnSetPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPath.Click

		Using fd As New OpenFileDialog
			With fd
				.Multiselect = False
				.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles()
				.ShowDialog()

				txtPath.Text = .FileName()
			End With
		End Using

		'@@@ need to set this same path, but encoded, in the local ini file.

	End Sub

	Private Sub btnStartServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartServer.Click

		LOServer = LibreOfficeHelper.StartServer(txtPath.Text, txtPipe.Text)
		SetServerStarted()

	End Sub

	Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

		LibreOfficeHelper.TerminateServer(LOServer)
		SetServerStopped()

	End Sub


	Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

		If Not LOServer Is Nothing AndAlso Not LOServer.HasExited Then LibreOfficeHelper.TerminateServer(LOServer)

	End Sub


End Class
