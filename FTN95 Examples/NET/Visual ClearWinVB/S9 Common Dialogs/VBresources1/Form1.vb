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
  Friend WithEvents menuItem10 As System.Windows.Forms.MenuItem
  Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
  Friend WithEvents menuItem9 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem8 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem7 As System.Windows.Forms.MenuItem
  Friend WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
  Friend WithEvents printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
  Friend WithEvents text_Box1 As Salford.VisualClearWin.Text_Box
  Friend WithEvents colorDialog1 As System.Windows.Forms.ColorDialog
  Friend WithEvents printDialog1 As System.Windows.Forms.PrintDialog
  Friend WithEvents fontDialog1 As System.Windows.Forms.FontDialog
  Friend WithEvents text_Box2 As Salford.VisualClearWin.Text_Box
  Friend WithEvents pageSetupDialog1 As System.Windows.Forms.PageSetupDialog
  Friend WithEvents drawing_Panel1 As Salford.VisualClearWin.Drawing_Panel
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.menuItem10 = New System.Windows.Forms.MenuItem
    Me.statusBar1 = New System.Windows.Forms.StatusBar
    Me.menuItem9 = New System.Windows.Forms.MenuItem
    Me.menuItem8 = New System.Windows.Forms.MenuItem
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem5 = New System.Windows.Forms.MenuItem
    Me.menuItem6 = New System.Windows.Forms.MenuItem
    Me.menuItem7 = New System.Windows.Forms.MenuItem
    Me.printDocument1 = New System.Drawing.Printing.PrintDocument
    Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
    Me.text_Box1 = New Salford.VisualClearWin.Text_Box
    Me.colorDialog1 = New System.Windows.Forms.ColorDialog
    Me.printDialog1 = New System.Windows.Forms.PrintDialog
    Me.fontDialog1 = New System.Windows.Forms.FontDialog
    Me.text_Box2 = New Salford.VisualClearWin.Text_Box
    Me.pageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
    Me.drawing_Panel1 = New Salford.VisualClearWin.Drawing_Panel
    Me.SuspendLayout()
    '
    'menuItem10
    '
    Me.menuItem10.Index = 1
    Me.menuItem10.Text = "Font|Calls the Choose font dialog"
    '
    'statusBar1
    '
    Me.statusBar1.Location = New System.Drawing.Point(0, 169)
    Me.statusBar1.Name = "statusBar1"
    Me.statusBar1.Size = New System.Drawing.Size(216, 16)
    Me.statusBar1.TabIndex = 4
    Me.statusBar1.Text = "Ready"
    '
    'menuItem9
    '
    Me.menuItem9.Index = 0
    Me.menuItem9.Text = "Color|Calls the Choose color dialog"
    '
    'menuItem8
    '
    Me.menuItem8.Index = 5
    Me.menuItem8.Text = "Print|Calls the Print dialog"
    '
    'menuItem2
    '
    Me.menuItem2.Index = 1
    Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem9, Me.menuItem10})
    Me.menuItem2.Text = "Format"
    '
    'openFileDialog1
    '
    Me.openFileDialog1.Multiselect = True
    '
    'saveFileDialog1
    '
    Me.saveFileDialog1.FileName = "doc1"
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem2})
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8})
    Me.menuItem1.Text = "File"
    '
    'menuItem3
    '
    Me.menuItem3.Index = 0
    Me.menuItem3.Text = "Open|Calls the Open dialog"
    '
    'menuItem4
    '
    Me.menuItem4.Index = 1
    Me.menuItem4.Text = "Save As|Calls the Save As dialog"
    '
    'menuItem5
    '
    Me.menuItem5.Index = 2
    Me.menuItem5.Text = "-"
    '
    'menuItem6
    '
    Me.menuItem6.Index = 3
    Me.menuItem6.Text = "Print Preview|Calls the Print Priview dialog"
    '
    'menuItem7
    '
    Me.menuItem7.Index = 4
    Me.menuItem7.Text = "Page Setup|Calls the Page Setup dialog"
    '
    'printPreviewDialog1
    '
    Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
    Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
    Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
    Me.printPreviewDialog1.Document = Me.printDocument1
    Me.printPreviewDialog1.Enabled = True
    Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
    Me.printPreviewDialog1.Location = New System.Drawing.Point(132, 174)
    Me.printPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
    Me.printPreviewDialog1.Name = "printPreviewDialog1"
    Me.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
    Me.printPreviewDialog1.Visible = False
    '
    'text_Box1
    '
    Me.text_Box1.Location = New System.Drawing.Point(8, 4)
    Me.text_Box1.Multiline = True
    Me.text_Box1.Name = "text_Box1"
    Me.text_Box1.Pivoting = Salford.VisualClearWin.Pivot.Horizontal
    Me.text_Box1.ReadOnly = True
    Me.text_Box1.Size = New System.Drawing.Size(200, 112)
    Me.text_Box1.TabIndex = 5
    Me.text_Box1.Text = ""
    '
    'printDialog1
    '
    Me.printDialog1.Document = Me.printDocument1
    '
    'fontDialog1
    '
    Me.fontDialog1.ShowColor = True
    '
    'text_Box2
    '
    Me.text_Box2.ForeColor = System.Drawing.Color.Black
    Me.text_Box2.Location = New System.Drawing.Point(96, 124)
    Me.text_Box2.Name = "text_Box2"
    Me.text_Box2.Pivoting = Salford.VisualClearWin.Pivot.Horizontal
    Me.text_Box2.Size = New System.Drawing.Size(112, 20)
    Me.text_Box2.TabIndex = 7
    Me.text_Box2.Text = "Font Sample"
    '
    'pageSetupDialog1
    '
    Me.pageSetupDialog1.Document = Me.printDocument1
    '
    'drawing_Panel1
    '
    Me.drawing_Panel1.BackColor = System.Drawing.Color.Black
    Me.drawing_Panel1.BitmapSize = New System.Drawing.Size(0, 0)
    Me.drawing_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.drawing_Panel1.FillColor = System.Drawing.Color.Black
    Me.drawing_Panel1.LineColor = System.Drawing.Color.Black
    Me.drawing_Panel1.Location = New System.Drawing.Point(8, 124)
    Me.drawing_Panel1.Name = "drawing_Panel1"
    Me.drawing_Panel1.Size = New System.Drawing.Size(72, 24)
    Me.drawing_Panel1.StringColor = System.Drawing.Color.Black
    Me.drawing_Panel1.TabIndex = 6
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(216, 185)
    Me.Controls.Add(Me.statusBar1)
    Me.Controls.Add(Me.text_Box1)
    Me.Controls.Add(Me.text_Box2)
    Me.Controls.Add(Me.drawing_Panel1)
    Me.MaximizeBox = False
    Me.Menu = Me.mainMenu1
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "Common dialogs"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
