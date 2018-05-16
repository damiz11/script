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
	  private System.Windows.Forms.MenuItem menuItem2;
	  private System.Windows.Forms.MenuItem menuItem3;
	  private System.Windows.Forms.MenuItem menuItem4;
	  private System.Windows.Forms.MenuItem menuItem5;
	  private System.Windows.Forms.MenuItem menuItem6;
	  private System.Windows.Forms.MenuItem menuItem7;
	  private System.Windows.Forms.MenuItem menuItem8;
	  private System.Windows.Forms.MenuItem menuItem9;
	  private System.Windows.Forms.MenuItem menuItem10;
	  private System.Windows.Forms.StatusBar statusBar1;
	  private System.Windows.Forms.OpenFileDialog openFileDialog1;
	  private Salford.VisualClearWin.Text_Box text_Box1;
	  private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	  private System.Drawing.Printing.PrintDocument printDocument1;
	  private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
	  private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
	  private System.Windows.Forms.ColorDialog colorDialog1;
	  private System.Windows.Forms.PrintDialog printDialog1;
	  private System.Windows.Forms.FontDialog fontDialog1;
      private Salford.VisualClearWin.Drawing_Panel drawing_Panel1;
      private Salford.VisualClearWin.Text_Box text_Box2;
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
		  System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.menuItem5 = new System.Windows.Forms.MenuItem();
		  this.menuItem6 = new System.Windows.Forms.MenuItem();
		  this.menuItem7 = new System.Windows.Forms.MenuItem();
		  this.menuItem8 = new System.Windows.Forms.MenuItem();
		  this.menuItem2 = new System.Windows.Forms.MenuItem();
		  this.menuItem9 = new System.Windows.Forms.MenuItem();
		  this.menuItem10 = new System.Windows.Forms.MenuItem();
		  this.statusBar1 = new System.Windows.Forms.StatusBar();
		  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		  this.text_Box1 = new Salford.VisualClearWin.Text_Box();
		  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		  this.printDocument1 = new System.Drawing.Printing.PrintDocument();
		  this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
		  this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
		  this.colorDialog1 = new System.Windows.Forms.ColorDialog();
		  this.printDialog1 = new System.Windows.Forms.PrintDialog();
		  this.fontDialog1 = new System.Windows.Forms.FontDialog();
		  this.drawing_Panel1 = new Salford.VisualClearWin.Drawing_Panel();
		  this.text_Box2 = new Salford.VisualClearWin.Text_Box();
		  this.SuspendLayout();
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
																				  this.menuItem3,
																				  this.menuItem4,
																				  this.menuItem5,
																				  this.menuItem6,
																				  this.menuItem7,
																				  this.menuItem8});
		  this.menuItem1.Text = "File";
		  // 
		  // menuItem3
		  // 
		  this.menuItem3.Index = 0;
		  this.menuItem3.Text = "Open|Calls the Open dialog";
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 1;
		  this.menuItem4.Text = "Save As|Calls the Save As dialog";
		  // 
		  // menuItem5
		  // 
		  this.menuItem5.Index = 2;
		  this.menuItem5.Text = "-";
		  // 
		  // menuItem6
		  // 
		  this.menuItem6.Index = 3;
		  this.menuItem6.Text = "Print Preview|Calls the Print Priview dialog";
		  // 
		  // menuItem7
		  // 
		  this.menuItem7.Index = 4;
		  this.menuItem7.Text = "Page Setup|Calls the Page Setup dialog";
		  // 
		  // menuItem8
		  // 
		  this.menuItem8.Index = 5;
		  this.menuItem8.Text = "Print|Calls the Print dialog";
		  // 
		  // menuItem2
		  // 
		  this.menuItem2.Index = 1;
		  this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem9,
																				  this.menuItem10});
		  this.menuItem2.Text = "Format";
		  // 
		  // menuItem9
		  // 
		  this.menuItem9.Index = 0;
		  this.menuItem9.Text = "Color|Calls the Choose color dialog";
		  // 
		  // menuItem10
		  // 
		  this.menuItem10.Index = 1;
		  this.menuItem10.Text = "Font|Calls the Choose font dialog";
		  // 
		  // statusBar1
		  // 
		  this.statusBar1.Location = new System.Drawing.Point(0, 169);
		  this.statusBar1.Name = "statusBar1";
		  this.statusBar1.Size = new System.Drawing.Size(216, 16);
		  this.statusBar1.TabIndex = 0;
		  this.statusBar1.Text = "Ready";
		  // 
		  // openFileDialog1
		  // 
		  this.openFileDialog1.Multiselect = true;
		  // 
		  // text_Box1
		  // 
		  this.text_Box1.Location = new System.Drawing.Point(8, 8);
		  this.text_Box1.Multiline = true;
		  this.text_Box1.Name = "text_Box1";
		  this.text_Box1.Pivoting = Salford.VisualClearWin.Pivot.Horizontal;
		  this.text_Box1.ReadOnly = true;
		  this.text_Box1.Size = new System.Drawing.Size(200, 112);
		  this.text_Box1.TabIndex = 1;
		  this.text_Box1.Text = "";
		  // 
		  // saveFileDialog1
		  // 
		  this.saveFileDialog1.FileName = "doc1";
		  // 
		  // printPreviewDialog1
		  // 
		  this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
		  this.printPreviewDialog1.Document = this.printDocument1;
		  this.printPreviewDialog1.Enabled = true;
		  this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
		  this.printPreviewDialog1.Location = new System.Drawing.Point(256, 17);
		  this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.Name = "printPreviewDialog1";
		  this.printPreviewDialog1.Opacity = 1;
		  this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
		  this.printPreviewDialog1.Visible = false;
		  // 
		  // pageSetupDialog1
		  // 
		  this.pageSetupDialog1.Document = this.printDocument1;
		  // 
		  // printDialog1
		  // 
		  this.printDialog1.Document = this.printDocument1;
		  // 
		  // fontDialog1
		  // 
		  this.fontDialog1.ShowColor = true;
		  // 
		  // drawing_Panel1
		  // 
		  this.drawing_Panel1.BackColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.BitmapSize = new System.Drawing.Size(0, 0);
		  this.drawing_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		  this.drawing_Panel1.FillColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.LineColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.Location = new System.Drawing.Point(8, 128);
		  this.drawing_Panel1.Name = "drawing_Panel1";
		  this.drawing_Panel1.Size = new System.Drawing.Size(72, 24);
		  this.drawing_Panel1.StringColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.TabIndex = 2;
		  // 
		  // text_Box2
		  // 
		  this.text_Box2.ForeColor = System.Drawing.Color.Black;
		  this.text_Box2.Location = new System.Drawing.Point(96, 128);
		  this.text_Box2.Name = "text_Box2";
		  this.text_Box2.Pivoting = Salford.VisualClearWin.Pivot.Horizontal;
		  this.text_Box2.Size = new System.Drawing.Size(112, 20);
		  this.text_Box2.TabIndex = 3;
		  this.text_Box2.Text = "Font Sample";
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(216, 185);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.text_Box2,
																	  this.drawing_Panel1,
																	  this.text_Box1,
																	  this.statusBar1});
		  this.MaximizeBox = false;
		  this.Menu = this.mainMenu1;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Common dialogs";
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
