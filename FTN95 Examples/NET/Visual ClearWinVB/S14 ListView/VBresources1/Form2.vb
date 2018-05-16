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
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents contextMenu1 As System.Windows.Forms.ContextMenu
  Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem9 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5_Details As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem6_LargeIcon As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem7_List As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem8_SmallIcon As System.Windows.Forms.MenuItem
  Friend WithEvents imageList2 As System.Windows.Forms.ImageList
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents colorDialog1 As System.Windows.Forms.ColorDialog
  Friend WithEvents decimal_UpDown3 As Salford.VisualClearWin.Decimal_UpDown
  Friend WithEvents decimal_UpDown2 As Salford.VisualClearWin.Decimal_UpDown
  Friend WithEvents decimal_UpDown1 As Salford.VisualClearWin.Decimal_UpDown
  Friend WithEvents button2 As System.Windows.Forms.Button
  Friend WithEvents button1 As System.Windows.Forms.Button
  Friend WithEvents label3 As System.Windows.Forms.Label
  Friend WithEvents label2 As System.Windows.Forms.Label
  Friend WithEvents label1 As System.Windows.Forms.Label
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.contextMenu1 = New System.Windows.Forms.ContextMenu
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.menuItem9 = New System.Windows.Forms.MenuItem
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem5_Details = New System.Windows.Forms.MenuItem
    Me.menuItem6_LargeIcon = New System.Windows.Forms.MenuItem
    Me.menuItem7_List = New System.Windows.Forms.MenuItem
    Me.menuItem8_SmallIcon = New System.Windows.Forms.MenuItem
    Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.colorDialog1 = New System.Windows.Forms.ColorDialog
    Me.decimal_UpDown3 = New Salford.VisualClearWin.Decimal_UpDown
    Me.decimal_UpDown2 = New Salford.VisualClearWin.Decimal_UpDown
    Me.decimal_UpDown1 = New Salford.VisualClearWin.Decimal_UpDown
    Me.button2 = New System.Windows.Forms.Button
    Me.button1 = New System.Windows.Forms.Button
    Me.label3 = New System.Windows.Forms.Label
    Me.label2 = New System.Windows.Forms.Label
    Me.label1 = New System.Windows.Forms.Label
    CType(Me.decimal_UpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.decimal_UpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.decimal_UpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.Text = "New"
    '
    'contextMenu1
    '
    Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem2, Me.menuItem3, Me.menuItem9, Me.menuItem4, Me.menuItem5_Details, Me.menuItem6_LargeIcon, Me.menuItem7_List, Me.menuItem8_SmallIcon})
    '
    'menuItem2
    '
    Me.menuItem2.Index = 1
    Me.menuItem2.Text = "Delete"
    '
    'menuItem3
    '
    Me.menuItem3.Index = 2
    Me.menuItem3.Text = "Edit"
    '
    'menuItem9
    '
    Me.menuItem9.Index = 3
    Me.menuItem9.Text = "Colours"
    '
    'menuItem4
    '
    Me.menuItem4.Index = 4
    Me.menuItem4.Text = "-"
    '
    'menuItem5_Details
    '
    Me.menuItem5_Details.Checked = True
    Me.menuItem5_Details.Index = 5
    Me.menuItem5_Details.Text = "Details"
    '
    'menuItem6_LargeIcon
    '
    Me.menuItem6_LargeIcon.Index = 6
    Me.menuItem6_LargeIcon.Text = "Large icon"
    '
    'menuItem7_List
    '
    Me.menuItem7_List.Index = 7
    Me.menuItem7_List.Text = "List"
    '
    'menuItem8_SmallIcon
    '
    Me.menuItem8_SmallIcon.Index = 8
    Me.menuItem8_SmallIcon.Text = "Small icon"
    '
    'imageList2
    '
    Me.imageList2.ImageSize = New System.Drawing.Size(32, 32)
    Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
    '
    'imageList1
    '
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
    '
    'decimal_UpDown3
    '
    Me.decimal_UpDown3.Location = New System.Drawing.Point(101, 68)
    Me.decimal_UpDown3.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.decimal_UpDown3.Name = "decimal_UpDown3"
    Me.decimal_UpDown3.Size = New System.Drawing.Size(48, 20)
    Me.decimal_UpDown3.TabIndex = 9
    '
    'decimal_UpDown2
    '
    Me.decimal_UpDown2.Location = New System.Drawing.Point(101, 44)
    Me.decimal_UpDown2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.decimal_UpDown2.Name = "decimal_UpDown2"
    Me.decimal_UpDown2.Size = New System.Drawing.Size(48, 20)
    Me.decimal_UpDown2.TabIndex = 7
    '
    'decimal_UpDown1
    '
    Me.decimal_UpDown1.Location = New System.Drawing.Point(101, 20)
    Me.decimal_UpDown1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.decimal_UpDown1.Name = "decimal_UpDown1"
    Me.decimal_UpDown1.Size = New System.Drawing.Size(48, 20)
    Me.decimal_UpDown1.TabIndex = 5
    '
    'button2
    '
    Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button2.Location = New System.Drawing.Point(101, 108)
    Me.button2.Name = "button2"
    Me.button2.Size = New System.Drawing.Size(56, 24)
    Me.button2.TabIndex = 11
    Me.button2.Text = "Cancel"
    '
    'button1
    '
    Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button1.Location = New System.Drawing.Point(21, 108)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(64, 24)
    Me.button1.TabIndex = 10
    Me.button1.Text = "OK"
    '
    'label3
    '
    Me.label3.Location = New System.Drawing.Point(53, 69)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(40, 16)
    Me.label3.TabIndex = 12
    Me.label3.Text = "Blue"
    '
    'label2
    '
    Me.label2.Location = New System.Drawing.Point(53, 48)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(40, 16)
    Me.label2.TabIndex = 8
    Me.label2.Text = "Green"
    '
    'label1
    '
    Me.label1.Location = New System.Drawing.Point(53, 27)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(40, 16)
    Me.label1.TabIndex = 6
    Me.label1.Text = "Red"
    '
    'Form2
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(178, 152)
    Me.Controls.Add(Me.decimal_UpDown3)
    Me.Controls.Add(Me.decimal_UpDown2)
    Me.Controls.Add(Me.decimal_UpDown1)
    Me.Controls.Add(Me.button2)
    Me.Controls.Add(Me.button1)
    Me.Controls.Add(Me.label3)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form2"
    Me.Text = "Edit Colours"
    CType(Me.decimal_UpDown3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.decimal_UpDown2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.decimal_UpDown1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
