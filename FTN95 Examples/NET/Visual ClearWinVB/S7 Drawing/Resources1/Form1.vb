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
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.drawingPanel1 = New Salford.VisualClearWin.Drawing_Panel
    Me.SuspendLayout()
    '
    'drawingPanel1
    '
    Me.drawingPanel1.BackColor = System.Drawing.SystemColors.Control
    Me.drawingPanel1.BitmapSize = New System.Drawing.Size(0, 0)
    Me.drawingPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.drawingPanel1.FillColor = System.Drawing.Color.White
    Me.drawingPanel1.LineColor = System.Drawing.Color.Red
    Me.drawingPanel1.Location = New System.Drawing.Point(8, 11)
    Me.drawingPanel1.Name = "drawingPanel1"
    Me.drawingPanel1.Pivoting = Salford.VisualClearWin.Pivot.Full
    Me.drawingPanel1.Size = New System.Drawing.Size(176, 96)
    Me.drawingPanel1.StringColor = System.Drawing.Color.Magenta
    Me.drawingPanel1.TabIndex = 5
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(192, 118)
    Me.Controls.Add(Me.drawingPanel1)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Graphics"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
