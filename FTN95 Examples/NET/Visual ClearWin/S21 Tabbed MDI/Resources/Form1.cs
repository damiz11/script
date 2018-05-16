using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Resources10
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
	  private Salford.VisualClearWin.Main_Menu main_Menu1;
	  private System.Windows.Forms.MenuItem menuItem5;
	  private System.Windows.Forms.ToolBar toolBar1;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.StatusBar statusBar1;
	  private System.Windows.Forms.MenuItem menuItemFile;
	  private System.Windows.Forms.MenuItem menuItemOpen;
	  private System.Windows.Forms.MenuItem menuItemExit;
	  private System.Windows.Forms.MenuItem menuItemNew;
	  private System.Windows.Forms.OpenFileDialog openFileDialog1;
	  private System.Windows.Forms.ToolBarButton toolBarButton_Open;
	  private System.Windows.Forms.ToolBarButton toolBarButton_New;
	  private Salford.VisualClearWin.Tab_Control tab_Control1;
	  private System.Windows.Forms.MenuItem menuItemRecentFiles;
	  private System.Windows.Forms.ImageList imageList2;
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
		  this.main_Menu1 = new Salford.VisualClearWin.Main_Menu();
		  this.imageList2 = new System.Windows.Forms.ImageList(this.components);
		  this.menuItemFile = new System.Windows.Forms.MenuItem();
		  this.menuItemNew = new System.Windows.Forms.MenuItem();
		  this.menuItemOpen = new System.Windows.Forms.MenuItem();
		  this.menuItem5 = new System.Windows.Forms.MenuItem();
		  this.menuItemRecentFiles = new System.Windows.Forms.MenuItem();
		  this.menuItemExit = new System.Windows.Forms.MenuItem();
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton_New = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton_Open = new System.Windows.Forms.ToolBarButton();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.statusBar1 = new System.Windows.Forms.StatusBar();
		  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		  this.tab_Control1 = new Salford.VisualClearWin.Tab_Control();
		  this.SuspendLayout();
		  // 
		  // main_Menu1
		  // 
		  this.main_Menu1.ImageBackColor = System.Drawing.SystemColors.Control;
		  this.main_Menu1.ImageList = this.imageList2;
		  this.main_Menu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.menuItemFile});
		  // 
		  // imageList2
		  // 
		  this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
		  this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
		  this.imageList2.TransparentColor = System.Drawing.Color.White;
		  // 
		  // menuItemFile
		  // 
		  this.menuItemFile.Index = 0;
		  this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItemNew,
																					 this.menuItemOpen,
																					 this.menuItem5,
																					 this.menuItemRecentFiles,
																					 this.menuItemExit});
		  this.menuItemFile.Text = "File";
		  // 
		  // menuItemNew
		  // 
		  this.main_Menu1.SetCallback(this.menuItemNew, "New");
		  this.main_Menu1.SetImageIndex(this.menuItemNew, "0");
		  this.menuItemNew.Index = 0;
		  this.main_Menu1.SetMenuTip(this.menuItemNew, "Creates a new file");
		  this.menuItemNew.Text = "New";
		  // 
		  // menuItemOpen
		  // 
		  this.main_Menu1.SetCallback(this.menuItemOpen, "Open");
		  this.main_Menu1.SetImageIndex(this.menuItemOpen, "1");
		  this.menuItemOpen.Index = 1;
		  this.main_Menu1.SetMenuTip(this.menuItemOpen, "Opens an existing file");
		  this.menuItemOpen.Text = "Open";
		  // 
		  // menuItem5
		  // 
		  this.main_Menu1.SetCallback(this.menuItem5, null);
		  this.main_Menu1.SetImageIndex(this.menuItem5, null);
		  this.menuItem5.Index = 2;
		  this.main_Menu1.SetMenuTip(this.menuItem5, null);
		  this.menuItem5.Text = "-";
		  // 
		  // menuItemRecentFiles
		  // 
		  this.main_Menu1.SetCallback(this.menuItemRecentFiles, "RecentFiles4");
		  this.main_Menu1.SetImageIndex(this.menuItemRecentFiles, "");
		  this.menuItemRecentFiles.Index = 3;
		  this.main_Menu1.SetMenuTip(this.menuItemRecentFiles, "");
		  this.menuItemRecentFiles.Text = "Recent Files";
		  // 
		  // menuItemExit
		  // 
		  this.main_Menu1.SetCallback(this.menuItemExit, "Exit");
		  this.main_Menu1.SetImageIndex(this.menuItemExit, "");
		  this.menuItemExit.Index = 4;
		  this.main_Menu1.SetMenuTip(this.menuItemExit, "Exits from the application");
		  this.menuItemExit.Text = "Exit";
		  // 
		  // toolBar1
		  // 
		  this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
		  this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarButton_New,
																					this.toolBarButton_Open});
		  this.toolBar1.ButtonSize = new System.Drawing.Size(16, 16);
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(642, 25);
		  this.toolBar1.TabIndex = 1;
		  // 
		  // toolBarButton_New
		  // 
		  this.toolBarButton_New.ImageIndex = 0;
		  this.toolBarButton_New.ToolTipText = "New";
		  // 
		  // toolBarButton_Open
		  // 
		  this.toolBarButton_Open.ImageIndex = 1;
		  this.toolBarButton_Open.ToolTipText = "Open";
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.White;
		  // 
		  // statusBar1
		  // 
		  this.statusBar1.Location = new System.Drawing.Point(0, 358);
		  this.statusBar1.Name = "statusBar1";
		  this.statusBar1.Size = new System.Drawing.Size(642, 24);
		  this.statusBar1.TabIndex = 2;
		  // 
		  // tab_Control1
		  // 
		  this.tab_Control1.IsMdiContainer = true;
		  this.tab_Control1.Location = new System.Drawing.Point(0, 24);
		  this.tab_Control1.Name = "tab_Control1";
		  this.tab_Control1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.tab_Control1.SelectedIndex = 0;
		  this.tab_Control1.Size = new System.Drawing.Size(643, 336);
		  this.tab_Control1.TabIndex = 3;
		  // 
		  // Form1
		  // 
		  this.AllowDrop = true;
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(642, 382);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.tab_Control1,
																	  this.statusBar1,
																	  this.toolBar1});
		  this.Menu = this.main_Menu1;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Tag = "";
		  this.Text = "Tabbed MDI";
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
