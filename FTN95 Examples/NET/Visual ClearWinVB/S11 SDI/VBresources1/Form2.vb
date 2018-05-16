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
  Friend WithEvents check_Box3 As Salford.VisualClearWin.Check_Box
  Friend WithEvents check_Box2 As Salford.VisualClearWin.Check_Box
  Friend WithEvents check_Box1 As Salford.VisualClearWin.Check_Box
  Friend WithEvents button3 As System.Windows.Forms.Button
  Friend WithEvents button2 As System.Windows.Forms.Button
  Friend WithEvents button1 As System.Windows.Forms.Button
  Friend WithEvents combo_Box1 As Salford.VisualClearWin.Combo_Box
  Friend WithEvents label1 As System.Windows.Forms.Label
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.check_Box3 = New Salford.VisualClearWin.Check_Box
    Me.check_Box2 = New Salford.VisualClearWin.Check_Box
    Me.check_Box1 = New Salford.VisualClearWin.Check_Box
    Me.button3 = New System.Windows.Forms.Button
    Me.button2 = New System.Windows.Forms.Button
    Me.button1 = New System.Windows.Forms.Button
    Me.combo_Box1 = New Salford.VisualClearWin.Combo_Box
    Me.label1 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'check_Box3
    '
    Me.check_Box3.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.check_Box3.Location = New System.Drawing.Point(16, 96)
    Me.check_Box3.Name = "check_Box3"
    Me.check_Box3.Persists = True
    Me.check_Box3.Size = New System.Drawing.Size(120, 16)
    Me.check_Box3.TabIndex = 7
    Me.check_Box3.Text = "Seach up"
    '
    'check_Box2
    '
    Me.check_Box2.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.check_Box2.Location = New System.Drawing.Point(16, 72)
    Me.check_Box2.Name = "check_Box2"
    Me.check_Box2.Persists = True
    Me.check_Box2.Size = New System.Drawing.Size(120, 16)
    Me.check_Box2.TabIndex = 6
    Me.check_Box2.Text = "Match whole word"
    '
    'check_Box1
    '
    Me.check_Box1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.check_Box1.Location = New System.Drawing.Point(16, 48)
    Me.check_Box1.Name = "check_Box1"
    Me.check_Box1.Persists = True
    Me.check_Box1.Size = New System.Drawing.Size(120, 16)
    Me.check_Box1.TabIndex = 5
    Me.check_Box1.Text = "Match case"
    '
    'button3
    '
    Me.button3.Location = New System.Drawing.Point(273, 139)
    Me.button3.Name = "button3"
    Me.button3.Size = New System.Drawing.Size(80, 24)
    Me.button3.TabIndex = 4
    Me.button3.Text = "Enter"
    '
    'button2
    '
    Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button2.Location = New System.Drawing.Point(273, 45)
    Me.button2.Name = "button2"
    Me.button2.Size = New System.Drawing.Size(80, 24)
    Me.button2.TabIndex = 3
    Me.button2.Text = "Close"
    '
    'button1
    '
    Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button1.Location = New System.Drawing.Point(273, 10)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(80, 24)
    Me.button1.TabIndex = 2
    Me.button1.Text = "Find Next"
    '
    'combo_Box1
    '
    Me.combo_Box1.Location = New System.Drawing.Point(80, 11)
    Me.combo_Box1.Name = "combo_Box1"
    Me.combo_Box1.Persists = True
    Me.combo_Box1.Size = New System.Drawing.Size(184, 21)
    Me.combo_Box1.TabIndex = 1
    '
    'label1
    '
    Me.label1.Location = New System.Drawing.Point(16, 16)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(56, 16)
    Me.label1.TabIndex = 0
    Me.label1.Text = "Find what:"
    '
    'Form2
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(369, 128)
    Me.Controls.Add(Me.check_Box3)
    Me.Controls.Add(Me.check_Box2)
    Me.Controls.Add(Me.check_Box1)
    Me.Controls.Add(Me.button3)
    Me.Controls.Add(Me.button2)
    Me.Controls.Add(Me.button1)
    Me.Controls.Add(Me.combo_Box1)
    Me.Controls.Add(Me.label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "Form2"
    Me.Text = "Find"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
