Public Class Form3
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
  Friend WithEvents menuItem31 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem30 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem11 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem8_Close As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem13_Open As System.Windows.Forms.MenuItem
  Friend WithEvents toolBarButton5_Underline As System.Windows.Forms.ToolBarButton
  Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents toolBarButton3_Bold As System.Windows.Forms.ToolBarButton
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem10_Save As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem9_SaveAs As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem12 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem14_RecentFiles4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem15 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem16_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents menuItem18 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem19_Undo As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem20_Redo As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem21 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem22_Cut As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem23_Copy As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem24_Paste As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem26 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem27_SelectAll As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem7 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem25_Bold As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem28_Italic As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem29_Underline As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem32 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem33_WordWrap As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem34_Font As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3_Cascade As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4_TileHorizontal As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5_TileVertical As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem17 As System.Windows.Forms.MenuItem
  Friend WithEvents toolBarButton4_Italic As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton6 As System.Windows.Forms.ToolBarButton
  Friend WithEvents contextMenu1 As System.Windows.Forms.ContextMenu
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents toolBarButton2_Open As System.Windows.Forms.ToolBarButton
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents fontDialog1 As System.Windows.Forms.FontDialog
  Friend WithEvents text_Box1 As Salford.VisualClearWin.RichText_Box
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form3))
    Me.menuItem31 = New System.Windows.Forms.MenuItem
    Me.menuItem30 = New System.Windows.Forms.MenuItem
    Me.menuItem6 = New System.Windows.Forms.MenuItem
    Me.menuItem11 = New System.Windows.Forms.MenuItem
    Me.menuItem8_Close = New System.Windows.Forms.MenuItem
    Me.menuItem13_Open = New System.Windows.Forms.MenuItem
    Me.toolBarButton5_Underline = New System.Windows.Forms.ToolBarButton
    Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
    Me.toolBarButton3_Bold = New System.Windows.Forms.ToolBarButton
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem10_Save = New System.Windows.Forms.MenuItem
    Me.menuItem9_SaveAs = New System.Windows.Forms.MenuItem
    Me.menuItem12 = New System.Windows.Forms.MenuItem
    Me.menuItem14_RecentFiles4 = New System.Windows.Forms.MenuItem
    Me.menuItem15 = New System.Windows.Forms.MenuItem
    Me.menuItem16_Exit = New System.Windows.Forms.MenuItem
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.menuItem18 = New System.Windows.Forms.MenuItem
    Me.menuItem19_Undo = New System.Windows.Forms.MenuItem
    Me.menuItem20_Redo = New System.Windows.Forms.MenuItem
    Me.menuItem21 = New System.Windows.Forms.MenuItem
    Me.menuItem22_Cut = New System.Windows.Forms.MenuItem
    Me.menuItem23_Copy = New System.Windows.Forms.MenuItem
    Me.menuItem24_Paste = New System.Windows.Forms.MenuItem
    Me.menuItem26 = New System.Windows.Forms.MenuItem
    Me.menuItem27_SelectAll = New System.Windows.Forms.MenuItem
    Me.menuItem7 = New System.Windows.Forms.MenuItem
    Me.menuItem25_Bold = New System.Windows.Forms.MenuItem
    Me.menuItem28_Italic = New System.Windows.Forms.MenuItem
    Me.menuItem29_Underline = New System.Windows.Forms.MenuItem
    Me.menuItem32 = New System.Windows.Forms.MenuItem
    Me.menuItem33_WordWrap = New System.Windows.Forms.MenuItem
    Me.menuItem34_Font = New System.Windows.Forms.MenuItem
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.menuItem3_Cascade = New System.Windows.Forms.MenuItem
    Me.menuItem4_TileHorizontal = New System.Windows.Forms.MenuItem
    Me.menuItem5_TileVertical = New System.Windows.Forms.MenuItem
    Me.menuItem17 = New System.Windows.Forms.MenuItem
    Me.toolBarButton4_Italic = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton6 = New System.Windows.Forms.ToolBarButton
    Me.contextMenu1 = New System.Windows.Forms.ContextMenu
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.toolBarButton2_Open = New System.Windows.Forms.ToolBarButton
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.fontDialog1 = New System.Windows.Forms.FontDialog
    Me.text_Box1 = New Salford.VisualClearWin.RichText_Box
    Me.SuspendLayout()
    '
    'menuItem31
    '
    Me.menuItem31.Index = 1
    Me.menuItem31.Text = "RichText File"
    '
    'menuItem30
    '
    Me.menuItem30.Index = 0
    Me.menuItem30.Text = "Text File"
    '
    'menuItem6
    '
    Me.menuItem6.Index = 0
    Me.menuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem30, Me.menuItem31})
    Me.menuItem6.Text = "New"
    '
    'menuItem11
    '
    Me.menuItem11.Index = 3
    Me.menuItem11.Text = "-"
    '
    'menuItem8_Close
    '
    Me.menuItem8_Close.Index = 2
    Me.menuItem8_Close.Text = "Close"
    '
    'menuItem13_Open
    '
    Me.menuItem13_Open.Index = 1
    Me.menuItem13_Open.Text = "&Open|Opens a file"
    '
    'toolBarButton5_Underline
    '
    Me.toolBarButton5_Underline.ImageIndex = 4
    '
    'saveFileDialog1
    '
    Me.saveFileDialog1.Filter = "Fortran files (*.f95)|*.f95|All files (*.*)|*.*"
    '
    'toolBarButton3_Bold
    '
    Me.toolBarButton3_Bold.ImageIndex = 2
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem6, Me.menuItem13_Open, Me.menuItem8_Close, Me.menuItem11, Me.menuItem10_Save, Me.menuItem9_SaveAs, Me.menuItem12, Me.menuItem14_RecentFiles4, Me.menuItem15, Me.menuItem16_Exit})
    Me.menuItem1.MergeType = System.Windows.Forms.MenuMerge.Replace
    Me.menuItem1.Text = "&File"
    '
    'menuItem10_Save
    '
    Me.menuItem10_Save.Enabled = False
    Me.menuItem10_Save.Index = 4
    Me.menuItem10_Save.Text = "Save"
    '
    'menuItem9_SaveAs
    '
    Me.menuItem9_SaveAs.Index = 5
    Me.menuItem9_SaveAs.Text = "Save As"
    '
    'menuItem12
    '
    Me.menuItem12.Index = 6
    Me.menuItem12.Text = "-"
    '
    'menuItem14_RecentFiles4
    '
    Me.menuItem14_RecentFiles4.Index = 7
    Me.menuItem14_RecentFiles4.Text = "Recent files"
    '
    'menuItem15
    '
    Me.menuItem15.Index = 8
    Me.menuItem15.Text = "-"
    '
    'menuItem16_Exit
    '
    Me.menuItem16_Exit.Index = 9
    Me.menuItem16_Exit.Text = "Exit"
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem18, Me.menuItem7, Me.menuItem2})
    '
    'menuItem18
    '
    Me.menuItem18.Index = 1
    Me.menuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem19_Undo, Me.menuItem20_Redo, Me.menuItem21, Me.menuItem22_Cut, Me.menuItem23_Copy, Me.menuItem24_Paste, Me.menuItem26, Me.menuItem27_SelectAll})
    Me.menuItem18.Text = "&Edit"
    '
    'menuItem19_Undo
    '
    Me.menuItem19_Undo.Index = 0
    Me.menuItem19_Undo.Text = "Undo"
    '
    'menuItem20_Redo
    '
    Me.menuItem20_Redo.Index = 1
    Me.menuItem20_Redo.Text = "Redo"
    '
    'menuItem21
    '
    Me.menuItem21.Index = 2
    Me.menuItem21.Text = "-"
    '
    'menuItem22_Cut
    '
    Me.menuItem22_Cut.Index = 3
    Me.menuItem22_Cut.Text = "Cut"
    '
    'menuItem23_Copy
    '
    Me.menuItem23_Copy.Index = 4
    Me.menuItem23_Copy.Text = "Copy"
    '
    'menuItem24_Paste
    '
    Me.menuItem24_Paste.Index = 5
    Me.menuItem24_Paste.Text = "Paste"
    '
    'menuItem26
    '
    Me.menuItem26.Index = 6
    Me.menuItem26.Text = "-"
    '
    'menuItem27_SelectAll
    '
    Me.menuItem27_SelectAll.Index = 7
    Me.menuItem27_SelectAll.Text = "Select All"
    '
    'menuItem7
    '
    Me.menuItem7.Index = 2
    Me.menuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem25_Bold, Me.menuItem28_Italic, Me.menuItem29_Underline, Me.menuItem32, Me.menuItem33_WordWrap, Me.menuItem34_Font})
    Me.menuItem7.Text = "&Format"
    '
    'menuItem25_Bold
    '
    Me.menuItem25_Bold.Index = 0
    Me.menuItem25_Bold.Text = "Bold"
    '
    'menuItem28_Italic
    '
    Me.menuItem28_Italic.Index = 1
    Me.menuItem28_Italic.Text = "Italic"
    '
    'menuItem29_Underline
    '
    Me.menuItem29_Underline.Index = 2
    Me.menuItem29_Underline.Text = "Underline"
    '
    'menuItem32
    '
    Me.menuItem32.Index = 3
    Me.menuItem32.Text = "-"
    '
    'menuItem33_WordWrap
    '
    Me.menuItem33_WordWrap.Index = 4
    Me.menuItem33_WordWrap.Text = "Word Wrap"
    '
    'menuItem34_Font
    '
    Me.menuItem34_Font.Index = 5
    Me.menuItem34_Font.Text = "Font"
    '
    'menuItem2
    '
    Me.menuItem2.Index = 3
    Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3_Cascade, Me.menuItem4_TileHorizontal, Me.menuItem5_TileVertical, Me.menuItem17})
    Me.menuItem2.Text = "&Window"
    '
    'menuItem3_Cascade
    '
    Me.menuItem3_Cascade.Index = 0
    Me.menuItem3_Cascade.Text = "Cascade"
    '
    'menuItem4_TileHorizontal
    '
    Me.menuItem4_TileHorizontal.Index = 1
    Me.menuItem4_TileHorizontal.Text = "Tile Horizontally"
    '
    'menuItem5_TileVertical
    '
    Me.menuItem5_TileVertical.Index = 2
    Me.menuItem5_TileVertical.Text = "Tile Vertically"
    '
    'menuItem17
    '
    Me.menuItem17.Index = 3
    Me.menuItem17.MdiList = True
    Me.menuItem17.Text = "Windows"
    '
    'toolBarButton4_Italic
    '
    Me.toolBarButton4_Italic.ImageIndex = 3
    '
    'toolBarButton6
    '
    Me.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'contextMenu1
    '
    Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem4, Me.menuItem3})
    '
    'menuItem4
    '
    Me.menuItem4.Index = 0
    Me.menuItem4.Text = "Text file"
    '
    'menuItem3
    '
    Me.menuItem3.Index = 1
    Me.menuItem3.Text = "RichText file"
    '
    'toolBarButton1
    '
    Me.toolBarButton1.DropDownMenu = Me.contextMenu1
    Me.toolBarButton1.ImageIndex = 0
    Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton2_Open, Me.toolBarButton6, Me.toolBarButton3_Bold, Me.toolBarButton4_Italic, Me.toolBarButton5_Underline})
    Me.toolBar1.ButtonSize = New System.Drawing.Size(16, 16)
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(208, 28)
    Me.toolBar1.TabIndex = 6
    '
    'toolBarButton2_Open
    '
    Me.toolBarButton2_Open.ImageIndex = 1
    '
    'imageList1
    '
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
    '
    'fontDialog1
    '
    Me.fontDialog1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.fontDialog1.ShowColor = True
    '
    'text_Box1
    '
    Me.text_Box1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.text_Box1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.text_Box1.Location = New System.Drawing.Point(0, 0)
    Me.text_Box1.Name = "text_Box1"
    Me.text_Box1.ShowSelectionMargin = True
    Me.text_Box1.Size = New System.Drawing.Size(208, 113)
    Me.text_Box1.TabIndex = 5
    Me.text_Box1.Text = ""
    Me.text_Box1.WordWrap = False
    '
    'Form3
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(208, 113)
    Me.Controls.Add(Me.toolBar1)
    Me.Controls.Add(Me.text_Box1)
    Me.Menu = Me.mainMenu1
    Me.Name = "Form3"
    Me.Text = "Form3"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
