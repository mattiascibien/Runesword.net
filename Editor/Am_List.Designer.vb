<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmList
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'This form is an MDI child.
		'This code simulates the VB6 
		' functionality of automatically
		' loading and showing an MDI
		' child's parent.
		Me.MDIParent = rsCreator.frmMDI
		rsCreator.frmMDI.Show
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents mnuListOpen As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListSave As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuList As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDataFilesCopy As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDataFilesCheck As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDataFiles As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents btnCheckIfExist As System.Windows.Forms.Button
	Public WithEvents btnOpen As System.Windows.Forms.Button
	Public WithEvents btnCopyFilesToFolder As System.Windows.Forms.Button
	Public WithEvents btnExit As System.Windows.Forms.Button
	Public WithEvents btnSave As System.Windows.Forms.Button
	Public WithEvents lstList As System.Windows.Forms.ListBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmList))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuList = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuListOpen = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuListSave = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuDataFiles = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuDataFilesCopy = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuDataFilesCheck = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem
		Me.btnCheckIfExist = New System.Windows.Forms.Button
		Me.btnOpen = New System.Windows.Forms.Button
		Me.btnCopyFilesToFolder = New System.Windows.Forms.Button
		Me.btnExit = New System.Windows.Forms.Button
		Me.btnSave = New System.Windows.Forms.Button
		Me.lstList = New System.Windows.Forms.ListBox
		Me.MainMenu1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "List of Data files"
		Me.ClientSize = New System.Drawing.Size(319, 402)
		Me.Location = New System.Drawing.Point(10, 29)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmList"
		Me.mnuList.Name = "mnuList"
		Me.mnuList.Text = "List"
		Me.mnuList.Checked = False
		Me.mnuList.Enabled = True
		Me.mnuList.Visible = True
		Me.mnuListOpen.Name = "mnuListOpen"
		Me.mnuListOpen.Text = "Open"
		Me.mnuListOpen.Checked = False
		Me.mnuListOpen.Enabled = True
		Me.mnuListOpen.Visible = True
		Me.mnuListSave.Name = "mnuListSave"
		Me.mnuListSave.Text = "Save"
		Me.mnuListSave.Checked = False
		Me.mnuListSave.Enabled = True
		Me.mnuListSave.Visible = True
		Me.mnuDataFiles.Name = "mnuDataFiles"
		Me.mnuDataFiles.Text = "Data Files"
		Me.mnuDataFiles.Checked = False
		Me.mnuDataFiles.Enabled = True
		Me.mnuDataFiles.Visible = True
		Me.mnuDataFilesCopy.Name = "mnuDataFilesCopy"
		Me.mnuDataFilesCopy.Text = "Copy files in tome folder"
		Me.mnuDataFilesCopy.Checked = False
		Me.mnuDataFilesCopy.Enabled = True
		Me.mnuDataFilesCopy.Visible = True
		Me.mnuDataFilesCheck.Name = "mnuDataFilesCheck"
		Me.mnuDataFilesCheck.Text = "Check availability of files"
		Me.mnuDataFilesCheck.Checked = False
		Me.mnuDataFilesCheck.Enabled = True
		Me.mnuDataFilesCheck.Visible = True
		Me.mnuQuit.Name = "mnuQuit"
		Me.mnuQuit.Text = "Return to Creator"
		Me.mnuQuit.Checked = False
		Me.mnuQuit.Enabled = True
		Me.mnuQuit.Visible = True
		Me.btnCheckIfExist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCheckIfExist.Text = "Check files existence"
		Me.btnCheckIfExist.Size = New System.Drawing.Size(113, 33)
		Me.btnCheckIfExist.Location = New System.Drawing.Point(128, 368)
		Me.btnCheckIfExist.TabIndex = 5
		Me.btnCheckIfExist.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCheckIfExist.BackColor = System.Drawing.SystemColors.Control
		Me.btnCheckIfExist.CausesValidation = True
		Me.btnCheckIfExist.Enabled = True
		Me.btnCheckIfExist.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCheckIfExist.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCheckIfExist.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCheckIfExist.TabStop = True
		Me.btnCheckIfExist.Name = "btnCheckIfExist"
		Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnOpen.Text = "Open saved list"
		Me.btnOpen.Size = New System.Drawing.Size(113, 33)
		Me.btnOpen.Location = New System.Drawing.Point(8, 368)
		Me.btnOpen.TabIndex = 4
		Me.btnOpen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOpen.BackColor = System.Drawing.SystemColors.Control
		Me.btnOpen.CausesValidation = True
		Me.btnOpen.Enabled = True
		Me.btnOpen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOpen.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOpen.TabStop = True
		Me.btnOpen.Name = "btnOpen"
		Me.btnCopyFilesToFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCopyFilesToFolder.Text = "Copy files into folder"
		Me.btnCopyFilesToFolder.Size = New System.Drawing.Size(113, 33)
		Me.btnCopyFilesToFolder.Location = New System.Drawing.Point(128, 328)
		Me.btnCopyFilesToFolder.TabIndex = 3
		Me.btnCopyFilesToFolder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCopyFilesToFolder.BackColor = System.Drawing.SystemColors.Control
		Me.btnCopyFilesToFolder.CausesValidation = True
		Me.btnCopyFilesToFolder.Enabled = True
		Me.btnCopyFilesToFolder.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCopyFilesToFolder.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCopyFilesToFolder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCopyFilesToFolder.TabStop = True
		Me.btnCopyFilesToFolder.Name = "btnCopyFilesToFolder"
		Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnExit.Text = "Exit"
		Me.btnExit.Size = New System.Drawing.Size(65, 73)
		Me.btnExit.Location = New System.Drawing.Point(248, 328)
		Me.btnExit.TabIndex = 2
		Me.btnExit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.BackColor = System.Drawing.SystemColors.Control
		Me.btnExit.CausesValidation = True
		Me.btnExit.Enabled = True
		Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnExit.TabStop = True
		Me.btnExit.Name = "btnExit"
		Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnSave.Text = "Save list to file"
		Me.btnSave.Size = New System.Drawing.Size(113, 33)
		Me.btnSave.Location = New System.Drawing.Point(8, 328)
		Me.btnSave.TabIndex = 1
		Me.btnSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.BackColor = System.Drawing.SystemColors.Control
		Me.btnSave.CausesValidation = True
		Me.btnSave.Enabled = True
		Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSave.TabStop = True
		Me.btnSave.Name = "btnSave"
		Me.lstList.Size = New System.Drawing.Size(305, 280)
		Me.lstList.Location = New System.Drawing.Point(8, 32)
		Me.lstList.Sorted = True
		Me.lstList.TabIndex = 0
		Me.lstList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstList.BackColor = System.Drawing.SystemColors.Window
		Me.lstList.CausesValidation = True
		Me.lstList.Enabled = True
		Me.lstList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstList.IntegralHeight = True
		Me.lstList.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstList.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstList.TabStop = True
		Me.lstList.Visible = True
		Me.lstList.MultiColumn = False
		Me.lstList.Name = "lstList"
		Me.Controls.Add(btnCheckIfExist)
		Me.Controls.Add(btnOpen)
		Me.Controls.Add(btnCopyFilesToFolder)
		Me.Controls.Add(btnExit)
		Me.Controls.Add(btnSave)
		Me.Controls.Add(lstList)
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuList, Me.mnuDataFiles, Me.mnuQuit})
		mnuList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuListOpen, Me.mnuListSave})
		mnuDataFiles.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuDataFilesCopy, Me.mnuDataFilesCheck})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class