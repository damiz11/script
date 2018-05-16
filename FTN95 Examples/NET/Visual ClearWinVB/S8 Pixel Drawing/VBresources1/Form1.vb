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
  Friend WithEvents drawingPanel1 As Salford.VisualClearWin.Drawing_Panel
  Friend WithEvents button1 As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.drawingPanel1 = New Salford.VisualClearWin.Drawing_Panel
    Me.button1 = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'drawingPanel1
    '
    Me.drawingPanel1.BitmapSize = New System.Drawing.Size(0, 0)
    Me.drawingPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.drawingPanel1.FillColor = System.Drawing.SystemColors.Control
    Me.drawingPanel1.LineColor = System.Drawing.Color.Black
    Me.drawingPanel1.Location = New System.Drawing.Point(9, 39)
    Me.drawingPanel1.Name = "drawingPanel1"
    Me.drawingPanel1.Size = New System.Drawing.Size(259, 259)
    Me.drawingPanel1.StringColor = System.Drawing.Color.Black
    Me.drawingPanel1.TabIndex = 4
    '
    'button1
    '
    Me.button1.Location = New System.Drawing.Point(187, 9)
    Me.button1.Name = "button1"
    Me.button1.TabIndex = 3
    Me.button1.Text = "Draw"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(276, 306)
    Me.Controls.Add(Me.drawingPanel1)
    Me.Controls.Add(Me.button1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "Mandelbrot"
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
    Mandelbrot.mandel(drawingPanel1.Drawing)
  End Sub
End Class
