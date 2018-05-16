using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MandelFront
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Salford.VisualClearWin.Drawing_Panel drawingPanel1;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
          this.drawingPanel1 = new Salford.VisualClearWin.Drawing_Panel();
          this.SuspendLayout();
          // 
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(184, 8);
          this.button1.Name = "button1";
          this.button1.TabIndex = 0;
          this.button1.Text = "Draw";
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // drawingPanel1
          // 
          this.drawingPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.drawingPanel1.FillColor = System.Drawing.SystemColors.Control;
          this.drawingPanel1.LineColor = System.Drawing.Color.Black;
          this.drawingPanel1.Location = new System.Drawing.Point(6, 38);
          this.drawingPanel1.Name = "drawingPanel1";
          this.drawingPanel1.Size = new System.Drawing.Size(259, 259);
          this.drawingPanel1.StringColor = System.Drawing.Color.Black;
          this.drawingPanel1.TabIndex = 2;
          // 
          // Form1
          // 
          this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
          this.ClientSize = new System.Drawing.Size(272, 302);
          this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.drawingPanel1,
                                                                      this.button1});
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "Form1";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Mandelbrot";
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
			Mandelbrot.mandel(drawingPanel1.Drawing);
		}
	}
}
