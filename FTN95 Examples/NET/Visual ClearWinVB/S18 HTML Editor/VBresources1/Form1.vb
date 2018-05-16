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
  Friend WithEvents menuItem31_htm2163 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem30_htm2167 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem29 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem34_htm2166 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem33_htm2165 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem32_htm2164 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem25_htm2150 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem26_htm2200 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem27_htm2168 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem28_htm2124 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem35 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem36_htm2119 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem37_htm2161 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem38_htm2162 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem39_htm2158 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem40_htm2182 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem41 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem42_htm2117 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem43_htm2116 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem44_htm2115 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem45_htm2312 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem46_htm2114 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem47_htm2313 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem48_htm2118 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem24_htm2230 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem9_htm2003 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem8 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem7 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem12_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem11 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem10_htm27 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
  Friend WithEvents toolBarButton14_htm2168 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton15_htm2124 As System.Windows.Forms.ToolBarButton
  Friend WithEvents menuItem20_htm67 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem19 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem18_htm26 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem23_htm31 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem22_htm17 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem21 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem14_htm29 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem13_htm43 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem15 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem16_htm16 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem17_htm15 As System.Windows.Forms.MenuItem
  Friend WithEvents toolBarButton21_htm56 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton22_htm63 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton24 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton33 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton36 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton20_htm52 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton29_htm60 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton31_htm2185 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton32_htm2184 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton25 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton27_htm59 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton28_htm57 As System.Windows.Forms.ToolBarButton
  Friend WithEvents comboBox3 As System.Windows.Forms.ComboBox
  Friend WithEvents comboBox2 As System.Windows.Forms.ComboBox
  Friend WithEvents comboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents toolBar2 As System.Windows.Forms.ToolBar
  Friend WithEvents toolBarSeparator As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton19 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarBlank As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton23 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton26 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton30 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton34_htm2187 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton35_htm2186 As System.Windows.Forms.ToolBarButton
  Friend WithEvents imageList2 As System.Windows.Forms.ImageList
  Friend WithEvents toolBarButton16 As System.Windows.Forms.ToolBarButton
  Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents toolBarButton2 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents toolBarButton3 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton4 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton5 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton6_htm16 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton7_htm15 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton8_htm26 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton9 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton10_htm43 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton11_htm29 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton12 As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton13_htm2200 As System.Windows.Forms.ToolBarButton
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents colorDialog1 As System.Windows.Forms.ColorDialog
  Friend WithEvents explorer_Box1 As Salford.VisualClearWin.Explorer_Box
  Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.menuItem31_htm2163 = New System.Windows.Forms.MenuItem
    Me.menuItem30_htm2167 = New System.Windows.Forms.MenuItem
    Me.menuItem29 = New System.Windows.Forms.MenuItem
    Me.menuItem34_htm2166 = New System.Windows.Forms.MenuItem
    Me.menuItem33_htm2165 = New System.Windows.Forms.MenuItem
    Me.menuItem32_htm2164 = New System.Windows.Forms.MenuItem
    Me.menuItem25_htm2150 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.menuItem26_htm2200 = New System.Windows.Forms.MenuItem
    Me.menuItem27_htm2168 = New System.Windows.Forms.MenuItem
    Me.menuItem28_htm2124 = New System.Windows.Forms.MenuItem
    Me.menuItem35 = New System.Windows.Forms.MenuItem
    Me.menuItem36_htm2119 = New System.Windows.Forms.MenuItem
    Me.menuItem37_htm2161 = New System.Windows.Forms.MenuItem
    Me.menuItem38_htm2162 = New System.Windows.Forms.MenuItem
    Me.menuItem39_htm2158 = New System.Windows.Forms.MenuItem
    Me.menuItem40_htm2182 = New System.Windows.Forms.MenuItem
    Me.menuItem41 = New System.Windows.Forms.MenuItem
    Me.menuItem42_htm2117 = New System.Windows.Forms.MenuItem
    Me.menuItem43_htm2116 = New System.Windows.Forms.MenuItem
    Me.menuItem44_htm2115 = New System.Windows.Forms.MenuItem
    Me.menuItem45_htm2312 = New System.Windows.Forms.MenuItem
    Me.menuItem46_htm2114 = New System.Windows.Forms.MenuItem
    Me.menuItem47_htm2313 = New System.Windows.Forms.MenuItem
    Me.menuItem48_htm2118 = New System.Windows.Forms.MenuItem
    Me.menuItem24_htm2230 = New System.Windows.Forms.MenuItem
    Me.menuItem9_htm2003 = New System.Windows.Forms.MenuItem
    Me.menuItem8 = New System.Windows.Forms.MenuItem
    Me.menuItem7 = New System.Windows.Forms.MenuItem
    Me.menuItem12_Exit = New System.Windows.Forms.MenuItem
    Me.menuItem11 = New System.Windows.Forms.MenuItem
    Me.menuItem10_htm27 = New System.Windows.Forms.MenuItem
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem5 = New System.Windows.Forms.MenuItem
    Me.menuItem6 = New System.Windows.Forms.MenuItem
    Me.toolBarButton14_htm2168 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton15_htm2124 = New System.Windows.Forms.ToolBarButton
    Me.menuItem20_htm67 = New System.Windows.Forms.MenuItem
    Me.menuItem19 = New System.Windows.Forms.MenuItem
    Me.menuItem18_htm26 = New System.Windows.Forms.MenuItem
    Me.menuItem23_htm31 = New System.Windows.Forms.MenuItem
    Me.menuItem22_htm17 = New System.Windows.Forms.MenuItem
    Me.menuItem21 = New System.Windows.Forms.MenuItem
    Me.menuItem14_htm29 = New System.Windows.Forms.MenuItem
    Me.menuItem13_htm43 = New System.Windows.Forms.MenuItem
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.menuItem15 = New System.Windows.Forms.MenuItem
    Me.menuItem16_htm16 = New System.Windows.Forms.MenuItem
    Me.menuItem17_htm15 = New System.Windows.Forms.MenuItem
    Me.toolBarButton21_htm56 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton22_htm63 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton24 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton33 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton36 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton20_htm52 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton29_htm60 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton31_htm2185 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton32_htm2184 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton25 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton27_htm59 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton28_htm57 = New System.Windows.Forms.ToolBarButton
    Me.comboBox3 = New System.Windows.Forms.ComboBox
    Me.comboBox2 = New System.Windows.Forms.ComboBox
    Me.comboBox1 = New System.Windows.Forms.ComboBox
    Me.toolBar2 = New System.Windows.Forms.ToolBar
    Me.toolBarSeparator = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton19 = New System.Windows.Forms.ToolBarButton
    Me.toolBarBlank = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton23 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton26 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton30 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton34_htm2187 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton35_htm2186 = New System.Windows.Forms.ToolBarButton
    Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
    Me.toolBarButton16 = New System.Windows.Forms.ToolBarButton
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton4 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton5 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton6_htm16 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton7_htm15 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton8_htm26 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton9 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton10_htm43 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton11_htm29 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton12 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton13_htm2200 = New System.Windows.Forms.ToolBarButton
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.colorDialog1 = New System.Windows.Forms.ColorDialog
    Me.explorer_Box1 = New Salford.VisualClearWin.Explorer_Box
    Me.statusBar1 = New System.Windows.Forms.StatusBar
    Me.SuspendLayout()
    '
    'menuItem31_htm2163
    '
    Me.menuItem31_htm2163.Index = 6
    Me.menuItem31_htm2163.Text = "Check box"
    '
    'menuItem30_htm2167
    '
    Me.menuItem30_htm2167.Index = 5
    Me.menuItem30_htm2167.Text = "Button"
    '
    'menuItem29
    '
    Me.menuItem29.Index = 4
    Me.menuItem29.Text = "-"
    '
    'menuItem34_htm2166
    '
    Me.menuItem34_htm2166.Index = 9
    Me.menuItem34_htm2166.Text = "List box"
    '
    'menuItem33_htm2165
    '
    Me.menuItem33_htm2165.Index = 8
    Me.menuItem33_htm2165.Text = "Drop down box"
    '
    'menuItem32_htm2164
    '
    Me.menuItem32_htm2164.Index = 7
    Me.menuItem32_htm2164.Text = "Radio button"
    '
    'menuItem25_htm2150
    '
    Me.menuItem25_htm2150.Index = 0
    Me.menuItem25_htm2150.Text = "Horizontal line"
    '
    'menuItem3
    '
    Me.menuItem3.Index = 2
    Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem25_htm2150, Me.menuItem26_htm2200, Me.menuItem27_htm2168, Me.menuItem28_htm2124, Me.menuItem29, Me.menuItem30_htm2167, Me.menuItem31_htm2163, Me.menuItem32_htm2164, Me.menuItem33_htm2165, Me.menuItem34_htm2166, Me.menuItem35, Me.menuItem36_htm2119, Me.menuItem37_htm2161, Me.menuItem38_htm2162, Me.menuItem39_htm2158, Me.menuItem40_htm2182, Me.menuItem41, Me.menuItem42_htm2117, Me.menuItem43_htm2116, Me.menuItem44_htm2115, Me.menuItem45_htm2312, Me.menuItem46_htm2114, Me.menuItem47_htm2313, Me.menuItem48_htm2118})
    Me.menuItem3.Text = "Insert"
    '
    'menuItem26_htm2200
    '
    Me.menuItem26_htm2200.Index = 1
    Me.menuItem26_htm2200.Text = "Table"
    '
    'menuItem27_htm2168
    '
    Me.menuItem27_htm2168.Index = 2
    Me.menuItem27_htm2168.Text = "Image"
    '
    'menuItem28_htm2124
    '
    Me.menuItem28_htm2124.Index = 3
    Me.menuItem28_htm2124.Text = "Hyperlink"
    '
    'menuItem35
    '
    Me.menuItem35.Index = 10
    Me.menuItem35.Text = "-"
    '
    'menuItem36_htm2119
    '
    Me.menuItem36_htm2119.Index = 11
    Me.menuItem36_htm2119.Text = "Box"
    '
    'menuItem37_htm2161
    '
    Me.menuItem37_htm2161.Index = 12
    Me.menuItem37_htm2161.Text = "Text box"
    '
    'menuItem38_htm2162
    '
    Me.menuItem38_htm2162.Index = 13
    Me.menuItem38_htm2162.Text = "Text area"
    '
    'menuItem39_htm2158
    '
    Me.menuItem39_htm2158.Index = 14
    Me.menuItem39_htm2158.Text = "Inline frame"
    '
    'menuItem40_htm2182
    '
    Me.menuItem40_htm2182.Index = 15
    Me.menuItem40_htm2182.Text = "Marquee"
    '
    'menuItem41
    '
    Me.menuItem41.Index = 16
    Me.menuItem41.Text = "-"
    '
    'menuItem42_htm2117
    '
    Me.menuItem42_htm2117.Index = 17
    Me.menuItem42_htm2117.Text = "Input submit"
    '
    'menuItem43_htm2116
    '
    Me.menuItem43_htm2116.Index = 18
    Me.menuItem43_htm2116.Text = "Input reset"
    '
    'menuItem44_htm2115
    '
    Me.menuItem44_htm2115.Index = 19
    Me.menuItem44_htm2115.Text = "Input button"
    '
    'menuItem45_htm2312
    '
    Me.menuItem45_htm2312.Index = 20
    Me.menuItem45_htm2312.Text = "Input hidden"
    '
    'menuItem46_htm2114
    '
    Me.menuItem46_htm2114.Index = 21
    Me.menuItem46_htm2114.Text = "Input image"
    '
    'menuItem47_htm2313
    '
    Me.menuItem47_htm2313.Index = 22
    Me.menuItem47_htm2313.Text = "Input password"
    '
    'menuItem48_htm2118
    '
    Me.menuItem48_htm2118.Index = 23
    Me.menuItem48_htm2118.Text = "Input upload"
    '
    'menuItem24_htm2230
    '
    Me.menuItem24_htm2230.Index = 11
    Me.menuItem24_htm2230.Text = "Remove format"
    '
    'menuItem9_htm2003
    '
    Me.menuItem9_htm2003.Index = 5
    Me.menuItem9_htm2003.Text = "Print Preview"
    '
    'menuItem8
    '
    Me.menuItem8.Index = 4
    Me.menuItem8.Text = "-"
    '
    'menuItem7
    '
    Me.menuItem7.Index = 3
    Me.menuItem7.Text = "Save As"
    '
    'menuItem12_Exit
    '
    Me.menuItem12_Exit.Index = 8
    Me.menuItem12_Exit.Text = "Exit"
    '
    'menuItem11
    '
    Me.menuItem11.Index = 7
    Me.menuItem11.Text = "-"
    '
    'menuItem10_htm27
    '
    Me.menuItem10_htm27.Index = 6
    Me.menuItem10_htm27.Text = "Print"
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.menuItem9_htm2003, Me.menuItem10_htm27, Me.menuItem11, Me.menuItem12_Exit})
    Me.menuItem1.Text = "File"
    '
    'menuItem4
    '
    Me.menuItem4.Index = 0
    Me.menuItem4.Text = "New"
    '
    'menuItem5
    '
    Me.menuItem5.Index = 1
    Me.menuItem5.Text = "Open"
    '
    'menuItem6
    '
    Me.menuItem6.Index = 2
    Me.menuItem6.Text = "Save"
    '
    'toolBarButton14_htm2168
    '
    Me.toolBarButton14_htm2168.ImageIndex = 9
    Me.toolBarButton14_htm2168.ToolTipText = "Insert image"
    '
    'toolBarButton15_htm2124
    '
    Me.toolBarButton15_htm2124.ImageIndex = 10
    Me.toolBarButton15_htm2124.ToolTipText = "Insert hyperlink"
    '
    'menuItem20_htm67
    '
    Me.menuItem20_htm67.Index = 7
    Me.menuItem20_htm67.Text = "Find"
    '
    'menuItem19
    '
    Me.menuItem19.Index = 6
    Me.menuItem19.Text = "-"
    '
    'menuItem18_htm26
    '
    Me.menuItem18_htm26.Index = 5
    Me.menuItem18_htm26.Text = "Paste"
    '
    'menuItem23_htm31
    '
    Me.menuItem23_htm31.Index = 10
    Me.menuItem23_htm31.Text = "Select All"
    '
    'menuItem22_htm17
    '
    Me.menuItem22_htm17.Index = 9
    Me.menuItem22_htm17.Text = "Delete"
    '
    'menuItem21
    '
    Me.menuItem21.Index = 8
    Me.menuItem21.Text = "-"
    '
    'menuItem14_htm29
    '
    Me.menuItem14_htm29.Index = 1
    Me.menuItem14_htm29.Text = "Redo"
    '
    'menuItem13_htm43
    '
    Me.menuItem13_htm43.Index = 0
    Me.menuItem13_htm43.Text = "Undo"
    '
    'menuItem2
    '
    Me.menuItem2.Index = 1
    Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem13_htm43, Me.menuItem14_htm29, Me.menuItem15, Me.menuItem16_htm16, Me.menuItem17_htm15, Me.menuItem18_htm26, Me.menuItem19, Me.menuItem20_htm67, Me.menuItem21, Me.menuItem22_htm17, Me.menuItem23_htm31, Me.menuItem24_htm2230})
    Me.menuItem2.Text = "Edit"
    '
    'menuItem15
    '
    Me.menuItem15.Index = 2
    Me.menuItem15.Text = "-"
    '
    'menuItem16_htm16
    '
    Me.menuItem16_htm16.Index = 3
    Me.menuItem16_htm16.Text = "Cut"
    '
    'menuItem17_htm15
    '
    Me.menuItem17_htm15.Index = 4
    Me.menuItem17_htm15.Text = "Copy"
    '
    'toolBarButton21_htm56
    '
    Me.toolBarButton21_htm56.ImageIndex = 1
    Me.toolBarButton21_htm56.ToolTipText = "Italic"
    '
    'toolBarButton22_htm63
    '
    Me.toolBarButton22_htm63.ImageIndex = 2
    Me.toolBarButton22_htm63.ToolTipText = "Underline"
    '
    'toolBarButton24
    '
    Me.toolBarButton24.ImageIndex = 3
    Me.toolBarButton24.ToolTipText = "Text colour"
    '
    'toolBarButton33
    '
    Me.toolBarButton33.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    Me.toolBarButton33.Text = "comboBox3"
    '
    'toolBarButton36
    '
    Me.toolBarButton36.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    Me.toolBarButton36.Text = "comboBox3"
    '
    'toolBarButton20_htm52
    '
    Me.toolBarButton20_htm52.ImageIndex = 0
    Me.toolBarButton20_htm52.ToolTipText = "Bold"
    '
    'toolBarButton29_htm60
    '
    Me.toolBarButton29_htm60.ImageIndex = 7
    Me.toolBarButton29_htm60.ToolTipText = "Align right"
    '
    'toolBarButton31_htm2185
    '
    Me.toolBarButton31_htm2185.ImageIndex = 8
    Me.toolBarButton31_htm2185.ToolTipText = "Bullet list"
    '
    'toolBarButton32_htm2184
    '
    Me.toolBarButton32_htm2184.ImageIndex = 9
    Me.toolBarButton32_htm2184.ToolTipText = "Numbered list"
    '
    'toolBarButton25
    '
    Me.toolBarButton25.ImageIndex = 4
    Me.toolBarButton25.ToolTipText = "Background colour"
    '
    'toolBarButton27_htm59
    '
    Me.toolBarButton27_htm59.ImageIndex = 5
    Me.toolBarButton27_htm59.ToolTipText = "Align left"
    '
    'toolBarButton28_htm57
    '
    Me.toolBarButton28_htm57.ImageIndex = 6
    Me.toolBarButton28_htm57.ToolTipText = "Centre"
    '
    'comboBox3
    '
    Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.comboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
    Me.comboBox3.Location = New System.Drawing.Point(256, 39)
    Me.comboBox3.Name = "comboBox3"
    Me.comboBox3.Size = New System.Drawing.Size(64, 21)
    Me.comboBox3.TabIndex = 10
    '
    'comboBox2
    '
    Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.comboBox2.Location = New System.Drawing.Point(128, 39)
    Me.comboBox2.MaxDropDownItems = 16
    Me.comboBox2.Name = "comboBox2"
    Me.comboBox2.Size = New System.Drawing.Size(112, 21)
    Me.comboBox2.Sorted = True
    Me.comboBox2.TabIndex = 9
    '
    'comboBox1
    '
    Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.comboBox1.Items.AddRange(New Object() {"Normal", "Formatted", "Address", "Heading 1", "Heading 2", "Heading 3", "Heading 4", "Heading 5", "Heading 6", "Numbered List", "Bulleted List", "Directory List", "Menu List", "Definition Term", "Definition"})
    Me.comboBox1.Location = New System.Drawing.Point(8, 39)
    Me.comboBox1.MaxDropDownItems = 16
    Me.comboBox1.Name = "comboBox1"
    Me.comboBox1.Size = New System.Drawing.Size(112, 21)
    Me.comboBox1.TabIndex = 8
    '
    'toolBar2
    '
    Me.toolBar2.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarSeparator, Me.toolBarButton19, Me.toolBarBlank, Me.toolBarBlank, Me.toolBarBlank, Me.toolBarButton23, Me.toolBarSeparator, Me.toolBarButton26, Me.toolBarBlank, Me.toolBarBlank, Me.toolBarBlank, Me.toolBarBlank, Me.toolBarBlank, Me.toolBarBlank, Me.toolBarBlank, Me.toolBarBlank, Me.toolBarButton30, Me.toolBarSeparator, Me.toolBarButton33, Me.toolBarBlank, Me.toolBarButton36, Me.toolBarSeparator, Me.toolBarButton20_htm52, Me.toolBarButton21_htm56, Me.toolBarButton22_htm63, Me.toolBarSeparator, Me.toolBarButton24, Me.toolBarButton25, Me.toolBarSeparator, Me.toolBarButton27_htm59, Me.toolBarButton28_htm57, Me.toolBarButton29_htm60, Me.toolBarSeparator, Me.toolBarButton31_htm2185, Me.toolBarButton32_htm2184, Me.toolBarSeparator, Me.toolBarButton34_htm2187, Me.toolBarButton35_htm2186, Me.toolBarSeparator})
    Me.toolBar2.DropDownArrows = True
    Me.toolBar2.ImageList = Me.imageList2
    Me.toolBar2.Location = New System.Drawing.Point(0, 28)
    Me.toolBar2.Name = "toolBar2"
    Me.toolBar2.ShowToolTips = True
    Me.toolBar2.Size = New System.Drawing.Size(680, 28)
    Me.toolBar2.TabIndex = 12
    Me.toolBar2.Wrappable = False
    '
    'toolBarSeparator
    '
    Me.toolBarSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton19
    '
    Me.toolBarButton19.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    Me.toolBarButton19.Text = "comboBox1"
    '
    'toolBarBlank
    '
    Me.toolBarBlank.Enabled = False
    '
    'toolBarButton23
    '
    Me.toolBarButton23.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    Me.toolBarButton23.Text = "comboBox1"
    '
    'toolBarButton26
    '
    Me.toolBarButton26.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    Me.toolBarButton26.Text = "comboBox2"
    '
    'toolBarButton30
    '
    Me.toolBarButton30.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    Me.toolBarButton30.Text = "comboBox2"
    '
    'toolBarButton34_htm2187
    '
    Me.toolBarButton34_htm2187.ImageIndex = 10
    Me.toolBarButton34_htm2187.ToolTipText = "Outdent"
    '
    'toolBarButton35_htm2186
    '
    Me.toolBarButton35_htm2186.ImageIndex = 11
    Me.toolBarButton35_htm2186.ToolTipText = "Indent"
    '
    'imageList2
    '
    Me.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.imageList2.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList2.TransparentColor = System.Drawing.Color.White
    '
    'toolBarButton16
    '
    Me.toolBarButton16.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem2, Me.menuItem3})
    '
    'toolBarButton2
    '
    Me.toolBarButton2.ImageIndex = 0
    Me.toolBarButton2.ToolTipText = "New"
    '
    'toolBarButton1
    '
    Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton2, Me.toolBarButton3, Me.toolBarButton4, Me.toolBarButton5, Me.toolBarButton6_htm16, Me.toolBarButton7_htm15, Me.toolBarButton8_htm26, Me.toolBarButton9, Me.toolBarButton10_htm43, Me.toolBarButton11_htm29, Me.toolBarButton12, Me.toolBarButton13_htm2200, Me.toolBarButton14_htm2168, Me.toolBarButton15_htm2124, Me.toolBarButton16})
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(680, 28)
    Me.toolBar1.TabIndex = 11
    '
    'toolBarButton3
    '
    Me.toolBarButton3.ImageIndex = 1
    Me.toolBarButton3.ToolTipText = "Open"
    '
    'toolBarButton4
    '
    Me.toolBarButton4.ImageIndex = 2
    Me.toolBarButton4.ToolTipText = "Save"
    '
    'toolBarButton5
    '
    Me.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton6_htm16
    '
    Me.toolBarButton6_htm16.ImageIndex = 3
    Me.toolBarButton6_htm16.ToolTipText = "Cut"
    '
    'toolBarButton7_htm15
    '
    Me.toolBarButton7_htm15.ImageIndex = 4
    Me.toolBarButton7_htm15.ToolTipText = "Copy"
    '
    'toolBarButton8_htm26
    '
    Me.toolBarButton8_htm26.ImageIndex = 5
    Me.toolBarButton8_htm26.ToolTipText = "Paste"
    '
    'toolBarButton9
    '
    Me.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton10_htm43
    '
    Me.toolBarButton10_htm43.ImageIndex = 6
    Me.toolBarButton10_htm43.ToolTipText = "Undo"
    '
    'toolBarButton11_htm29
    '
    Me.toolBarButton11_htm29.ImageIndex = 7
    Me.toolBarButton11_htm29.ToolTipText = "Redo"
    '
    'toolBarButton12
    '
    Me.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton13_htm2200
    '
    Me.toolBarButton13_htm2200.ImageIndex = 8
    Me.toolBarButton13_htm2200.ToolTipText = "Insert table"
    '
    'imageList1
    '
    Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.White
    '
    'openFileDialog1
    '
    Me.openFileDialog1.DefaultExt = "htm"
    Me.openFileDialog1.Filter = "Web files|*.htm;*.html|All files|*.*"
    '
    'explorer_Box1
    '
    Me.explorer_Box1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.explorer_Box1.DesignView = True
    Me.explorer_Box1.Location = New System.Drawing.Point(0, 64)
    Me.explorer_Box1.Name = "explorer_Box1"
    Me.explorer_Box1.Size = New System.Drawing.Size(680, 308)
    Me.explorer_Box1.TabIndex = 14
    '
    'statusBar1
    '
    Me.statusBar1.Dock = System.Windows.Forms.DockStyle.None
    Me.statusBar1.Location = New System.Drawing.Point(0, 375)
    Me.statusBar1.Name = "statusBar1"
    Me.statusBar1.Size = New System.Drawing.Size(680, 16)
    Me.statusBar1.TabIndex = 13
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(680, 403)
    Me.Controls.Add(Me.explorer_Box1)
    Me.Controls.Add(Me.statusBar1)
    Me.Controls.Add(Me.comboBox3)
    Me.Controls.Add(Me.comboBox2)
    Me.Controls.Add(Me.comboBox1)
    Me.Controls.Add(Me.toolBar2)
    Me.Controls.Add(Me.toolBar1)
    Me.Menu = Me.mainMenu1
    Me.Name = "Form1"
    Me.Text = "HTML Edit"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
