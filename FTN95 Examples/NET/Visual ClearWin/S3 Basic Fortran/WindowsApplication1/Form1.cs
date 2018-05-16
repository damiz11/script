using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Resources1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
	  private System.Windows.Forms.Button button1;
      private System.ComponentModel.IContainer components;
      private System.Windows.Forms.Label label1;
	  private Salford.VisualClearWin.Double_Box double_Box1;
	  private Salford.VisualClearWin.Double_Box double_Box2;
	  private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label2;

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
		  this.double_Box1 = new Salford.VisualClearWin.Double_Box();
		  this.label1 = new System.Windows.Forms.Label();
		  this.label2 = new System.Windows.Forms.Label();
		  this.double_Box2 = new Salford.VisualClearWin.Double_Box();
		  this.groupBox1 = new System.Windows.Forms.GroupBox();
		  this.SuspendLayout();
		  // 
		  // button1
		  // 
		  this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.button1.Location = new System.Drawing.Point(15, 61);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(194, 26);
		  this.button1.TabIndex = 1;
		  this.button1.Text = "Square";
		  // 
		  // double_Box1
		  // 
		  this.double_Box1.Location = new System.Drawing.Point(16, 32);
		  this.double_Box1.Maximum = 10000000;
		  this.double_Box1.Minimum = -10000000;
		  this.double_Box1.Name = "double_Box1";
		  this.double_Box1.Size = new System.Drawing.Size(88, 20);
		  this.double_Box1.TabIndex = 0;
		  this.double_Box1.Text = "0";
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(15, 16);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(40, 16);
		  this.label1.TabIndex = 5;
		  this.label1.Text = "Value:";
		  // 
		  // label2
		  // 
		  this.label2.Location = new System.Drawing.Point(119, 16);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(40, 16);
		  this.label2.TabIndex = 7;
		  this.label2.Text = "Result:";
		  // 
		  // double_Box2
		  // 
		  this.double_Box2.Location = new System.Drawing.Point(120, 32);
		  this.double_Box2.Maximum = 10000000;
		  this.double_Box2.Minimum = -10000000;
		  this.double_Box2.Name = "double_Box2";
		  this.double_Box2.ReadOnly = true;
		  this.double_Box2.Size = new System.Drawing.Size(88, 20);
		  this.double_Box2.TabIndex = 2;
		  this.double_Box2.Text = "";
		  // 
		  // groupBox1
		  // 
		  this.groupBox1.Location = new System.Drawing.Point(4, 0);
		  this.groupBox1.Name = "groupBox1";
		  this.groupBox1.Size = new System.Drawing.Size(216, 96);
		  this.groupBox1.TabIndex = 8;
		  this.groupBox1.TabStop = false;
		  // 
		  // Form1
		  // 
		  this.AcceptButton = this.button1;
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(224, 100);
		  this.Controls.Add(this.label2);
		  this.Controls.Add(this.double_Box2);
		  this.Controls.Add(this.label1);
		  this.Controls.Add(this.double_Box1);
		  this.Controls.Add(this.button1);
		  this.Controls.Add(this.groupBox1);
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "A Simple Form";
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
