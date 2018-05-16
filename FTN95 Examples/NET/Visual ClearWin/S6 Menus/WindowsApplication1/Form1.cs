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
      private System.ComponentModel.IContainer components = null;
      private System.Windows.Forms.MainMenu mainMenu1;
      private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem2;
      private System.Windows.Forms.MenuItem menuItem3;
      private System.Windows.Forms.MenuItem menuItem4;
      private System.Windows.Forms.MenuItem menuItem5;
      private System.Windows.Forms.MenuItem menuItem7;
      private System.Windows.Forms.MenuItem menuItem8;
      private System.Windows.Forms.MenuItem menuItem6_Exit;
      private System.Windows.Forms.MenuItem menuItem9_Cut;
	  private System.Windows.Forms.MenuItem menuItem2_Exit;
      private System.Windows.Forms.ToolBar toolBar1;
      private System.Windows.Forms.ToolBarButton toolBarButton1;
      private System.Windows.Forms.ContextMenu contextMenu1;
      private System.Windows.Forms.ImageList imageList1;
      private System.Windows.Forms.StatusBar statusBar1;
	  private System.Windows.Forms.StatusBarPanel statusBarPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.ContextMenu contextMenu2;
	  private System.Windows.Forms.ToolBarButton toolBarButton2_Exit;
	  private System.Windows.Forms.StatusBarPanel statusBarPanel2;

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
		  this.contextMenu1 = new System.Windows.Forms.ContextMenu();
		  this.menuItem5 = new System.Windows.Forms.MenuItem();
		  this.menuItem6_Exit = new System.Windows.Forms.MenuItem();
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem2_Exit = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.menuItem2 = new System.Windows.Forms.MenuItem();
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton2_Exit = new System.Windows.Forms.ToolBarButton();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.statusBar1 = new System.Windows.Forms.StatusBar();
		  this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
		  this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
		  this.label1 = new System.Windows.Forms.Label();
		  this.textBox1 = new System.Windows.Forms.TextBox();
		  this.contextMenu2 = new System.Windows.Forms.ContextMenu();
		  this.menuItem9_Cut = new System.Windows.Forms.MenuItem();
		  this.menuItem7 = new System.Windows.Forms.MenuItem();
		  this.menuItem8 = new System.Windows.Forms.MenuItem();
		  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
		  this.SuspendLayout();
		  // 
		  // contextMenu1
		  // 
		  this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem5,
																					 this.menuItem6_Exit});
		  // 
		  // menuItem5
		  // 
		  this.menuItem5.Index = 0;
		  this.menuItem5.Text = "About|About this sample";
		  // 
		  // menuItem6_Exit
		  // 
		  this.menuItem6_Exit.Index = 1;
		  this.menuItem6_Exit.Text = "Exit|Exits from the application";
		  // 
		  // mainMenu1
		  // 
		  this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem1,
																				  this.menuItem3});
		  // 
		  // menuItem1
		  // 
		  this.menuItem1.Index = 0;
		  this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem2_Exit});
		  this.menuItem1.Text = "File";
		  // 
		  // menuItem2_Exit
		  // 
		  this.menuItem2_Exit.Index = 0;
		  this.menuItem2_Exit.Shortcut = System.Windows.Forms.Shortcut.F1;
		  this.menuItem2_Exit.Text = "Exit|Exits from the application";
		  // 
		  // menuItem3
		  // 
		  this.menuItem3.Index = 1;
		  this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem4,
																				  this.menuItem2});
		  this.menuItem3.Text = "Help";
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 0;
		  this.menuItem4.Text = "&About|About this application";
		  // 
		  // menuItem2
		  // 
		  this.menuItem2.Index = 1;
		  this.menuItem2.Text = "More";
		  // 
		  // toolBar1
		  // 
		  this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarButton1,
																					this.toolBarButton2_Exit});
		  this.toolBar1.ButtonSize = new System.Drawing.Size(16, 16);
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(240, 25);
		  this.toolBar1.TabIndex = 8;
		  // 
		  // toolBarButton1
		  // 
		  this.toolBarButton1.DropDownMenu = this.contextMenu1;
		  this.toolBarButton1.ImageIndex = 1;
		  this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
		  this.toolBarButton1.ToolTipText = "Open";
		  // 
		  // toolBarButton2_Exit
		  // 
		  this.toolBarButton2_Exit.ImageIndex = 0;
		  this.toolBarButton2_Exit.ToolTipText = "Exits from the application";
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // statusBar1
		  // 
		  this.statusBar1.Location = new System.Drawing.Point(0, 89);
		  this.statusBar1.Name = "statusBar1";
		  this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					  this.statusBarPanel1,
																					  this.statusBarPanel2});
		  this.statusBar1.ShowPanels = true;
		  this.statusBar1.Size = new System.Drawing.Size(240, 24);
		  this.statusBar1.TabIndex = 9;
		  this.statusBar1.Text = "statusBar1";
		  // 
		  // statusBarPanel1
		  // 
		  this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
		  this.statusBarPanel1.Text = "Press Ctrl+A for About.";
		  this.statusBarPanel1.Width = 174;
		  // 
		  // statusBarPanel2
		  // 
		  this.statusBarPanel2.Text = "Page 1";
		  this.statusBarPanel2.Width = 50;
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(8, 64);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(120, 16);
		  this.label1.TabIndex = 10;
		  this.label1.Text = "Context menu here...";
		  // 
		  // textBox1
		  // 
		  this.textBox1.ContextMenu = this.contextMenu2;
		  this.textBox1.Location = new System.Drawing.Point(112, 32);
		  this.textBox1.Name = "textBox1";
		  this.textBox1.Size = new System.Drawing.Size(112, 20);
		  this.textBox1.TabIndex = 11;
		  this.textBox1.Text = "Context menu here...";
		  // 
		  // contextMenu2
		  // 
		  this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem9_Cut,
																					 this.menuItem7,
																					 this.menuItem8});
		  // 
		  // menuItem9_Cut
		  // 
		  this.menuItem9_Cut.Index = 0;
		  this.menuItem9_Cut.Text = " Cut|Cuts the text to the clipboard";
		  // 
		  // menuItem7
		  // 
		  this.menuItem7.Index = 1;
		  this.menuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
		  this.menuItem7.Text = " Copy|Copies the text to the clipboard";
		  // 
		  // menuItem8
		  // 
		  this.menuItem8.Index = 2;
		  this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
		  this.menuItem8.Text = " Paste|Pastes the text from the clipboard";
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(240, 113);
		  this.ContextMenu = this.contextMenu1;
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.textBox1,
																	  this.label1,
																	  this.statusBar1,
																	  this.toolBar1});
		  this.MaximizeBox = false;
		  this.Menu = this.mainMenu1;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Menus";
		  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
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
