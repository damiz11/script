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
  Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem2_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
  Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
  Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem6_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents ContextMenu2 As System.Windows.Forms.ContextMenu
  Friend WithEvents MenuItem6_Cut As System.Windows.Forms.MenuItem
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
  Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents MenuItem7_Copy As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem8_Paste As System.Windows.Forms.MenuItem
  Friend WithEvents ToolBarButton2_Exit As System.Windows.Forms.ToolBarButton
  Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.MainMenu1 = New System.Windows.Forms.MainMenu
    Me.MenuItem1 = New System.Windows.Forms.MenuItem
    Me.MenuItem2_Exit = New System.Windows.Forms.MenuItem
    Me.MenuItem3 = New System.Windows.Forms.MenuItem
    Me.MenuItem7 = New System.Windows.Forms.MenuItem
    Me.MenuItem6 = New System.Windows.Forms.MenuItem
    Me.ToolBar1 = New System.Windows.Forms.ToolBar
    Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
    Me.MenuItem5 = New System.Windows.Forms.MenuItem
    Me.MenuItem6_Exit = New System.Windows.Forms.MenuItem
    Me.ToolBarButton2_Exit = New System.Windows.Forms.ToolBarButton
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.TextBox1 = New System.Windows.Forms.TextBox
    Me.ContextMenu2 = New System.Windows.Forms.ContextMenu
    Me.MenuItem6_Cut = New System.Windows.Forms.MenuItem
    Me.MenuItem7_Copy = New System.Windows.Forms.MenuItem
    Me.MenuItem8_Paste = New System.Windows.Forms.MenuItem
    Me.Label1 = New System.Windows.Forms.Label
    Me.StatusBar1 = New System.Windows.Forms.StatusBar
    Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
    Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
    CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MainMenu1
    '
    Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3})
    '
    'MenuItem1
    '
    Me.MenuItem1.Index = 0
    Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2_Exit})
    Me.MenuItem1.Text = "File"
    '
    'MenuItem2_Exit
    '
    Me.MenuItem2_Exit.Index = 0
    Me.MenuItem2_Exit.Text = "Exit|Exits the application"
    '
    'MenuItem3
    '
    Me.MenuItem3.Index = 1
    Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem6})
    Me.MenuItem3.Text = "Help"
    '
    'MenuItem7
    '
    Me.MenuItem7.Index = 0
    Me.MenuItem7.Text = "&About|About this application"
    '
    'MenuItem6
    '
    Me.MenuItem6.Index = 1
    Me.MenuItem6.Text = "More"
    '
    'ToolBar1
    '
    Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2_Exit})
    Me.ToolBar1.DropDownArrows = True
    Me.ToolBar1.ImageList = Me.ImageList1
    Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
    Me.ToolBar1.Name = "ToolBar1"
    Me.ToolBar1.ShowToolTips = True
    Me.ToolBar1.Size = New System.Drawing.Size(292, 28)
    Me.ToolBar1.TabIndex = 0
    '
    'ToolBarButton1
    '
    Me.ToolBarButton1.DropDownMenu = Me.ContextMenu1
    Me.ToolBarButton1.ImageIndex = 1
    Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
    Me.ToolBarButton1.ToolTipText = "Open"
    '
    'ContextMenu1
    '
    Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6_Exit})
    '
    'MenuItem5
    '
    Me.MenuItem5.Index = 0
    Me.MenuItem5.Text = "About|About this application"
    '
    'MenuItem6_Exit
    '
    Me.MenuItem6_Exit.Index = 1
    Me.MenuItem6_Exit.Text = "Exit|Exits the application"
    '
    'ToolBarButton2_Exit
    '
    Me.ToolBarButton2_Exit.ImageIndex = 0
    Me.ToolBarButton2_Exit.ToolTipText = "Exits from the application"
    '
    'ImageList1
    '
    Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    '
    'TextBox1
    '
    Me.TextBox1.ContextMenu = Me.ContextMenu2
    Me.TextBox1.Location = New System.Drawing.Point(144, 40)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(136, 20)
    Me.TextBox1.TabIndex = 1
    Me.TextBox1.Text = "Context menu here...."
    '
    'ContextMenu2
    '
    Me.ContextMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6_Cut, Me.MenuItem7_Copy, Me.MenuItem8_Paste})
    '
    'MenuItem6_Cut
    '
    Me.MenuItem6_Cut.Index = 0
    Me.MenuItem6_Cut.Text = "Cut|Cuts the selection to the clipboard"
    '
    'MenuItem7_Copy
    '
    Me.MenuItem7_Copy.Index = 1
    Me.MenuItem7_Copy.Text = "Copy|Copies the selection to the clipboard"
    '
    'MenuItem8_Paste
    '
    Me.MenuItem8_Paste.Index = 2
    Me.MenuItem8_Paste.Text = "Paste|Pastes the clipboard into the text"
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(16, 72)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(128, 16)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Context menu here..."
    '
    'StatusBar1
    '
    Me.StatusBar1.Location = New System.Drawing.Point(0, 97)
    Me.StatusBar1.Name = "StatusBar1"
    Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
    Me.StatusBar1.ShowPanels = True
    Me.StatusBar1.Size = New System.Drawing.Size(292, 24)
    Me.StatusBar1.TabIndex = 3
    '
    'StatusBarPanel1
    '
    Me.StatusBarPanel1.Text = "Press Ctrl+A for About"
    '
    'StatusBarPanel2
    '
    Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
    Me.StatusBarPanel2.Text = "Page 1"
    Me.StatusBarPanel2.Width = 176
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(292, 121)
    Me.ContextMenu = Me.ContextMenu1
    Me.Controls.Add(Me.StatusBar1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.ToolBar1)
    Me.Menu = Me.MainMenu1
    Me.Name = "Form1"
    Me.Text = "Menus"
    CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
