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
  Friend WithEvents DoubleBox1 As Salford.VisualClearWin.Double_Box
  Friend WithEvents DoubleBox2 As Salford.VisualClearWin.Double_Box
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.DoubleBox1 = New Salford.VisualClearWin.Double_Box()
    Me.DoubleBox2 = New Salford.VisualClearWin.Double_Box()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'DoubleBox1
    '
    Me.DoubleBox1.AutoCorrect = False
    Me.DoubleBox1.ExpFigs = 2
    Me.DoubleBox1.Location = New System.Drawing.Point(72, 16)
    Me.DoubleBox1.Maximum = 100
    Me.DoubleBox1.Name = "DoubleBox1"
    Me.DoubleBox1.Size = New System.Drawing.Size(80, 20)
    Me.DoubleBox1.TabIndex = 0
    Me.DoubleBox1.Text = "0"
    '
    'DoubleBox2
    '
    Me.DoubleBox2.AutoCorrect = False
    Me.DoubleBox2.Location = New System.Drawing.Point(72, 88)
    Me.DoubleBox2.Name = "DoubleBox2"
    Me.DoubleBox2.ReadOnly = True
    Me.DoubleBox2.Size = New System.Drawing.Size(80, 20)
    Me.DoubleBox2.TabIndex = 1
    Me.DoubleBox2.Text = ""
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(16, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 16)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Input"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(16, 88)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(40, 16)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Output"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(24, 48)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(128, 24)
    Me.Button1.TabIndex = 4
    Me.Button1.Text = "Process"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(182, 134)
    Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Label2, Me.Label1, Me.DoubleBox2, Me.DoubleBox1})
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Form1"
    Me.ResumeLayout(False)

  End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DoubleBox2.Value = Project1.Process(DoubleBox1.Value)
    End Sub

End Class
