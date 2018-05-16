using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Resources
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
	  private Salford.VisualClearWin.Main_Menu main_Menu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem2;
	  private System.Windows.Forms.MenuItem menuItem3;
	  private System.Windows.Forms.MenuItem menuItem4;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.MenuItem menuItem6;
	  private System.Windows.Forms.MenuItem menuItem7;
	  private Salford.VisualClearWin.Context_Menu context_Menu1;
	  private System.Windows.Forms.MenuItem menuItem8;
	  private System.Windows.Forms.MenuItem menuItem9;
	  private System.Windows.Forms.MenuItem menuItem10;
	  private System.Windows.Forms.StatusBar statusBar1;
	  private System.Windows.Forms.OpenFileDialog openFileDialog1;
	  private System.Windows.Forms.PictureBox pictureBox1;
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
		  System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
		  this.main_Menu1 = new Salford.VisualClearWin.Main_Menu();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.menuItem2 = new System.Windows.Forms.MenuItem();
		  this.menuItem6 = new System.Windows.Forms.MenuItem();
		  this.menuItem7 = new System.Windows.Forms.MenuItem();
		  this.context_Menu1 = new Salford.VisualClearWin.Context_Menu();
		  this.menuItem8 = new System.Windows.Forms.MenuItem();
		  this.menuItem9 = new System.Windows.Forms.MenuItem();
		  this.menuItem10 = new System.Windows.Forms.MenuItem();
		  this.statusBar1 = new System.Windows.Forms.StatusBar();
		  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		  this.pictureBox1 = new System.Windows.Forms.PictureBox();
		  this.SuspendLayout();
		  // 
		  // main_Menu1
		  // 
		  this.main_Menu1.ImageBackColor = System.Drawing.SystemColors.Control;
		  this.main_Menu1.ImageList = this.imageList1;
		  this.main_Menu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.menuItem1,
																				   this.menuItem6});
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.White;
		  // 
		  // menuItem1
		  // 
		  this.menuItem1.Index = 0;
		  this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem3,
																				  this.menuItem4,
																				  this.menuItem2});
		  this.menuItem1.Text = "File";
		  // 
		  // menuItem3
		  // 
		  this.main_Menu1.SetCallback(this.menuItem3, "Open");
		  this.main_Menu1.SetImageIndex(this.menuItem3, "0");
		  this.menuItem3.Index = 0;
		  this.main_Menu1.SetMenuTip(this.menuItem3, "Opens a file.");
		  this.menuItem3.Text = "Open";
		  // 
		  // menuItem4
		  // 
		  this.main_Menu1.SetCallback(this.menuItem4, null);
		  this.main_Menu1.SetImageIndex(this.menuItem4, null);
		  this.menuItem4.Index = 1;
		  this.main_Menu1.SetMenuTip(this.menuItem4, null);
		  this.menuItem4.Text = "-";
		  // 
		  // menuItem2
		  // 
		  this.main_Menu1.SetCallback(this.menuItem2, "Exit");
		  this.main_Menu1.SetImageIndex(this.menuItem2, "1");
		  this.menuItem2.Index = 2;
		  this.main_Menu1.SetMenuTip(this.menuItem2, "Exits the application.");
		  this.menuItem2.Text = "Exit";
		  // 
		  // menuItem6
		  // 
		  this.menuItem6.Index = 1;
		  this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem7});
		  this.menuItem6.Text = "Help";
		  // 
		  // menuItem7
		  // 
		  this.main_Menu1.SetCallback(this.menuItem7, "");
		  this.main_Menu1.SetImageIndex(this.menuItem7, "2");
		  this.menuItem7.Index = 0;
		  this.main_Menu1.SetMenuTip(this.menuItem7, "Gives information about this application.");
		  this.menuItem7.Text = "About";
		  // 
		  // context_Menu1
		  // 
		  this.context_Menu1.ImageBackColor = System.Drawing.SystemColors.Control;
		  this.context_Menu1.ImageList = this.imageList1;
		  this.context_Menu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10});
		  // 
		  // menuItem8
		  // 
		  this.context_Menu1.SetCallback(this.menuItem8, "");
		  this.context_Menu1.SetImageIndex(this.menuItem8, "");
		  this.menuItem8.Index = 0;
		  this.context_Menu1.SetMenuTip(this.menuItem8, "");
		  this.menuItem8.Text = "Cut";
		  // 
		  // menuItem9
		  // 
		  this.context_Menu1.SetCallback(this.menuItem9, "");
		  this.context_Menu1.SetImageIndex(this.menuItem9, "");
		  this.menuItem9.Index = 1;
		  this.context_Menu1.SetMenuTip(this.menuItem9, "Copies to the clipboard");
		  this.menuItem9.Text = "Copy";
		  // 
		  // menuItem10
		  // 
		  this.context_Menu1.SetCallback(this.menuItem10, "");
		  this.context_Menu1.SetImageIndex(this.menuItem10, "");
		  this.menuItem10.Index = 2;
		  this.context_Menu1.SetMenuTip(this.menuItem10, "");
		  this.menuItem10.Text = "Paste";
		  // 
		  // statusBar1
		  // 
		  this.statusBar1.Location = new System.Drawing.Point(0, 242);
		  this.statusBar1.Name = "statusBar1";
		  this.statusBar1.Size = new System.Drawing.Size(292, 24);
		  this.statusBar1.TabIndex = 0;
		  this.statusBar1.Text = "Ready";
		  // 
		  // pictureBox1
		  // 
		  this.pictureBox1.Location = new System.Drawing.Point(200, 256);
		  this.pictureBox1.Name = "pictureBox1";
		  this.pictureBox1.TabIndex = 1;
		  this.pictureBox1.TabStop = false;
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(292, 266);
		  this.ContextMenu = this.context_Menu1;
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.pictureBox1,
																	  this.statusBar1});
		  this.Menu = this.main_Menu1;
		  this.Name = "Form1";
		  this.Text = "Form1";
		  this.ResumeLayout(false);

		}
		#endregion
	}
}
