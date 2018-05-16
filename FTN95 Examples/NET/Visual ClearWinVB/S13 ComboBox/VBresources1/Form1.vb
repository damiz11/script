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
  Friend WithEvents button1 As System.Windows.Forms.Button
  Friend WithEvents label2 As System.Windows.Forms.Label
  Friend WithEvents int32_Box1 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents combo_Box1 As Salford.VisualClearWin.Combo_Box
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.button1 = New System.Windows.Forms.Button
    Me.label2 = New System.Windows.Forms.Label
    Me.int32_Box1 = New Salford.VisualClearWin.Int32_Box
    Me.combo_Box1 = New Salford.VisualClearWin.Combo_Box
    Me.SuspendLayout()
    '
    'button1
    '
    Me.button1.Location = New System.Drawing.Point(25, 96)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(48, 24)
    Me.button1.TabIndex = 9
    Me.button1.Text = "Insert"
    '
    'label2
    '
    Me.label2.Location = New System.Drawing.Point(89, 55)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(48, 16)
    Me.label2.TabIndex = 8
    Me.label2.Text = "Selected"
    '
    'int32_Box1
    '
    Me.int32_Box1.Location = New System.Drawing.Point(145, 51)
    Me.int32_Box1.Maximum = 2147483647
    Me.int32_Box1.Minimum = -2147483648
    Me.int32_Box1.Name = "int32_Box1"
    Me.int32_Box1.ReadOnly = True
    Me.int32_Box1.Size = New System.Drawing.Size(24, 20)
    Me.int32_Box1.TabIndex = 7
    Me.int32_Box1.Text = ""
    '
    'combo_Box1
    '
    Me.combo_Box1.Location = New System.Drawing.Point(25, 16)
    Me.combo_Box1.Name = "combo_Box1"
    Me.combo_Box1.Size = New System.Drawing.Size(216, 21)
    Me.combo_Box1.TabIndex = 6
    '
    'Form1
    '
    Me.AcceptButton = Me.button1
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(266, 88)
    Me.Controls.Add(Me.button1)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.int32_Box1)
    Me.Controls.Add(Me.combo_Box1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "ComboBox"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
