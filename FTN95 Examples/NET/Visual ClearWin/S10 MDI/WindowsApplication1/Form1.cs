using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Resources
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
	  private System.Windows.Forms.MainMenu mainMenu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem3;
	  private System.Windows.Forms.StatusBar statusBar1;
	  private System.Windows.Forms.OpenFileDialog openFileDialog1;
	  private System.Windows.Forms.MenuItem menuItem8;
	  private System.Windows.Forms.MenuItem menuItem15;
	  private System.Windows.Forms.MenuItem menuItem2;
	  private System.Windows.Forms.MenuItem menuItem5;
	  private System.Windows.Forms.ToolBar toolBar1;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.ToolBarButton toolBarButton1;
	  private System.Windows.Forms.ContextMenu contextMenu1;
	  private System.Windows.Forms.MenuItem menuItem4;
	  private System.Windows.Forms.MenuItem menuItem6;
	  private System.Windows.Forms.MenuItem menuItem4_Open;
	  private System.Windows.Forms.MenuItem menuItem9_Exit;
	  private System.Windows.Forms.ToolBarButton toolBarButton2_Open;
	  private System.Windows.Forms.MenuItem menuItem14_RecentFiles4;
      private System.ComponentModel.IContainer components;

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
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.menuItem2 = new System.Windows.Forms.MenuItem();
		  this.menuItem5 = new System.Windows.Forms.MenuItem();
		  this.menuItem4_Open = new System.Windows.Forms.MenuItem();
		  this.menuItem15 = new System.Windows.Forms.MenuItem();
		  this.menuItem14_RecentFiles4 = new System.Windows.Forms.MenuItem();
		  this.menuItem8 = new System.Windows.Forms.MenuItem();
		  this.menuItem9_Exit = new System.Windows.Forms.MenuItem();
		  this.statusBar1 = new System.Windows.Forms.StatusBar();
		  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
		  this.contextMenu1 = new System.Windows.Forms.ContextMenu();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.menuItem6 = new System.Windows.Forms.MenuItem();
		  this.toolBarButton2_Open = new System.Windows.Forms.ToolBarButton();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.SuspendLayout();
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
																				  this.menuItem3,
																				  this.menuItem4_Open,
																				  this.menuItem15,
																				  this.menuItem14_RecentFiles4,
																				  this.menuItem8,
																				  this.menuItem9_Exit});
		  this.menuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
		  this.menuItem1.Text = "&File";
		  // 
		  // menuItem3
		  // 
		  this.menuItem3.Index = 0;
		  this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem2,
																				  this.menuItem5});
		  this.menuItem3.Text = "New";
		  // 
		  // menuItem2
		  // 
		  this.menuItem2.Index = 0;
		  this.menuItem2.Text = "Text file";
		  // 
		  // menuItem5
		  // 
		  this.menuItem5.Index = 1;
		  this.menuItem5.Text = "RichText file";
		  // 
		  // menuItem4_Open
		  // 
		  this.menuItem4_Open.Index = 1;
		  this.menuItem4_Open.Text = "&Open|Opens a file";
		  // 
		  // menuItem15
		  // 
		  this.menuItem15.Index = 2;
		  this.menuItem15.Text = "-";
		  // 
		  // menuItem14_RecentFiles4
		  // 
		  this.menuItem14_RecentFiles4.Index = 3;
		  this.menuItem14_RecentFiles4.Text = "Recent files";
		  // 
		  // menuItem8
		  // 
		  this.menuItem8.Index = 4;
		  this.menuItem8.Text = "-";
		  // 
		  // menuItem9_Exit
		  // 
		  this.menuItem9_Exit.Index = 5;
		  this.menuItem9_Exit.Text = "Exit";
		  // 
		  // statusBar1
		  // 
		  this.statusBar1.Location = new System.Drawing.Point(0, 321);
		  this.statusBar1.Name = "statusBar1";
		  this.statusBar1.Size = new System.Drawing.Size(416, 24);
		  this.statusBar1.TabIndex = 1;
		  // 
		  // openFileDialog1
		  // 
		  this.openFileDialog1.Filter = "Fotran files (*.f95)|*.f95|All files (*.*)|*.*";
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
		  this.toolBar1.Size = new System.Drawing.Size(416, 25);
		  this.toolBar1.TabIndex = 3;
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
																					 this.menuItem6});
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 0;
		  this.menuItem4.Text = "Text file";
		  // 
		  // menuItem6
		  // 
		  this.menuItem6.Index = 1;
		  this.menuItem6.Text = "RichText file";
		  // 
		  // toolBarButton2_Open
		  // 
		  this.toolBarButton2_Open.ImageIndex = 1;
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // Form1
		  // 
		  this.AllowDrop = true;
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(416, 345);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.toolBar1,
																	  this.statusBar1});
		  this.IsMdiContainer = true;
		  this.Menu = this.mainMenu1;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "MDI";
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
