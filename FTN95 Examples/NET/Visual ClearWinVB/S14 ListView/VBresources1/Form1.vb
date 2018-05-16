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
  Friend WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents list_View1 As Salford.VisualClearWin.List_View
  Friend WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents imageList2 As System.Windows.Forms.ImageList
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents colorDialog1 As System.Windows.Forms.ColorDialog
  Friend WithEvents drawing_Panel1 As Salford.VisualClearWin.Drawing_Panel
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Red", "255", "0", "0"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
    Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Green", "0", "255", "0"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
    Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Blue", "0", "0", "255"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
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
    Me.columnHeader4 = New System.Windows.Forms.ColumnHeader
    Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.list_View1 = New Salford.VisualClearWin.List_View
    Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.columnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.colorDialog1 = New System.Windows.Forms.ColorDialog
    Me.drawing_Panel1 = New Salford.VisualClearWin.Drawing_Panel
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
    'columnHeader4
    '
    Me.columnHeader4.Text = "Blue"
    Me.columnHeader4.Width = 56
    '
    'columnHeader1
    '
    Me.columnHeader1.Text = "Colour"
    '
    'list_View1
    '
    Me.list_View1.AllowColumnReorder = True
    Me.list_View1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4})
    Me.list_View1.ContextMenu = Me.contextMenu1
    Me.list_View1.GridLines = True
    Me.list_View1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
    Me.list_View1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
    Me.list_View1.LabelEdit = True
    Me.list_View1.LargeImageList = Me.imageList2
    Me.list_View1.Location = New System.Drawing.Point(17, 20)
    Me.list_View1.MultiSelect = False
    Me.list_View1.Name = "list_View1"
    Me.list_View1.Size = New System.Drawing.Size(232, 136)
    Me.list_View1.SmallImageList = Me.imageList1
    Me.list_View1.TabIndex = 2
    Me.list_View1.View = System.Windows.Forms.View.Details
    '
    'columnHeader2
    '
    Me.columnHeader2.Text = "Red"
    Me.columnHeader2.Width = 56
    '
    'columnHeader3
    '
    Me.columnHeader3.Text = "Green"
    Me.columnHeader3.Width = 56
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
    'drawing_Panel1
    '
    Me.drawing_Panel1.BitmapSize = New System.Drawing.Size(0, 0)
    Me.drawing_Panel1.FillColor = System.Drawing.Color.Black
    Me.drawing_Panel1.LineColor = System.Drawing.Color.Black
    Me.drawing_Panel1.Location = New System.Drawing.Point(17, 164)
    Me.drawing_Panel1.Name = "drawing_Panel1"
    Me.drawing_Panel1.Size = New System.Drawing.Size(232, 8)
    Me.drawing_Panel1.StringColor = System.Drawing.Color.Black
    Me.drawing_Panel1.TabIndex = 3
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(266, 192)
    Me.Controls.Add(Me.list_View1)
    Me.Controls.Add(Me.drawing_Panel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "List View"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
