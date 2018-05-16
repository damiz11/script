using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;
		private Salford.VisualClearWin.Double_Box doubleBox1;
		private Salford.VisualClearWin.Double_Box doubleBox2;

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
		  this.label2 = new System.Windows.Forms.Label();
		  this.doubleBox1 = new Salford.VisualClearWin.Double_Box();
		  this.doubleBox2 = new Salford.VisualClearWin.Double_Box();
		  this.SuspendLayout();
		  // 
		  // button1
		  // 
		  this.button1.Location = new System.Drawing.Point(32, 48);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(96, 24);
		  this.button1.TabIndex = 2;
		  this.button1.Text = "Square";
		  this.button1.Click += new System.EventHandler(this.button1_Click);
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(16, 18);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(32, 16);
		  this.label1.TabIndex = 1;
		  this.label1.Text = "Input";
		  this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  // 
		  // label2
		  // 
		  this.label2.Location = new System.Drawing.Point(16, 80);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(40, 16);
		  this.label2.TabIndex = 3;
		  this.label2.Text = "Output";
		  this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  // 
		  // doubleBox1
		  // 
		  this.doubleBox1.AutoCorrect = false;
		  this.doubleBox1.ExpFigs = 2;
		  this.doubleBox1.Location = new System.Drawing.Point(56, 16);
		  this.doubleBox1.Name = "doubleBox1";
		  this.doubleBox1.Size = new System.Drawing.Size(80, 20);
		  this.doubleBox1.TabIndex = 0;
		  this.doubleBox1.Text = "";
		  // 
		  // doubleBox2
		  // 
		  this.doubleBox2.AutoCorrect = false;
		  this.doubleBox2.Location = new System.Drawing.Point(56, 80);
		  this.doubleBox2.Maximum = 10000000;
		  this.doubleBox2.Minimum = -10000000;
		  this.doubleBox2.Name = "doubleBox2";
		  this.doubleBox2.ReadOnly = true;
		  this.doubleBox2.Size = new System.Drawing.Size(80, 20);
		  this.doubleBox2.TabIndex = 5;
		  this.doubleBox2.Text = "0";
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(154, 128);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.doubleBox2,
																	  this.doubleBox1,
																	  this.label2,
																	  this.label1,
																	  this.button1});
		  this.ForeColor = System.Drawing.SystemColors.WindowText;
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Sample 1";
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			doubleBox2.Value = Resources.Process(doubleBox1.Value);
		}

	}
}
