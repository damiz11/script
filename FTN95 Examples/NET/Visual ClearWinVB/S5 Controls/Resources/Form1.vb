Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
  Friend WithEvents Tab_Control1 As Salford.VisualClearWin.Tab_Control
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
  Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
  Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Group_Box1 As Salford.VisualClearWin.Group_Box
  Friend WithEvents check_Box1 As Salford.VisualClearWin.Check_Box
  Friend WithEvents check_Box2 As Salford.VisualClearWin.Check_Box
  Friend WithEvents check_Box3 As Salford.VisualClearWin.Check_Box
  Friend WithEvents Int32_Box1 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents Int32_Box2 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents Int32_Box3 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents Int32_Box4 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents Text_Box1 As Salford.VisualClearWin.Text_Box
  Friend WithEvents Combo_Box1 As Salford.VisualClearWin.Combo_Box
  Friend WithEvents Int32_Box5 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents List_View1 As Salford.VisualClearWin.List_View
  Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
  Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
  Friend WithEvents Int32_Box6 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents List_Box1 As Salford.VisualClearWin.List_Box
  Friend WithEvents Int32_Box7 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents Tree_View1 As Salford.VisualClearWin.Tree_View
  Friend WithEvents Track_Bar1 As Salford.VisualClearWin.Track_Bar
  Friend WithEvents Int32_Box8 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
  Friend WithEvents Int32_Box9 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents Radio_Button1 As Salford.VisualClearWin.Radio_Button
  Friend WithEvents Radio_Button2 As Salford.VisualClearWin.Radio_Button
  Friend WithEvents Radio_Button3 As Salford.VisualClearWin.Radio_Button
  Friend WithEvents Int32_Box10 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents Int32_Box11 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents Int32_Box12 As Salford.VisualClearWin.Int32_Box
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item1", "Data1"}, -1)
    Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item2", "Data2"}, -1)
    Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item3", "Data3"}, -1)
    Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.Tab_Control1 = New Salford.VisualClearWin.Tab_Control
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.Group_Box1 = New Salford.VisualClearWin.Group_Box
    Me.Int32_Box3 = New Salford.VisualClearWin.Int32_Box
    Me.Int32_Box2 = New Salford.VisualClearWin.Int32_Box
    Me.Int32_Box1 = New Salford.VisualClearWin.Int32_Box
    Me.check_Box1 = New Salford.VisualClearWin.Check_Box
    Me.check_Box2 = New Salford.VisualClearWin.Check_Box
    Me.check_Box3 = New Salford.VisualClearWin.Check_Box
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.Combo_Box1 = New Salford.VisualClearWin.Combo_Box
    Me.Text_Box1 = New Salford.VisualClearWin.Text_Box
    Me.Int32_Box4 = New Salford.VisualClearWin.Int32_Box
    Me.TabPage3 = New System.Windows.Forms.TabPage
    Me.List_View1 = New Salford.VisualClearWin.List_View
    Me.Int32_Box5 = New Salford.VisualClearWin.Int32_Box
    Me.TabPage4 = New System.Windows.Forms.TabPage
    Me.TabPage5 = New System.Windows.Forms.TabPage
    Me.TabPage6 = New System.Windows.Forms.TabPage
    Me.TabPage7 = New System.Windows.Forms.TabPage
    Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
    Me.TabPage8 = New System.Windows.Forms.TabPage
    Me.Int32_Box6 = New Salford.VisualClearWin.Int32_Box
    Me.List_Box1 = New Salford.VisualClearWin.List_Box
    Me.Int32_Box7 = New Salford.VisualClearWin.Int32_Box
    Me.Tree_View1 = New Salford.VisualClearWin.Tree_View
    Me.Track_Bar1 = New Salford.VisualClearWin.Track_Bar
    Me.Int32_Box8 = New Salford.VisualClearWin.Int32_Box
    Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
    Me.Int32_Box9 = New Salford.VisualClearWin.Int32_Box
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.Radio_Button1 = New Salford.VisualClearWin.Radio_Button
    Me.Radio_Button2 = New Salford.VisualClearWin.Radio_Button
    Me.Radio_Button3 = New Salford.VisualClearWin.Radio_Button
    Me.Int32_Box10 = New Salford.VisualClearWin.Int32_Box
    Me.Int32_Box11 = New Salford.VisualClearWin.Int32_Box
    Me.Int32_Box12 = New Salford.VisualClearWin.Int32_Box
    Me.Tab_Control1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.Group_Box1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.TabPage4.SuspendLayout()
    Me.TabPage5.SuspendLayout()
    Me.TabPage6.SuspendLayout()
    Me.TabPage7.SuspendLayout()
    Me.TabPage8.SuspendLayout()
    CType(Me.Track_Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'columnHeader1
    '
    Me.columnHeader1.Text = "Column 1"
    '
    'columnHeader2
    '
    Me.columnHeader2.Text = "Column 2"
    '
    'Tab_Control1
    '
    Me.Tab_Control1.Controls.Add(Me.TabPage1)
    Me.Tab_Control1.Controls.Add(Me.TabPage2)
    Me.Tab_Control1.Controls.Add(Me.TabPage3)
    Me.Tab_Control1.Controls.Add(Me.TabPage8)
    Me.Tab_Control1.Controls.Add(Me.TabPage4)
    Me.Tab_Control1.Controls.Add(Me.TabPage6)
    Me.Tab_Control1.Controls.Add(Me.TabPage5)
    Me.Tab_Control1.Controls.Add(Me.TabPage7)
    Me.Tab_Control1.Location = New System.Drawing.Point(8, 8)
    Me.Tab_Control1.Name = "Tab_Control1"
    Me.Tab_Control1.Pivoting = Salford.VisualClearWin.Pivot.Full
    Me.Tab_Control1.SelectedIndex = 0
    Me.Tab_Control1.Size = New System.Drawing.Size(584, 192)
    Me.Tab_Control1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.Group_Box1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Size = New System.Drawing.Size(576, 166)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Check boxes"
    '
    'Group_Box1
    '
    Me.Group_Box1.Controls.Add(Me.Int32_Box3)
    Me.Group_Box1.Controls.Add(Me.Int32_Box2)
    Me.Group_Box1.Controls.Add(Me.Int32_Box1)
    Me.Group_Box1.Controls.Add(Me.check_Box1)
    Me.Group_Box1.Controls.Add(Me.check_Box2)
    Me.Group_Box1.Controls.Add(Me.check_Box3)
    Me.Group_Box1.Location = New System.Drawing.Point(8, 8)
    Me.Group_Box1.Name = "Group_Box1"
    Me.Group_Box1.Size = New System.Drawing.Size(552, 152)
    Me.Group_Box1.TabIndex = 0
    Me.Group_Box1.TabStop = False
    Me.Group_Box1.Text = "Group"
    '
    'Int32_Box3
    '
    Me.Int32_Box3.Location = New System.Drawing.Point(128, 104)
    Me.Int32_Box3.Maximum = 2147483647
    Me.Int32_Box3.Minimum = -2147483648
    Me.Int32_Box3.Name = "Int32_Box3"
    Me.Int32_Box3.Size = New System.Drawing.Size(24, 20)
    Me.Int32_Box3.TabIndex = 8
    Me.Int32_Box3.Text = ""
    '
    'Int32_Box2
    '
    Me.Int32_Box2.Location = New System.Drawing.Point(128, 72)
    Me.Int32_Box2.Maximum = 2147483647
    Me.Int32_Box2.Minimum = -2147483648
    Me.Int32_Box2.Name = "Int32_Box2"
    Me.Int32_Box2.Size = New System.Drawing.Size(24, 20)
    Me.Int32_Box2.TabIndex = 7
    Me.Int32_Box2.Text = ""
    '
    'Int32_Box1
    '
    Me.Int32_Box1.Location = New System.Drawing.Point(128, 40)
    Me.Int32_Box1.Maximum = 2147483647
    Me.Int32_Box1.Minimum = -2147483648
    Me.Int32_Box1.Name = "Int32_Box1"
    Me.Int32_Box1.Size = New System.Drawing.Size(24, 20)
    Me.Int32_Box1.TabIndex = 6
    Me.Int32_Box1.Text = ""
    '
    'check_Box1
    '
    Me.check_Box1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.check_Box1.Location = New System.Drawing.Point(40, 44)
    Me.check_Box1.Name = "check_Box1"
    Me.check_Box1.Size = New System.Drawing.Size(72, 16)
    Me.check_Box1.TabIndex = 3
    Me.check_Box1.Text = "Check 1"
    '
    'check_Box2
    '
    Me.check_Box2.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.check_Box2.Location = New System.Drawing.Point(40, 75)
    Me.check_Box2.Name = "check_Box2"
    Me.check_Box2.Size = New System.Drawing.Size(72, 13)
    Me.check_Box2.TabIndex = 4
    Me.check_Box2.Text = "Check 2"
    '
    'check_Box3
    '
    Me.check_Box3.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.check_Box3.Location = New System.Drawing.Point(40, 108)
    Me.check_Box3.Name = "check_Box3"
    Me.check_Box3.Size = New System.Drawing.Size(72, 16)
    Me.check_Box3.TabIndex = 5
    Me.check_Box3.Text = "Check 3"
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.Combo_Box1)
    Me.TabPage2.Controls.Add(Me.Text_Box1)
    Me.TabPage2.Controls.Add(Me.Int32_Box4)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Size = New System.Drawing.Size(576, 166)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Combo Box"
    '
    'Combo_Box1
    '
    Me.Combo_Box1.Items.AddRange(New Object() {"Item 1", "Item 2", "Item 3"})
    Me.Combo_Box1.Location = New System.Drawing.Point(24, 64)
    Me.Combo_Box1.Name = "Combo_Box1"
    Me.Combo_Box1.Pivoting = Salford.VisualClearWin.Pivot.Horizontal
    Me.Combo_Box1.Size = New System.Drawing.Size(520, 21)
    Me.Combo_Box1.TabIndex = 2
    '
    'Text_Box1
    '
    Me.Text_Box1.Location = New System.Drawing.Point(80, 16)
    Me.Text_Box1.Name = "Text_Box1"
    Me.Text_Box1.Pivoting = Salford.VisualClearWin.Pivot.Horizontal
    Me.Text_Box1.Size = New System.Drawing.Size(456, 20)
    Me.Text_Box1.TabIndex = 1
    Me.Text_Box1.Text = ""
    '
    'Int32_Box4
    '
    Me.Int32_Box4.Location = New System.Drawing.Point(24, 16)
    Me.Int32_Box4.Maximum = 2147483647
    Me.Int32_Box4.Minimum = -2147483648
    Me.Int32_Box4.Name = "Int32_Box4"
    Me.Int32_Box4.Size = New System.Drawing.Size(32, 20)
    Me.Int32_Box4.TabIndex = 0
    Me.Int32_Box4.Text = "0"
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.List_View1)
    Me.TabPage3.Controls.Add(Me.Int32_Box5)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Size = New System.Drawing.Size(576, 166)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "List view"
    '
    'List_View1
    '
    Me.List_View1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
    Me.List_View1.FullRowSelect = True
    Me.List_View1.GridLines = True
    Me.List_View1.HideSelection = False
    Me.List_View1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
    Me.List_View1.Location = New System.Drawing.Point(16, 48)
    Me.List_View1.MultiSelect = False
    Me.List_View1.Name = "List_View1"
    Me.List_View1.Pivoting = Salford.VisualClearWin.Pivot.Full
    Me.List_View1.Size = New System.Drawing.Size(544, 104)
    Me.List_View1.TabIndex = 1
    Me.List_View1.View = System.Windows.Forms.View.Details
    '
    'Int32_Box5
    '
    Me.Int32_Box5.Location = New System.Drawing.Point(16, 16)
    Me.Int32_Box5.Maximum = 2147483647
    Me.Int32_Box5.Minimum = -2147483648
    Me.Int32_Box5.Name = "Int32_Box5"
    Me.Int32_Box5.Size = New System.Drawing.Size(24, 20)
    Me.Int32_Box5.TabIndex = 0
    Me.Int32_Box5.Text = "0"
    '
    'TabPage4
    '
    Me.TabPage4.Controls.Add(Me.Tree_View1)
    Me.TabPage4.Controls.Add(Me.Int32_Box7)
    Me.TabPage4.Location = New System.Drawing.Point(4, 22)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Size = New System.Drawing.Size(576, 166)
    Me.TabPage4.TabIndex = 3
    Me.TabPage4.Text = "Tree view"
    '
    'TabPage5
    '
    Me.TabPage5.Controls.Add(Me.Int32_Box8)
    Me.TabPage5.Controls.Add(Me.Track_Bar1)
    Me.TabPage5.Location = New System.Drawing.Point(4, 22)
    Me.TabPage5.Name = "TabPage5"
    Me.TabPage5.Size = New System.Drawing.Size(576, 166)
    Me.TabPage5.TabIndex = 4
    Me.TabPage5.Text = "Track bar"
    '
    'TabPage6
    '
    Me.TabPage6.Controls.Add(Me.Int32_Box9)
    Me.TabPage6.Controls.Add(Me.ProgressBar1)
    Me.TabPage6.Location = New System.Drawing.Point(4, 22)
    Me.TabPage6.Name = "TabPage6"
    Me.TabPage6.Size = New System.Drawing.Size(576, 166)
    Me.TabPage6.TabIndex = 5
    Me.TabPage6.Text = "Progress"
    '
    'TabPage7
    '
    Me.TabPage7.Controls.Add(Me.Int32_Box12)
    Me.TabPage7.Controls.Add(Me.Int32_Box11)
    Me.TabPage7.Controls.Add(Me.Int32_Box10)
    Me.TabPage7.Controls.Add(Me.Radio_Button3)
    Me.TabPage7.Controls.Add(Me.Radio_Button2)
    Me.TabPage7.Controls.Add(Me.Radio_Button1)
    Me.TabPage7.Location = New System.Drawing.Point(4, 22)
    Me.TabPage7.Name = "TabPage7"
    Me.TabPage7.Size = New System.Drawing.Size(576, 166)
    Me.TabPage7.TabIndex = 6
    Me.TabPage7.Text = "Radio buttons"
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Column 1"
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Column 2"
    '
    'ColumnHeader5
    '
    Me.ColumnHeader5.Text = "Column 1"
    '
    'ColumnHeader6
    '
    Me.ColumnHeader6.Text = "Column 2"
    '
    'TabPage8
    '
    Me.TabPage8.Controls.Add(Me.List_Box1)
    Me.TabPage8.Controls.Add(Me.Int32_Box6)
    Me.TabPage8.Location = New System.Drawing.Point(4, 22)
    Me.TabPage8.Name = "TabPage8"
    Me.TabPage8.Size = New System.Drawing.Size(576, 166)
    Me.TabPage8.TabIndex = 7
    Me.TabPage8.Text = "List box"
    '
    'Int32_Box6
    '
    Me.Int32_Box6.Location = New System.Drawing.Point(8, 16)
    Me.Int32_Box6.Maximum = 2147483647
    Me.Int32_Box6.Minimum = -2147483648
    Me.Int32_Box6.Name = "Int32_Box6"
    Me.Int32_Box6.Size = New System.Drawing.Size(24, 20)
    Me.Int32_Box6.TabIndex = 0
    Me.Int32_Box6.Text = "0"
    '
    'List_Box1
    '
    Me.List_Box1.Items.AddRange(New Object() {"Item1", "Item2", "Item3"})
    Me.List_Box1.Location = New System.Drawing.Point(8, 48)
    Me.List_Box1.Name = "List_Box1"
    Me.List_Box1.Pivoting = Salford.VisualClearWin.Pivot.Full
    Me.List_Box1.Size = New System.Drawing.Size(552, 95)
    Me.List_Box1.TabIndex = 1
    Me.List_Box1.Val = -1
    '
    'Int32_Box7
    '
    Me.Int32_Box7.Location = New System.Drawing.Point(8, 8)
    Me.Int32_Box7.Maximum = 2147483647
    Me.Int32_Box7.Minimum = -2147483648
    Me.Int32_Box7.Name = "Int32_Box7"
    Me.Int32_Box7.Size = New System.Drawing.Size(32, 20)
    Me.Int32_Box7.TabIndex = 0
    Me.Int32_Box7.Text = "0"
    '
    'Tree_View1
    '
    Me.Tree_View1.HideSelection = False
    Me.Tree_View1.ImageIndex = -1
    Me.Tree_View1.Location = New System.Drawing.Point(8, 40)
    Me.Tree_View1.Name = "Tree_View1"
    Me.Tree_View1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Chapter 1", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Section 1.1"), New System.Windows.Forms.TreeNode("Section 1.2")}), New System.Windows.Forms.TreeNode("Chapter 2", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Section 2.1"), New System.Windows.Forms.TreeNode("Section 2.2")})})
    Me.Tree_View1.Pivoting = Salford.VisualClearWin.Pivot.Full
    Me.Tree_View1.SelectedImageIndex = -1
    Me.Tree_View1.Size = New System.Drawing.Size(552, 112)
    Me.Tree_View1.TabIndex = 1
    '
    'Track_Bar1
    '
    Me.Track_Bar1.Location = New System.Drawing.Point(96, 16)
    Me.Track_Bar1.Name = "Track_Bar1"
    Me.Track_Bar1.Size = New System.Drawing.Size(352, 45)
    Me.Track_Bar1.TabIndex = 0
    '
    'Int32_Box8
    '
    Me.Int32_Box8.Location = New System.Drawing.Point(240, 96)
    Me.Int32_Box8.Maximum = 2147483647
    Me.Int32_Box8.Minimum = -2147483648
    Me.Int32_Box8.Name = "Int32_Box8"
    Me.Int32_Box8.Size = New System.Drawing.Size(48, 20)
    Me.Int32_Box8.TabIndex = 1
    Me.Int32_Box8.Text = ""
    '
    'ProgressBar1
    '
    Me.ProgressBar1.Location = New System.Drawing.Point(40, 16)
    Me.ProgressBar1.Maximum = 480
    Me.ProgressBar1.Name = "ProgressBar1"
    Me.ProgressBar1.Size = New System.Drawing.Size(480, 24)
    Me.ProgressBar1.Step = 1
    Me.ProgressBar1.TabIndex = 0
    '
    'Int32_Box9
    '
    Me.Int32_Box9.Location = New System.Drawing.Point(240, 64)
    Me.Int32_Box9.Maximum = 2147483647
    Me.Int32_Box9.Minimum = -2147483648
    Me.Int32_Box9.Name = "Int32_Box9"
    Me.Int32_Box9.ReadOnly = True
    Me.Int32_Box9.Size = New System.Drawing.Size(72, 20)
    Me.Int32_Box9.TabIndex = 1
    Me.Int32_Box9.Text = ""
    '
    'Timer1
    '
    Me.Timer1.Enabled = True
    Me.Timer1.Interval = 1000
    '
    'Radio_Button1
    '
    Me.Radio_Button1.Location = New System.Drawing.Point(56, 43)
    Me.Radio_Button1.Name = "Radio_Button1"
    Me.Radio_Button1.Size = New System.Drawing.Size(72, 16)
    Me.Radio_Button1.TabIndex = 0
    Me.Radio_Button1.Text = "Radio 1"
    '
    'Radio_Button2
    '
    Me.Radio_Button2.Location = New System.Drawing.Point(56, 68)
    Me.Radio_Button2.Name = "Radio_Button2"
    Me.Radio_Button2.Size = New System.Drawing.Size(72, 16)
    Me.Radio_Button2.TabIndex = 1
    Me.Radio_Button2.Text = "Radio 2"
    '
    'Radio_Button3
    '
    Me.Radio_Button3.Location = New System.Drawing.Point(56, 92)
    Me.Radio_Button3.Name = "Radio_Button3"
    Me.Radio_Button3.Size = New System.Drawing.Size(72, 16)
    Me.Radio_Button3.TabIndex = 2
    Me.Radio_Button3.Text = "Radio 3"
    '
    'Int32_Box10
    '
    Me.Int32_Box10.Location = New System.Drawing.Point(144, 40)
    Me.Int32_Box10.Maximum = 2147483647
    Me.Int32_Box10.Minimum = -2147483648
    Me.Int32_Box10.Name = "Int32_Box10"
    Me.Int32_Box10.Size = New System.Drawing.Size(48, 20)
    Me.Int32_Box10.TabIndex = 3
    Me.Int32_Box10.Text = ""
    '
    'Int32_Box11
    '
    Me.Int32_Box11.Location = New System.Drawing.Point(144, 64)
    Me.Int32_Box11.Maximum = 2147483647
    Me.Int32_Box11.Minimum = -2147483648
    Me.Int32_Box11.Name = "Int32_Box11"
    Me.Int32_Box11.Size = New System.Drawing.Size(48, 20)
    Me.Int32_Box11.TabIndex = 4
    Me.Int32_Box11.Text = ""
    '
    'Int32_Box12
    '
    Me.Int32_Box12.Location = New System.Drawing.Point(144, 88)
    Me.Int32_Box12.Maximum = 2147483647
    Me.Int32_Box12.Minimum = -2147483648
    Me.Int32_Box12.Name = "Int32_Box12"
    Me.Int32_Box12.Size = New System.Drawing.Size(48, 20)
    Me.Int32_Box12.TabIndex = 5
    Me.Int32_Box12.Text = ""
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(600, 206)
    Me.Controls.Add(Me.Tab_Control1)
    Me.Name = "Form1"
    Me.Text = "Controls"
    Me.Tab_Control1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.Group_Box1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage3.ResumeLayout(False)
    Me.TabPage4.ResumeLayout(False)
    Me.TabPage5.ResumeLayout(False)
    Me.TabPage6.ResumeLayout(False)
    Me.TabPage7.ResumeLayout(False)
    Me.TabPage8.ResumeLayout(False)
    CType(Me.Track_Bar1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
