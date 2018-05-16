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
  Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents button1 As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
    Me.pictureBox1 = New System.Windows.Forms.PictureBox
    Me.button1 = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'pictureBox1
    '
    Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
    Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.pictureBox1.Location = New System.Drawing.Point(9, 9)
    Me.pictureBox1.Name = "pictureBox1"
    Me.pictureBox1.Size = New System.Drawing.Size(233, 253)
    Me.pictureBox1.TabIndex = 3
    Me.pictureBox1.TabStop = False
    '
    'button1
    '
    Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button1.Location = New System.Drawing.Point(170, 272)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(72, 24)
    Me.button1.TabIndex = 2
    Me.button1.Text = "OK"
    '
    'Form2
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(250, 304)
    Me.ControlBox = False
    Me.Controls.Add(Me.pictureBox1)
    Me.Controls.Add(Me.button1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form2"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "About..."
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
