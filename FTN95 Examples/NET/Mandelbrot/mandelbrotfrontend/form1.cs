using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MandelbrotFrontend
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Drawing.Bitmap bitmap1;
		private double zoom = 1.0;
		private double x = 0.0, y = 0.0;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 256);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 272);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Use the cursor keys to move and the page up / page down keys to zoom";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 309);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void SetupBitmap()
		{
			bitmap1 = new Bitmap(pictureBox1.Height-1, pictureBox1.Width-1);
			pictureBox1.Image = bitmap1;
		}

		private void DrawMandlebrot()
		{
			MandelbrotBackend.DrawMandelbrot(zoom, x, y, Math.Min(pictureBox1.Height-1, pictureBox1.Width-1));
		}

		private void SetupMandelbrot()
		{
			MandelbrotBackend.SetupMandelbrot(bitmap1, pictureBox1);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			SetupBitmap();
			SetupMandelbrot();
			DrawMandlebrot();
		}

		private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
				y += 20/zoom;
			else if (e.KeyCode == Keys.Up)
				y -= 20/zoom;
			else if (e.KeyCode == Keys.Left)
				x -= 20/zoom;
			else if (e.KeyCode == Keys.Right)
				x += 20/zoom;
			else if (e.KeyCode == Keys.PageUp)
				zoom *= 1.25;
			else if (e.KeyCode == Keys.PageDown)
				zoom /= 1.25;
			DrawMandlebrot();
		}
	}
}
