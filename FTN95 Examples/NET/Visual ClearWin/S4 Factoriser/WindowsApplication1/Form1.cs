using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Resources2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
	  private System.Windows.Forms.Button button1;
      private System.ComponentModel.IContainer components=null;
      private System.Windows.Forms.Label label1;
	  private System.Windows.Forms.TextBox textBox1;
	  private System.Windows.Forms.MainMenu mainMenu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem3;
	  private Salford.VisualClearWin.Int32_Box int32_Box1;
	  private System.Windows.Forms.MenuItem menuItem2_Exit;
	  private System.Windows.Forms.MenuItem menuItem4;

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
		  this.button1 = new System.Windows.Forms.Button();
		  this.label1 = new System.Windows.Forms.Label();
		  this.textBox1 = new System.Windows.Forms.TextBox();
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem2_Exit = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.int32_Box1 = new Salford.VisualClearWin.Int32_Box();
		  this.SuspendLayout();
		  // 
		  // button1
		  // 
		  this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.button1.Location = new System.Drawing.Point(192, 16);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(64, 24);
		  this.button1.TabIndex = 0;
		  this.button1.Text = "Factorise";
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(16, 20);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(128, 16);
		  this.label1.TabIndex = 5;
		  this.label1.Text = "Number to be factorised:";
		  // 
		  // textBox1
		  // 
		  this.textBox1.Location = new System.Drawing.Point(16, 56);
		  this.textBox1.Name = "textBox1";
		  this.textBox1.ReadOnly = true;
		  this.textBox1.Size = new System.Drawing.Size(240, 20);
		  this.textBox1.TabIndex = 6;
		  this.textBox1.Text = "";
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
		  this.menuItem2_Exit.Text = "Exit";
		  // 
		  // menuItem3
		  // 
		  this.menuItem3.Index = 1;
		  this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem4});
		  this.menuItem3.Text = "Help";
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 0;
		  this.menuItem4.Text = "About";
		  // 
		  // int32_Box1
		  // 
		  this.int32_Box1.Location = new System.Drawing.Point(152, 18);
		  this.int32_Box1.Maximum = 2147483647;
		  this.int32_Box1.Minimum = -2147483648;
		  this.int32_Box1.Name = "int32_Box1";
		  this.int32_Box1.Size = new System.Drawing.Size(32, 20);
		  this.int32_Box1.TabIndex = 7;
		  this.int32_Box1.Text = "0";
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(274, 99);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.int32_Box1,
																	  this.textBox1,
																	  this.label1,
																	  this.button1});
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.MaximizeBox = false;
		  this.Menu = this.mainMenu1;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Factoriser";
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
