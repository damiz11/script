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
  Friend WithEvents toolBarButton2_GoForward As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton3_StopDownload As System.Windows.Forms.ToolBarButton
  Friend WithEvents explorer_Box1 As Salford.VisualClearWin.Explorer_Box
  Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
  Friend WithEvents toolBarButton5_WebPrint As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton4_Refresh As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents toolBarButton1_GoBack As System.Windows.Forms.ToolBarButton
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents label1 As System.Windows.Forms.Label
  Friend WithEvents combo_Box1 As Salford.VisualClearWin.Combo_Box
  Friend WithEvents button1 As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.toolBarButton2_GoForward = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton3_StopDownload = New System.Windows.Forms.ToolBarButton
    Me.explorer_Box1 = New Salford.VisualClearWin.Explorer_Box
    Me.statusBar1 = New System.Windows.Forms.StatusBar
    Me.toolBarButton5_WebPrint = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton4_Refresh = New System.Windows.Forms.ToolBarButton
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.toolBarButton1_GoBack = New System.Windows.Forms.ToolBarButton
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.label1 = New System.Windows.Forms.Label
    Me.combo_Box1 = New Salford.VisualClearWin.Combo_Box
    Me.button1 = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'toolBarButton2_GoForward
    '
    Me.toolBarButton2_GoForward.ImageIndex = 1
    Me.toolBarButton2_GoForward.ToolTipText = "Forward"
    '
    'toolBarButton3_StopDownload
    '
    Me.toolBarButton3_StopDownload.ImageIndex = 2
    Me.toolBarButton3_StopDownload.ToolTipText = "Stop"
    '
    'explorer_Box1
    '
    Me.explorer_Box1.Location = New System.Drawing.Point(0, 56)
    Me.explorer_Box1.Name = "explorer_Box1"
    Me.explorer_Box1.Pivoting = Salford.VisualClearWin.Pivot.Full
    Me.explorer_Box1.Size = New System.Drawing.Size(688, 385)
    Me.explorer_Box1.TabIndex = 15
    '
    'statusBar1
    '
    Me.statusBar1.Location = New System.Drawing.Point(0, 446)
    Me.statusBar1.Name = "statusBar1"
    Me.statusBar1.Size = New System.Drawing.Size(688, 16)
    Me.statusBar1.TabIndex = 14
    '
    'toolBarButton5_WebPrint
    '
    Me.toolBarButton5_WebPrint.ImageIndex = 4
    Me.toolBarButton5_WebPrint.ToolTipText = "Print"
    '
    'toolBarButton4_Refresh
    '
    Me.toolBarButton4_Refresh.ImageIndex = 3
    Me.toolBarButton4_Refresh.ToolTipText = "Refresh"
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1_GoBack, Me.toolBarButton2_GoForward, Me.toolBarButton3_StopDownload, Me.toolBarButton4_Refresh, Me.toolBarButton5_WebPrint})
    Me.toolBar1.ButtonSize = New System.Drawing.Size(30, 30)
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(688, 28)
    Me.toolBar1.TabIndex = 13
    Me.toolBar1.Wrappable = False
    '
    'toolBarButton1_GoBack
    '
    Me.toolBarButton1_GoBack.ImageIndex = 0
    Me.toolBarButton1_GoBack.ToolTipText = "Back"
    '
    'imageList1
    '
    Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
    '
    'label1
    '
    Me.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
    Me.label1.Location = New System.Drawing.Point(12, 32)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(46, 19)
    Me.label1.TabIndex = 10
    Me.label1.Text = "Address"
    Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'combo_Box1
    '
    Me.combo_Box1.Location = New System.Drawing.Point(65, 32)
    Me.combo_Box1.Name = "combo_Box1"
    Me.combo_Box1.Persists = True
    Me.combo_Box1.Pivoting = Salford.VisualClearWin.Pivot.Horizontal
    Me.combo_Box1.Size = New System.Drawing.Size(564, 21)
    Me.combo_Box1.TabIndex = 11
    '
    'button1
    '
    Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
    Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.button1.Location = New System.Drawing.Point(633, 32)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(48, 25)
    Me.button1.TabIndex = 12
    Me.button1.Text = "Go"
    Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(688, 462)
    Me.Controls.Add(Me.statusBar1)
    Me.Controls.Add(Me.toolBar1)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.combo_Box1)
    Me.Controls.Add(Me.button1)
    Me.Controls.Add(Me.explorer_Box1)
    Me.Name = "Form1"
    Me.Text = "Visual ClearWin Browser"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
