using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Resources10
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
	  private Salford.VisualClearWin.Main_Menu main_Menu1;
	  private System.Windows.Forms.MenuItem menuItem5;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.ToolBar toolBar1;
	  private System.Windows.Forms.TabControl tabControl1;
	  private System.Windows.Forms.TabPage tabPage1;
	  private System.Windows.Forms.TextBox textBox1;
	  private System.Windows.Forms.MenuItem menuItemFile;
	  private System.Windows.Forms.MenuItem menuItemNew;
	  private System.Windows.Forms.MenuItem menuItemOpen;
	  private System.Windows.Forms.MenuItem menuItemSave;
	  private System.Windows.Forms.MenuItem menuItemExit;
	  private System.Windows.Forms.MenuItem menuItemSaveAs;
	  private System.Windows.Forms.ToolBarButton toolBarButton_New;
	  private System.Windows.Forms.ToolBarButton toolBarButton_Open;
	  private System.Windows.Forms.ToolBarButton toolBarButton_Save;
	  private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	  private System.Windows.Forms.MenuItem menuItemWindow;
	  private System.Windows.Forms.MenuItem menuItemCloseAll;
	  private System.Windows.Forms.MenuItem menuItemWindows;
	  private System.Windows.Forms.MenuItem menuItemRecentFiles;
	  private System.Windows.Forms.ImageList imageList2;
	  private System.ComponentModel.IContainer components;

		public Form2()
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
		  System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
		  this.main_Menu1 = new Salford.VisualClearWin.Main_Menu();
		  this.imageList2 = new System.Windows.Forms.ImageList(this.components);
		  this.menuItemFile = new System.Windows.Forms.MenuItem();
		  this.menuItemNew = new System.Windows.Forms.MenuItem();
		  this.menuItemOpen = new System.Windows.Forms.MenuItem();
		  this.menuItemSave = new System.Windows.Forms.MenuItem();
		  this.menuItemSaveAs = new System.Windows.Forms.MenuItem();
		  this.menuItem5 = new System.Windows.Forms.MenuItem();
		  this.menuItemRecentFiles = new System.Windows.Forms.MenuItem();
		  this.menuItemExit = new System.Windows.Forms.MenuItem();
		  this.menuItemWindow = new System.Windows.Forms.MenuItem();
		  this.menuItemCloseAll = new System.Windows.Forms.MenuItem();
		  this.menuItemWindows = new System.Windows.Forms.MenuItem();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton_New = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton_Open = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton_Save = new System.Windows.Forms.ToolBarButton();
		  this.tabControl1 = new System.Windows.Forms.TabControl();
		  this.tabPage1 = new System.Windows.Forms.TabPage();
		  this.textBox1 = new System.Windows.Forms.TextBox();
		  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		  this.tabControl1.SuspendLayout();
		  this.tabPage1.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // main_Menu1
		  // 
		  this.main_Menu1.ImageBackColor = System.Drawing.SystemColors.Control;
		  this.main_Menu1.ImageList = this.imageList2;
		  this.main_Menu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.menuItemFile,
																				   this.menuItemWindow});
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
																					 this.menuItemSave,
																					 this.menuItemSaveAs,
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
		  // menuItemSave
		  // 
		  this.main_Menu1.SetCallback(this.menuItemSave, "Save");
		  this.menuItemSave.Enabled = false;
		  this.main_Menu1.SetImageIndex(this.menuItemSave, "2");
		  this.menuItemSave.Index = 2;
		  this.main_Menu1.SetMenuTip(this.menuItemSave, "Saves the current file");
		  this.menuItemSave.Text = "Save";
		  // 
		  // menuItemSaveAs
		  // 
		  this.main_Menu1.SetCallback(this.menuItemSaveAs, "SaveAs");
		  this.main_Menu1.SetImageIndex(this.menuItemSaveAs, "");
		  this.menuItemSaveAs.Index = 3;
		  this.main_Menu1.SetMenuTip(this.menuItemSaveAs, "Saves the current file with a new name.");
		  this.menuItemSaveAs.Text = "Save As";
		  // 
		  // menuItem5
		  // 
		  this.main_Menu1.SetCallback(this.menuItem5, null);
		  this.main_Menu1.SetImageIndex(this.menuItem5, null);
		  this.menuItem5.Index = 4;
		  this.main_Menu1.SetMenuTip(this.menuItem5, null);
		  this.menuItem5.Text = "-";
		  // 
		  // menuItemRecentFiles
		  // 
		  this.main_Menu1.SetCallback(this.menuItemRecentFiles, "RecentFiles4");
		  this.main_Menu1.SetImageIndex(this.menuItemRecentFiles, "");
		  this.menuItemRecentFiles.Index = 5;
		  this.main_Menu1.SetMenuTip(this.menuItemRecentFiles, "");
		  this.menuItemRecentFiles.Text = "Recent Files...";
		  // 
		  // menuItemExit
		  // 
		  this.main_Menu1.SetCallback(this.menuItemExit, "Exit");
		  this.main_Menu1.SetImageIndex(this.menuItemExit, "");
		  this.menuItemExit.Index = 6;
		  this.main_Menu1.SetMenuTip(this.menuItemExit, "Exits from the application");
		  this.menuItemExit.Text = "Exit";
		  // 
		  // menuItemWindow
		  // 
		  this.menuItemWindow.Index = 1;
		  this.menuItemWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItemCloseAll,
																					   this.menuItemWindows});
		  this.menuItemWindow.Text = "Window";
		  // 
		  // menuItemCloseAll
		  // 
		  this.main_Menu1.SetCallback(this.menuItemCloseAll, "CloseAll");
		  this.main_Menu1.SetImageIndex(this.menuItemCloseAll, "3");
		  this.menuItemCloseAll.Index = 0;
		  this.main_Menu1.SetMenuTip(this.menuItemCloseAll, "Closes all files");
		  this.menuItemCloseAll.Text = "Close All";
		  // 
		  // menuItemWindows
		  // 
		  this.main_Menu1.SetCallback(this.menuItemWindows, "Windows");
		  this.main_Menu1.SetImageIndex(this.menuItemWindows, "");
		  this.menuItemWindows.Index = 1;
		  this.main_Menu1.SetMenuTip(this.menuItemWindows, "");
		  this.menuItemWindows.Text = "Windows";
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
																					this.toolBarButton_New,
																					this.toolBarButton_Open,
																					this.toolBarButton_Save});
		  this.toolBar1.ButtonSize = new System.Drawing.Size(16, 16);
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(292, 25);
		  this.toolBar1.TabIndex = 0;
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
		  // toolBarButton_Save
		  // 
		  this.toolBarButton_Save.ImageIndex = 2;
		  this.toolBarButton_Save.ToolTipText = "Save";
		  // 
		  // tabControl1
		  // 
		  this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.tabPage1});
		  this.tabControl1.Location = new System.Drawing.Point(24, 56);
		  this.tabControl1.Name = "tabControl1";
		  this.tabControl1.SelectedIndex = 0;
		  this.tabControl1.Size = new System.Drawing.Size(232, 168);
		  this.tabControl1.TabIndex = 1;
		  // 
		  // tabPage1
		  // 
		  this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																			   this.textBox1});
		  this.tabPage1.Location = new System.Drawing.Point(4, 22);
		  this.tabPage1.Name = "tabPage1";
		  this.tabPage1.Size = new System.Drawing.Size(224, 142);
		  this.tabPage1.TabIndex = 0;
		  this.tabPage1.Text = "tabPage1";
		  // 
		  // textBox1
		  // 
		  this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		  this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.textBox1.Multiline = true;
		  this.textBox1.Name = "textBox1";
		  this.textBox1.Size = new System.Drawing.Size(224, 142);
		  this.textBox1.TabIndex = 0;
		  this.textBox1.Text = "";
		  // 
		  // saveFileDialog1
		  // 
		  this.saveFileDialog1.FileName = "doc1";
		  // 
		  // Form2
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(292, 266);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.tabControl1,
																	  this.toolBar1});
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.Menu = this.main_Menu1;
		  this.Name = "Form2";
		  this.Text = "Form2";
		  this.tabControl1.ResumeLayout(false);
		  this.tabPage1.ResumeLayout(false);
		  this.ResumeLayout(false);

		}
		#endregion
	}
}
