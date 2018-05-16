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
  Friend WithEvents toolBarButton7 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton8 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton9 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton4 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton5 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton6 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton10 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton18_DrawingPaste As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton19_DrawingDelete As System.Windows.Forms.ToolBarButton
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents toolBarButton11 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton16_DrawingCut As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton17_DrawingCopy As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents color_Picker1 As Salford.VisualClearWin.Color_Picker
  Friend WithEvents toolBarButton0 As System.Windows.Forms.ToolBarButton
  Friend WithEvents contextMenu1 As System.Windows.Forms.ContextMenu
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton2 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton3 As System.Windows.Forms.ToolBarButton
  Friend WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
  Friend WithEvents drawingPanel1 As Salford.VisualClearWin.Drawing_Panel
  Friend WithEvents menuItem8 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem9_New As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem11_Open As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem12_Save As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem13_SaveAs As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem14 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem11_Print As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem11 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem15_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents statusBarPanel1 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents statusBarPanel2 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents printDialog1 As System.Windows.Forms.PrintDialog
  Friend WithEvents menuItem6_DrawingCopy As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem7_DrawingPaste As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem8_DrawingDelete As System.Windows.Forms.MenuItem
  Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents contextMenu2 As System.Windows.Forms.ContextMenu
  Friend WithEvents menuItem5_DrawingCut As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem9_DrawingSelectAll As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem10 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem11_DrawingCopyTo As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem12_DrawingPasteFrom As System.Windows.Forms.MenuItem
  Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.toolBarButton7 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton8 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton9 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton4 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton5 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton6 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton10 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton18_DrawingPaste = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton19_DrawingDelete = New System.Windows.Forms.ToolBarButton
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.toolBarButton11 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton16_DrawingCut = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton17_DrawingCopy = New System.Windows.Forms.ToolBarButton
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.color_Picker1 = New Salford.VisualClearWin.Color_Picker
    Me.toolBarButton0 = New System.Windows.Forms.ToolBarButton
    Me.contextMenu1 = New System.Windows.Forms.ContextMenu
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton
    Me.printDocument1 = New System.Drawing.Printing.PrintDocument
    Me.drawingPanel1 = New Salford.VisualClearWin.Drawing_Panel
    Me.menuItem8 = New System.Windows.Forms.MenuItem
    Me.menuItem9_New = New System.Windows.Forms.MenuItem
    Me.menuItem11_Open = New System.Windows.Forms.MenuItem
    Me.menuItem12_Save = New System.Windows.Forms.MenuItem
    Me.menuItem13_SaveAs = New System.Windows.Forms.MenuItem
    Me.menuItem14 = New System.Windows.Forms.MenuItem
    Me.menuItem11_Print = New System.Windows.Forms.MenuItem
    Me.menuItem11 = New System.Windows.Forms.MenuItem
    Me.menuItem15_Exit = New System.Windows.Forms.MenuItem
    Me.statusBarPanel1 = New System.Windows.Forms.StatusBarPanel
    Me.statusBarPanel2 = New System.Windows.Forms.StatusBarPanel
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.printDialog1 = New System.Windows.Forms.PrintDialog
    Me.menuItem6_DrawingCopy = New System.Windows.Forms.MenuItem
    Me.menuItem7_DrawingPaste = New System.Windows.Forms.MenuItem
    Me.menuItem8_DrawingDelete = New System.Windows.Forms.MenuItem
    Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.contextMenu2 = New System.Windows.Forms.ContextMenu
    Me.menuItem5_DrawingCut = New System.Windows.Forms.MenuItem
    Me.menuItem9_DrawingSelectAll = New System.Windows.Forms.MenuItem
    Me.menuItem10 = New System.Windows.Forms.MenuItem
    Me.menuItem11_DrawingCopyTo = New System.Windows.Forms.MenuItem
    Me.menuItem12_DrawingPasteFrom = New System.Windows.Forms.MenuItem
    Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.statusBar1 = New System.Windows.Forms.StatusBar
    Me.toolBar1.SuspendLayout()
    CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.statusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'toolBarButton7
    '
    Me.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton8
    '
    Me.toolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton9
    '
    Me.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton4
    '
    Me.toolBarButton4.ImageIndex = 3
    Me.toolBarButton4.ToolTipText = "Draw rectangle"
    '
    'toolBarButton5
    '
    Me.toolBarButton5.ImageIndex = 4
    Me.toolBarButton5.ToolTipText = "Draw ellipse"
    '
    'toolBarButton6
    '
    Me.toolBarButton6.ImageIndex = 6
    Me.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    Me.toolBarButton6.ToolTipText = "Select a rectangle"
    '
    'toolBarButton10
    '
    Me.toolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton18_DrawingPaste
    '
    Me.toolBarButton18_DrawingPaste.ImageIndex = 9
    Me.toolBarButton18_DrawingPaste.ToolTipText = "Paste"
    '
    'toolBarButton19_DrawingDelete
    '
    Me.toolBarButton19_DrawingDelete.ImageIndex = 10
    Me.toolBarButton19_DrawingDelete.ToolTipText = "Delete"
    '
    'imageList1
    '
    Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.White
    '
    'toolBarButton11
    '
    Me.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton16_DrawingCut
    '
    Me.toolBarButton16_DrawingCut.ImageIndex = 7
    Me.toolBarButton16_DrawingCut.ToolTipText = "Cut"
    '
    'toolBarButton17_DrawingCopy
    '
    Me.toolBarButton17_DrawingCopy.ImageIndex = 8
    Me.toolBarButton17_DrawingCopy.ToolTipText = "Copy"
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton0, Me.toolBarButton1, Me.toolBarButton2, Me.toolBarButton3, Me.toolBarButton4, Me.toolBarButton5, Me.toolBarButton6, Me.toolBarButton7, Me.toolBarButton8, Me.toolBarButton9, Me.toolBarButton10, Me.toolBarButton11, Me.toolBarButton16_DrawingCut, Me.toolBarButton17_DrawingCopy, Me.toolBarButton18_DrawingPaste, Me.toolBarButton19_DrawingDelete})
    Me.toolBar1.ButtonSize = New System.Drawing.Size(23, 22)
    Me.toolBar1.Controls.Add(Me.color_Picker1)
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(610, 28)
    Me.toolBar1.TabIndex = 3
    '
    'color_Picker1
    '
    Me.color_Picker1.ColorPanelLocation = New System.Drawing.Point(23, 3)
    Me.color_Picker1.ColorPanelShow = True
    Me.color_Picker1.ColorPanelSize = New System.Drawing.Size(4, 17)
    Me.color_Picker1.Colour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte))
    Me.color_Picker1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.color_Picker1.Image = CType(resources.GetObject("color_Picker1.Image"), System.Drawing.Image)
    Me.color_Picker1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.color_Picker1.Location = New System.Drawing.Point(180, 0)
    Me.color_Picker1.Name = "color_Picker1"
    Me.color_Picker1.Size = New System.Drawing.Size(32, 23)
    Me.color_Picker1.TabIndex = 10
    Me.toolTip1.SetToolTip(Me.color_Picker1, "Select the drawing colour")
    Me.color_Picker1.Value = -65536
    '
    'toolBarButton0
    '
    Me.toolBarButton0.DropDownMenu = Me.contextMenu1
    Me.toolBarButton0.ImageIndex = 11
    Me.toolBarButton0.Pushed = True
    Me.toolBarButton0.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
    Me.toolBarButton0.ToolTipText = "Draw pixels"
    '
    'contextMenu1
    '
    Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem2, Me.menuItem3, Me.menuItem4})
    '
    'menuItem1
    '
    Me.menuItem1.Checked = True
    Me.menuItem1.Index = 0
    Me.menuItem1.Text = "1 pixel"
    '
    'menuItem2
    '
    Me.menuItem2.Index = 1
    Me.menuItem2.Text = "2 pixels"
    '
    'menuItem3
    '
    Me.menuItem3.Index = 2
    Me.menuItem3.Text = "3 pixels"
    '
    'menuItem4
    '
    Me.menuItem4.Index = 3
    Me.menuItem4.Text = "4 pixels"
    '
    'toolBarButton1
    '
    Me.toolBarButton1.ImageIndex = 0
    Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    Me.toolBarButton1.ToolTipText = "Draw line"
    '
    'toolBarButton2
    '
    Me.toolBarButton2.ImageIndex = 1
    Me.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    Me.toolBarButton2.ToolTipText = "Draw filled rectangle"
    '
    'toolBarButton3
    '
    Me.toolBarButton3.ImageIndex = 2
    Me.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    Me.toolBarButton3.ToolTipText = "Draw filled ellipse"
    '
    'drawingPanel1
    '
    Me.drawingPanel1.BackColor = System.Drawing.Color.White
    Me.drawingPanel1.BitmapSize = New System.Drawing.Size(800, 400)
    Me.drawingPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.drawingPanel1.Cursor = System.Windows.Forms.Cursors.Cross
    Me.drawingPanel1.FillColor = System.Drawing.Color.Red
    Me.drawingPanel1.LineColor = System.Drawing.Color.Red
    Me.drawingPanel1.Location = New System.Drawing.Point(3, 30)
    Me.drawingPanel1.Name = "drawingPanel1"
    Me.drawingPanel1.Pivoting = Salford.VisualClearWin.Pivot.Full
    Me.drawingPanel1.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.drawingPanel1.Size = New System.Drawing.Size(604, 315)
    Me.drawingPanel1.StringColor = System.Drawing.Color.Black
    Me.drawingPanel1.TabIndex = 2
    '
    'menuItem8
    '
    Me.menuItem8.Index = 0
    Me.menuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem9_New, Me.menuItem11_Open, Me.menuItem12_Save, Me.menuItem13_SaveAs, Me.menuItem14, Me.menuItem11_Print, Me.menuItem11, Me.menuItem15_Exit})
    Me.menuItem8.Text = "File"
    '
    'menuItem9_New
    '
    Me.menuItem9_New.Index = 0
    Me.menuItem9_New.Text = "New"
    '
    'menuItem11_Open
    '
    Me.menuItem11_Open.Index = 1
    Me.menuItem11_Open.Text = "Open"
    '
    'menuItem12_Save
    '
    Me.menuItem12_Save.Index = 2
    Me.menuItem12_Save.Text = "Save"
    '
    'menuItem13_SaveAs
    '
    Me.menuItem13_SaveAs.Index = 3
    Me.menuItem13_SaveAs.Text = "Save As"
    '
    'menuItem14
    '
    Me.menuItem14.Index = 4
    Me.menuItem14.Text = "-"
    '
    'menuItem11_Print
    '
    Me.menuItem11_Print.Index = 5
    Me.menuItem11_Print.Text = "Print"
    '
    'menuItem11
    '
    Me.menuItem11.Index = 6
    Me.menuItem11.Text = "-"
    '
    'menuItem15_Exit
    '
    Me.menuItem15_Exit.Index = 7
    Me.menuItem15_Exit.Text = "Exit"
    '
    'statusBarPanel1
    '
    Me.statusBarPanel1.Width = 400
    '
    'statusBarPanel2
    '
    Me.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
    Me.statusBarPanel2.Text = "(0,0)"
    Me.statusBarPanel2.Width = 194
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem8})
    '
    'printDialog1
    '
    Me.printDialog1.Document = Me.printDocument1
    '
    'menuItem6_DrawingCopy
    '
    Me.menuItem6_DrawingCopy.Index = 1
    Me.menuItem6_DrawingCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC
    Me.menuItem6_DrawingCopy.Text = "Copy"
    '
    'menuItem7_DrawingPaste
    '
    Me.menuItem7_DrawingPaste.Index = 2
    Me.menuItem7_DrawingPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV
    Me.menuItem7_DrawingPaste.Text = "Paste"
    '
    'menuItem8_DrawingDelete
    '
    Me.menuItem8_DrawingDelete.Index = 3
    Me.menuItem8_DrawingDelete.Shortcut = System.Windows.Forms.Shortcut.Del
    Me.menuItem8_DrawingDelete.Text = "Delete"
    '
    'contextMenu2
    '
    Me.contextMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem5_DrawingCut, Me.menuItem6_DrawingCopy, Me.menuItem7_DrawingPaste, Me.menuItem8_DrawingDelete, Me.menuItem9_DrawingSelectAll, Me.menuItem10, Me.menuItem11_DrawingCopyTo, Me.menuItem12_DrawingPasteFrom})
    '
    'menuItem5_DrawingCut
    '
    Me.menuItem5_DrawingCut.Index = 0
    Me.menuItem5_DrawingCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX
    Me.menuItem5_DrawingCut.Text = "Cut"
    '
    'menuItem9_DrawingSelectAll
    '
    Me.menuItem9_DrawingSelectAll.Index = 4
    Me.menuItem9_DrawingSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA
    Me.menuItem9_DrawingSelectAll.Text = "Select All"
    '
    'menuItem10
    '
    Me.menuItem10.Index = 5
    Me.menuItem10.Text = "-"
    '
    'menuItem11_DrawingCopyTo
    '
    Me.menuItem11_DrawingCopyTo.Index = 6
    Me.menuItem11_DrawingCopyTo.Text = "Copy To"
    '
    'menuItem12_DrawingPasteFrom
    '
    Me.menuItem12_DrawingPasteFrom.Index = 7
    Me.menuItem12_DrawingPasteFrom.Text = "Paste From"
    '
    'saveFileDialog1
    '
    Me.saveFileDialog1.DefaultExt = "bmp"
    Me.saveFileDialog1.Filter = "Bitmap files|*.bmp|All files|*.*"
    Me.saveFileDialog1.Title = "Copy To"
    '
    'openFileDialog1
    '
    Me.openFileDialog1.DefaultExt = "bmp"
    Me.openFileDialog1.Filter = "Bitmap files|*.bmp|All files|*.*"
    Me.openFileDialog1.Title = "Paste From"
    '
    'statusBar1
    '
    Me.statusBar1.Location = New System.Drawing.Point(0, 345)
    Me.statusBar1.Name = "statusBar1"
    Me.statusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.statusBarPanel1, Me.statusBarPanel2})
    Me.statusBar1.ShowPanels = True
    Me.statusBar1.Size = New System.Drawing.Size(610, 24)
    Me.statusBar1.TabIndex = 1
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(610, 369)
    Me.Controls.Add(Me.toolBar1)
    Me.Controls.Add(Me.drawingPanel1)
    Me.Controls.Add(Me.statusBar1)
    Me.Menu = Me.mainMenu1
    Me.Name = "Form1"
    Me.Text = "Paint"
    Me.toolBar1.ResumeLayout(False)
    CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.statusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
