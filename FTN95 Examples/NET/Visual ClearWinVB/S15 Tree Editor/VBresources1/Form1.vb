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
  Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents label3 As System.Windows.Forms.Label
  Friend WithEvents label2 As System.Windows.Forms.Label
  Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents label1 As System.Windows.Forms.Label
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents decimal_UpDown2 As Salford.VisualClearWin.Decimal_UpDown
  Friend WithEvents decimal_UpDown1 As Salford.VisualClearWin.Decimal_UpDown
  Friend WithEvents text_Box1 As Salford.VisualClearWin.Text_Box
  Friend WithEvents menuItem3_Open As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem2_New As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4_Save As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5_SaveAs As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem6_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents tree_View1 As Salford.VisualClearWin.Tree_View
  Friend WithEvents imageList2 As System.Windows.Forms.ImageList
  Friend WithEvents toolBarButton8_Right As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton7_Left As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton6_Up As System.Windows.Forms.ToolBarButton
  Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents toolBarButton5_Down As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton5 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents toolBarButton2 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton3 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton4 As System.Windows.Forms.ToolBarButton
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
    Me.label3 = New System.Windows.Forms.Label
    Me.label2 = New System.Windows.Forms.Label
    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.label1 = New System.Windows.Forms.Label
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.decimal_UpDown2 = New Salford.VisualClearWin.Decimal_UpDown
    Me.decimal_UpDown1 = New Salford.VisualClearWin.Decimal_UpDown
    Me.text_Box1 = New Salford.VisualClearWin.Text_Box
    Me.menuItem3_Open = New System.Windows.Forms.MenuItem
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem2_New = New System.Windows.Forms.MenuItem
    Me.menuItem4_Save = New System.Windows.Forms.MenuItem
    Me.menuItem5_SaveAs = New System.Windows.Forms.MenuItem
    Me.menuItem6_Exit = New System.Windows.Forms.MenuItem
    Me.tree_View1 = New Salford.VisualClearWin.Tree_View
    Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
    Me.toolBarButton8_Right = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton7_Left = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton6_Up = New System.Windows.Forms.ToolBarButton
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.toolBarButton5_Down = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton5 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton4 = New System.Windows.Forms.ToolBarButton
    CType(Me.decimal_UpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.decimal_UpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'saveFileDialog1
    '
    Me.saveFileDialog1.Filter = "Tree files (*.tre)|*.tre|All files (*.*)|*.*"
    '
    'label3
    '
    Me.label3.Location = New System.Drawing.Point(8, 71)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(32, 16)
    Me.label3.TabIndex = 15
    Me.label3.Text = "Data:"
    '
    'label2
    '
    Me.label2.Location = New System.Drawing.Point(112, 47)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(86, 16)
    Me.label2.TabIndex = 14
    Me.label2.Text = "Selected Image:"
    '
    'openFileDialog1
    '
    Me.openFileDialog1.DefaultExt = "tre"
    Me.openFileDialog1.Filter = "Tree files (*.tre)|*.tre|All files (*.*)|*.*"
    '
    'label1
    '
    Me.label1.Location = New System.Drawing.Point(8, 47)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(39, 16)
    Me.label1.TabIndex = 13
    Me.label1.Text = "Image:"
    '
    'imageList1
    '
    Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.White
    '
    'decimal_UpDown2
    '
    Me.decimal_UpDown2.Enabled = False
    Me.decimal_UpDown2.Location = New System.Drawing.Point(208, 44)
    Me.decimal_UpDown2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
    Me.decimal_UpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
    Me.decimal_UpDown2.Name = "decimal_UpDown2"
    Me.decimal_UpDown2.Size = New System.Drawing.Size(40, 20)
    Me.decimal_UpDown2.TabIndex = 12
    '
    'decimal_UpDown1
    '
    Me.decimal_UpDown1.Enabled = False
    Me.decimal_UpDown1.Location = New System.Drawing.Point(56, 44)
    Me.decimal_UpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
    Me.decimal_UpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
    Me.decimal_UpDown1.Name = "decimal_UpDown1"
    Me.decimal_UpDown1.Size = New System.Drawing.Size(40, 20)
    Me.decimal_UpDown1.TabIndex = 11
    '
    'text_Box1
    '
    Me.text_Box1.Enabled = False
    Me.text_Box1.HideSelection = False
    Me.text_Box1.Location = New System.Drawing.Point(48, 68)
    Me.text_Box1.Name = "text_Box1"
    Me.text_Box1.Pivoting = Salford.VisualClearWin.Pivot.Horizontal
    Me.text_Box1.Size = New System.Drawing.Size(234, 20)
    Me.text_Box1.TabIndex = 10
    Me.text_Box1.Text = ""
    Me.toolTip1.SetToolTip(Me.text_Box1, "Enter node data here...")
    '
    'menuItem3_Open
    '
    Me.menuItem3_Open.Index = 1
    Me.menuItem3_Open.Text = "Open"
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2_New, Me.menuItem3_Open, Me.menuItem4_Save, Me.menuItem5_SaveAs, Me.menuItem6_Exit})
    Me.menuItem1.Text = "File"
    '
    'menuItem2_New
    '
    Me.menuItem2_New.Index = 0
    Me.menuItem2_New.Text = "New"
    '
    'menuItem4_Save
    '
    Me.menuItem4_Save.Index = 2
    Me.menuItem4_Save.Text = "Save"
    '
    'menuItem5_SaveAs
    '
    Me.menuItem5_SaveAs.Index = 3
    Me.menuItem5_SaveAs.Text = "Save As"
    '
    'menuItem6_Exit
    '
    Me.menuItem6_Exit.Index = 4
    Me.menuItem6_Exit.Text = "Exit"
    '
    'tree_View1
    '
    Me.tree_View1.HideSelection = False
    Me.tree_View1.ImageList = Me.imageList2
    Me.tree_View1.LabelEdit = True
    Me.tree_View1.Location = New System.Drawing.Point(0, 92)
    Me.tree_View1.Name = "tree_View1"
    Me.tree_View1.Pivoting = Salford.VisualClearWin.Pivot.Full
    Me.tree_View1.Size = New System.Drawing.Size(288, 176)
    Me.tree_View1.TabIndex = 8
    Me.toolTip1.SetToolTip(Me.tree_View1, "Edit the tree here...")
    '
    'imageList2
    '
    Me.imageList2.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
    '
    'toolBarButton8_Right
    '
    Me.toolBarButton8_Right.ImageIndex = 6
    Me.toolBarButton8_Right.ToolTipText = "Move right"
    '
    'toolBarButton7_Left
    '
    Me.toolBarButton7_Left.ImageIndex = 5
    Me.toolBarButton7_Left.ToolTipText = "Move left"
    '
    'toolBarButton6_Up
    '
    Me.toolBarButton6_Up.ImageIndex = 4
    Me.toolBarButton6_Up.ToolTipText = "Move up"
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
    '
    'toolBarButton5_Down
    '
    Me.toolBarButton5_Down.ImageIndex = 3
    Me.toolBarButton5_Down.ToolTipText = "Move down"
    '
    'toolBarButton5
    '
    Me.toolBarButton5.ImageIndex = 7
    Me.toolBarButton5.ToolTipText = "Insert a sibling node"
    '
    'toolBarButton1
    '
    Me.toolBarButton1.ImageIndex = 0
    Me.toolBarButton1.ToolTipText = "Append a sibling node"
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton5, Me.toolBarButton2, Me.toolBarButton3, Me.toolBarButton4, Me.toolBarButton5_Down, Me.toolBarButton6_Up, Me.toolBarButton7_Left, Me.toolBarButton8_Right})
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(288, 28)
    Me.toolBar1.TabIndex = 9
    '
    'toolBarButton2
    '
    Me.toolBarButton2.ImageIndex = 1
    Me.toolBarButton2.ToolTipText = "Add a child node"
    '
    'toolBarButton3
    '
    Me.toolBarButton3.ImageIndex = 2
    Me.toolBarButton3.ToolTipText = "Delete the selected node and its children"
    '
    'toolBarButton4
    '
    Me.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(288, 257)
    Me.Controls.Add(Me.tree_View1)
    Me.Controls.Add(Me.toolBar1)
    Me.Controls.Add(Me.label3)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.decimal_UpDown2)
    Me.Controls.Add(Me.decimal_UpDown1)
    Me.Controls.Add(Me.text_Box1)
    Me.Menu = Me.mainMenu1
    Me.Name = "Form1"
    Me.Text = "TreeNode Editor"
    CType(Me.decimal_UpDown2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.decimal_UpDown1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
