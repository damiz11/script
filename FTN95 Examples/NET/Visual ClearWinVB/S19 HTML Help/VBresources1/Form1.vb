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
  Friend WithEvents explorer_Box1 As Salford.VisualClearWin.Explorer_Box
  Friend WithEvents splitter1 As System.Windows.Forms.Splitter
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents tree_View1 As Salford.VisualClearWin.Tree_View
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.explorer_Box1 = New Salford.VisualClearWin.Explorer_Box
    Me.splitter1 = New System.Windows.Forms.Splitter
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.tree_View1 = New Salford.VisualClearWin.Tree_View
    Me.SuspendLayout()
    '
    'explorer_Box1
    '
    Me.explorer_Box1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.explorer_Box1.Location = New System.Drawing.Point(0, 0)
    Me.explorer_Box1.Name = "explorer_Box1"
    Me.explorer_Box1.Size = New System.Drawing.Size(744, 446)
    Me.explorer_Box1.TabIndex = 5
    Me.explorer_Box1.URL = "mk:@MSITStore:vcw.chm::/s0.htm"
    '
    'splitter1
    '
    Me.splitter1.Location = New System.Drawing.Point(208, 0)
    Me.splitter1.Name = "splitter1"
    Me.splitter1.Size = New System.Drawing.Size(4, 446)
    Me.splitter1.TabIndex = 4
    Me.splitter1.TabStop = False
    '
    'imageList1
    '
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
    '
    'tree_View1
    '
    Me.tree_View1.Dock = System.Windows.Forms.DockStyle.Left
    Me.tree_View1.HideSelection = False
    Me.tree_View1.ImageIndex = 2
    Me.tree_View1.ImageList = Me.imageList1
    Me.tree_View1.Location = New System.Drawing.Point(0, 0)
    Me.tree_View1.Name = "tree_View1"
    Me.tree_View1.SelectedImageIndex = 2
    Me.tree_View1.Size = New System.Drawing.Size(208, 446)
    Me.tree_View1.TabIndex = 3
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(744, 446)
    Me.Controls.Add(Me.splitter1)
    Me.Controls.Add(Me.tree_View1)
    Me.Controls.Add(Me.explorer_Box1)
    Me.Name = "Form1"
    Me.Text = "Visual ClearWin"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
