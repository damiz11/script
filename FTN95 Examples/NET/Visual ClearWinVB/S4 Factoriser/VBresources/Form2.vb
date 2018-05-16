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
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents label3 As System.Windows.Forms.Label
  Friend WithEvents label2 As System.Windows.Forms.Label
  Friend WithEvents label1 As System.Windows.Forms.Label
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Button1 = New System.Windows.Forms.Button
    Me.label3 = New System.Windows.Forms.Label
    Me.label2 = New System.Windows.Forms.Label
    Me.label1 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'Button1
    '
    Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Button1.Location = New System.Drawing.Point(70, 128)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(88, 24)
    Me.Button1.TabIndex = 0
    Me.Button1.Text = "OK"
    '
    'label3
    '
    Me.label3.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label3.ForeColor = System.Drawing.Color.OrangeRed
    Me.label3.Location = New System.Drawing.Point(26, 88)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(169, 24)
    Me.label3.TabIndex = 6
    Me.label3.Text = "Visual ClearWin"
    Me.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'label2
    '
    Me.label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label2.ForeColor = System.Drawing.Color.Black
    Me.label2.Location = New System.Drawing.Point(5, 56)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(224, 16)
    Me.label2.TabIndex = 5
    Me.label2.Text = " Program written to demonstrate"
    Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'label1
    '
    Me.label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label1.ForeColor = System.Drawing.Color.Black
    Me.label1.Location = New System.Drawing.Point(34, 8)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(160, 24)
    Me.label1.TabIndex = 4
    Me.label1.Text = "Factoriser"
    Me.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Form2
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(226, 168)
    Me.Controls.Add(Me.label3)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.Button1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form2"
    Me.Text = "About Factoriser"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
