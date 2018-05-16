using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Resources5
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.ToolBar toolBar1;
	  private System.Windows.Forms.ToolBarButton toolBarButton1;
	  private System.Windows.Forms.ToolBarButton toolBarButton2;
	  private Salford.VisualClearWin.Tree_View tree_View1;
	  private System.Windows.Forms.ImageList imageList2;
	  private System.Windows.Forms.ToolBarButton toolBarButton3;
	  private System.Windows.Forms.ToolBarButton toolBarButton4;
	  private System.Windows.Forms.ToolBarButton toolBarButton5_Down;
	  private System.Windows.Forms.ToolBarButton toolBarButton6_Up;
	  private System.Windows.Forms.ToolBarButton toolBarButton7_Left;
	  private System.Windows.Forms.ToolBarButton toolBarButton8_Right;
	  private System.Windows.Forms.ToolBarButton toolBarButton5;
	  private Salford.VisualClearWin.Text_Box text_Box1;
	  private System.Windows.Forms.ToolTip toolTip1;
	  private System.Windows.Forms.MainMenu mainMenu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem2_New;
	  private System.Windows.Forms.MenuItem menuItem3_Open;
	  private System.Windows.Forms.MenuItem menuItem4_Save;
	  private System.Windows.Forms.MenuItem menuItem5_SaveAs;
	  private System.Windows.Forms.MenuItem menuItem6_Exit;
	  private System.Windows.Forms.OpenFileDialog openFileDialog1;
	  private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown1;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown2;
	  private System.Windows.Forms.Label label1;
	  private System.Windows.Forms.Label label2;
	  private System.Windows.Forms.Label label3;
      private System.ComponentModel.IContainer components=null;

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
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton5_Down = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton6_Up = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton7_Left = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton8_Right = new System.Windows.Forms.ToolBarButton();
		  this.tree_View1 = new Salford.VisualClearWin.Tree_View();
		  this.imageList2 = new System.Windows.Forms.ImageList(this.components);
		  this.text_Box1 = new Salford.VisualClearWin.Text_Box();
		  this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem2_New = new System.Windows.Forms.MenuItem();
		  this.menuItem3_Open = new System.Windows.Forms.MenuItem();
		  this.menuItem4_Save = new System.Windows.Forms.MenuItem();
		  this.menuItem5_SaveAs = new System.Windows.Forms.MenuItem();
		  this.menuItem6_Exit = new System.Windows.Forms.MenuItem();
		  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		  this.decimal_UpDown1 = new Salford.VisualClearWin.Decimal_UpDown();
		  this.decimal_UpDown2 = new Salford.VisualClearWin.Decimal_UpDown();
		  this.label1 = new System.Windows.Forms.Label();
		  this.label2 = new System.Windows.Forms.Label();
		  this.label3 = new System.Windows.Forms.Label();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown1)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown2)).BeginInit();
		  this.SuspendLayout();
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.White;
		  // 
		  // toolBar1
		  // 
		  this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
		  this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarButton1,
																					this.toolBarButton5,
																					this.toolBarButton2,
																					this.toolBarButton3,
																					this.toolBarButton4,
																					this.toolBarButton5_Down,
																					this.toolBarButton6_Up,
																					this.toolBarButton7_Left,
																					this.toolBarButton8_Right});
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(288, 25);
		  this.toolBar1.TabIndex = 1;
		  // 
		  // toolBarButton1
		  // 
		  this.toolBarButton1.ImageIndex = 0;
		  this.toolBarButton1.ToolTipText = "Append a sibling node";
		  // 
		  // toolBarButton5
		  // 
		  this.toolBarButton5.ImageIndex = 7;
		  this.toolBarButton5.ToolTipText = "Insert a sibling node";
		  // 
		  // toolBarButton2
		  // 
		  this.toolBarButton2.ImageIndex = 1;
		  this.toolBarButton2.ToolTipText = "Add a child node";
		  // 
		  // toolBarButton3
		  // 
		  this.toolBarButton3.ImageIndex = 2;
		  this.toolBarButton3.ToolTipText = "Delete the selected node and its children";
		  // 
		  // toolBarButton4
		  // 
		  this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton5_Down
		  // 
		  this.toolBarButton5_Down.ImageIndex = 3;
		  this.toolBarButton5_Down.ToolTipText = "Move down";
		  // 
		  // toolBarButton6_Up
		  // 
		  this.toolBarButton6_Up.ImageIndex = 4;
		  this.toolBarButton6_Up.ToolTipText = "Move up";
		  // 
		  // toolBarButton7_Left
		  // 
		  this.toolBarButton7_Left.ImageIndex = 5;
		  this.toolBarButton7_Left.ToolTipText = "Move left";
		  // 
		  // toolBarButton8_Right
		  // 
		  this.toolBarButton8_Right.ImageIndex = 6;
		  this.toolBarButton8_Right.ToolTipText = "Move right";
		  // 
		  // tree_View1
		  // 
		  this.tree_View1.HideSelection = false;
		  this.tree_View1.ImageList = this.imageList2;
		  this.tree_View1.LabelEdit = true;
		  this.tree_View1.Location = new System.Drawing.Point(0, 80);
		  this.tree_View1.Name = "tree_View1";
		  this.tree_View1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.tree_View1.Size = new System.Drawing.Size(288, 176);
		  this.tree_View1.TabIndex = 0;
		  this.toolTip1.SetToolTip(this.tree_View1, "Edit the tree here...");
		  // 
		  // imageList2
		  // 
		  this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		  this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
		  this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // text_Box1
		  // 
		  this.text_Box1.Enabled = false;
		  this.text_Box1.HideSelection = false;
		  this.text_Box1.Location = new System.Drawing.Point(48, 56);
		  this.text_Box1.Name = "text_Box1";
		  this.text_Box1.Pivoting = Salford.VisualClearWin.Pivot.Horizontal;
		  this.text_Box1.Size = new System.Drawing.Size(234, 20);
		  this.text_Box1.TabIndex = 2;
		  this.text_Box1.Text = "";
		  this.toolTip1.SetToolTip(this.text_Box1, "Enter node data here...");
		  // 
		  // mainMenu1
		  // 
		  this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem1});
		  // 
		  // menuItem1
		  // 
		  this.menuItem1.Index = 0;
		  this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem2_New,
																				  this.menuItem3_Open,
																				  this.menuItem4_Save,
																				  this.menuItem5_SaveAs,
																				  this.menuItem6_Exit});
		  this.menuItem1.Text = "File";
		  // 
		  // menuItem2_New
		  // 
		  this.menuItem2_New.Index = 0;
		  this.menuItem2_New.Text = "New";
		  // 
		  // menuItem3_Open
		  // 
		  this.menuItem3_Open.Index = 1;
		  this.menuItem3_Open.Text = "Open";
		  // 
		  // menuItem4_Save
		  // 
		  this.menuItem4_Save.Index = 2;
		  this.menuItem4_Save.Text = "Save";
		  // 
		  // menuItem5_SaveAs
		  // 
		  this.menuItem5_SaveAs.Index = 3;
		  this.menuItem5_SaveAs.Text = "Save As";
		  // 
		  // menuItem6_Exit
		  // 
		  this.menuItem6_Exit.Index = 4;
		  this.menuItem6_Exit.Text = "Exit";
		  // 
		  // openFileDialog1
		  // 
		  this.openFileDialog1.DefaultExt = "tre";
		  this.openFileDialog1.Filter = "Tree files (*.tre)|*.tre|All files (*.*)|*.*";
		  // 
		  // saveFileDialog1
		  // 
		  this.saveFileDialog1.Filter = "Tree files (*.tre)|*.tre|All files (*.*)|*.*";
		  // 
		  // decimal_UpDown1
		  // 
		  this.decimal_UpDown1.Enabled = false;
		  this.decimal_UpDown1.Location = new System.Drawing.Point(56, 32);
		  this.decimal_UpDown1.Maximum = new System.Decimal(new int[] {
																		10,
																		0,
																		0,
																		0});
		  this.decimal_UpDown1.Minimum = new System.Decimal(new int[] {
																		1,
																		0,
																		0,
																		-2147483648});
		  this.decimal_UpDown1.Name = "decimal_UpDown1";
		  this.decimal_UpDown1.Size = new System.Drawing.Size(40, 20);
		  this.decimal_UpDown1.TabIndex = 3;
		  // 
		  // decimal_UpDown2
		  // 
		  this.decimal_UpDown2.Enabled = false;
		  this.decimal_UpDown2.Location = new System.Drawing.Point(208, 32);
		  this.decimal_UpDown2.Maximum = new System.Decimal(new int[] {
																		10,
																		0,
																		0,
																		0});
		  this.decimal_UpDown2.Minimum = new System.Decimal(new int[] {
																		1,
																		0,
																		0,
																		-2147483648});
		  this.decimal_UpDown2.Name = "decimal_UpDown2";
		  this.decimal_UpDown2.Size = new System.Drawing.Size(40, 20);
		  this.decimal_UpDown2.TabIndex = 4;
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(8, 35);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(39, 16);
		  this.label1.TabIndex = 5;
		  this.label1.Text = "Image:";
		  // 
		  // label2
		  // 
		  this.label2.Location = new System.Drawing.Point(112, 35);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(86, 16);
		  this.label2.TabIndex = 6;
		  this.label2.Text = "Selected Image:";
		  // 
		  // label3
		  // 
		  this.label3.Location = new System.Drawing.Point(8, 59);
		  this.label3.Name = "label3";
		  this.label3.Size = new System.Drawing.Size(32, 16);
		  this.label3.TabIndex = 7;
		  this.label3.Text = "Data:";
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(288, 257);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.label3,
																	  this.label2,
																	  this.label1,
																	  this.decimal_UpDown2,
																	  this.decimal_UpDown1,
																	  this.text_Box1,
																	  this.tree_View1,
																	  this.toolBar1});
		  this.Menu = this.mainMenu1;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "TreeNode Editor";
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown1)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown2)).EndInit();
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
