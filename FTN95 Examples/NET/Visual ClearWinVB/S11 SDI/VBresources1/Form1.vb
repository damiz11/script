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
  Friend WithEvents toolBarButton6 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton2 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton3 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton5 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton10 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton15 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton16 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton17 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton14 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton11 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton12 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton13 As System.Windows.Forms.ToolBarButton
  Friend WithEvents fontDialog1 As System.Windows.Forms.FontDialog
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents toolBarButton1_New As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton2_Open As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton3_Save As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton4 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton5_Cut As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton6_Copy As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton7_Paste As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton18 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton_Print As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton20 As System.Windows.Forms.ToolBarButton
  Friend WithEvents pageSetupDialog1 As System.Windows.Forms.PageSetupDialog
  Friend WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
  Friend WithEvents printDialog1 As System.Windows.Forms.PrintDialog
  Friend WithEvents printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
  Friend WithEvents menuItem14_Undo As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem16 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem17_Cut As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem13 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem18_Copy As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem19_Paste As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5_RecentFiles4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem7_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
  Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents menuItem21 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem15 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem20_WordWrap As System.Windows.Forms.MenuItem
  Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents comboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem2_New As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3_Open As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem8_Save As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem9_SaveAs As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem11_PageSetup As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem12_PrintPreview As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem10_Print As System.Windows.Forms.MenuItem
  Friend WithEvents text_Box1 As Salford.VisualClearWin.Text_Box
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.toolBarButton7 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton8 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton9 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton6 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton5 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton10 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton15 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton16 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton17 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton14 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton11 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton12 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton13 = New System.Windows.Forms.ToolBarButton
    Me.fontDialog1 = New System.Windows.Forms.FontDialog
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.toolBarButton1_New = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton2_Open = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton3_Save = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton4 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton5_Cut = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton6_Copy = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton7_Paste = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton18 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton_Print = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton20 = New System.Windows.Forms.ToolBarButton
    Me.pageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
    Me.printDocument1 = New System.Drawing.Printing.PrintDocument
    Me.printDialog1 = New System.Windows.Forms.PrintDialog
    Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
    Me.menuItem14_Undo = New System.Windows.Forms.MenuItem
    Me.menuItem16 = New System.Windows.Forms.MenuItem
    Me.menuItem17_Cut = New System.Windows.Forms.MenuItem
    Me.menuItem13 = New System.Windows.Forms.MenuItem
    Me.menuItem18_Copy = New System.Windows.Forms.MenuItem
    Me.menuItem19_Paste = New System.Windows.Forms.MenuItem
    Me.menuItem5_RecentFiles4 = New System.Windows.Forms.MenuItem
    Me.menuItem6 = New System.Windows.Forms.MenuItem
    Me.menuItem7_Exit = New System.Windows.Forms.MenuItem
    Me.statusBar1 = New System.Windows.Forms.StatusBar
    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
    Me.menuItem21 = New System.Windows.Forms.MenuItem
    Me.menuItem15 = New System.Windows.Forms.MenuItem
    Me.menuItem20_WordWrap = New System.Windows.Forms.MenuItem
    Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.comboBox1 = New System.Windows.Forms.ComboBox
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem2_New = New System.Windows.Forms.MenuItem
    Me.menuItem3_Open = New System.Windows.Forms.MenuItem
    Me.menuItem8_Save = New System.Windows.Forms.MenuItem
    Me.menuItem9_SaveAs = New System.Windows.Forms.MenuItem
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem11_PageSetup = New System.Windows.Forms.MenuItem
    Me.menuItem12_PrintPreview = New System.Windows.Forms.MenuItem
    Me.menuItem10_Print = New System.Windows.Forms.MenuItem
    Me.text_Box1 = New Salford.VisualClearWin.Text_Box
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
    'toolBarButton6
    '
    Me.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton2
    '
    Me.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton3
    '
    Me.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton5
    '
    Me.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton10
    '
    Me.toolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton15
    '
    Me.toolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton16
    '
    Me.toolBarButton16.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton17
    '
    Me.toolBarButton17.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton14
    '
    Me.toolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton11
    '
    Me.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton12
    '
    Me.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton13
    '
    Me.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'fontDialog1
    '
    Me.fontDialog1.ShowColor = True
    '
    'imageList1
    '
    Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1_New, Me.toolBarButton2_Open, Me.toolBarButton3_Save, Me.toolBarButton4, Me.toolBarButton5_Cut, Me.toolBarButton6_Copy, Me.toolBarButton7_Paste, Me.toolBarButton1, Me.toolBarButton2, Me.toolBarButton3, Me.toolBarButton5, Me.toolBarButton6, Me.toolBarButton7, Me.toolBarButton8, Me.toolBarButton9, Me.toolBarButton10, Me.toolBarButton11, Me.toolBarButton12, Me.toolBarButton13, Me.toolBarButton14, Me.toolBarButton15, Me.toolBarButton16, Me.toolBarButton17, Me.toolBarButton18, Me.toolBarButton_Print, Me.toolBarButton20})
    Me.toolBar1.ButtonSize = New System.Drawing.Size(16, 16)
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(696, 28)
    Me.toolBar1.TabIndex = 4
    '
    'toolBarButton1_New
    '
    Me.toolBarButton1_New.ImageIndex = 0
    Me.toolBarButton1_New.ToolTipText = "New"
    '
    'toolBarButton2_Open
    '
    Me.toolBarButton2_Open.ImageIndex = 1
    Me.toolBarButton2_Open.ToolTipText = "Open"
    '
    'toolBarButton3_Save
    '
    Me.toolBarButton3_Save.ImageIndex = 2
    Me.toolBarButton3_Save.ToolTipText = "Save"
    '
    'toolBarButton4
    '
    Me.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton5_Cut
    '
    Me.toolBarButton5_Cut.ImageIndex = 4
    Me.toolBarButton5_Cut.ToolTipText = "Cut"
    '
    'toolBarButton6_Copy
    '
    Me.toolBarButton6_Copy.ImageIndex = 5
    Me.toolBarButton6_Copy.ToolTipText = "Copy"
    '
    'toolBarButton7_Paste
    '
    Me.toolBarButton7_Paste.ImageIndex = 6
    Me.toolBarButton7_Paste.ToolTipText = "Paste"
    '
    'toolBarButton1
    '
    Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    Me.toolBarButton1.Text = "comboBox1"
    '
    'toolBarButton18
    '
    Me.toolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    Me.toolBarButton18.Text = "comboBox1"
    '
    'toolBarButton_Print
    '
    Me.toolBarButton_Print.ImageIndex = 7
    Me.toolBarButton_Print.ToolTipText = "Print"
    '
    'toolBarButton20
    '
    Me.toolBarButton20.ImageIndex = 8
    Me.toolBarButton20.ToolTipText = "Find"
    '
    'pageSetupDialog1
    '
    Me.pageSetupDialog1.Document = Me.printDocument1
    '
    'printDialog1
    '
    Me.printDialog1.AllowSomePages = True
    Me.printDialog1.Document = Me.printDocument1
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
    'menuItem14_Undo
    '
    Me.menuItem14_Undo.Index = 0
    Me.menuItem14_Undo.Text = "Undo|Undoes the last edit"
    '
    'menuItem16
    '
    Me.menuItem16.Index = 1
    Me.menuItem16.Text = "-"
    '
    'menuItem17_Cut
    '
    Me.menuItem17_Cut.Index = 2
    Me.menuItem17_Cut.Text = "Cut|Cuts the selection to the clipboard"
    '
    'menuItem13
    '
    Me.menuItem13.Index = 1
    Me.menuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem14_Undo, Me.menuItem16, Me.menuItem17_Cut, Me.menuItem18_Copy, Me.menuItem19_Paste})
    Me.menuItem13.Text = "Edit"
    '
    'menuItem18_Copy
    '
    Me.menuItem18_Copy.Index = 3
    Me.menuItem18_Copy.Text = "Copy|Copies the selection to the clipboard"
    '
    'menuItem19_Paste
    '
    Me.menuItem19_Paste.Index = 4
    Me.menuItem19_Paste.Text = "Paste|Pastes the clipboard at the current position"
    '
    'menuItem5_RecentFiles4
    '
    Me.menuItem5_RecentFiles4.Index = 8
    Me.menuItem5_RecentFiles4.Text = "Recent files"
    '
    'menuItem6
    '
    Me.menuItem6.Index = 9
    Me.menuItem6.Text = "-"
    '
    'menuItem7_Exit
    '
    Me.menuItem7_Exit.Index = 10
    Me.menuItem7_Exit.Text = "Exit|Exits from the application"
    '
    'statusBar1
    '
    Me.statusBar1.Location = New System.Drawing.Point(0, 401)
    Me.statusBar1.Name = "statusBar1"
    Me.statusBar1.Size = New System.Drawing.Size(696, 24)
    Me.statusBar1.TabIndex = 1
    Me.statusBar1.Text = "Ready"
    '
    'openFileDialog1
    '
    Me.openFileDialog1.Filter = "Fotran files (*.f95)|*.f95|All files (*.*)|*.*"
    '
    'saveFileDialog1
    '
    Me.saveFileDialog1.Filter = "Fortran files (*.f95)|*.f95|All files (*.*)|*.*"
    '
    'menuItem21
    '
    Me.menuItem21.Index = 1
    Me.menuItem21.Text = "Font...|Displays the Font dialog"
    '
    'menuItem15
    '
    Me.menuItem15.Index = 2
    Me.menuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem20_WordWrap, Me.menuItem21})
    Me.menuItem15.Text = "Format"
    '
    'menuItem20_WordWrap
    '
    Me.menuItem20_WordWrap.Index = 0
    Me.menuItem20_WordWrap.Text = "Word Wrap|Toggles the Word Wrap property"
    '
    'comboBox1
    '
    Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.comboBox1.Items.AddRange(New Object() {"Courier New", "Microsoft Sans Serif"})
    Me.comboBox1.Location = New System.Drawing.Point(150, 4)
    Me.comboBox1.MaxDropDownItems = 16
    Me.comboBox1.MaxLength = 80
    Me.comboBox1.Name = "comboBox1"
    Me.comboBox1.Size = New System.Drawing.Size(126, 21)
    Me.comboBox1.TabIndex = 10
    Me.toolTip1.SetToolTip(Me.comboBox1, "Font name")
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem13, Me.menuItem15})
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2_New, Me.menuItem3_Open, Me.menuItem8_Save, Me.menuItem9_SaveAs, Me.menuItem4, Me.menuItem11_PageSetup, Me.menuItem12_PrintPreview, Me.menuItem10_Print, Me.menuItem5_RecentFiles4, Me.menuItem6, Me.menuItem7_Exit})
    Me.menuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems
    Me.menuItem1.Text = "&File"
    '
    'menuItem2_New
    '
    Me.menuItem2_New.Index = 0
    Me.menuItem2_New.Text = "New|Creates a new document"
    '
    'menuItem3_Open
    '
    Me.menuItem3_Open.Index = 1
    Me.menuItem3_Open.Text = "&Open|Opens files"
    '
    'menuItem8_Save
    '
    Me.menuItem8_Save.Enabled = False
    Me.menuItem8_Save.Index = 2
    Me.menuItem8_Save.Text = "Save|Saves the document"
    '
    'menuItem9_SaveAs
    '
    Me.menuItem9_SaveAs.Index = 3
    Me.menuItem9_SaveAs.Text = "Save As|Saves the document with a different name"
    '
    'menuItem4
    '
    Me.menuItem4.Index = 4
    Me.menuItem4.Text = "-"
    '
    'menuItem11_PageSetup
    '
    Me.menuItem11_PageSetup.Index = 5
    Me.menuItem11_PageSetup.Text = "Page Setup|Displays the Page Setup dialog"
    '
    'menuItem12_PrintPreview
    '
    Me.menuItem12_PrintPreview.Index = 6
    Me.menuItem12_PrintPreview.Text = "Print Preview|Displays the Print Preview dialog"
    '
    'menuItem10_Print
    '
    Me.menuItem10_Print.Index = 7
    Me.menuItem10_Print.Text = "Print...|Starts a printing process"
    '
    'text_Box1
    '
    Me.text_Box1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.text_Box1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.text_Box1.HideSelection = False
    Me.text_Box1.Location = New System.Drawing.Point(0, 28)
    Me.text_Box1.MaxLength = 0
    Me.text_Box1.Multiline = True
    Me.text_Box1.Name = "text_Box1"
    Me.text_Box1.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.text_Box1.Size = New System.Drawing.Size(696, 373)
    Me.text_Box1.TabIndex = 0
    Me.text_Box1.Text = ""
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(696, 425)
    Me.Controls.Add(Me.text_Box1)
    Me.Controls.Add(Me.toolBar1)
    Me.Controls.Add(Me.statusBar1)
    Me.Controls.Add(Me.comboBox1)
    Me.Menu = Me.mainMenu1
    Me.Name = "Form1"
    Me.Text = "MyNotes"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
