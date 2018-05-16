Public Class Form4
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
  Friend WithEvents menuItem16_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem30 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem31 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem13_Open As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem8_Close As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem11 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5_PrintPreview As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5_Print As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem14_RecentFiles4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem15 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3_Cascade As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4_TileHorizontal As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5_TileVertical As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem17 As System.Windows.Forms.MenuItem
  Friend WithEvents contextMenu1 As System.Windows.Forms.ContextMenu
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
  Friend WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton2_Open As System.Windows.Forms.ToolBarButton
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents printDialog1 As System.Windows.Forms.PrintDialog
  Friend WithEvents drawing_Panel1 As Salford.VisualClearWin.Drawing_Panel
  Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form4))
    Me.menuItem16_Exit = New System.Windows.Forms.MenuItem
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem6 = New System.Windows.Forms.MenuItem
    Me.menuItem30 = New System.Windows.Forms.MenuItem
    Me.menuItem31 = New System.Windows.Forms.MenuItem
    Me.menuItem13_Open = New System.Windows.Forms.MenuItem
    Me.menuItem8_Close = New System.Windows.Forms.MenuItem
    Me.menuItem11 = New System.Windows.Forms.MenuItem
    Me.menuItem5_PrintPreview = New System.Windows.Forms.MenuItem
    Me.menuItem5_Print = New System.Windows.Forms.MenuItem
    Me.menuItem14_RecentFiles4 = New System.Windows.Forms.MenuItem
    Me.menuItem15 = New System.Windows.Forms.MenuItem
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.menuItem3_Cascade = New System.Windows.Forms.MenuItem
    Me.menuItem4_TileHorizontal = New System.Windows.Forms.MenuItem
    Me.menuItem5_TileVertical = New System.Windows.Forms.MenuItem
    Me.menuItem17 = New System.Windows.Forms.MenuItem
    Me.contextMenu1 = New System.Windows.Forms.ContextMenu
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
    Me.printDocument1 = New System.Drawing.Printing.PrintDocument
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton2_Open = New System.Windows.Forms.ToolBarButton
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.printDialog1 = New System.Windows.Forms.PrintDialog
    Me.drawing_Panel1 = New Salford.VisualClearWin.Drawing_Panel
    Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
    Me.SuspendLayout()
    '
    'menuItem16_Exit
    '
    Me.menuItem16_Exit.Index = 8
    Me.menuItem16_Exit.Text = "Exit"
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem2})
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem6, Me.menuItem13_Open, Me.menuItem8_Close, Me.menuItem11, Me.menuItem5_PrintPreview, Me.menuItem5_Print, Me.menuItem14_RecentFiles4, Me.menuItem15, Me.menuItem16_Exit})
    Me.menuItem1.MergeType = System.Windows.Forms.MenuMerge.Replace
    Me.menuItem1.Text = "&File"
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
    'menuItem31
    '
    Me.menuItem31.Index = 1
    Me.menuItem31.Text = "RichText file"
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
    'menuItem5_PrintPreview
    '
    Me.menuItem5_PrintPreview.Index = 4
    Me.menuItem5_PrintPreview.Text = "Print Preview"
    '
    'menuItem5_Print
    '
    Me.menuItem5_Print.Index = 5
    Me.menuItem5_Print.Text = "Print..."
    '
    'menuItem14_RecentFiles4
    '
    Me.menuItem14_RecentFiles4.Index = 6
    Me.menuItem14_RecentFiles4.Text = "Recent files"
    '
    'menuItem15
    '
    Me.menuItem15.Index = 7
    Me.menuItem15.Text = "-"
    '
    'menuItem2
    '
    Me.menuItem2.Index = 1
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
    'printPreviewDialog1
    '
    Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
    Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
    Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
    Me.printPreviewDialog1.Document = Me.printDocument1
    Me.printPreviewDialog1.Enabled = True
    Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
    Me.printPreviewDialog1.Location = New System.Drawing.Point(44, 58)
    Me.printPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
    Me.printPreviewDialog1.Name = "printPreviewDialog1"
    Me.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
    Me.printPreviewDialog1.Visible = False
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton2_Open})
    Me.toolBar1.ButtonSize = New System.Drawing.Size(16, 16)
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(208, 28)
    Me.toolBar1.TabIndex = 6
    '
    'toolBarButton1
    '
    Me.toolBarButton1.DropDownMenu = Me.contextMenu1
    Me.toolBarButton1.ImageIndex = 0
    Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
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
    'printDialog1
    '
    Me.printDialog1.AllowSomePages = True
    Me.printDialog1.Document = Me.printDocument1
    '
    'drawing_Panel1
    '
    Me.drawing_Panel1.BitmapSize = New System.Drawing.Size(0, 0)
    Me.drawing_Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.drawing_Panel1.FillColor = System.Drawing.Color.Black
    Me.drawing_Panel1.LineColor = System.Drawing.Color.Black
    Me.drawing_Panel1.Location = New System.Drawing.Point(0, 0)
    Me.drawing_Panel1.Name = "drawing_Panel1"
    Me.drawing_Panel1.Size = New System.Drawing.Size(208, 169)
    Me.drawing_Panel1.StringColor = System.Drawing.Color.Black
    Me.drawing_Panel1.TabIndex = 5
    '
    'saveFileDialog1
    '
    Me.saveFileDialog1.Filter = "Fortran files (*.f95)|*.f95|All files (*.*)|*.*"
    '
    'Form4
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(208, 169)
    Me.Controls.Add(Me.toolBar1)
    Me.Controls.Add(Me.drawing_Panel1)
    Me.Menu = Me.mainMenu1
    Me.Name = "Form4"
    Me.Text = "Form4"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
