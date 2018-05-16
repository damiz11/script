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
  Friend WithEvents label2 As System.Windows.Forms.Label
  Friend WithEvents label1 As System.Windows.Forms.Label
  Friend WithEvents button1 As System.Windows.Forms.Button
  Friend WithEvents double_Box1 As Salford.VisualClearWin.Double_Box
  Friend WithEvents double_Box2 As Salford.VisualClearWin.Double_Box
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.label2 = New System.Windows.Forms.Label
    Me.label1 = New System.Windows.Forms.Label
    Me.double_Box1 = New Salford.VisualClearWin.Double_Box
    Me.double_Box2 = New Salford.VisualClearWin.Double_Box
    Me.button1 = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'label2
    '
    Me.label2.Location = New System.Drawing.Point(20, 91)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(40, 16)
    Me.label2.TabIndex = 10
    Me.label2.Text = "Result"
    '
    'label1
    '
    Me.label1.Location = New System.Drawing.Point(20, 20)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(40, 16)
    Me.label1.TabIndex = 9
    Me.label1.Text = "Value"
    '
    'double_Box1
    '
    Me.double_Box1.Location = New System.Drawing.Point(64, 16)
    Me.double_Box1.Maximum = 10000000
    Me.double_Box1.Minimum = -10000000
    Me.double_Box1.Name = "double_Box1"
    Me.double_Box1.Size = New System.Drawing.Size(88, 20)
    Me.double_Box1.TabIndex = 11
    Me.double_Box1.Text = "0"
    '
    'double_Box2
    '
    Me.double_Box2.Location = New System.Drawing.Point(64, 88)
    Me.double_Box2.Maximum = 10000000
    Me.double_Box2.Minimum = -10000000
    Me.double_Box2.Name = "double_Box2"
    Me.double_Box2.ReadOnly = True
    Me.double_Box2.Size = New System.Drawing.Size(88, 20)
    Me.double_Box2.TabIndex = 12
    Me.double_Box2.Text = ""
    '
    'button1
    '
    Me.button1.Location = New System.Drawing.Point(32, 48)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(112, 24)
    Me.button1.TabIndex = 13
    Me.button1.Text = "Square"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(176, 126)
    Me.Controls.Add(Me.button1)
    Me.Controls.Add(Me.double_Box2)
    Me.Controls.Add(Me.double_Box1)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "Square"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
