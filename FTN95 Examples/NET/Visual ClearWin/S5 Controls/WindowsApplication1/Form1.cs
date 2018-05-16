using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Resources3
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private Salford.VisualClearWin.Tab_Control tab_Control1;
      private System.Windows.Forms.TabPage tabPage1;
      private Salford.VisualClearWin.Int32_Box int32_Box3;
      private Salford.VisualClearWin.Int32_Box int32_Box2;
      private Salford.VisualClearWin.Int32_Box int32_Box1;
      private Salford.VisualClearWin.Check_Box check_Box3;
      private Salford.VisualClearWin.Check_Box check_Box2;
      private Salford.VisualClearWin.Check_Box check_Box1;
      private System.Windows.Forms.TabPage tabPage2;
      private Salford.VisualClearWin.Radio_Button radio_Button1;
      private Salford.VisualClearWin.Int32_Box int32_Box4;
      private Salford.VisualClearWin.Int32_Box int32_Box5;
      private Salford.VisualClearWin.Radio_Button radio_Button2;
      private Salford.VisualClearWin.Int32_Box int32_Box6;
      private Salford.VisualClearWin.Radio_Button radio_Button3;
      private System.Windows.Forms.TabPage tabPage3;
      private Salford.VisualClearWin.List_Box list_Box1;
      private Salford.VisualClearWin.Int32_Box int32_Box7;
      private System.Windows.Forms.TabPage tabPage4;
      private Salford.VisualClearWin.Combo_Box combo_Box1;
      private Salford.VisualClearWin.Int32_Box int32_Box8;
      private Salford.VisualClearWin.Text_Box text_Box1;
      private System.Windows.Forms.TabPage tabPage5;
      private Salford.VisualClearWin.Track_Bar track_Bar1;
      private Salford.VisualClearWin.Int32_Box int32_Box9;
      private System.Windows.Forms.TabPage tabPage6;
      private System.Windows.Forms.ProgressBar progressBar1;
      private System.Windows.Forms.Timer timer1;
      private Salford.VisualClearWin.Int32_Box int32_Box10;
      private System.Windows.Forms.TabPage tabPage7;
      private System.Windows.Forms.TabPage tabPage8;
      private Salford.VisualClearWin.List_View list_View1;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private Salford.VisualClearWin.Int32_Box int32_Box11;
      private Salford.VisualClearWin.Tree_View tree_View1;
      private Salford.VisualClearWin.Int32_Box int32_Box12;
      private Salford.VisualClearWin.Group_Box group_Box1;
      private System.ComponentModel.IContainer components = null;

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
		  System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
																												 "Item 1",
																												 "Data 1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))));
		  System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
																												 "Item 2",
																												 "Data 2"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))));
		  System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
																												 "Item 3",
																												 "Data 3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))));
		  this.tab_Control1 = new Salford.VisualClearWin.Tab_Control();
		  this.tabPage1 = new System.Windows.Forms.TabPage();
		  this.group_Box1 = new Salford.VisualClearWin.Group_Box();
		  this.check_Box1 = new Salford.VisualClearWin.Check_Box();
		  this.int32_Box2 = new Salford.VisualClearWin.Int32_Box();
		  this.check_Box2 = new Salford.VisualClearWin.Check_Box();
		  this.int32_Box1 = new Salford.VisualClearWin.Int32_Box();
		  this.int32_Box3 = new Salford.VisualClearWin.Int32_Box();
		  this.check_Box3 = new Salford.VisualClearWin.Check_Box();
		  this.tabPage4 = new System.Windows.Forms.TabPage();
		  this.text_Box1 = new Salford.VisualClearWin.Text_Box();
		  this.int32_Box8 = new Salford.VisualClearWin.Int32_Box();
		  this.combo_Box1 = new Salford.VisualClearWin.Combo_Box();
		  this.tabPage7 = new System.Windows.Forms.TabPage();
		  this.int32_Box11 = new Salford.VisualClearWin.Int32_Box();
		  this.list_View1 = new Salford.VisualClearWin.List_View();
		  this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
		  this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
		  this.tabPage3 = new System.Windows.Forms.TabPage();
		  this.int32_Box7 = new Salford.VisualClearWin.Int32_Box();
		  this.list_Box1 = new Salford.VisualClearWin.List_Box();
		  this.tabPage8 = new System.Windows.Forms.TabPage();
		  this.int32_Box12 = new Salford.VisualClearWin.Int32_Box();
		  this.tree_View1 = new Salford.VisualClearWin.Tree_View();
		  this.tabPage5 = new System.Windows.Forms.TabPage();
		  this.int32_Box9 = new Salford.VisualClearWin.Int32_Box();
		  this.track_Bar1 = new Salford.VisualClearWin.Track_Bar();
		  this.tabPage6 = new System.Windows.Forms.TabPage();
		  this.int32_Box10 = new Salford.VisualClearWin.Int32_Box();
		  this.progressBar1 = new System.Windows.Forms.ProgressBar();
		  this.tabPage2 = new System.Windows.Forms.TabPage();
		  this.int32_Box6 = new Salford.VisualClearWin.Int32_Box();
		  this.radio_Button3 = new Salford.VisualClearWin.Radio_Button();
		  this.int32_Box5 = new Salford.VisualClearWin.Int32_Box();
		  this.radio_Button2 = new Salford.VisualClearWin.Radio_Button();
		  this.int32_Box4 = new Salford.VisualClearWin.Int32_Box();
		  this.radio_Button1 = new Salford.VisualClearWin.Radio_Button();
		  this.timer1 = new System.Windows.Forms.Timer(this.components);
		  this.tab_Control1.SuspendLayout();
		  this.tabPage1.SuspendLayout();
		  this.group_Box1.SuspendLayout();
		  this.tabPage4.SuspendLayout();
		  this.tabPage7.SuspendLayout();
		  this.tabPage3.SuspendLayout();
		  this.tabPage8.SuspendLayout();
		  this.tabPage5.SuspendLayout();
		  ((System.ComponentModel.ISupportInitialize)(this.track_Bar1)).BeginInit();
		  this.tabPage6.SuspendLayout();
		  this.tabPage2.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // tab_Control1
		  // 
		  this.tab_Control1.Controls.Add(this.tabPage1);
		  this.tab_Control1.Controls.Add(this.tabPage4);
		  this.tab_Control1.Controls.Add(this.tabPage7);
		  this.tab_Control1.Controls.Add(this.tabPage3);
		  this.tab_Control1.Controls.Add(this.tabPage8);
		  this.tab_Control1.Controls.Add(this.tabPage5);
		  this.tab_Control1.Controls.Add(this.tabPage6);
		  this.tab_Control1.Controls.Add(this.tabPage2);
		  this.tab_Control1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.tab_Control1.HotTrack = true;
		  this.tab_Control1.ItemSize = new System.Drawing.Size(74, 18);
		  this.tab_Control1.Location = new System.Drawing.Point(8, 8);
		  this.tab_Control1.Name = "tab_Control1";
		  this.tab_Control1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.tab_Control1.SelectedIndex = 0;
		  this.tab_Control1.Size = new System.Drawing.Size(504, 152);
		  this.tab_Control1.TabIndex = 0;
		  // 
		  // tabPage1
		  // 
		  this.tabPage1.Controls.Add(this.group_Box1);
		  this.tabPage1.Location = new System.Drawing.Point(4, 22);
		  this.tabPage1.Name = "tabPage1";
		  this.tabPage1.Size = new System.Drawing.Size(496, 126);
		  this.tabPage1.TabIndex = 0;
		  this.tabPage1.Text = "Check boxes";
		  // 
		  // group_Box1
		  // 
		  this.group_Box1.Controls.Add(this.check_Box1);
		  this.group_Box1.Controls.Add(this.int32_Box2);
		  this.group_Box1.Controls.Add(this.check_Box2);
		  this.group_Box1.Controls.Add(this.int32_Box1);
		  this.group_Box1.Controls.Add(this.int32_Box3);
		  this.group_Box1.Controls.Add(this.check_Box3);
		  this.group_Box1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.group_Box1.Location = new System.Drawing.Point(8, 8);
		  this.group_Box1.Name = "group_Box1";
		  this.group_Box1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.group_Box1.Size = new System.Drawing.Size(480, 112);
		  this.group_Box1.TabIndex = 6;
		  this.group_Box1.TabStop = false;
		  this.group_Box1.Text = "Group";
		  // 
		  // check_Box1
		  // 
		  this.check_Box1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.check_Box1.Location = new System.Drawing.Point(56, 24);
		  this.check_Box1.Name = "check_Box1";
		  this.check_Box1.Size = new System.Drawing.Size(72, 16);
		  this.check_Box1.TabIndex = 0;
		  this.check_Box1.Text = "Check 1";
		  // 
		  // int32_Box2
		  // 
		  this.int32_Box2.Location = new System.Drawing.Point(152, 52);
		  this.int32_Box2.Maximum = 2147483647;
		  this.int32_Box2.Minimum = -2147483648;
		  this.int32_Box2.Name = "int32_Box2";
		  this.int32_Box2.Size = new System.Drawing.Size(32, 20);
		  this.int32_Box2.TabIndex = 4;
		  this.int32_Box2.Text = "";
		  // 
		  // check_Box2
		  // 
		  this.check_Box2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.check_Box2.Location = new System.Drawing.Point(56, 52);
		  this.check_Box2.Name = "check_Box2";
		  this.check_Box2.Size = new System.Drawing.Size(72, 13);
		  this.check_Box2.TabIndex = 1;
		  this.check_Box2.Text = "Check 2";
		  // 
		  // int32_Box1
		  // 
		  this.int32_Box1.Location = new System.Drawing.Point(152, 24);
		  this.int32_Box1.Maximum = 2147483647;
		  this.int32_Box1.Minimum = -2147483648;
		  this.int32_Box1.Name = "int32_Box1";
		  this.int32_Box1.Size = new System.Drawing.Size(32, 20);
		  this.int32_Box1.TabIndex = 3;
		  this.int32_Box1.Text = "";
		  // 
		  // int32_Box3
		  // 
		  this.int32_Box3.Location = new System.Drawing.Point(152, 80);
		  this.int32_Box3.Maximum = 2147483647;
		  this.int32_Box3.Minimum = -2147483648;
		  this.int32_Box3.Name = "int32_Box3";
		  this.int32_Box3.Size = new System.Drawing.Size(32, 20);
		  this.int32_Box3.TabIndex = 5;
		  this.int32_Box3.Text = "";
		  // 
		  // check_Box3
		  // 
		  this.check_Box3.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.check_Box3.Location = new System.Drawing.Point(56, 80);
		  this.check_Box3.Name = "check_Box3";
		  this.check_Box3.Size = new System.Drawing.Size(72, 16);
		  this.check_Box3.TabIndex = 2;
		  this.check_Box3.Text = "Check 3";
		  // 
		  // tabPage4
		  // 
		  this.tabPage4.Controls.Add(this.text_Box1);
		  this.tabPage4.Controls.Add(this.int32_Box8);
		  this.tabPage4.Controls.Add(this.combo_Box1);
		  this.tabPage4.Location = new System.Drawing.Point(4, 22);
		  this.tabPage4.Name = "tabPage4";
		  this.tabPage4.Size = new System.Drawing.Size(496, 126);
		  this.tabPage4.TabIndex = 3;
		  this.tabPage4.Text = "Combo Box";
		  // 
		  // text_Box1
		  // 
		  this.text_Box1.Location = new System.Drawing.Point(64, 16);
		  this.text_Box1.Name = "text_Box1";
		  this.text_Box1.Size = new System.Drawing.Size(184, 20);
		  this.text_Box1.TabIndex = 2;
		  this.text_Box1.Text = "";
		  // 
		  // int32_Box8
		  // 
		  this.int32_Box8.Location = new System.Drawing.Point(8, 16);
		  this.int32_Box8.Maximum = 2147483647;
		  this.int32_Box8.Minimum = -2147483648;
		  this.int32_Box8.Name = "int32_Box8";
		  this.int32_Box8.Size = new System.Drawing.Size(24, 20);
		  this.int32_Box8.TabIndex = 1;
		  this.int32_Box8.Text = "";
		  // 
		  // combo_Box1
		  // 
		  this.combo_Box1.Items.AddRange(new object[] {
														"Item 1",
														"Item 2",
														"Item 3"});
		  this.combo_Box1.Location = new System.Drawing.Point(8, 48);
		  this.combo_Box1.Name = "combo_Box1";
		  this.combo_Box1.Pivoting = Salford.VisualClearWin.Pivot.Horizontal;
		  this.combo_Box1.Size = new System.Drawing.Size(480, 21);
		  this.combo_Box1.TabIndex = 0;
		  // 
		  // tabPage7
		  // 
		  this.tabPage7.Controls.Add(this.int32_Box11);
		  this.tabPage7.Controls.Add(this.list_View1);
		  this.tabPage7.Location = new System.Drawing.Point(4, 22);
		  this.tabPage7.Name = "tabPage7";
		  this.tabPage7.Size = new System.Drawing.Size(496, 126);
		  this.tabPage7.TabIndex = 6;
		  this.tabPage7.Text = "List view";
		  // 
		  // int32_Box11
		  // 
		  this.int32_Box11.Location = new System.Drawing.Point(8, 8);
		  this.int32_Box11.Maximum = 2147483647;
		  this.int32_Box11.Minimum = -2147483648;
		  this.int32_Box11.Name = "int32_Box11";
		  this.int32_Box11.Size = new System.Drawing.Size(24, 20);
		  this.int32_Box11.TabIndex = 1;
		  this.int32_Box11.Text = "";
		  // 
		  // list_View1
		  // 
		  this.list_View1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader1,
																					 this.columnHeader2});
		  this.list_View1.FullRowSelect = true;
		  this.list_View1.GridLines = true;
		  this.list_View1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
																				   listViewItem1,
																				   listViewItem2,
																				   listViewItem3});
		  this.list_View1.Location = new System.Drawing.Point(8, 40);
		  this.list_View1.MultiSelect = false;
		  this.list_View1.Name = "list_View1";
		  this.list_View1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.list_View1.Size = new System.Drawing.Size(480, 72);
		  this.list_View1.TabIndex = 0;
		  this.list_View1.View = System.Windows.Forms.View.Details;
		  // 
		  // columnHeader1
		  // 
		  this.columnHeader1.Text = "Column 1";
		  // 
		  // columnHeader2
		  // 
		  this.columnHeader2.Text = "Column 2";
		  // 
		  // tabPage3
		  // 
		  this.tabPage3.Controls.Add(this.int32_Box7);
		  this.tabPage3.Controls.Add(this.list_Box1);
		  this.tabPage3.Location = new System.Drawing.Point(4, 22);
		  this.tabPage3.Name = "tabPage3";
		  this.tabPage3.Size = new System.Drawing.Size(496, 126);
		  this.tabPage3.TabIndex = 2;
		  this.tabPage3.Text = "List box";
		  // 
		  // int32_Box7
		  // 
		  this.int32_Box7.Location = new System.Drawing.Point(8, 8);
		  this.int32_Box7.Maximum = 2147483647;
		  this.int32_Box7.Minimum = -2147483648;
		  this.int32_Box7.Name = "int32_Box7";
		  this.int32_Box7.Size = new System.Drawing.Size(32, 20);
		  this.int32_Box7.TabIndex = 1;
		  this.int32_Box7.Text = "";
		  // 
		  // list_Box1
		  // 
		  this.list_Box1.Items.AddRange(new object[] {
													   "Item 1",
													   "Item 2",
													   "Item 3"});
		  this.list_Box1.Location = new System.Drawing.Point(8, 40);
		  this.list_Box1.Name = "list_Box1";
		  this.list_Box1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.list_Box1.Size = new System.Drawing.Size(480, 69);
		  this.list_Box1.TabIndex = 0;
		  this.list_Box1.Val = -1;
		  // 
		  // tabPage8
		  // 
		  this.tabPage8.Controls.Add(this.int32_Box12);
		  this.tabPage8.Controls.Add(this.tree_View1);
		  this.tabPage8.Location = new System.Drawing.Point(4, 22);
		  this.tabPage8.Name = "tabPage8";
		  this.tabPage8.Size = new System.Drawing.Size(496, 126);
		  this.tabPage8.TabIndex = 7;
		  this.tabPage8.Text = "Tree view";
		  // 
		  // int32_Box12
		  // 
		  this.int32_Box12.Location = new System.Drawing.Point(8, 8);
		  this.int32_Box12.Maximum = 2147483647;
		  this.int32_Box12.Minimum = -2147483648;
		  this.int32_Box12.Name = "int32_Box12";
		  this.int32_Box12.Size = new System.Drawing.Size(32, 20);
		  this.int32_Box12.TabIndex = 1;
		  this.int32_Box12.Text = "";
		  // 
		  // tree_View1
		  // 
		  this.tree_View1.HideSelection = false;
		  this.tree_View1.ImageIndex = -1;
		  this.tree_View1.Location = new System.Drawing.Point(8, 40);
		  this.tree_View1.Name = "tree_View1";
		  this.tree_View1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																			   new System.Windows.Forms.TreeNode("Chapter 1", new System.Windows.Forms.TreeNode[] {
																																									new System.Windows.Forms.TreeNode("Section 1.1"),
																																									new System.Windows.Forms.TreeNode("Section 1.2")}),
																			   new System.Windows.Forms.TreeNode("Chapter 2", new System.Windows.Forms.TreeNode[] {
																																									new System.Windows.Forms.TreeNode("Section 2.1"),
																																									new System.Windows.Forms.TreeNode("Section 2.2")})});
		  this.tree_View1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.tree_View1.SelectedImageIndex = -1;
		  this.tree_View1.Size = new System.Drawing.Size(480, 80);
		  this.tree_View1.TabIndex = 0;
		  // 
		  // tabPage5
		  // 
		  this.tabPage5.Controls.Add(this.int32_Box9);
		  this.tabPage5.Controls.Add(this.track_Bar1);
		  this.tabPage5.Location = new System.Drawing.Point(4, 22);
		  this.tabPage5.Name = "tabPage5";
		  this.tabPage5.Size = new System.Drawing.Size(496, 126);
		  this.tabPage5.TabIndex = 4;
		  this.tabPage5.Text = "Track bar";
		  // 
		  // int32_Box9
		  // 
		  this.int32_Box9.Location = new System.Drawing.Point(104, 88);
		  this.int32_Box9.Maximum = 2147483647;
		  this.int32_Box9.Minimum = -2147483648;
		  this.int32_Box9.Name = "int32_Box9";
		  this.int32_Box9.Size = new System.Drawing.Size(48, 20);
		  this.int32_Box9.TabIndex = 1;
		  this.int32_Box9.Text = "";
		  // 
		  // track_Bar1
		  // 
		  this.track_Bar1.Location = new System.Drawing.Point(48, 24);
		  this.track_Bar1.Name = "track_Bar1";
		  this.track_Bar1.Size = new System.Drawing.Size(160, 45);
		  this.track_Bar1.TabIndex = 0;
		  // 
		  // tabPage6
		  // 
		  this.tabPage6.Controls.Add(this.int32_Box10);
		  this.tabPage6.Controls.Add(this.progressBar1);
		  this.tabPage6.Location = new System.Drawing.Point(4, 22);
		  this.tabPage6.Name = "tabPage6";
		  this.tabPage6.Size = new System.Drawing.Size(496, 126);
		  this.tabPage6.TabIndex = 5;
		  this.tabPage6.Text = "Progress";
		  // 
		  // int32_Box10
		  // 
		  this.int32_Box10.Location = new System.Drawing.Point(224, 80);
		  this.int32_Box10.Maximum = 2147483647;
		  this.int32_Box10.Minimum = -2147483648;
		  this.int32_Box10.Name = "int32_Box10";
		  this.int32_Box10.ReadOnly = true;
		  this.int32_Box10.Size = new System.Drawing.Size(24, 20);
		  this.int32_Box10.TabIndex = 1;
		  this.int32_Box10.Text = "0";
		  // 
		  // progressBar1
		  // 
		  this.progressBar1.Location = new System.Drawing.Point(16, 40);
		  this.progressBar1.Maximum = 464;
		  this.progressBar1.Name = "progressBar1";
		  this.progressBar1.Size = new System.Drawing.Size(464, 24);
		  this.progressBar1.Step = 1;
		  this.progressBar1.TabIndex = 0;
		  // 
		  // tabPage2
		  // 
		  this.tabPage2.Controls.Add(this.int32_Box6);
		  this.tabPage2.Controls.Add(this.radio_Button3);
		  this.tabPage2.Controls.Add(this.int32_Box5);
		  this.tabPage2.Controls.Add(this.radio_Button2);
		  this.tabPage2.Controls.Add(this.int32_Box4);
		  this.tabPage2.Controls.Add(this.radio_Button1);
		  this.tabPage2.Location = new System.Drawing.Point(4, 22);
		  this.tabPage2.Name = "tabPage2";
		  this.tabPage2.Size = new System.Drawing.Size(496, 126);
		  this.tabPage2.TabIndex = 1;
		  this.tabPage2.Text = "Radio buttons";
		  // 
		  // int32_Box6
		  // 
		  this.int32_Box6.Location = new System.Drawing.Point(160, 72);
		  this.int32_Box6.Maximum = 2147483647;
		  this.int32_Box6.Minimum = -2147483648;
		  this.int32_Box6.Name = "int32_Box6";
		  this.int32_Box6.Size = new System.Drawing.Size(24, 20);
		  this.int32_Box6.TabIndex = 5;
		  this.int32_Box6.Text = "";
		  // 
		  // radio_Button3
		  // 
		  this.radio_Button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.radio_Button3.Location = new System.Drawing.Point(72, 72);
		  this.radio_Button3.Name = "radio_Button3";
		  this.radio_Button3.Size = new System.Drawing.Size(64, 16);
		  this.radio_Button3.TabIndex = 4;
		  this.radio_Button3.Text = "Radio 3";
		  // 
		  // int32_Box5
		  // 
		  this.int32_Box5.Location = new System.Drawing.Point(160, 48);
		  this.int32_Box5.Maximum = 2147483647;
		  this.int32_Box5.Minimum = -2147483648;
		  this.int32_Box5.Name = "int32_Box5";
		  this.int32_Box5.Size = new System.Drawing.Size(24, 20);
		  this.int32_Box5.TabIndex = 3;
		  this.int32_Box5.Text = "";
		  // 
		  // radio_Button2
		  // 
		  this.radio_Button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.radio_Button2.Location = new System.Drawing.Point(72, 48);
		  this.radio_Button2.Name = "radio_Button2";
		  this.radio_Button2.Size = new System.Drawing.Size(64, 16);
		  this.radio_Button2.TabIndex = 2;
		  this.radio_Button2.Text = "Radio 2";
		  // 
		  // int32_Box4
		  // 
		  this.int32_Box4.Location = new System.Drawing.Point(160, 24);
		  this.int32_Box4.Maximum = 2147483647;
		  this.int32_Box4.Minimum = -2147483648;
		  this.int32_Box4.Name = "int32_Box4";
		  this.int32_Box4.Size = new System.Drawing.Size(24, 20);
		  this.int32_Box4.TabIndex = 1;
		  this.int32_Box4.Text = "0";
		  // 
		  // radio_Button1
		  // 
		  this.radio_Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.radio_Button1.Location = new System.Drawing.Point(72, 24);
		  this.radio_Button1.Name = "radio_Button1";
		  this.radio_Button1.Size = new System.Drawing.Size(64, 16);
		  this.radio_Button1.TabIndex = 0;
		  this.radio_Button1.Text = "Radio 1";
		  // 
		  // timer1
		  // 
		  this.timer1.Enabled = true;
		  this.timer1.Interval = 1000;
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(528, 174);
		  this.Controls.Add(this.tab_Control1);
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Controls";
		  this.tab_Control1.ResumeLayout(false);
		  this.tabPage1.ResumeLayout(false);
		  this.group_Box1.ResumeLayout(false);
		  this.tabPage4.ResumeLayout(false);
		  this.tabPage7.ResumeLayout(false);
		  this.tabPage3.ResumeLayout(false);
		  this.tabPage8.ResumeLayout(false);
		  this.tabPage5.ResumeLayout(false);
		  ((System.ComponentModel.ISupportInitialize)(this.track_Bar1)).EndInit();
		  this.tabPage6.ResumeLayout(false);
		  this.tabPage2.ResumeLayout(false);
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
