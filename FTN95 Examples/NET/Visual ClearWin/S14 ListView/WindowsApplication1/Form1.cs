using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Resources4
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
	  private Salford.VisualClearWin.List_View list_View1;
	  private System.Windows.Forms.ColumnHeader columnHeader1;
	  private System.Windows.Forms.ColumnHeader columnHeader2;
	  private System.Windows.Forms.ColumnHeader columnHeader3;
	  private System.Windows.Forms.ColumnHeader columnHeader4;
	  private Salford.VisualClearWin.Drawing_Panel drawing_Panel1;
	  private System.Windows.Forms.ContextMenu contextMenu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem2;
	  private System.Windows.Forms.MenuItem menuItem3;
	  private System.Windows.Forms.MenuItem menuItem4;
	  private System.Windows.Forms.MenuItem menuItem5_Details;
	  private System.Windows.Forms.MenuItem menuItem6_LargeIcon;
	  private System.Windows.Forms.MenuItem menuItem8_SmallIcon;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.ImageList imageList2;
	  private System.Windows.Forms.MenuItem menuItem7_List;
	  private System.Windows.Forms.MenuItem menuItem9;
	  private System.Windows.Forms.ColorDialog colorDialog1;
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
		  System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Red", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)))),
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "255"),
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "0"),
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "0")}, 0);
		  System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Green", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)))),
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "0"),
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "255"),
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "0")}, 0);
		  System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Blue", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)))),
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "0"),
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "0"),
																																							new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "255")}, 0);
		  System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
		  this.list_View1 = new Salford.VisualClearWin.List_View();
		  this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
		  this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
		  this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
		  this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
		  this.contextMenu1 = new System.Windows.Forms.ContextMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem2 = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.menuItem9 = new System.Windows.Forms.MenuItem();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.menuItem5_Details = new System.Windows.Forms.MenuItem();
		  this.menuItem6_LargeIcon = new System.Windows.Forms.MenuItem();
		  this.menuItem7_List = new System.Windows.Forms.MenuItem();
		  this.menuItem8_SmallIcon = new System.Windows.Forms.MenuItem();
		  this.imageList2 = new System.Windows.Forms.ImageList(this.components);
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.drawing_Panel1 = new Salford.VisualClearWin.Drawing_Panel();
		  this.colorDialog1 = new System.Windows.Forms.ColorDialog();
		  this.SuspendLayout();
		  // 
		  // list_View1
		  // 
		  this.list_View1.AllowColumnReorder = true;
		  this.list_View1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader1,
																					 this.columnHeader2,
																					 this.columnHeader3,
																					 this.columnHeader4});
		  this.list_View1.ContextMenu = this.contextMenu1;
		  this.list_View1.GridLines = true;
		  this.list_View1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		  this.list_View1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
																				   listViewItem1,
																				   listViewItem2,
																				   listViewItem3});
		  this.list_View1.LabelEdit = true;
		  this.list_View1.LargeImageList = this.imageList2;
		  this.list_View1.Location = new System.Drawing.Point(16, 16);
		  this.list_View1.MultiSelect = false;
		  this.list_View1.Name = "list_View1";
		  this.list_View1.Size = new System.Drawing.Size(232, 136);
		  this.list_View1.SmallImageList = this.imageList1;
		  this.list_View1.TabIndex = 0;
		  this.list_View1.View = System.Windows.Forms.View.Details;
		  // 
		  // columnHeader1
		  // 
		  this.columnHeader1.Text = "Colour";
		  // 
		  // columnHeader2
		  // 
		  this.columnHeader2.Text = "Red";
		  this.columnHeader2.Width = 56;
		  // 
		  // columnHeader3
		  // 
		  this.columnHeader3.Text = "Green";
		  this.columnHeader3.Width = 56;
		  // 
		  // columnHeader4
		  // 
		  this.columnHeader4.Text = "Blue";
		  this.columnHeader4.Width = 56;
		  // 
		  // contextMenu1
		  // 
		  this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem1,
																					 this.menuItem2,
																					 this.menuItem3,
																					 this.menuItem9,
																					 this.menuItem4,
																					 this.menuItem5_Details,
																					 this.menuItem6_LargeIcon,
																					 this.menuItem7_List,
																					 this.menuItem8_SmallIcon});
		  // 
		  // menuItem1
		  // 
		  this.menuItem1.Index = 0;
		  this.menuItem1.Text = "New";
		  // 
		  // menuItem2
		  // 
		  this.menuItem2.Index = 1;
		  this.menuItem2.Text = "Delete";
		  // 
		  // menuItem3
		  // 
		  this.menuItem3.Index = 2;
		  this.menuItem3.Text = "Edit";
		  // 
		  // menuItem9
		  // 
		  this.menuItem9.Index = 3;
		  this.menuItem9.Text = "Colours";
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 4;
		  this.menuItem4.Text = "-";
		  // 
		  // menuItem5_Details
		  // 
		  this.menuItem5_Details.Checked = true;
		  this.menuItem5_Details.Index = 5;
		  this.menuItem5_Details.Text = "Details";
		  // 
		  // menuItem6_LargeIcon
		  // 
		  this.menuItem6_LargeIcon.Index = 6;
		  this.menuItem6_LargeIcon.Text = "Large icon";
		  // 
		  // menuItem7_List
		  // 
		  this.menuItem7_List.Index = 7;
		  this.menuItem7_List.Text = "List";
		  // 
		  // menuItem8_SmallIcon
		  // 
		  this.menuItem8_SmallIcon.Index = 8;
		  this.menuItem8_SmallIcon.Text = "Small icon";
		  // 
		  // imageList2
		  // 
		  this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		  this.imageList2.ImageSize = new System.Drawing.Size(32, 32);
		  this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
		  this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // drawing_Panel1
		  // 
		  this.drawing_Panel1.BitmapSize = new System.Drawing.Size(0, 0);
		  this.drawing_Panel1.FillColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.LineColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.Location = new System.Drawing.Point(16, 160);
		  this.drawing_Panel1.Name = "drawing_Panel1";
		  this.drawing_Panel1.Size = new System.Drawing.Size(232, 8);
		  this.drawing_Panel1.StringColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.TabIndex = 1;
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(266, 192);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.drawing_Panel1,
																	  this.list_View1});
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "List View";
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
