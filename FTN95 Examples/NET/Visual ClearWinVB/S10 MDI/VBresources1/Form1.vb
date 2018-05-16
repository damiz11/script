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
  Friend WithEvents menuItem14_RecentFiles4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem15 As System.Windows.Forms.MenuItem
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
  Friend WithEvents contextMenu1 As System.Windows.Forms.ContextMenu
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
  Friend WithEvents toolBarButton2_Open As System.Windows.Forms.ToolBarButton
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents menuItem9_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem8 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4_Open As System.Windows.Forms.MenuItem
  Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.menuItem14_RecentFiles4 = New System.Windows.Forms.MenuItem
    Me.menuItem15 = New System.Windows.Forms.MenuItem
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.contextMenu1 = New System.Windows.Forms.ContextMenu
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem6 = New System.Windows.Forms.MenuItem
    Me.toolBarButton2_Open = New System.Windows.Forms.ToolBarButton
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.menuItem9_Exit = New System.Windows.Forms.MenuItem
    Me.menuItem8 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.menuItem5 = New System.Windows.Forms.MenuItem
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem4_Open = New System.Windows.Forms.MenuItem
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.statusBar1 = New System.Windows.Forms.StatusBar
    Me.SuspendLayout()
    '
    'menuItem14_RecentFiles4
    '
    Me.menuItem14_RecentFiles4.Index = 3
    Me.menuItem14_RecentFiles4.Text = "Recent files"
    '
    'menuItem15
    '
    Me.menuItem15.Index = 2
    Me.menuItem15.Text = "-"
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
    Me.toolBar1.Size = New System.Drawing.Size(416, 28)
    Me.toolBar1.TabIndex = 5
    '
    'toolBarButton1
    '
    Me.toolBarButton1.DropDownMenu = Me.contextMenu1
    Me.toolBarButton1.ImageIndex = 0
    Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
    '
    'contextMenu1
    '
    Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem4, Me.menuItem6})
    '
    'menuItem4
    '
    Me.menuItem4.Index = 0
    Me.menuItem4.Text = "Text file"
    '
    'menuItem6
    '
    Me.menuItem6.Index = 1
    Me.menuItem6.Text = "RichText file"
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
    'menuItem9_Exit
    '
    Me.menuItem9_Exit.Index = 5
    Me.menuItem9_Exit.Text = "Exit"
    '
    'menuItem8
    '
    Me.menuItem8.Index = 4
    Me.menuItem8.Text = "-"
    '
    'menuItem3
    '
    Me.menuItem3.Index = 0
    Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem5})
    Me.menuItem3.Text = "New"
    '
    'menuItem2
    '
    Me.menuItem2.Index = 0
    Me.menuItem2.Text = "Text file"
    '
    'menuItem5
    '
    Me.menuItem5.Index = 1
    Me.menuItem5.Text = "RichText file"
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.menuItem4_Open, Me.menuItem15, Me.menuItem14_RecentFiles4, Me.menuItem8, Me.menuItem9_Exit})
    Me.menuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems
    Me.menuItem1.Text = "&File"
    '
    'menuItem4_Open
    '
    Me.menuItem4_Open.Index = 1
    Me.menuItem4_Open.Text = "&Open|Opens a file"
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
    '
    'openFileDialog1
    '
    Me.openFileDialog1.Filter = "Fotran files (*.f95)|*.f95|All files (*.*)|*.*"
    '
    'statusBar1
    '
    Me.statusBar1.Location = New System.Drawing.Point(0, 321)
    Me.statusBar1.Name = "statusBar1"
    Me.statusBar1.Size = New System.Drawing.Size(416, 24)
    Me.statusBar1.TabIndex = 4
    '
    'Form1
    '
    Me.AllowDrop = True
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(416, 345)
    Me.Controls.Add(Me.toolBar1)
    Me.Controls.Add(Me.statusBar1)
    Me.IsMdiContainer = True
    Me.Menu = Me.mainMenu1
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "MDI"
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub
End Class
