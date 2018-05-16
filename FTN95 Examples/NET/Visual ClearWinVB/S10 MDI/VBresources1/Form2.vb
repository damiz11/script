Public Class Form2
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
  Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3_Cascade As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4_TileHorizontal As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5_TileVertical As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem17 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem33_WordWrap As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem32 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem34_Font As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem23_Copy As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem22_Cut As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem21 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem27_SelectAll As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem26 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem24_Paste As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem20_Redo As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5_Delete As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem31 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem9_SaveAs As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem14_RecentFiles4 As System.Windows.Forms.MenuItem
  Friend WithEvents text_Box1 As Salford.VisualClearWin.Text_Box
  Friend WithEvents fontDialog1 As System.Windows.Forms.FontDialog
  Friend WithEvents printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
  Friend WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
  Friend WithEvents pageSetupDialog1 As System.Windows.Forms.PageSetupDialog
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents menuItem19_Undo As System.Windows.Forms.MenuItem
  Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents toolBarButton2__Open As System.Windows.Forms.ToolBarButton
  Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem30 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem13_Open As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem8_Close As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem11 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem10_Save As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem12 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem29_PageSetup As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem28_PrintPreview As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem7_Print As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem15 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem16_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents menuItem18 As System.Windows.Forms.MenuItem
  Friend WithEvents contextMenu1 As System.Windows.Forms.ContextMenu
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents printDialog1 As System.Windows.Forms.PrintDialog
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.menuItem3_Cascade = New System.Windows.Forms.MenuItem
    Me.menuItem4_TileHorizontal = New System.Windows.Forms.MenuItem
    Me.menuItem5_TileVertical = New System.Windows.Forms.MenuItem
    Me.menuItem17 = New System.Windows.Forms.MenuItem
    Me.menuItem33_WordWrap = New System.Windows.Forms.MenuItem
    Me.menuItem32 = New System.Windows.Forms.MenuItem
    Me.menuItem34_Font = New System.Windows.Forms.MenuItem
    Me.menuItem23_Copy = New System.Windows.Forms.MenuItem
    Me.menuItem22_Cut = New System.Windows.Forms.MenuItem
    Me.menuItem21 = New System.Windows.Forms.MenuItem
    Me.menuItem27_SelectAll = New System.Windows.Forms.MenuItem
    Me.menuItem26 = New System.Windows.Forms.MenuItem
    Me.menuItem24_Paste = New System.Windows.Forms.MenuItem
    Me.menuItem20_Redo = New System.Windows.Forms.MenuItem
    Me.menuItem5_Delete = New System.Windows.Forms.MenuItem
    Me.menuItem31 = New System.Windows.Forms.MenuItem
    Me.menuItem9_SaveAs = New System.Windows.Forms.MenuItem
    Me.menuItem14_RecentFiles4 = New System.Windows.Forms.MenuItem
    Me.text_Box1 = New Salford.VisualClearWin.Text_Box
    Me.fontDialog1 = New System.Windows.Forms.FontDialog
    Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
    Me.printDocument1 = New System.Drawing.Printing.PrintDocument
    Me.pageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.menuItem19_Undo = New System.Windows.Forms.MenuItem
    Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
    Me.toolBarButton2__Open = New System.Windows.Forms.ToolBarButton
    Me.menuItem6 = New System.Windows.Forms.MenuItem
    Me.menuItem30 = New System.Windows.Forms.MenuItem
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem13_Open = New System.Windows.Forms.MenuItem
    Me.menuItem8_Close = New System.Windows.Forms.MenuItem
    Me.menuItem11 = New System.Windows.Forms.MenuItem
    Me.menuItem10_Save = New System.Windows.Forms.MenuItem
    Me.menuItem12 = New System.Windows.Forms.MenuItem
    Me.menuItem29_PageSetup = New System.Windows.Forms.MenuItem
    Me.menuItem28_PrintPreview = New System.Windows.Forms.MenuItem
    Me.menuItem7_Print = New System.Windows.Forms.MenuItem
    Me.menuItem15 = New System.Windows.Forms.MenuItem
    Me.menuItem16_Exit = New System.Windows.Forms.MenuItem
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.menuItem18 = New System.Windows.Forms.MenuItem
    Me.contextMenu1 = New System.Windows.Forms.ContextMenu
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.printDialog1 = New System.Windows.Forms.PrintDialog
    Me.SuspendLayout()
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
    'menuItem33_WordWrap
    '
    Me.menuItem33_WordWrap.Index = 0
    Me.menuItem33_WordWrap.Text = "Word Wrap"
    '
    'menuItem32
    '
    Me.menuItem32.Index = 2
    Me.menuItem32.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem33_WordWrap, Me.menuItem34_Font})
    Me.menuItem32.Text = "Format"
    '
    'menuItem34_Font
    '
    Me.menuItem34_Font.Index = 1
    Me.menuItem34_Font.Text = "Font"
    '
    'menuItem23_Copy
    '
    Me.menuItem23_Copy.Index = 4
    Me.menuItem23_Copy.Text = "Copy"
    '
    'menuItem22_Cut
    '
    Me.menuItem22_Cut.Index = 3
    Me.menuItem22_Cut.Text = "Cut"
    '
    'menuItem21
    '
    Me.menuItem21.Index = 2
    Me.menuItem21.Text = "-"
    '
    'menuItem27_SelectAll
    '
    Me.menuItem27_SelectAll.Index = 8
    Me.menuItem27_SelectAll.Text = "Select All"
    '
    'menuItem26
    '
    Me.menuItem26.Index = 7
    Me.menuItem26.Text = "-"
    '
    'menuItem24_Paste
    '
    Me.menuItem24_Paste.Index = 5
    Me.menuItem24_Paste.Text = "Paste"
    '
    'menuItem20_Redo
    '
    Me.menuItem20_Redo.Index = 1
    Me.menuItem20_Redo.Text = "Redo"
    '
    'menuItem5_Delete
    '
    Me.menuItem5_Delete.Index = 6
    Me.menuItem5_Delete.Text = "Delete"
    '
    'menuItem31
    '
    Me.menuItem31.Index = 1
    Me.menuItem31.Text = "RichText file"
    '
    'menuItem9_SaveAs
    '
    Me.menuItem9_SaveAs.Index = 5
    Me.menuItem9_SaveAs.Text = "Save As"
    '
    'menuItem14_RecentFiles4
    '
    Me.menuItem14_RecentFiles4.Index = 10
    Me.menuItem14_RecentFiles4.Text = "Recent files"
    '
    'text_Box1
    '
    Me.text_Box1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.text_Box1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.text_Box1.Location = New System.Drawing.Point(0, 28)
    Me.text_Box1.Multiline = True
    Me.text_Box1.Name = "text_Box1"
    Me.text_Box1.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.text_Box1.Size = New System.Drawing.Size(208, 41)
    Me.text_Box1.TabIndex = 5
    Me.text_Box1.Text = ""
    '
    'fontDialog1
    '
    Me.fontDialog1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.fontDialog1.ShowColor = True
    '
    'printPreviewDialog1
    '
    Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
    Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
    Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
    Me.printPreviewDialog1.Document = Me.printDocument1
    Me.printPreviewDialog1.Enabled = True
    Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
    Me.printPreviewDialog1.Location = New System.Drawing.Point(17, 17)
    Me.printPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
    Me.printPreviewDialog1.Name = "printPreviewDialog1"
    Me.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
    Me.printPreviewDialog1.Visible = False
    '
    'pageSetupDialog1
    '
    Me.pageSetupDialog1.Document = Me.printDocument1
    '
    'imageList1
    '
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
    '
    'menuItem19_Undo
    '
    Me.menuItem19_Undo.Index = 0
    Me.menuItem19_Undo.Text = "Undo"
    '
    'saveFileDialog1
    '
    Me.saveFileDialog1.Filter = "Fortran files (*.f95)|*.f95|All files (*.*)|*.*"
    '
    'toolBarButton2__Open
    '
    Me.toolBarButton2__Open.ImageIndex = 1
    '
    'menuItem6
    '
    Me.menuItem6.Index = 0
    Me.menuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem30, Me.menuItem31})
    Me.menuItem6.Text = "New"
    '
    'menuItem30
    '
    Me.menuItem30.Index = 0
    Me.menuItem30.Text = "Text file"
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem6, Me.menuItem13_Open, Me.menuItem8_Close, Me.menuItem11, Me.menuItem10_Save, Me.menuItem9_SaveAs, Me.menuItem12, Me.menuItem29_PageSetup, Me.menuItem28_PrintPreview, Me.menuItem7_Print, Me.menuItem14_RecentFiles4, Me.menuItem15, Me.menuItem16_Exit})
    Me.menuItem1.MergeType = System.Windows.Forms.MenuMerge.Replace
    Me.menuItem1.Text = "&File"
    '
    'menuItem13_Open
    '
    Me.menuItem13_Open.Index = 1
    Me.menuItem13_Open.Text = "&Open"
    '
    'menuItem8_Close
    '
    Me.menuItem8_Close.Index = 2
    Me.menuItem8_Close.Text = "Close"
    '
    'menuItem11
    '
    Me.menuItem11.Index = 3
    Me.menuItem11.Text = "-"
    '
    'menuItem10_Save
    '
    Me.menuItem10_Save.Enabled = False
    Me.menuItem10_Save.Index = 4
    Me.menuItem10_Save.Text = "Save"
    '
    'menuItem12
    '
    Me.menuItem12.Index = 6
    Me.menuItem12.Text = "-"
    '
    'menuItem29_PageSetup
    '
    Me.menuItem29_PageSetup.Index = 7
    Me.menuItem29_PageSetup.Text = "Page Setup"
    '
    'menuItem28_PrintPreview
    '
    Me.menuItem28_PrintPreview.Index = 8
    Me.menuItem28_PrintPreview.Text = "Print Preview"
    '
    'menuItem7_Print
    '
    Me.menuItem7_Print.Index = 9
    Me.menuItem7_Print.Text = "Print..."
    '
    'menuItem15
    '
    Me.menuItem15.Index = 11
    Me.menuItem15.Text = "-"
    '
    'menuItem16_Exit
    '
    Me.menuItem16_Exit.Index = 12
    Me.menuItem16_Exit.Text = "Exit"
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem18, Me.menuItem32, Me.menuItem2})
    '
    'menuItem18
    '
    Me.menuItem18.Index = 1
    Me.menuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem19_Undo, Me.menuItem20_Redo, Me.menuItem21, Me.menuItem22_Cut, Me.menuItem23_Copy, Me.menuItem24_Paste, Me.menuItem5_Delete, Me.menuItem26, Me.menuItem27_SelectAll})
    Me.menuItem18.Text = "&Edit"
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
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton2__Open})
    Me.toolBar1.ButtonSize = New System.Drawing.Size(16, 16)
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(208, 28)
    Me.toolBar1.TabIndex = 6
    '
    'printDialog1
    '
    Me.printDialog1.AllowSomePages = True
    Me.printDialog1.Document = Me.printDocument1
    '
    'Form2
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(208, 69)
    Me.Controls.Add(Me.text_Box1)
    Me.Controls.Add(Me.toolBar1)
    Me.Menu = Me.mainMenu1
    Me.Name = "Form2"
    Me.Text = "Form2"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
