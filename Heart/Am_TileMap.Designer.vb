<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMap
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
		Me.MDIParent = prjHeart.frmMDI
		prjHeart.frmMDI.Show
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
	Public WithEvents _lnCursor_0 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents _lnCursor_1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents _lnCursor_2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents _lnCursor_3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents picMap As System.Windows.Forms.Panel
	Public WithEvents picBox As System.Windows.Forms.Panel
	Public WithEvents tmrLeftRightScroll As System.Windows.Forms.Timer
	Public WithEvents _optTool_9 As System.Windows.Forms.RadioButton
	Public WithEvents btnRedo As System.Windows.Forms.Button
	Public WithEvents btnUndo As System.Windows.Forms.Button
	Public WithEvents _optTool_8 As System.Windows.Forms.RadioButton
	Public WithEvents _optTool_7 As System.Windows.Forms.RadioButton
	Public WithEvents _optTool_6 As System.Windows.Forms.RadioButton
	Public WithEvents _optTool_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optTool_5 As System.Windows.Forms.RadioButton
	Public WithEvents _optTool_4 As System.Windows.Forms.RadioButton
	Public WithEvents _optTool_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optTool_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optTool_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optTileLayer_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optTileLayer_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optTileLayer_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optTileLayer_0 As System.Windows.Forms.RadioButton
	Public WithEvents _chkTileShow_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkTileShow_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkTileShow_0 As System.Windows.Forms.CheckBox
	Public WithEvents Frame3 As System.Windows.Forms.Panel
	Public WithEvents _optBrushSize_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optBrushSize_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optBrushSize_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.Panel
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents vsbTiles As System.Windows.Forms.VScrollBar
	Public WithEvents shpSelect As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents picTiles As System.Windows.Forms.Panel
	Public WithEvents lstEncItems As System.Windows.Forms.CheckedListBox
	Public WithEvents lstEncCreatures As System.Windows.Forms.CheckedListBox
	Public WithEvents cmbTileSet As System.Windows.Forms.ComboBox
	Public WithEvents hsbMap As System.Windows.Forms.HScrollBar
	Public WithEvents btnMap As System.Windows.Forms.Button
	Public WithEvents vsbMap As System.Windows.Forms.VScrollBar
	Public WithEvents cmbEncounters As System.Windows.Forms.ComboBox
	Public WithEvents lblEncItems As System.Windows.Forms.Label
	Public WithEvents lblEncCreatures As System.Windows.Forms.Label
	Public WithEvents chkTileShow As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents lnCursor As LineShapeArray
	Public WithEvents optBrushSize As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optTileLayer As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optTool As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMap))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.picBox = New System.Windows.Forms.Panel
		Me.picMap = New System.Windows.Forms.Panel
		Me._lnCursor_0 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me._lnCursor_1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me._lnCursor_2 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me._lnCursor_3 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.tmrLeftRightScroll = New System.Windows.Forms.Timer(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._optTool_9 = New System.Windows.Forms.RadioButton
		Me.btnRedo = New System.Windows.Forms.Button
		Me.btnUndo = New System.Windows.Forms.Button
		Me._optTool_8 = New System.Windows.Forms.RadioButton
		Me._optTool_7 = New System.Windows.Forms.RadioButton
		Me._optTool_6 = New System.Windows.Forms.RadioButton
		Me._optTool_3 = New System.Windows.Forms.RadioButton
		Me._optTool_5 = New System.Windows.Forms.RadioButton
		Me._optTool_4 = New System.Windows.Forms.RadioButton
		Me._optTool_2 = New System.Windows.Forms.RadioButton
		Me._optTool_1 = New System.Windows.Forms.RadioButton
		Me._optTool_0 = New System.Windows.Forms.RadioButton
		Me.Frame3 = New System.Windows.Forms.Panel
		Me._optTileLayer_3 = New System.Windows.Forms.RadioButton
		Me._optTileLayer_2 = New System.Windows.Forms.RadioButton
		Me._optTileLayer_1 = New System.Windows.Forms.RadioButton
		Me._optTileLayer_0 = New System.Windows.Forms.RadioButton
		Me._chkTileShow_2 = New System.Windows.Forms.CheckBox
		Me._chkTileShow_1 = New System.Windows.Forms.CheckBox
		Me._chkTileShow_0 = New System.Windows.Forms.CheckBox
		Me.Frame2 = New System.Windows.Forms.Panel
		Me._optBrushSize_2 = New System.Windows.Forms.RadioButton
		Me._optBrushSize_1 = New System.Windows.Forms.RadioButton
		Me._optBrushSize_0 = New System.Windows.Forms.RadioButton
		Me.picTiles = New System.Windows.Forms.Panel
		Me.vsbTiles = New System.Windows.Forms.VScrollBar
		Me.shpSelect = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.lstEncItems = New System.Windows.Forms.CheckedListBox
		Me.lstEncCreatures = New System.Windows.Forms.CheckedListBox
		Me.cmbTileSet = New System.Windows.Forms.ComboBox
		Me.hsbMap = New System.Windows.Forms.HScrollBar
		Me.btnMap = New System.Windows.Forms.Button
		Me.vsbMap = New System.Windows.Forms.VScrollBar
		Me.cmbEncounters = New System.Windows.Forms.ComboBox
		Me.lblEncItems = New System.Windows.Forms.Label
		Me.lblEncCreatures = New System.Windows.Forms.Label
		Me.chkTileShow = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.lnCursor = New LineShapeArray(components)
		Me.optBrushSize = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optTileLayer = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optTool = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.picBox.SuspendLayout()
		Me.picMap.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.picTiles.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.chkTileShow, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lnCursor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optBrushSize, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optTileLayer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optTool, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Map"
		Me.ClientSize = New System.Drawing.Size(515, 365)
		Me.Location = New System.Drawing.Point(95, 112)
		Me.KeyPreview = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmMap"
		Me.picBox.Size = New System.Drawing.Size(345, 317)
		Me.picBox.Location = New System.Drawing.Point(126, 3)
		Me.picBox.TabIndex = 36
		Me.picBox.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picBox.Dock = System.Windows.Forms.DockStyle.None
		Me.picBox.BackColor = System.Drawing.SystemColors.Control
		Me.picBox.CausesValidation = True
		Me.picBox.Enabled = True
		Me.picBox.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picBox.Cursor = System.Windows.Forms.Cursors.Default
		Me.picBox.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picBox.TabStop = True
		Me.picBox.Visible = True
		Me.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picBox.Name = "picBox"
		Me.picMap.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.picMap.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picMap.Size = New System.Drawing.Size(800, 600)
		Me.picMap.Location = New System.Drawing.Point(0, 0)
		Me.picMap.TabIndex = 37
		Me.picMap.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picMap.Dock = System.Windows.Forms.DockStyle.None
		Me.picMap.CausesValidation = True
		Me.picMap.Enabled = True
		Me.picMap.Cursor = System.Windows.Forms.Cursors.Default
		Me.picMap.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picMap.TabStop = True
		Me.picMap.Visible = True
		Me.picMap.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picMap.Name = "picMap"
		Me._lnCursor_0.BorderColor = System.Drawing.Color.Yellow
		Me._lnCursor_0.BorderWidth = 2
		Me._lnCursor_0.X1 = 7
		Me._lnCursor_0.X2 = 10
		Me._lnCursor_0.Y1 = 4
		Me._lnCursor_0.Y2 = 2
		Me._lnCursor_0.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._lnCursor_0.Visible = True
		Me._lnCursor_0.Name = "_lnCursor_0"
		Me._lnCursor_1.BorderColor = System.Drawing.Color.Yellow
		Me._lnCursor_1.BorderWidth = 2
		Me._lnCursor_1.X1 = 10
		Me._lnCursor_1.X2 = 14
		Me._lnCursor_1.Y1 = 2
		Me._lnCursor_1.Y2 = 4
		Me._lnCursor_1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._lnCursor_1.Visible = True
		Me._lnCursor_1.Name = "_lnCursor_1"
		Me._lnCursor_2.BorderColor = System.Drawing.Color.Yellow
		Me._lnCursor_2.BorderWidth = 2
		Me._lnCursor_2.X1 = 14
		Me._lnCursor_2.X2 = 10
		Me._lnCursor_2.Y1 = 4
		Me._lnCursor_2.Y2 = 5
		Me._lnCursor_2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._lnCursor_2.Visible = True
		Me._lnCursor_2.Name = "_lnCursor_2"
		Me._lnCursor_3.BorderColor = System.Drawing.Color.Yellow
		Me._lnCursor_3.BorderWidth = 2
		Me._lnCursor_3.X1 = 10
		Me._lnCursor_3.X2 = 7
		Me._lnCursor_3.Y1 = 5
		Me._lnCursor_3.Y2 = 4
		Me._lnCursor_3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._lnCursor_3.Visible = True
		Me._lnCursor_3.Name = "_lnCursor_3"
		Me.tmrLeftRightScroll.Interval = 300
		Me.tmrLeftRightScroll.Enabled = True
		Me.Frame1.Size = New System.Drawing.Size(121, 155)
		Me.Frame1.Location = New System.Drawing.Point(1, -2)
		Me.Frame1.TabIndex = 10
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._optTool_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_9.Enabled = False
		Me._optTool_9.Size = New System.Drawing.Size(25, 25)
		Me._optTool_9.Location = New System.Drawing.Point(62, 124)
		Me._optTool_9.Image = CType(resources.GetObject("_optTool_9.Image"), System.Drawing.Image)
		Me._optTool_9.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_9.TabIndex = 35
		Me._optTool_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_9.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_9.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_9.CausesValidation = True
		Me._optTool_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_9.TabStop = True
		Me._optTool_9.Checked = False
		Me._optTool_9.Visible = True
		Me._optTool_9.Name = "_optTool_9"
		Me.btnRedo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnRedo.Enabled = False
		Me.btnRedo.Size = New System.Drawing.Size(25, 25)
		Me.btnRedo.Location = New System.Drawing.Point(89, 124)
		Me.btnRedo.Image = CType(resources.GetObject("btnRedo.Image"), System.Drawing.Image)
		Me.btnRedo.TabIndex = 27
		Me.ToolTip1.SetToolTip(Me.btnRedo, "Redo")
		Me.btnRedo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRedo.BackColor = System.Drawing.SystemColors.Control
		Me.btnRedo.CausesValidation = True
		Me.btnRedo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnRedo.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnRedo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnRedo.TabStop = True
		Me.btnRedo.Name = "btnRedo"
		Me.btnUndo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnUndo.Enabled = False
		Me.btnUndo.Size = New System.Drawing.Size(25, 25)
		Me.btnUndo.Location = New System.Drawing.Point(33, 124)
		Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
		Me.btnUndo.TabIndex = 26
		Me.ToolTip1.SetToolTip(Me.btnUndo, "Undo")
		Me.btnUndo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUndo.BackColor = System.Drawing.SystemColors.Control
		Me.btnUndo.CausesValidation = True
		Me.btnUndo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnUndo.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnUndo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnUndo.TabStop = True
		Me.btnUndo.Name = "btnUndo"
		Me._optTool_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_8.Size = New System.Drawing.Size(25, 25)
		Me._optTool_8.Location = New System.Drawing.Point(89, 96)
		Me._optTool_8.Image = CType(resources.GetObject("_optTool_8.Image"), System.Drawing.Image)
		Me._optTool_8.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_8.TabIndex = 25
		Me.ToolTip1.SetToolTip(Me._optTool_8, "Hide Tile")
		Me._optTool_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_8.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_8.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_8.CausesValidation = True
		Me._optTool_8.Enabled = True
		Me._optTool_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_8.TabStop = True
		Me._optTool_8.Checked = False
		Me._optTool_8.Visible = True
		Me._optTool_8.Name = "_optTool_8"
		Me._optTool_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_7.Size = New System.Drawing.Size(25, 25)
		Me._optTool_7.Location = New System.Drawing.Point(61, 96)
		Me._optTool_7.Image = CType(resources.GetObject("_optTool_7.Image"), System.Drawing.Image)
		Me._optTool_7.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_7.TabIndex = 24
		Me.ToolTip1.SetToolTip(Me._optTool_7, "Show Tile")
		Me._optTool_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_7.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_7.CausesValidation = True
		Me._optTool_7.Enabled = True
		Me._optTool_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_7.TabStop = True
		Me._optTool_7.Checked = False
		Me._optTool_7.Visible = True
		Me._optTool_7.Name = "_optTool_7"
		Me._optTool_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_6.Size = New System.Drawing.Size(25, 25)
		Me._optTool_6.Location = New System.Drawing.Point(33, 96)
		Me._optTool_6.Image = CType(resources.GetObject("_optTool_6.Image"), System.Drawing.Image)
		Me._optTool_6.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_6.TabIndex = 23
		Me.ToolTip1.SetToolTip(Me._optTool_6, "Zoom Out")
		Me._optTool_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_6.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_6.CausesValidation = True
		Me._optTool_6.Enabled = True
		Me._optTool_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_6.TabStop = True
		Me._optTool_6.Checked = False
		Me._optTool_6.Visible = True
		Me._optTool_6.Name = "_optTool_6"
		Me._optTool_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_3.Size = New System.Drawing.Size(25, 25)
		Me._optTool_3.Location = New System.Drawing.Point(33, 68)
		Me._optTool_3.Image = CType(resources.GetObject("_optTool_3.Image"), System.Drawing.Image)
		Me._optTool_3.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_3.TabIndex = 22
		Me.ToolTip1.SetToolTip(Me._optTool_3, "Zoom In")
		Me._optTool_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_3.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_3.CausesValidation = True
		Me._optTool_3.Enabled = True
		Me._optTool_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_3.TabStop = True
		Me._optTool_3.Checked = False
		Me._optTool_3.Visible = True
		Me._optTool_3.Name = "_optTool_3"
		Me._optTool_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_5.Size = New System.Drawing.Size(25, 25)
		Me._optTool_5.Location = New System.Drawing.Point(89, 68)
		Me._optTool_5.Image = CType(resources.GetObject("_optTool_5.Image"), System.Drawing.Image)
		Me._optTool_5.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_5.TabIndex = 21
		Me._optTool_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_5.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_5.CausesValidation = True
		Me._optTool_5.Enabled = True
		Me._optTool_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_5.TabStop = True
		Me._optTool_5.Checked = False
		Me._optTool_5.Visible = True
		Me._optTool_5.Name = "_optTool_5"
		Me._optTool_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_4.Size = New System.Drawing.Size(25, 25)
		Me._optTool_4.Location = New System.Drawing.Point(61, 68)
		Me._optTool_4.Image = CType(resources.GetObject("_optTool_4.Image"), System.Drawing.Image)
		Me._optTool_4.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_4.TabIndex = 20
		Me.ToolTip1.SetToolTip(Me._optTool_4, "Eye Dropper")
		Me._optTool_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_4.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_4.CausesValidation = True
		Me._optTool_4.Enabled = True
		Me._optTool_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_4.TabStop = True
		Me._optTool_4.Checked = False
		Me._optTool_4.Visible = True
		Me._optTool_4.Name = "_optTool_4"
		Me._optTool_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_2.Size = New System.Drawing.Size(25, 25)
		Me._optTool_2.Location = New System.Drawing.Point(89, 40)
		Me._optTool_2.Image = CType(resources.GetObject("_optTool_2.Image"), System.Drawing.Image)
		Me._optTool_2.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_2.TabIndex = 19
		Me.ToolTip1.SetToolTip(Me._optTool_2, "Erase")
		Me._optTool_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_2.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_2.CausesValidation = True
		Me._optTool_2.Enabled = True
		Me._optTool_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_2.TabStop = True
		Me._optTool_2.Checked = False
		Me._optTool_2.Visible = True
		Me._optTool_2.Name = "_optTool_2"
		Me._optTool_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_1.Size = New System.Drawing.Size(25, 25)
		Me._optTool_1.Location = New System.Drawing.Point(61, 40)
		Me._optTool_1.Image = CType(resources.GetObject("_optTool_1.Image"), System.Drawing.Image)
		Me._optTool_1.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_1.TabIndex = 18
		Me.ToolTip1.SetToolTip(Me._optTool_1, "Fill")
		Me._optTool_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_1.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_1.CausesValidation = True
		Me._optTool_1.Enabled = True
		Me._optTool_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_1.TabStop = True
		Me._optTool_1.Checked = False
		Me._optTool_1.Visible = True
		Me._optTool_1.Name = "_optTool_1"
		Me._optTool_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTool_0.Size = New System.Drawing.Size(25, 25)
		Me._optTool_0.Location = New System.Drawing.Point(33, 40)
		Me._optTool_0.Image = CType(resources.GetObject("_optTool_0.Image"), System.Drawing.Image)
		Me._optTool_0.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTool_0.TabIndex = 17
		Me.ToolTip1.SetToolTip(Me._optTool_0, "Paint")
		Me._optTool_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTool_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTool_0.BackColor = System.Drawing.SystemColors.Control
		Me._optTool_0.CausesValidation = True
		Me._optTool_0.Enabled = True
		Me._optTool_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTool_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTool_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTool_0.TabStop = True
		Me._optTool_0.Checked = False
		Me._optTool_0.Visible = True
		Me._optTool_0.Name = "_optTool_0"
		Me.Frame3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Frame3.Size = New System.Drawing.Size(29, 140)
		Me.Frame3.Location = New System.Drawing.Point(5, 11)
		Me.Frame3.TabIndex = 15
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Name = "Frame3"
		Me._optTileLayer_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTileLayer_3.Size = New System.Drawing.Size(25, 25)
		Me._optTileLayer_3.Location = New System.Drawing.Point(0, 113)
		Me._optTileLayer_3.Image = CType(resources.GetObject("_optTileLayer_3.Image"), System.Drawing.Image)
		Me._optTileLayer_3.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTileLayer_3.TabIndex = 34
		Me.ToolTip1.SetToolTip(Me._optTileLayer_3, "Paint Encounter")
		Me._optTileLayer_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTileLayer_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTileLayer_3.BackColor = System.Drawing.SystemColors.Control
		Me._optTileLayer_3.CausesValidation = True
		Me._optTileLayer_3.Enabled = True
		Me._optTileLayer_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTileLayer_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTileLayer_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTileLayer_3.TabStop = True
		Me._optTileLayer_3.Checked = False
		Me._optTileLayer_3.Visible = True
		Me._optTileLayer_3.Name = "_optTileLayer_3"
		Me._optTileLayer_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTileLayer_2.Size = New System.Drawing.Size(25, 24)
		Me._optTileLayer_2.Location = New System.Drawing.Point(0, 76)
		Me._optTileLayer_2.Image = CType(resources.GetObject("_optTileLayer_2.Image"), System.Drawing.Image)
		Me._optTileLayer_2.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTileLayer_2.TabIndex = 33
		Me.ToolTip1.SetToolTip(Me._optTileLayer_2, "Bottom Layer")
		Me._optTileLayer_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTileLayer_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTileLayer_2.BackColor = System.Drawing.SystemColors.Control
		Me._optTileLayer_2.CausesValidation = True
		Me._optTileLayer_2.Enabled = True
		Me._optTileLayer_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTileLayer_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTileLayer_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTileLayer_2.TabStop = True
		Me._optTileLayer_2.Checked = False
		Me._optTileLayer_2.Visible = True
		Me._optTileLayer_2.Name = "_optTileLayer_2"
		Me._optTileLayer_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTileLayer_1.Size = New System.Drawing.Size(25, 24)
		Me._optTileLayer_1.Location = New System.Drawing.Point(0, 39)
		Me._optTileLayer_1.Image = CType(resources.GetObject("_optTileLayer_1.Image"), System.Drawing.Image)
		Me._optTileLayer_1.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTileLayer_1.TabIndex = 32
		Me.ToolTip1.SetToolTip(Me._optTileLayer_1, "Middle Layer")
		Me._optTileLayer_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTileLayer_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTileLayer_1.BackColor = System.Drawing.SystemColors.Control
		Me._optTileLayer_1.CausesValidation = True
		Me._optTileLayer_1.Enabled = True
		Me._optTileLayer_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTileLayer_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTileLayer_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTileLayer_1.TabStop = True
		Me._optTileLayer_1.Checked = False
		Me._optTileLayer_1.Visible = True
		Me._optTileLayer_1.Name = "_optTileLayer_1"
		Me._optTileLayer_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optTileLayer_0.Size = New System.Drawing.Size(25, 24)
		Me._optTileLayer_0.Location = New System.Drawing.Point(0, 1)
		Me._optTileLayer_0.Image = CType(resources.GetObject("_optTileLayer_0.Image"), System.Drawing.Image)
		Me._optTileLayer_0.Appearance = System.Windows.Forms.Appearance.Button
		Me._optTileLayer_0.TabIndex = 31
		Me.ToolTip1.SetToolTip(Me._optTileLayer_0, "Top Layer")
		Me._optTileLayer_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTileLayer_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTileLayer_0.BackColor = System.Drawing.SystemColors.Control
		Me._optTileLayer_0.CausesValidation = True
		Me._optTileLayer_0.Enabled = True
		Me._optTileLayer_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTileLayer_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTileLayer_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTileLayer_0.TabStop = True
		Me._optTileLayer_0.Checked = False
		Me._optTileLayer_0.Visible = True
		Me._optTileLayer_0.Name = "_optTileLayer_0"
		Me._chkTileShow_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._chkTileShow_2.Size = New System.Drawing.Size(25, 10)
		Me._chkTileShow_2.Location = New System.Drawing.Point(0, 100)
		Me._chkTileShow_2.Image = CType(resources.GetObject("_chkTileShow_2.Image"), System.Drawing.Image)
		Me._chkTileShow_2.Appearance = System.Windows.Forms.Appearance.Button
		Me._chkTileShow_2.TabIndex = 30
		Me.ToolTip1.SetToolTip(Me._chkTileShow_2, "Show Bottom Layer")
		Me._chkTileShow_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkTileShow_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkTileShow_2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkTileShow_2.BackColor = System.Drawing.SystemColors.Control
		Me._chkTileShow_2.Text = ""
		Me._chkTileShow_2.CausesValidation = True
		Me._chkTileShow_2.Enabled = True
		Me._chkTileShow_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkTileShow_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkTileShow_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkTileShow_2.TabStop = True
		Me._chkTileShow_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkTileShow_2.Visible = True
		Me._chkTileShow_2.Name = "_chkTileShow_2"
		Me._chkTileShow_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._chkTileShow_1.Size = New System.Drawing.Size(25, 10)
		Me._chkTileShow_1.Location = New System.Drawing.Point(0, 63)
		Me._chkTileShow_1.Image = CType(resources.GetObject("_chkTileShow_1.Image"), System.Drawing.Image)
		Me._chkTileShow_1.Appearance = System.Windows.Forms.Appearance.Button
		Me._chkTileShow_1.TabIndex = 29
		Me.ToolTip1.SetToolTip(Me._chkTileShow_1, "Show Middle Layer")
		Me._chkTileShow_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkTileShow_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkTileShow_1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkTileShow_1.BackColor = System.Drawing.SystemColors.Control
		Me._chkTileShow_1.Text = ""
		Me._chkTileShow_1.CausesValidation = True
		Me._chkTileShow_1.Enabled = True
		Me._chkTileShow_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkTileShow_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkTileShow_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkTileShow_1.TabStop = True
		Me._chkTileShow_1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkTileShow_1.Visible = True
		Me._chkTileShow_1.Name = "_chkTileShow_1"
		Me._chkTileShow_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._chkTileShow_0.Size = New System.Drawing.Size(25, 10)
		Me._chkTileShow_0.Location = New System.Drawing.Point(0, 25)
		Me._chkTileShow_0.Image = CType(resources.GetObject("_chkTileShow_0.Image"), System.Drawing.Image)
		Me._chkTileShow_0.Appearance = System.Windows.Forms.Appearance.Button
		Me._chkTileShow_0.TabIndex = 28
		Me.ToolTip1.SetToolTip(Me._chkTileShow_0, "Show Top Layer")
		Me._chkTileShow_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkTileShow_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkTileShow_0.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chkTileShow_0.BackColor = System.Drawing.SystemColors.Control
		Me._chkTileShow_0.Text = ""
		Me._chkTileShow_0.CausesValidation = True
		Me._chkTileShow_0.Enabled = True
		Me._chkTileShow_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkTileShow_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkTileShow_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkTileShow_0.TabStop = True
		Me._chkTileShow_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkTileShow_0.Visible = True
		Me._chkTileShow_0.Name = "_chkTileShow_0"
		Me.Frame2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Frame2.Text = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(83, 29)
		Me.Frame2.Location = New System.Drawing.Point(34, 11)
		Me.Frame2.TabIndex = 11
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me._optBrushSize_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optBrushSize_2.Size = New System.Drawing.Size(25, 25)
		Me._optBrushSize_2.Location = New System.Drawing.Point(55, 1)
		Me._optBrushSize_2.Image = CType(resources.GetObject("_optBrushSize_2.Image"), System.Drawing.Image)
		Me._optBrushSize_2.Appearance = System.Windows.Forms.Appearance.Button
		Me._optBrushSize_2.TabIndex = 14
		Me.ToolTip1.SetToolTip(Me._optBrushSize_2, "Large Brush")
		Me._optBrushSize_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optBrushSize_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBrushSize_2.BackColor = System.Drawing.SystemColors.Control
		Me._optBrushSize_2.CausesValidation = True
		Me._optBrushSize_2.Enabled = True
		Me._optBrushSize_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optBrushSize_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optBrushSize_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optBrushSize_2.TabStop = True
		Me._optBrushSize_2.Checked = False
		Me._optBrushSize_2.Visible = True
		Me._optBrushSize_2.Name = "_optBrushSize_2"
		Me._optBrushSize_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optBrushSize_1.Size = New System.Drawing.Size(25, 25)
		Me._optBrushSize_1.Location = New System.Drawing.Point(27, 1)
		Me._optBrushSize_1.Image = CType(resources.GetObject("_optBrushSize_1.Image"), System.Drawing.Image)
		Me._optBrushSize_1.Appearance = System.Windows.Forms.Appearance.Button
		Me._optBrushSize_1.TabIndex = 13
		Me.ToolTip1.SetToolTip(Me._optBrushSize_1, "Medium Brush")
		Me._optBrushSize_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optBrushSize_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBrushSize_1.BackColor = System.Drawing.SystemColors.Control
		Me._optBrushSize_1.CausesValidation = True
		Me._optBrushSize_1.Enabled = True
		Me._optBrushSize_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optBrushSize_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optBrushSize_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optBrushSize_1.TabStop = True
		Me._optBrushSize_1.Checked = False
		Me._optBrushSize_1.Visible = True
		Me._optBrushSize_1.Name = "_optBrushSize_1"
		Me._optBrushSize_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._optBrushSize_0.Size = New System.Drawing.Size(25, 25)
		Me._optBrushSize_0.Location = New System.Drawing.Point(-1, 1)
		Me._optBrushSize_0.Image = CType(resources.GetObject("_optBrushSize_0.Image"), System.Drawing.Image)
		Me._optBrushSize_0.Appearance = System.Windows.Forms.Appearance.Button
		Me._optBrushSize_0.TabIndex = 12
		Me.ToolTip1.SetToolTip(Me._optBrushSize_0, "Small Brush")
		Me._optBrushSize_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optBrushSize_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBrushSize_0.BackColor = System.Drawing.SystemColors.Control
		Me._optBrushSize_0.CausesValidation = True
		Me._optBrushSize_0.Enabled = True
		Me._optBrushSize_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optBrushSize_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optBrushSize_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optBrushSize_0.TabStop = True
		Me._optBrushSize_0.Checked = False
		Me._optBrushSize_0.Visible = True
		Me._optBrushSize_0.Name = "_optBrushSize_0"
		Me.picTiles.Size = New System.Drawing.Size(122, 154)
		Me.picTiles.Location = New System.Drawing.Point(1, 181)
		Me.picTiles.TabIndex = 3
		Me.picTiles.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picTiles.Dock = System.Windows.Forms.DockStyle.None
		Me.picTiles.BackColor = System.Drawing.SystemColors.Control
		Me.picTiles.CausesValidation = True
		Me.picTiles.Enabled = True
		Me.picTiles.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picTiles.Cursor = System.Windows.Forms.Cursors.Default
		Me.picTiles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picTiles.TabStop = True
		Me.picTiles.Visible = True
		Me.picTiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picTiles.Name = "picTiles"
		Me.vsbTiles.Size = New System.Drawing.Size(13, 156)
		Me.vsbTiles.LargeChange = 6
		Me.vsbTiles.Location = New System.Drawing.Point(105, 0)
		Me.vsbTiles.Maximum = 159
		Me.vsbTiles.TabIndex = 16
		Me.vsbTiles.CausesValidation = True
		Me.vsbTiles.Enabled = True
		Me.vsbTiles.Minimum = 0
		Me.vsbTiles.Cursor = System.Windows.Forms.Cursors.Default
		Me.vsbTiles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.vsbTiles.SmallChange = 1
		Me.vsbTiles.TabStop = True
		Me.vsbTiles.Value = 0
		Me.vsbTiles.Visible = True
		Me.vsbTiles.Name = "vsbTiles"
		Me.shpSelect.BorderColor = System.Drawing.Color.Yellow
		Me.shpSelect.BorderWidth = 2
		Me.shpSelect.Size = New System.Drawing.Size(99, 76)
		Me.shpSelect.Location = New System.Drawing.Point(3, 1)
		Me.shpSelect.BackColor = System.Drawing.SystemColors.Window
		Me.shpSelect.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.shpSelect.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.shpSelect.FillColor = System.Drawing.Color.Black
		Me.shpSelect.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.shpSelect.Visible = True
		Me.shpSelect.Name = "shpSelect"
		Me.lstEncItems.Size = New System.Drawing.Size(120, 64)
		Me.lstEncItems.Location = New System.Drawing.Point(1, 250)
		Me.lstEncItems.TabIndex = 9
		Me.lstEncItems.Visible = False
		Me.lstEncItems.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstEncItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstEncItems.BackColor = System.Drawing.SystemColors.Window
		Me.lstEncItems.CausesValidation = True
		Me.lstEncItems.Enabled = True
		Me.lstEncItems.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstEncItems.IntegralHeight = True
		Me.lstEncItems.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstEncItems.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstEncItems.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstEncItems.Sorted = False
		Me.lstEncItems.TabStop = True
		Me.lstEncItems.MultiColumn = False
		Me.lstEncItems.Name = "lstEncItems"
		Me.lstEncCreatures.Size = New System.Drawing.Size(120, 34)
		Me.lstEncCreatures.Location = New System.Drawing.Point(1, 198)
		Me.lstEncCreatures.TabIndex = 8
		Me.lstEncCreatures.Visible = False
		Me.lstEncCreatures.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstEncCreatures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstEncCreatures.BackColor = System.Drawing.SystemColors.Window
		Me.lstEncCreatures.CausesValidation = True
		Me.lstEncCreatures.Enabled = True
		Me.lstEncCreatures.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstEncCreatures.IntegralHeight = True
		Me.lstEncCreatures.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstEncCreatures.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstEncCreatures.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstEncCreatures.Sorted = False
		Me.lstEncCreatures.TabStop = True
		Me.lstEncCreatures.MultiColumn = False
		Me.lstEncCreatures.Name = "lstEncCreatures"
		Me.cmbTileSet.Size = New System.Drawing.Size(121, 21)
		Me.cmbTileSet.Location = New System.Drawing.Point(1, 157)
		Me.cmbTileSet.Sorted = True
		Me.cmbTileSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTileSet.TabIndex = 4
		Me.cmbTileSet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbTileSet.BackColor = System.Drawing.SystemColors.Window
		Me.cmbTileSet.CausesValidation = True
		Me.cmbTileSet.Enabled = True
		Me.cmbTileSet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbTileSet.IntegralHeight = True
		Me.cmbTileSet.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbTileSet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbTileSet.TabStop = True
		Me.cmbTileSet.Visible = True
		Me.cmbTileSet.Name = "cmbTileSet"
		Me.hsbMap.Size = New System.Drawing.Size(339, 13)
		Me.hsbMap.LargeChange = 12
		Me.hsbMap.Location = New System.Drawing.Point(127, 321)
		Me.hsbMap.Maximum = 127
		Me.hsbMap.TabIndex = 1
		Me.hsbMap.CausesValidation = True
		Me.hsbMap.Enabled = True
		Me.hsbMap.Minimum = 0
		Me.hsbMap.Cursor = System.Windows.Forms.Cursors.Default
		Me.hsbMap.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.hsbMap.SmallChange = 1
		Me.hsbMap.TabStop = True
		Me.hsbMap.Value = 0
		Me.hsbMap.Visible = True
		Me.hsbMap.Name = "hsbMap"
		Me.btnMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnMap.Size = New System.Drawing.Size(13, 13)
		Me.btnMap.Location = New System.Drawing.Point(472, 320)
		Me.btnMap.TabIndex = 2
		Me.btnMap.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMap.BackColor = System.Drawing.SystemColors.Control
		Me.btnMap.CausesValidation = True
		Me.btnMap.Enabled = True
		Me.btnMap.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnMap.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnMap.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnMap.TabStop = True
		Me.btnMap.Name = "btnMap"
		Me.vsbMap.Size = New System.Drawing.Size(13, 304)
		Me.vsbMap.LargeChange = 12
		Me.vsbMap.Location = New System.Drawing.Point(473, 2)
		Me.vsbMap.Maximum = 241
		Me.vsbMap.TabIndex = 0
		Me.vsbMap.CausesValidation = True
		Me.vsbMap.Enabled = True
		Me.vsbMap.Minimum = 0
		Me.vsbMap.Cursor = System.Windows.Forms.Cursors.Default
		Me.vsbMap.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.vsbMap.SmallChange = 1
		Me.vsbMap.TabStop = True
		Me.vsbMap.Value = 0
		Me.vsbMap.Visible = True
		Me.vsbMap.Name = "vsbMap"
		Me.cmbEncounters.Size = New System.Drawing.Size(121, 21)
		Me.cmbEncounters.Location = New System.Drawing.Point(1, 157)
		Me.cmbEncounters.Sorted = True
		Me.cmbEncounters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbEncounters.TabIndex = 5
		Me.cmbEncounters.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbEncounters.BackColor = System.Drawing.SystemColors.Window
		Me.cmbEncounters.CausesValidation = True
		Me.cmbEncounters.Enabled = True
		Me.cmbEncounters.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbEncounters.IntegralHeight = True
		Me.cmbEncounters.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbEncounters.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbEncounters.TabStop = True
		Me.cmbEncounters.Visible = True
		Me.cmbEncounters.Name = "cmbEncounters"
		Me.lblEncItems.Text = "Items:"
		Me.lblEncItems.Size = New System.Drawing.Size(105, 13)
		Me.lblEncItems.Location = New System.Drawing.Point(3, 234)
		Me.lblEncItems.TabIndex = 7
		Me.lblEncItems.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEncItems.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEncItems.BackColor = System.Drawing.SystemColors.Control
		Me.lblEncItems.Enabled = True
		Me.lblEncItems.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblEncItems.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEncItems.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEncItems.UseMnemonic = True
		Me.lblEncItems.Visible = True
		Me.lblEncItems.AutoSize = False
		Me.lblEncItems.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblEncItems.Name = "lblEncItems"
		Me.lblEncCreatures.Text = "Creatures:"
		Me.lblEncCreatures.Size = New System.Drawing.Size(105, 13)
		Me.lblEncCreatures.Location = New System.Drawing.Point(2, 181)
		Me.lblEncCreatures.TabIndex = 6
		Me.lblEncCreatures.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEncCreatures.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEncCreatures.BackColor = System.Drawing.SystemColors.Control
		Me.lblEncCreatures.Enabled = True
		Me.lblEncCreatures.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblEncCreatures.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEncCreatures.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEncCreatures.UseMnemonic = True
		Me.lblEncCreatures.Visible = True
		Me.lblEncCreatures.AutoSize = False
		Me.lblEncCreatures.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblEncCreatures.Name = "lblEncCreatures"
		Me.chkTileShow.SetIndex(_chkTileShow_2, CType(2, Short))
		Me.chkTileShow.SetIndex(_chkTileShow_1, CType(1, Short))
		Me.chkTileShow.SetIndex(_chkTileShow_0, CType(0, Short))
		Me.lnCursor.SetIndex(_lnCursor_0, CType(0, Short))
		Me.lnCursor.SetIndex(_lnCursor_1, CType(1, Short))
		Me.lnCursor.SetIndex(_lnCursor_2, CType(2, Short))
		Me.lnCursor.SetIndex(_lnCursor_3, CType(3, Short))
		Me.optBrushSize.SetIndex(_optBrushSize_2, CType(2, Short))
		Me.optBrushSize.SetIndex(_optBrushSize_1, CType(1, Short))
		Me.optBrushSize.SetIndex(_optBrushSize_0, CType(0, Short))
		Me.optTileLayer.SetIndex(_optTileLayer_3, CType(3, Short))
		Me.optTileLayer.SetIndex(_optTileLayer_2, CType(2, Short))
		Me.optTileLayer.SetIndex(_optTileLayer_1, CType(1, Short))
		Me.optTileLayer.SetIndex(_optTileLayer_0, CType(0, Short))
		Me.optTool.SetIndex(_optTool_9, CType(9, Short))
		Me.optTool.SetIndex(_optTool_8, CType(8, Short))
		Me.optTool.SetIndex(_optTool_7, CType(7, Short))
		Me.optTool.SetIndex(_optTool_6, CType(6, Short))
		Me.optTool.SetIndex(_optTool_3, CType(3, Short))
		Me.optTool.SetIndex(_optTool_5, CType(5, Short))
		Me.optTool.SetIndex(_optTool_4, CType(4, Short))
		Me.optTool.SetIndex(_optTool_2, CType(2, Short))
		Me.optTool.SetIndex(_optTool_1, CType(1, Short))
		Me.optTool.SetIndex(_optTool_0, CType(0, Short))
		CType(Me.optTool, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optTileLayer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optBrushSize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lnCursor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkTileShow, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(picBox)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(picTiles)
		Me.Controls.Add(lstEncItems)
		Me.Controls.Add(lstEncCreatures)
		Me.Controls.Add(cmbTileSet)
		Me.Controls.Add(hsbMap)
		Me.Controls.Add(btnMap)
		Me.Controls.Add(vsbMap)
		Me.Controls.Add(cmbEncounters)
		Me.Controls.Add(lblEncItems)
		Me.Controls.Add(lblEncCreatures)
		Me.picBox.Controls.Add(picMap)
		Me.ShapeContainer1.Shapes.Add(_lnCursor_0)
		Me.ShapeContainer1.Shapes.Add(_lnCursor_1)
		Me.ShapeContainer1.Shapes.Add(_lnCursor_2)
		Me.ShapeContainer1.Shapes.Add(_lnCursor_3)
		Me.picMap.Controls.Add(ShapeContainer1)
		Me.Frame1.Controls.Add(_optTool_9)
		Me.Frame1.Controls.Add(btnRedo)
		Me.Frame1.Controls.Add(btnUndo)
		Me.Frame1.Controls.Add(_optTool_8)
		Me.Frame1.Controls.Add(_optTool_7)
		Me.Frame1.Controls.Add(_optTool_6)
		Me.Frame1.Controls.Add(_optTool_3)
		Me.Frame1.Controls.Add(_optTool_5)
		Me.Frame1.Controls.Add(_optTool_4)
		Me.Frame1.Controls.Add(_optTool_2)
		Me.Frame1.Controls.Add(_optTool_1)
		Me.Frame1.Controls.Add(_optTool_0)
		Me.Frame1.Controls.Add(Frame3)
		Me.Frame1.Controls.Add(Frame2)
		Me.Frame3.Controls.Add(_optTileLayer_3)
		Me.Frame3.Controls.Add(_optTileLayer_2)
		Me.Frame3.Controls.Add(_optTileLayer_1)
		Me.Frame3.Controls.Add(_optTileLayer_0)
		Me.Frame3.Controls.Add(_chkTileShow_2)
		Me.Frame3.Controls.Add(_chkTileShow_1)
		Me.Frame3.Controls.Add(_chkTileShow_0)
		Me.Frame2.Controls.Add(_optBrushSize_2)
		Me.Frame2.Controls.Add(_optBrushSize_1)
		Me.Frame2.Controls.Add(_optBrushSize_0)
		Me.picTiles.Controls.Add(vsbTiles)
		Me.ShapeContainer1.Shapes.Add(shpSelect)
		Me.picBox.ResumeLayout(False)
		Me.picMap.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.picTiles.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class