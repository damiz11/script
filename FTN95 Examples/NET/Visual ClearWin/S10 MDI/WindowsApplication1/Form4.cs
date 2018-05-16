using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Resources
{
	/// <summary>
	/// Summary description for Form4.
	/// </summary>
	public class Form4 : System.Windows.Forms.Form
	{
	  private System.Windows.Forms.PrintDialog printDialog1;
	  private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	  private System.Windows.Forms.MainMenu mainMenu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem2;
	  private System.Windows.Forms.MenuItem menuItem17;
	  private System.Windows.Forms.MenuItem menuItem11;
	  private System.Windows.Forms.MenuItem menuItem6;
	  private System.Windows.Forms.MenuItem menuItem15;
	  private System.Drawing.Printing.PrintDocument printDocument1;
	  private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
	  private System.Windows.Forms.MenuItem menuItem30;
	  private System.Windows.Forms.MenuItem menuItem31;
	  private Salford.VisualClearWin.Drawing_Panel drawing_Panel1;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.ToolBar toolBar1;
	  private System.Windows.Forms.ToolBarButton toolBarButton1;
	  private System.Windows.Forms.ContextMenu contextMenu1;
	  private System.Windows.Forms.MenuItem menuItem4;
	  private System.Windows.Forms.MenuItem menuItem3;
	  private System.Windows.Forms.MenuItem menuItem13_Open;
	  private System.Windows.Forms.MenuItem menuItem8_Close;
	  private System.Windows.Forms.MenuItem menuItem5_PrintPreview;
	  private System.Windows.Forms.MenuItem menuItem5_Print;
	  private System.Windows.Forms.MenuItem menuItem16_Exit;
	  private System.Windows.Forms.MenuItem menuItem3_Cascade;
	  private System.Windows.Forms.MenuItem menuItem4_TileHorizontal;
	  private System.Windows.Forms.MenuItem menuItem5_TileVertical;
	  private System.Windows.Forms.ToolBarButton toolBarButton2_Open;
	  private System.Windows.Forms.MenuItem menuItem14_RecentFiles4;
	  private System.ComponentModel.IContainer components;

		public Form4()
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
				if(components != null)
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
		  System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form4));
		  this.printDialog1 = new System.Windows.Forms.PrintDialog();
		  this.printDocument1 = new System.Drawing.Printing.PrintDocument();
		  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem6 = new System.Windows.Forms.MenuItem();
		  this.menuItem30 = new System.Windows.Forms.MenuItem();
		  this.menuItem31 = new System.Windows.Forms.MenuItem();
		  this.menuItem13_Open = new System.Windows.Forms.MenuItem();
		  this.menuItem8_Close = new System.Windows.Forms.MenuItem();
		  this.menuItem11 = new System.Windows.Forms.MenuItem();
		  this.menuItem5_PrintPreview = new System.Windows.Forms.MenuItem();
		  this.menuItem5_Print = new System.Windows.Forms.MenuItem();
		  this.menuItem14_RecentFiles4 = new System.Windows.Forms.MenuItem();
		  this.menuItem15 = new System.Windows.Forms.MenuItem();
		  this.menuItem16_Exit = new System.Windows.Forms.MenuItem();
		  this.menuItem2 = new System.Windows.Forms.MenuItem();
		  this.menuItem3_Cascade = new System.Windows.Forms.MenuItem();
		  this.menuItem4_TileHorizontal = new System.Windows.Forms.MenuItem();
		  this.menuItem5_TileVertical = new System.Windows.Forms.MenuItem();
		  this.menuItem17 = new System.Windows.Forms.MenuItem();
		  this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
		  this.drawing_Panel1 = new Salford.VisualClearWin.Drawing_Panel();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
		  this.contextMenu1 = new System.Windows.Forms.ContextMenu();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.toolBarButton2_Open = new System.Windows.Forms.ToolBarButton();
		  this.SuspendLayout();
		  // 
		  // printDialog1
		  // 
		  this.printDialog1.AllowSomePages = true;
		  this.printDialog1.Document = this.printDocument1;
		  // 
		  // saveFileDialog1
		  // 
		  this.saveFileDialog1.Filter = "Fortran files (*.f95)|*.f95|All files (*.*)|*.*";
		  // 
		  // mainMenu1
		  // 
		  this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem1,
																				  this.menuItem2});
		  // 
		  // menuItem1
		  // 
		  this.menuItem1.Index = 0;
		  this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem6,
																				  this.menuItem13_Open,
																				  this.menuItem8_Close,
																				  this.menuItem11,
																				  this.menuItem5_PrintPreview,
																				  this.menuItem5_Print,
																				  this.menuItem14_RecentFiles4,
																				  this.menuItem15,
																				  this.menuItem16_Exit});
		  this.menuItem1.MergeType = System.Windows.Forms.MenuMerge.Replace;
		  this.menuItem1.Text = "&File";
		  // 
		  // menuItem6
		  // 
		  this.menuItem6.Index = 0;
		  this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem30,
																				  this.menuItem31});
		  this.menuItem6.Text = "New";
		  // 
		  // menuItem30
		  // 
		  this.menuItem30.Index = 0;
		  this.menuItem30.Text = "Text file";
		  // 
		  // menuItem31
		  // 
		  this.menuItem31.Index = 1;
		  this.menuItem31.Text = "RichText file";
		  // 
		  // menuItem13_Open
		  // 
		  this.menuItem13_Open.Index = 1;
		  this.menuItem13_Open.Text = "&Open";
		  // 
		  // menuItem8_Close
		  // 
		  this.menuItem8_Close.Index = 2;
		  this.menuItem8_Close.Text = "Close";
		  // 
		  // menuItem11
		  // 
		  this.menuItem11.Index = 3;
		  this.menuItem11.Text = "-";
		  // 
		  // menuItem5_PrintPreview
		  // 
		  this.menuItem5_PrintPreview.Index = 4;
		  this.menuItem5_PrintPreview.Text = "Print Preview";
		  // 
		  // menuItem5_Print
		  // 
		  this.menuItem5_Print.Index = 5;
		  this.menuItem5_Print.Text = "Print...";
		  // 
		  // menuItem14_RecentFiles4
		  // 
		  this.menuItem14_RecentFiles4.Index = 6;
		  this.menuItem14_RecentFiles4.Text = "Recent files";
		  // 
		  // menuItem15
		  // 
		  this.menuItem15.Index = 7;
		  this.menuItem15.Text = "-";
		  // 
		  // menuItem16_Exit
		  // 
		  this.menuItem16_Exit.Index = 8;
		  this.menuItem16_Exit.Text = "Exit";
		  // 
		  // menuItem2
		  // 
		  this.menuItem2.Index = 1;
		  this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem3_Cascade,
																				  this.menuItem4_TileHorizontal,
																				  this.menuItem5_TileVertical,
																				  this.menuItem17});
		  this.menuItem2.Text = "&Window";
		  // 
		  // menuItem3_Cascade
		  // 
		  this.menuItem3_Cascade.Index = 0;
		  this.menuItem3_Cascade.Text = "Cascade";
		  // 
		  // menuItem4_TileHorizontal
		  // 
		  this.menuItem4_TileHorizontal.Index = 1;
		  this.menuItem4_TileHorizontal.Text = "Tile Horizontally";
		  // 
		  // menuItem5_TileVertical
		  // 
		  this.menuItem5_TileVertical.Index = 2;
		  this.menuItem5_TileVertical.Text = "Tile Vertically";
		  // 
		  // menuItem17
		  // 
		  this.menuItem17.Index = 3;
		  this.menuItem17.MdiList = true;
		  this.menuItem17.Text = "Windows";
		  // 
		  // printPreviewDialog1
		  // 
		  this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
		  this.printPreviewDialog1.Document = this.printDocument1;
		  this.printPreviewDialog1.Enabled = true;
		  this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
		  this.printPreviewDialog1.Location = new System.Drawing.Point(126, 17);
		  this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.Name = "printPreviewDialog1";
		  this.printPreviewDialog1.Opacity = 1;
		  this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
		  this.printPreviewDialog1.Visible = false;
		  // 
		  // drawing_Panel1
		  // 
		  this.drawing_Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		  this.drawing_Panel1.FillColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.LineColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.Name = "drawing_Panel1";
		  this.drawing_Panel1.Size = new System.Drawing.Size(208, 166);
		  this.drawing_Panel1.StringColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.TabIndex = 0;
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // toolBar1
		  // 
		  this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
		  this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarButton1,
																					this.toolBarButton2_Open});
		  this.toolBar1.ButtonSize = new System.Drawing.Size(16, 16);
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(208, 25);
		  this.toolBar1.TabIndex = 4;
		  // 
		  // toolBarButton1
		  // 
		  this.toolBarButton1.DropDownMenu = this.contextMenu1;
		  this.toolBarButton1.ImageIndex = 0;
		  this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
		  // 
		  // contextMenu1
		  // 
		  this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem4,
																					 this.menuItem3});
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 0;
		  this.menuItem4.Text = "Text file";
		  // 
		  // menuItem3
		  // 
		  this.menuItem3.Index = 1;
		  this.menuItem3.Text = "RichText file";
		  // 
		  // toolBarButton2_Open
		  // 
		  this.toolBarButton2_Open.ImageIndex = 1;
		  // 
		  // Form4
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(208, 166);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.toolBar1,
																	  this.drawing_Panel1});
		  this.Menu = this.mainMenu1;
		  this.Name = "Form4";
		  this.Text = "Form4";
		  this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		  this.ResumeLayout(false);

		}
		#endregion

	}
}
