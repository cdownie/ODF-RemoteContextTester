<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btnSetPath = New System.Windows.Forms.Button
		Me.txtPath = New System.Windows.Forms.TextBox
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.btnStop = New System.Windows.Forms.Button
		Me.btnStartServer = New System.Windows.Forms.Button
		Me.txtPipe = New System.Windows.Forms.TextBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.btnTest = New System.Windows.Forms.Button
		Me.lblStatus = New System.Windows.Forms.Label
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnSetPath
		'
		Me.btnSetPath.Location = New System.Drawing.Point(379, 17)
		Me.btnSetPath.Name = "btnSetPath"
		Me.btnSetPath.Size = New System.Drawing.Size(75, 23)
		Me.btnSetPath.TabIndex = 0
		Me.btnSetPath.Text = "Set Path"
		Me.btnSetPath.UseVisualStyleBackColor = True
		'
		'txtPath
		'
		Me.txtPath.Enabled = False
		Me.txtPath.Location = New System.Drawing.Point(77, 19)
		Me.txtPath.Name = "txtPath"
		Me.txtPath.Size = New System.Drawing.Size(296, 20)
		Me.txtPath.TabIndex = 1
		Me.txtPath.Text = "C:\Program Files (x86)\OpenOffice.org 3\program\soffice.exe"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblStatus)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.btnStop)
		Me.GroupBox1.Controls.Add(Me.btnStartServer)
		Me.GroupBox1.Controls.Add(Me.txtPipe)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtPath)
		Me.GroupBox1.Controls.Add(Me.btnSetPath)
		Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(463, 134)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "LibreOffice Server Settings"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.AppWorkspace
		Me.Label3.Location = New System.Drawing.Point(83, 42)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(123, 13)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Local path to soffice.exe"
		'
		'btnStop
		'
		Me.btnStop.Enabled = False
		Me.btnStop.Location = New System.Drawing.Point(158, 105)
		Me.btnStop.Name = "btnStop"
		Me.btnStop.Size = New System.Drawing.Size(75, 23)
		Me.btnStop.TabIndex = 6
		Me.btnStop.Text = "Stop Server"
		Me.btnStop.UseVisualStyleBackColor = True
		'
		'btnStartServer
		'
		Me.btnStartServer.Location = New System.Drawing.Point(77, 105)
		Me.btnStartServer.Name = "btnStartServer"
		Me.btnStartServer.Size = New System.Drawing.Size(75, 23)
		Me.btnStartServer.TabIndex = 5
		Me.btnStartServer.Text = "Start Server"
		Me.btnStartServer.UseVisualStyleBackColor = True
		'
		'txtPipe
		'
		Me.txtPipe.Location = New System.Drawing.Point(77, 72)
		Me.txtPipe.Name = "txtPipe"
		Me.txtPipe.Size = New System.Drawing.Size(296, 20)
		Me.txtPipe.TabIndex = 4
		Me.txtPipe.Text = "namedPipe1"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 75)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(59, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Pipe Name"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(29, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Path"
		'
		'btnTest
		'
		Me.btnTest.Location = New System.Drawing.Point(12, 161)
		Me.btnTest.Name = "btnTest"
		Me.btnTest.Size = New System.Drawing.Size(152, 23)
		Me.btnTest.TabIndex = 3
		Me.btnTest.Text = "Test Connection"
		Me.btnTest.UseVisualStyleBackColor = True
		'
		'lblStatus
		'
		Me.lblStatus.AutoSize = True
		Me.lblStatus.BackColor = System.Drawing.Color.IndianRed
		Me.lblStatus.ForeColor = System.Drawing.Color.Snow
		Me.lblStatus.Location = New System.Drawing.Point(254, 105)
		Me.lblStatus.MinimumSize = New System.Drawing.Size(200, 0)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Padding = New System.Windows.Forms.Padding(4)
		Me.lblStatus.Size = New System.Drawing.Size(200, 21)
		Me.lblStatus.TabIndex = 8
		Me.lblStatus.Text = "Server Stopped"
		Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(488, 196)
		Me.Controls.Add(Me.btnTest)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "frmMain"
		Me.Text = "ODF-RemoteContextTester"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnSetPath As System.Windows.Forms.Button
	Friend WithEvents txtPath As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents txtPipe As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnStartServer As System.Windows.Forms.Button
	Friend WithEvents btnTest As System.Windows.Forms.Button
	Friend WithEvents btnStop As System.Windows.Forms.Button
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
