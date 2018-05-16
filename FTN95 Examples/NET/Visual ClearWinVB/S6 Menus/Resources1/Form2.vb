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
  Friend WithEvents label1 As System.Windows.Forms.Label
  Friend WithEvents button1 As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.label1 = New System.Windows.Forms.Label
    Me.button1 = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'label1
    '
    Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label1.ForeColor = System.Drawing.Color.IndianRed
    Me.label1.Location = New System.Drawing.Point(32, 24)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(128, 32)
    Me.label1.TabIndex = 3
    Me.label1.Text = "A Sample from Salford Software"
    Me.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'button1
    '
    Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button1.Location = New System.Drawing.Point(64, 72)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(72, 24)
    Me.button1.TabIndex = 2
    Me.button1.Text = "OK"
    '
    'Form2
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(192, 118)
    Me.ControlBox = False
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.button1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form2"
    Me.Text = "About..."
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
