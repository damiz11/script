using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Resources9
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.ComponentModel.IContainer components=null;
	  private System.Windows.Forms.MainMenu mainMenu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem2;
	  private System.Windows.Forms.MenuItem menuItem3;
	  private System.Windows.Forms.MenuItem menuItem8;
	  private System.Windows.Forms.MenuItem menuItem11;
	  private System.Windows.Forms.MenuItem menuItem15;
	  private System.Windows.Forms.MenuItem menuItem19;
	  private System.Windows.Forms.MenuItem menuItem21;
	  private System.Windows.Forms.MenuItem menuItem29;
	  private System.Windows.Forms.MenuItem menuItem35;
	  private System.Windows.Forms.MenuItem menuItem41;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.ImageList imageList2;
	  private System.Windows.Forms.ToolBar toolBar1;
	  private System.Windows.Forms.ToolBarButton toolBarButton1;
	  private System.Windows.Forms.ToolBarButton toolBarButton5;
	  private System.Windows.Forms.ToolBarButton toolBarButton9;
	  private System.Windows.Forms.ToolBarButton toolBarButton12;
	  private System.Windows.Forms.ToolBarButton toolBarButton16;
	  private System.Windows.Forms.ToolBar toolBar2;
	  private System.Windows.Forms.ToolBarButton toolBarButton23;
	  private System.Windows.Forms.ToolBarButton toolBarButton24;
	  private System.Windows.Forms.ToolBarButton toolBarButton25;
	  private System.Windows.Forms.ToolBarButton toolBarButton26;
	  private System.Windows.Forms.ToolBarButton toolBarButton30;
	  private System.Windows.Forms.ToolBarButton toolBarButton33;
	  private System.Windows.Forms.ToolBarButton toolBarButton36;
	  private System.Windows.Forms.StatusBar statusBar1;
	  private System.Windows.Forms.MenuItem menuItem12_Exit;
	  private System.Windows.Forms.OpenFileDialog openFileDialog1;
	  private System.Windows.Forms.ColorDialog colorDialog1;
	  private System.Windows.Forms.MenuItem menuItem27_htm2168;
	  private System.Windows.Forms.MenuItem menuItem28_htm2124;
	  private System.Windows.Forms.MenuItem menuItem30_htm2167;
	  private System.Windows.Forms.MenuItem menuItem31_htm2163;
	  private System.Windows.Forms.MenuItem menuItem32_htm2164;
	  private System.Windows.Forms.MenuItem menuItem33_htm2165;
	  private System.Windows.Forms.MenuItem menuItem34_htm2166;
	  private System.Windows.Forms.MenuItem menuItem36_htm2119;
	  private System.Windows.Forms.MenuItem menuItem37_htm2161;
	  private System.Windows.Forms.MenuItem menuItem38_htm2162;
	  private System.Windows.Forms.MenuItem menuItem39_htm2158;
	  private System.Windows.Forms.MenuItem menuItem40_htm2182;
	  private System.Windows.Forms.MenuItem menuItem42_htm2117;
	  private System.Windows.Forms.MenuItem menuItem43_htm2116;
	  private System.Windows.Forms.MenuItem menuItem44_htm2115;
	  private System.Windows.Forms.MenuItem menuItem45_htm2312;
	  private System.Windows.Forms.MenuItem menuItem46_htm2114;
	  private System.Windows.Forms.MenuItem menuItem47_htm2313;
	  private System.Windows.Forms.MenuItem menuItem48_htm2118;
	  private System.Windows.Forms.ToolBarButton toolBarButton6_htm16;
	  private System.Windows.Forms.ToolBarButton toolBarButton14_htm2168;
	  private System.Windows.Forms.ToolBarButton toolBarButton15_htm2124;
	  private System.Windows.Forms.ToolBarButton toolBarButton19;
	  private System.Windows.Forms.ToolBarButton toolBarButton20_htm52;
	  private System.Windows.Forms.ToolBarButton toolBarButton21_htm56;
	  private System.Windows.Forms.ToolBarButton toolBarButton22_htm63;
	  private System.Windows.Forms.ToolBarButton toolBarButton27_htm59;
	  private System.Windows.Forms.ToolBarButton toolBarButton28_htm57;
	  private System.Windows.Forms.ToolBarButton toolBarButton29_htm60;
	  private System.Windows.Forms.ToolBarButton toolBarButton31_htm2185;
	  private System.Windows.Forms.ToolBarButton toolBarButton32_htm2184;
	  private System.Windows.Forms.ToolBarButton toolBarButton34_htm2187;
	  private System.Windows.Forms.ToolBarButton toolBarButton35_htm2186;
	  private System.Windows.Forms.ToolBarButton toolBarSeparator;
	  private System.Windows.Forms.ComboBox comboBox1;
	  private System.Windows.Forms.ComboBox comboBox2;
	  private System.Windows.Forms.ComboBox comboBox3;
	  private System.Windows.Forms.MenuItem menuItem17_htm15;
	  private System.Windows.Forms.ToolBarButton toolBarButton7_htm15;
	  private System.Windows.Forms.ToolBarButton toolBarButton8_htm26;
	  private System.Windows.Forms.MenuItem menuItem9_htm2003;
	  private System.Windows.Forms.MenuItem menuItem10_htm27;
	  private System.Windows.Forms.MenuItem menuItem20_htm67;
	  private System.Windows.Forms.MenuItem menuItem23_htm31;
	  private System.Windows.Forms.ToolBarButton toolBarButton10_htm43;
	  private System.Windows.Forms.ToolBarButton toolBarButton11_htm29;
	  private System.Windows.Forms.MenuItem menuItem13_htm43;
	  private System.Windows.Forms.MenuItem menuItem14_htm29;
	  private System.Windows.Forms.MenuItem menuItem16_htm16;
	  private System.Windows.Forms.MenuItem menuItem18_htm26;
	  private System.Windows.Forms.MenuItem menuItem22_htm17;
	  private System.Windows.Forms.MenuItem menuItem24_htm2230;
	  private System.Windows.Forms.MenuItem menuItem25_htm2150;
	  private System.Windows.Forms.MenuItem menuItem4;
	  private System.Windows.Forms.MenuItem menuItem5;
	  private System.Windows.Forms.ToolBarButton toolBarButton2;
	  private System.Windows.Forms.MenuItem menuItem6;
	  private System.Windows.Forms.MenuItem menuItem7;
	  private System.Windows.Forms.ToolBarButton toolBarButton4;
	  private System.Windows.Forms.MenuItem menuItem26_htm2200;
	  private System.Windows.Forms.ToolBarButton toolBarButton13_htm2200;
	  private Salford.VisualClearWin.Explorer_Box explorer_Box1;
	  private System.Windows.Forms.ToolBarButton toolBarBlank;
	  private System.Windows.Forms.ToolBarButton toolBarButton3;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		  this.components = new System.ComponentModel.Container();
		  System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
		  this.comboBox3 = new System.Windows.Forms.ComboBox();
		  this.comboBox2 = new System.Windows.Forms.ComboBox();
		  this.comboBox1 = new System.Windows.Forms.ComboBox();
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.menuItem5 = new System.Windows.Forms.MenuItem();
		  this.menuItem6 = new System.Windows.Forms.MenuItem();
		  this.menuItem7 = new System.Windows.Forms.MenuItem();
		  this.menuItem8 = new System.Windows.Forms.MenuItem();
		  this.menuItem9_htm2003 = new System.Windows.Forms.MenuItem();
		  this.menuItem10_htm27 = new System.Windows.Forms.MenuItem();
		  this.menuItem11 = new System.Windows.Forms.MenuItem();
		  this.menuItem12_Exit = new System.Windows.Forms.MenuItem();
		  this.menuItem2 = new System.Windows.Forms.MenuItem();
		  this.menuItem13_htm43 = new System.Windows.Forms.MenuItem();
		  this.menuItem14_htm29 = new System.Windows.Forms.MenuItem();
		  this.menuItem15 = new System.Windows.Forms.MenuItem();
		  this.menuItem16_htm16 = new System.Windows.Forms.MenuItem();
		  this.menuItem17_htm15 = new System.Windows.Forms.MenuItem();
		  this.menuItem18_htm26 = new System.Windows.Forms.MenuItem();
		  this.menuItem19 = new System.Windows.Forms.MenuItem();
		  this.menuItem20_htm67 = new System.Windows.Forms.MenuItem();
		  this.menuItem21 = new System.Windows.Forms.MenuItem();
		  this.menuItem22_htm17 = new System.Windows.Forms.MenuItem();
		  this.menuItem23_htm31 = new System.Windows.Forms.MenuItem();
		  this.menuItem24_htm2230 = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.menuItem25_htm2150 = new System.Windows.Forms.MenuItem();
		  this.menuItem26_htm2200 = new System.Windows.Forms.MenuItem();
		  this.menuItem27_htm2168 = new System.Windows.Forms.MenuItem();
		  this.menuItem28_htm2124 = new System.Windows.Forms.MenuItem();
		  this.menuItem29 = new System.Windows.Forms.MenuItem();
		  this.menuItem30_htm2167 = new System.Windows.Forms.MenuItem();
		  this.menuItem31_htm2163 = new System.Windows.Forms.MenuItem();
		  this.menuItem32_htm2164 = new System.Windows.Forms.MenuItem();
		  this.menuItem33_htm2165 = new System.Windows.Forms.MenuItem();
		  this.menuItem34_htm2166 = new System.Windows.Forms.MenuItem();
		  this.menuItem35 = new System.Windows.Forms.MenuItem();
		  this.menuItem36_htm2119 = new System.Windows.Forms.MenuItem();
		  this.menuItem37_htm2161 = new System.Windows.Forms.MenuItem();
		  this.menuItem38_htm2162 = new System.Windows.Forms.MenuItem();
		  this.menuItem39_htm2158 = new System.Windows.Forms.MenuItem();
		  this.menuItem40_htm2182 = new System.Windows.Forms.MenuItem();
		  this.menuItem41 = new System.Windows.Forms.MenuItem();
		  this.menuItem42_htm2117 = new System.Windows.Forms.MenuItem();
		  this.menuItem43_htm2116 = new System.Windows.Forms.MenuItem();
		  this.menuItem44_htm2115 = new System.Windows.Forms.MenuItem();
		  this.menuItem45_htm2312 = new System.Windows.Forms.MenuItem();
		  this.menuItem46_htm2114 = new System.Windows.Forms.MenuItem();
		  this.menuItem47_htm2313 = new System.Windows.Forms.MenuItem();
		  this.menuItem48_htm2118 = new System.Windows.Forms.MenuItem();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.imageList2 = new System.Windows.Forms.ImageList(this.components);
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton6_htm16 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton7_htm15 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton8_htm26 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton10_htm43 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton11_htm29 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton13_htm2200 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton14_htm2168 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton15_htm2124 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
		  this.toolBar2 = new System.Windows.Forms.ToolBar();
		  this.toolBarSeparator = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton19 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarBlank = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton23 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton26 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton30 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton33 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton36 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton20_htm52 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton21_htm56 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton22_htm63 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton24 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton25 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton27_htm59 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton28_htm57 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton29_htm60 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton31_htm2185 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton32_htm2184 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton34_htm2187 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton35_htm2186 = new System.Windows.Forms.ToolBarButton();
		  this.statusBar1 = new System.Windows.Forms.StatusBar();
		  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		  this.colorDialog1 = new System.Windows.Forms.ColorDialog();
		  this.explorer_Box1 = new Salford.VisualClearWin.Explorer_Box();
		  this.SuspendLayout();
		  // 
		  // comboBox3
		  // 
		  this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		  this.comboBox3.Items.AddRange(new object[] {
													   "1",
													   "2",
													   "3",
													   "4",
													   "5",
													   "6",
													   "7"});
		  this.comboBox3.Location = new System.Drawing.Point(256, 28);
		  this.comboBox3.Name = "comboBox3";
		  this.comboBox3.Size = new System.Drawing.Size(64, 21);
		  this.comboBox3.TabIndex = 3;
		  // 
		  // comboBox2
		  // 
		  this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		  this.comboBox2.Location = new System.Drawing.Point(128, 28);
		  this.comboBox2.MaxDropDownItems = 16;
		  this.comboBox2.Name = "comboBox2";
		  this.comboBox2.Size = new System.Drawing.Size(112, 21);
		  this.comboBox2.Sorted = true;
		  this.comboBox2.TabIndex = 2;
		  // 
		  // comboBox1
		  // 
		  this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		  this.comboBox1.Items.AddRange(new object[] {
													   "Normal",
													   "Formatted",
													   "Address",
													   "Heading 1",
													   "Heading 2",
													   "Heading 3",
													   "Heading 4",
													   "Heading 5",
													   "Heading 6",
													   "Numbered List",
													   "Bulleted List",
													   "Directory List",
													   "Menu List",
													   "Definition Term",
													   "Definition"});
		  this.comboBox1.Location = new System.Drawing.Point(8, 28);
		  this.comboBox1.MaxDropDownItems = 16;
		  this.comboBox1.Name = "comboBox1";
		  this.comboBox1.Size = new System.Drawing.Size(112, 21);
		  this.comboBox1.TabIndex = 1;
		  // 
		  // mainMenu1
		  // 
		  this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem1,
																				  this.menuItem2,
																				  this.menuItem3});
		  // 
		  // menuItem1
		  // 
		  this.menuItem1.Index = 0;
		  this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem4,
																				  this.menuItem5,
																				  this.menuItem6,
																				  this.menuItem7,
																				  this.menuItem8,
																				  this.menuItem9_htm2003,
																				  this.menuItem10_htm27,
																				  this.menuItem11,
																				  this.menuItem12_Exit});
		  this.menuItem1.Text = "File";
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 0;
		  this.menuItem4.Text = "New";
		  // 
		  // menuItem5
		  // 
		  this.menuItem5.Index = 1;
		  this.menuItem5.Text = "Open";
		  // 
		  // menuItem6
		  // 
		  this.menuItem6.Index = 2;
		  this.menuItem6.Text = "Save";
		  // 
		  // menuItem7
		  // 
		  this.menuItem7.Index = 3;
		  this.menuItem7.Text = "Save As";
		  // 
		  // menuItem8
		  // 
		  this.menuItem8.Index = 4;
		  this.menuItem8.Text = "-";
		  // 
		  // menuItem9_htm2003
		  // 
		  this.menuItem9_htm2003.Index = 5;
		  this.menuItem9_htm2003.Text = "Print Preview";
		  // 
		  // menuItem10_htm27
		  // 
		  this.menuItem10_htm27.Index = 6;
		  this.menuItem10_htm27.Text = "Print";
		  // 
		  // menuItem11
		  // 
		  this.menuItem11.Index = 7;
		  this.menuItem11.Text = "-";
		  // 
		  // menuItem12_Exit
		  // 
		  this.menuItem12_Exit.Index = 8;
		  this.menuItem12_Exit.Text = "Exit";
		  // 
		  // menuItem2
		  // 
		  this.menuItem2.Index = 1;
		  this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem13_htm43,
																				  this.menuItem14_htm29,
																				  this.menuItem15,
																				  this.menuItem16_htm16,
																				  this.menuItem17_htm15,
																				  this.menuItem18_htm26,
																				  this.menuItem19,
																				  this.menuItem20_htm67,
																				  this.menuItem21,
																				  this.menuItem22_htm17,
																				  this.menuItem23_htm31,
																				  this.menuItem24_htm2230});
		  this.menuItem2.Text = "Edit";
		  // 
		  // menuItem13_htm43
		  // 
		  this.menuItem13_htm43.Index = 0;
		  this.menuItem13_htm43.Text = "Undo";
		  // 
		  // menuItem14_htm29
		  // 
		  this.menuItem14_htm29.Index = 1;
		  this.menuItem14_htm29.Text = "Redo";
		  // 
		  // menuItem15
		  // 
		  this.menuItem15.Index = 2;
		  this.menuItem15.Text = "-";
		  // 
		  // menuItem16_htm16
		  // 
		  this.menuItem16_htm16.Index = 3;
		  this.menuItem16_htm16.Text = "Cut";
		  // 
		  // menuItem17_htm15
		  // 
		  this.menuItem17_htm15.Index = 4;
		  this.menuItem17_htm15.Text = "Copy";
		  // 
		  // menuItem18_htm26
		  // 
		  this.menuItem18_htm26.Index = 5;
		  this.menuItem18_htm26.Text = "Paste";
		  // 
		  // menuItem19
		  // 
		  this.menuItem19.Index = 6;
		  this.menuItem19.Text = "-";
		  // 
		  // menuItem20_htm67
		  // 
		  this.menuItem20_htm67.Index = 7;
		  this.menuItem20_htm67.Text = "Find";
		  // 
		  // menuItem21
		  // 
		  this.menuItem21.Index = 8;
		  this.menuItem21.Text = "-";
		  // 
		  // menuItem22_htm17
		  // 
		  this.menuItem22_htm17.Index = 9;
		  this.menuItem22_htm17.Text = "Delete";
		  // 
		  // menuItem23_htm31
		  // 
		  this.menuItem23_htm31.Index = 10;
		  this.menuItem23_htm31.Text = "Select All";
		  // 
		  // menuItem24_htm2230
		  // 
		  this.menuItem24_htm2230.Index = 11;
		  this.menuItem24_htm2230.Text = "Remove format";
		  // 
		  // menuItem3
		  // 
		  this.menuItem3.Index = 2;
		  this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem25_htm2150,
																				  this.menuItem26_htm2200,
																				  this.menuItem27_htm2168,
																				  this.menuItem28_htm2124,
																				  this.menuItem29,
																				  this.menuItem30_htm2167,
																				  this.menuItem31_htm2163,
																				  this.menuItem32_htm2164,
																				  this.menuItem33_htm2165,
																				  this.menuItem34_htm2166,
																				  this.menuItem35,
																				  this.menuItem36_htm2119,
																				  this.menuItem37_htm2161,
																				  this.menuItem38_htm2162,
																				  this.menuItem39_htm2158,
																				  this.menuItem40_htm2182,
																				  this.menuItem41,
																				  this.menuItem42_htm2117,
																				  this.menuItem43_htm2116,
																				  this.menuItem44_htm2115,
																				  this.menuItem45_htm2312,
																				  this.menuItem46_htm2114,
																				  this.menuItem47_htm2313,
																				  this.menuItem48_htm2118});
		  this.menuItem3.Text = "Insert";
		  // 
		  // menuItem25_htm2150
		  // 
		  this.menuItem25_htm2150.Index = 0;
		  this.menuItem25_htm2150.Text = "Horizontal line";
		  // 
		  // menuItem26_htm2200
		  // 
		  this.menuItem26_htm2200.Index = 1;
		  this.menuItem26_htm2200.Text = "Table";
		  // 
		  // menuItem27_htm2168
		  // 
		  this.menuItem27_htm2168.Index = 2;
		  this.menuItem27_htm2168.Text = "Image";
		  // 
		  // menuItem28_htm2124
		  // 
		  this.menuItem28_htm2124.Index = 3;
		  this.menuItem28_htm2124.Text = "Hyperlink";
		  // 
		  // menuItem29
		  // 
		  this.menuItem29.Index = 4;
		  this.menuItem29.Text = "-";
		  // 
		  // menuItem30_htm2167
		  // 
		  this.menuItem30_htm2167.Index = 5;
		  this.menuItem30_htm2167.Text = "Button";
		  // 
		  // menuItem31_htm2163
		  // 
		  this.menuItem31_htm2163.Index = 6;
		  this.menuItem31_htm2163.Text = "Check box";
		  // 
		  // menuItem32_htm2164
		  // 
		  this.menuItem32_htm2164.Index = 7;
		  this.menuItem32_htm2164.Text = "Radio button";
		  // 
		  // menuItem33_htm2165
		  // 
		  this.menuItem33_htm2165.Index = 8;
		  this.menuItem33_htm2165.Text = "Drop down box";
		  // 
		  // menuItem34_htm2166
		  // 
		  this.menuItem34_htm2166.Index = 9;
		  this.menuItem34_htm2166.Text = "List box";
		  // 
		  // menuItem35
		  // 
		  this.menuItem35.Index = 10;
		  this.menuItem35.Text = "-";
		  // 
		  // menuItem36_htm2119
		  // 
		  this.menuItem36_htm2119.Index = 11;
		  this.menuItem36_htm2119.Text = "Box";
		  // 
		  // menuItem37_htm2161
		  // 
		  this.menuItem37_htm2161.Index = 12;
		  this.menuItem37_htm2161.Text = "Text box";
		  // 
		  // menuItem38_htm2162
		  // 
		  this.menuItem38_htm2162.Index = 13;
		  this.menuItem38_htm2162.Text = "Text area";
		  // 
		  // menuItem39_htm2158
		  // 
		  this.menuItem39_htm2158.Index = 14;
		  this.menuItem39_htm2158.Text = "Inline frame";
		  // 
		  // menuItem40_htm2182
		  // 
		  this.menuItem40_htm2182.Index = 15;
		  this.menuItem40_htm2182.Text = "Marquee";
		  // 
		  // menuItem41
		  // 
		  this.menuItem41.Index = 16;
		  this.menuItem41.Text = "-";
		  // 
		  // menuItem42_htm2117
		  // 
		  this.menuItem42_htm2117.Index = 17;
		  this.menuItem42_htm2117.Text = "Input submit";
		  // 
		  // menuItem43_htm2116
		  // 
		  this.menuItem43_htm2116.Index = 18;
		  this.menuItem43_htm2116.Text = "Input reset";
		  // 
		  // menuItem44_htm2115
		  // 
		  this.menuItem44_htm2115.Index = 19;
		  this.menuItem44_htm2115.Text = "Input button";
		  // 
		  // menuItem45_htm2312
		  // 
		  this.menuItem45_htm2312.Index = 20;
		  this.menuItem45_htm2312.Text = "Input hidden";
		  // 
		  // menuItem46_htm2114
		  // 
		  this.menuItem46_htm2114.Index = 21;
		  this.menuItem46_htm2114.Text = "Input image";
		  // 
		  // menuItem47_htm2313
		  // 
		  this.menuItem47_htm2313.Index = 22;
		  this.menuItem47_htm2313.Text = "Input password";
		  // 
		  // menuItem48_htm2118
		  // 
		  this.menuItem48_htm2118.Index = 23;
		  this.menuItem48_htm2118.Text = "Input upload";
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.White;
		  // 
		  // imageList2
		  // 
		  this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		  this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
		  this.imageList2.TransparentColor = System.Drawing.Color.White;
		  // 
		  // toolBar1
		  // 
		  this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
		  this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarButton1,
																					this.toolBarButton2,
																					this.toolBarButton3,
																					this.toolBarButton4,
																					this.toolBarButton5,
																					this.toolBarButton6_htm16,
																					this.toolBarButton7_htm15,
																					this.toolBarButton8_htm26,
																					this.toolBarButton9,
																					this.toolBarButton10_htm43,
																					this.toolBarButton11_htm29,
																					this.toolBarButton12,
																					this.toolBarButton13_htm2200,
																					this.toolBarButton14_htm2168,
																					this.toolBarButton15_htm2124,
																					this.toolBarButton16});
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(680, 25);
		  this.toolBar1.TabIndex = 4;
		  // 
		  // toolBarButton1
		  // 
		  this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton2
		  // 
		  this.toolBarButton2.ImageIndex = 0;
		  this.toolBarButton2.ToolTipText = "New";
		  // 
		  // toolBarButton3
		  // 
		  this.toolBarButton3.ImageIndex = 1;
		  this.toolBarButton3.ToolTipText = "Open";
		  // 
		  // toolBarButton4
		  // 
		  this.toolBarButton4.ImageIndex = 2;
		  this.toolBarButton4.ToolTipText = "Save";
		  // 
		  // toolBarButton5
		  // 
		  this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton6_htm16
		  // 
		  this.toolBarButton6_htm16.ImageIndex = 3;
		  this.toolBarButton6_htm16.ToolTipText = "Cut";
		  // 
		  // toolBarButton7_htm15
		  // 
		  this.toolBarButton7_htm15.ImageIndex = 4;
		  this.toolBarButton7_htm15.ToolTipText = "Copy";
		  // 
		  // toolBarButton8_htm26
		  // 
		  this.toolBarButton8_htm26.ImageIndex = 5;
		  this.toolBarButton8_htm26.ToolTipText = "Paste";
		  // 
		  // toolBarButton9
		  // 
		  this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton10_htm43
		  // 
		  this.toolBarButton10_htm43.ImageIndex = 6;
		  this.toolBarButton10_htm43.ToolTipText = "Undo";
		  // 
		  // toolBarButton11_htm29
		  // 
		  this.toolBarButton11_htm29.ImageIndex = 7;
		  this.toolBarButton11_htm29.ToolTipText = "Redo";
		  // 
		  // toolBarButton12
		  // 
		  this.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton13_htm2200
		  // 
		  this.toolBarButton13_htm2200.ImageIndex = 8;
		  this.toolBarButton13_htm2200.ToolTipText = "Insert table";
		  // 
		  // toolBarButton14_htm2168
		  // 
		  this.toolBarButton14_htm2168.ImageIndex = 9;
		  this.toolBarButton14_htm2168.ToolTipText = "Insert image";
		  // 
		  // toolBarButton15_htm2124
		  // 
		  this.toolBarButton15_htm2124.ImageIndex = 10;
		  this.toolBarButton15_htm2124.ToolTipText = "Insert hyperlink";
		  // 
		  // toolBarButton16
		  // 
		  this.toolBarButton16.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBar2
		  // 
		  this.toolBar2.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
		  this.toolBar2.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarSeparator,
																					this.toolBarButton19,
																					this.toolBarBlank,
																					this.toolBarBlank,
																					this.toolBarBlank,
																					this.toolBarButton23,
																					this.toolBarSeparator,
																					this.toolBarButton26,
																					this.toolBarBlank,
																					this.toolBarBlank,
																					this.toolBarBlank,
																					this.toolBarBlank,
																					this.toolBarBlank,
																					this.toolBarBlank,
																					this.toolBarBlank,
																					this.toolBarBlank,
																					this.toolBarButton30,
																					this.toolBarSeparator,
																					this.toolBarButton33,
																					this.toolBarBlank,
																					this.toolBarButton36,
																					this.toolBarSeparator,
																					this.toolBarButton20_htm52,
																					this.toolBarButton21_htm56,
																					this.toolBarButton22_htm63,
																					this.toolBarSeparator,
																					this.toolBarButton24,
																					this.toolBarButton25,
																					this.toolBarSeparator,
																					this.toolBarButton27_htm59,
																					this.toolBarButton28_htm57,
																					this.toolBarButton29_htm60,
																					this.toolBarSeparator,
																					this.toolBarButton31_htm2185,
																					this.toolBarButton32_htm2184,
																					this.toolBarSeparator,
																					this.toolBarButton34_htm2187,
																					this.toolBarButton35_htm2186,
																					this.toolBarSeparator});
		  this.toolBar2.DropDownArrows = true;
		  this.toolBar2.ImageList = this.imageList2;
		  this.toolBar2.Location = new System.Drawing.Point(0, 25);
		  this.toolBar2.Name = "toolBar2";
		  this.toolBar2.ShowToolTips = true;
		  this.toolBar2.Size = new System.Drawing.Size(680, 25);
		  this.toolBar2.TabIndex = 5;
		  this.toolBar2.Wrappable = false;
		  // 
		  // toolBarSeparator
		  // 
		  this.toolBarSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton19
		  // 
		  this.toolBarButton19.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  this.toolBarButton19.Text = "comboBox1";
		  // 
		  // toolBarBlank
		  // 
		  this.toolBarBlank.Enabled = false;
		  // 
		  // toolBarButton23
		  // 
		  this.toolBarButton23.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  this.toolBarButton23.Text = "comboBox1";
		  // 
		  // toolBarButton26
		  // 
		  this.toolBarButton26.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  this.toolBarButton26.Text = "comboBox2";
		  // 
		  // toolBarButton30
		  // 
		  this.toolBarButton30.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  this.toolBarButton30.Text = "comboBox2";
		  // 
		  // toolBarButton33
		  // 
		  this.toolBarButton33.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  this.toolBarButton33.Text = "comboBox3";
		  // 
		  // toolBarButton36
		  // 
		  this.toolBarButton36.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  this.toolBarButton36.Text = "comboBox3";
		  // 
		  // toolBarButton20_htm52
		  // 
		  this.toolBarButton20_htm52.ImageIndex = 0;
		  this.toolBarButton20_htm52.ToolTipText = "Bold";
		  // 
		  // toolBarButton21_htm56
		  // 
		  this.toolBarButton21_htm56.ImageIndex = 1;
		  this.toolBarButton21_htm56.ToolTipText = "Italic";
		  // 
		  // toolBarButton22_htm63
		  // 
		  this.toolBarButton22_htm63.ImageIndex = 2;
		  this.toolBarButton22_htm63.ToolTipText = "Underline";
		  // 
		  // toolBarButton24
		  // 
		  this.toolBarButton24.ImageIndex = 3;
		  this.toolBarButton24.ToolTipText = "Text colour";
		  // 
		  // toolBarButton25
		  // 
		  this.toolBarButton25.ImageIndex = 4;
		  this.toolBarButton25.ToolTipText = "Background colour";
		  // 
		  // toolBarButton27_htm59
		  // 
		  this.toolBarButton27_htm59.ImageIndex = 5;
		  this.toolBarButton27_htm59.ToolTipText = "Align left";
		  // 
		  // toolBarButton28_htm57
		  // 
		  this.toolBarButton28_htm57.ImageIndex = 6;
		  this.toolBarButton28_htm57.ToolTipText = "Centre";
		  // 
		  // toolBarButton29_htm60
		  // 
		  this.toolBarButton29_htm60.ImageIndex = 7;
		  this.toolBarButton29_htm60.ToolTipText = "Align right";
		  // 
		  // toolBarButton31_htm2185
		  // 
		  this.toolBarButton31_htm2185.ImageIndex = 8;
		  this.toolBarButton31_htm2185.ToolTipText = "Bullet list";
		  // 
		  // toolBarButton32_htm2184
		  // 
		  this.toolBarButton32_htm2184.ImageIndex = 9;
		  this.toolBarButton32_htm2184.ToolTipText = "Numbered list";
		  // 
		  // toolBarButton34_htm2187
		  // 
		  this.toolBarButton34_htm2187.ImageIndex = 10;
		  this.toolBarButton34_htm2187.ToolTipText = "Outdent";
		  // 
		  // toolBarButton35_htm2186
		  // 
		  this.toolBarButton35_htm2186.ImageIndex = 11;
		  this.toolBarButton35_htm2186.ToolTipText = "Indent";
		  // 
		  // statusBar1
		  // 
		  this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
		  this.statusBar1.Location = new System.Drawing.Point(0, 364);
		  this.statusBar1.Name = "statusBar1";
		  this.statusBar1.Size = new System.Drawing.Size(680, 16);
		  this.statusBar1.TabIndex = 6;
		  // 
		  // openFileDialog1
		  // 
		  this.openFileDialog1.DefaultExt = "htm";
		  this.openFileDialog1.Filter = "Web files|*.htm;*.html|All files|*.*";
		  // 
		  // explorer_Box1
		  // 
		  this.explorer_Box1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right);
		  this.explorer_Box1.DesignView = true;
		  this.explorer_Box1.Location = new System.Drawing.Point(0, 53);
		  this.explorer_Box1.Name = "explorer_Box1";
		  this.explorer_Box1.Size = new System.Drawing.Size(680, 308);
		  this.explorer_Box1.TabIndex = 7;
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(680, 382);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.explorer_Box1,
																	  this.comboBox3,
																	  this.comboBox2,
																	  this.comboBox1,
																	  this.statusBar1,
																	  this.toolBar2,
																	  this.toolBar1});
		  this.Menu = this.mainMenu1;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "HTML Edit";
		  this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

	}
}
