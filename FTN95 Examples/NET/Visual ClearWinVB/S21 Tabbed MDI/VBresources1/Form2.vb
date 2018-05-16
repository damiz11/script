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
  Friend WithEvents tabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents tabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents textBox1 As System.Windows.Forms.TextBox
  Friend WithEvents toolBarButton_Save As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton_New As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton_Open As System.Windows.Forms.ToolBarButton
  Friend WithEvents menuItemFile As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemNew As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemOpen As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemSave As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemSaveAs As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemRecentFiles As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemExit As System.Windows.Forms.MenuItem
  Friend WithEvents imageList2 As System.Windows.Forms.ImageList
  Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents main_Menu1 As Salford.VisualClearWin.Main_Menu
  Friend WithEvents menuItemWindow As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemCloseAll As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemWindows As System.Windows.Forms.MenuItem
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
    Me.tabControl1 = New System.Windows.Forms.TabControl
    Me.tabPage1 = New System.Windows.Forms.TabPage
    Me.textBox1 = New System.Windows.Forms.TextBox
    Me.toolBarButton_Save = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton_New = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton_Open = New System.Windows.Forms.ToolBarButton
    Me.menuItemFile = New System.Windows.Forms.MenuItem
    Me.menuItemNew = New System.Windows.Forms.MenuItem
    Me.menuItemOpen = New System.Windows.Forms.MenuItem
    Me.menuItemSave = New System.Windows.Forms.MenuItem
    Me.menuItemSaveAs = New System.Windows.Forms.MenuItem
    Me.menuItem5 = New System.Windows.Forms.MenuItem
    Me.menuItemRecentFiles = New System.Windows.Forms.MenuItem
    Me.menuItemExit = New System.Windows.Forms.MenuItem
    Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
    Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
    Me.main_Menu1 = New Salford.VisualClearWin.Main_Menu
    Me.menuItemWindow = New System.Windows.Forms.MenuItem
    Me.menuItemCloseAll = New System.Windows.Forms.MenuItem
    Me.menuItemWindows = New System.Windows.Forms.MenuItem
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.tabControl1.SuspendLayout()
    Me.tabPage1.SuspendLayout()
    Me.SuspendLayout()
    '
    'tabControl1
    '
    Me.tabControl1.Controls.Add(Me.tabPage1)
    Me.tabControl1.Location = New System.Drawing.Point(24, 64)
    Me.tabControl1.Name = "tabControl1"
    Me.tabControl1.SelectedIndex = 0
    Me.tabControl1.Size = New System.Drawing.Size(232, 168)
    Me.tabControl1.TabIndex = 3
    '
    'tabPage1
    '
    Me.tabPage1.Controls.Add(Me.textBox1)
    Me.tabPage1.Location = New System.Drawing.Point(4, 22)
    Me.tabPage1.Name = "tabPage1"
    Me.tabPage1.Size = New System.Drawing.Size(224, 142)
    Me.tabPage1.TabIndex = 0
    Me.tabPage1.Text = "tabPage1"
    '
    'textBox1
    '
    Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.textBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.textBox1.Location = New System.Drawing.Point(0, 0)
    Me.textBox1.Multiline = True
    Me.textBox1.Name = "textBox1"
    Me.textBox1.Size = New System.Drawing.Size(224, 142)
    Me.textBox1.TabIndex = 0
    Me.textBox1.Text = ""
    '
    'toolBarButton_Save
    '
    Me.toolBarButton_Save.ImageIndex = 2
    Me.toolBarButton_Save.ToolTipText = "Save"
    '
    'toolBarButton_New
    '
    Me.toolBarButton_New.ImageIndex = 0
    Me.toolBarButton_New.ToolTipText = "New"
    '
    'toolBarButton_Open
    '
    Me.toolBarButton_Open.ImageIndex = 1
    Me.toolBarButton_Open.ToolTipText = "Open"
    '
    'menuItemFile
    '
    Me.menuItemFile.Index = 0
    Me.menuItemFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemNew, Me.menuItemOpen, Me.menuItemSave, Me.menuItemSaveAs, Me.menuItem5, Me.menuItemRecentFiles, Me.menuItemExit})
    Me.menuItemFile.Text = "File"
    '
    'menuItemNew
    '
    Me.main_Menu1.SetCallback(Me.menuItemNew, "New")
    Me.main_Menu1.SetImageIndex(Me.menuItemNew, "0")
    Me.menuItemNew.Index = 0
    Me.main_Menu1.SetMenuTip(Me.menuItemNew, "Creates a new file")
    Me.menuItemNew.Text = "New"
    '
    'menuItemOpen
    '
    Me.main_Menu1.SetCallback(Me.menuItemOpen, "Open")
    Me.main_Menu1.SetImageIndex(Me.menuItemOpen, "1")
    Me.menuItemOpen.Index = 1
    Me.main_Menu1.SetMenuTip(Me.menuItemOpen, "Opens an existing file")
    Me.menuItemOpen.Text = "Open"
    '
    'menuItemSave
    '
    Me.main_Menu1.SetCallback(Me.menuItemSave, "Save")
    Me.menuItemSave.Enabled = False
    Me.main_Menu1.SetImageIndex(Me.menuItemSave, "2")
    Me.menuItemSave.Index = 2
    Me.main_Menu1.SetMenuTip(Me.menuItemSave, "Saves the current file")
    Me.menuItemSave.Text = "Save"
    '
    'menuItemSaveAs
    '
    Me.main_Menu1.SetCallback(Me.menuItemSaveAs, "SaveAs")
    Me.main_Menu1.SetImageIndex(Me.menuItemSaveAs, "")
    Me.menuItemSaveAs.Index = 3
    Me.main_Menu1.SetMenuTip(Me.menuItemSaveAs, "Saves the current file with a new name.")
    Me.menuItemSaveAs.Text = "Save As"
    '
    'menuItem5
    '
    Me.main_Menu1.SetCallback(Me.menuItem5, Nothing)
    Me.main_Menu1.SetImageIndex(Me.menuItem5, Nothing)
    Me.menuItem5.Index = 4
    Me.main_Menu1.SetMenuTip(Me.menuItem5, Nothing)
    Me.menuItem5.Text = "-"
    '
    'menuItemRecentFiles
    '
    Me.main_Menu1.SetCallback(Me.menuItemRecentFiles, "RecentFiles4")
    Me.main_Menu1.SetImageIndex(Me.menuItemRecentFiles, "")
    Me.menuItemRecentFiles.Index = 5
    Me.main_Menu1.SetMenuTip(Me.menuItemRecentFiles, "")
    Me.menuItemRecentFiles.Text = "Recent Files..."
    '
    'menuItemExit
    '
    Me.main_Menu1.SetCallback(Me.menuItemExit, "Exit")
    Me.main_Menu1.SetImageIndex(Me.menuItemExit, "")
    Me.menuItemExit.Index = 6
    Me.main_Menu1.SetMenuTip(Me.menuItemExit, "Exits from the application")
    Me.menuItemExit.Text = "Exit"
    '
    'imageList2
    '
    Me.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
    Me.imageList2.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList2.TransparentColor = System.Drawing.Color.White
    '
    'saveFileDialog1
    '
    Me.saveFileDialog1.FileName = "doc1"
    '
    'main_Menu1
    '
    Me.main_Menu1.ImageBackColor = System.Drawing.SystemColors.Control
    Me.main_Menu1.ImageList = Me.imageList2
    Me.main_Menu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemFile, Me.menuItemWindow})
    Me.main_Menu1.TextBackColor = System.Drawing.SystemColors.Window
    '
    'menuItemWindow
    '
    Me.menuItemWindow.Index = 1
    Me.menuItemWindow.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemCloseAll, Me.menuItemWindows})
    Me.menuItemWindow.Text = "Window"
    '
    'menuItemCloseAll
    '
    Me.main_Menu1.SetCallback(Me.menuItemCloseAll, "CloseAll")
    Me.main_Menu1.SetImageIndex(Me.menuItemCloseAll, "3")
    Me.menuItemCloseAll.Index = 0
    Me.main_Menu1.SetMenuTip(Me.menuItemCloseAll, "Closes all files")
    Me.menuItemCloseAll.Text = "Close All"
    '
    'menuItemWindows
    '
    Me.main_Menu1.SetCallback(Me.menuItemWindows, "Windows")
    Me.main_Menu1.SetImageIndex(Me.menuItemWindows, "")
    Me.menuItemWindows.Index = 1
    Me.main_Menu1.SetMenuTip(Me.menuItemWindows, "")
    Me.menuItemWindows.Text = "Windows"
    '
    'imageList1
    '
    Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.White
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton_New, Me.toolBarButton_Open, Me.toolBarButton_Save})
    Me.toolBar1.ButtonSize = New System.Drawing.Size(16, 16)
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(288, 28)
    Me.toolBar1.TabIndex = 2
    '
    'Form2
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(288, 265)
    Me.Controls.Add(Me.tabControl1)
    Me.Controls.Add(Me.toolBar1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Menu = Me.main_Menu1
    Me.Name = "Form2"
    Me.Text = "Form2"
    Me.tabControl1.ResumeLayout(False)
    Me.tabPage1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
