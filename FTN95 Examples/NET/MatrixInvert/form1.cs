using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MatrixInvert
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
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

			Random rnd = new Random();
					
			textBox1.Text = rnd.NextDouble().ToString();
			textBox2.Text = rnd.NextDouble().ToString();
			textBox3.Text = rnd.NextDouble().ToString();
			textBox4.Text = rnd.NextDouble().ToString();
			textBox5.Text = rnd.NextDouble().ToString();
			textBox6.Text = rnd.NextDouble().ToString();
			textBox7.Text = rnd.NextDouble().ToString();
			textBox8.Text = rnd.NextDouble().ToString();
			textBox9.Text = rnd.NextDouble().ToString();
			textBox10.Text = rnd.NextDouble().ToString();
			textBox11.Text = rnd.NextDouble().ToString();
			textBox12.Text = rnd.NextDouble().ToString();
			textBox13.Text = rnd.NextDouble().ToString();
			textBox14.Text = rnd.NextDouble().ToString();
			textBox15.Text = rnd.NextDouble().ToString();
			textBox16.Text = rnd.NextDouble().ToString();
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(64, 136);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(48, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "textBox1";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(120, 136);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(48, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "textBox2";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(176, 136);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(48, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "textBox3";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(232, 136);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(48, 20);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "textBox4";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(64, 168);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(48, 20);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "textBox5";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(120, 168);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(48, 20);
			this.textBox6.TabIndex = 5;
			this.textBox6.Text = "textBox6";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(176, 168);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(48, 20);
			this.textBox7.TabIndex = 6;
			this.textBox7.Text = "textBox7";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(232, 168);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(48, 20);
			this.textBox8.TabIndex = 7;
			this.textBox8.Text = "textBox8";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(64, 200);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(48, 20);
			this.textBox9.TabIndex = 8;
			this.textBox9.Text = "textBox9";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(136, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 24);
			this.button1.TabIndex = 9;
			this.button1.Text = "Invert";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(120, 200);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(48, 20);
			this.textBox10.TabIndex = 10;
			this.textBox10.Text = "textBox10";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(176, 200);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(48, 20);
			this.textBox11.TabIndex = 11;
			this.textBox11.Text = "textBox11";
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(232, 200);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(48, 20);
			this.textBox12.TabIndex = 12;
			this.textBox12.Text = "textBox12";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(64, 232);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(48, 20);
			this.textBox13.TabIndex = 13;
			this.textBox13.Text = "textBox13";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(120, 232);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(48, 20);
			this.textBox14.TabIndex = 14;
			this.textBox14.Text = "textBox14";
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(176, 232);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(48, 20);
			this.textBox15.TabIndex = 15;
			this.textBox15.Text = "textBox15";
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(232, 232);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(48, 20);
			this.textBox16.TabIndex = 16;
			this.textBox16.Text = "textBox16";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(72, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = ".NET Matrix Inversion";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label2});
			this.groupBox1.Location = new System.Drawing.Point(24, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(296, 96);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Usage";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(264, 64);
			this.label2.TabIndex = 0;
			this.label2.Text = "Click Invert to invert the matrix.  Subsequent clicks will perform the inversion " +
				"on the numbers within the dialog.  Random numbers are used to populate the dialo" +
				"g in the first instance but feel free to add your own.";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.label1,
																		  this.textBox16,
																		  this.textBox15,
																		  this.textBox14,
																		  this.textBox13,
																		  this.textBox12,
																		  this.textBox11,
																		  this.textBox10,
																		  this.button1,
																		  this.textBox9,
																		  this.textBox8,
																		  this.textBox7,
																		  this.textBox6,
																		  this.textBox5,
																		  this.textBox4,
																		  this.textBox3,
																		  this.textBox2,
																		  this.textBox1});
			this.Name = "Form1";
			this.Text = "Matrix Inversion";
			this.groupBox1.ResumeLayout(false);
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
			//
			// Populate the array and call the Fortran
			//

			double[,] a = new double[4,4];
			double d = 0;
			double[] l = new double[100];
			double[] m = new double[100];
			a[0,0] = Double.Parse(textBox1.Text);
			a[0,1] = Double.Parse(textBox2.Text);
			a[0,2] = Double.Parse(textBox3.Text);
			a[0,3] = Double.Parse(textBox4.Text);
			a[1,0] = Double.Parse(textBox5.Text);
			a[1,1] = Double.Parse(textBox6.Text);
			a[1,2] = Double.Parse(textBox7.Text);
			a[1,3] = Double.Parse(textBox8.Text);
			a[2,0] = Double.Parse(textBox9.Text);
			a[2,1] = Double.Parse(textBox10.Text);
			a[2,2] = Double.Parse(textBox11.Text);
			a[2,3] = Double.Parse(textBox12.Text);
			a[3,0] = Double.Parse(textBox13.Text);
			a[3,1] = Double.Parse(textBox14.Text);
			a[3,2] = Double.Parse(textBox15.Text);
			a[3,3] = Double.Parse(textBox16.Text);

			FortranMatrixInvert.DinverStub(a,d,l,m);

			textBox1.Text = a[0,0].ToString();
			textBox2.Text = a[0,1].ToString();
			textBox3.Text = a[0,2].ToString();
			textBox4.Text = a[0,3].ToString();
			textBox5.Text = a[1,0].ToString();
			textBox6.Text = a[1,1].ToString();
			textBox7.Text = a[1,2].ToString();
			textBox8.Text = a[1,3].ToString();
			textBox9.Text = a[2,0].ToString();
			textBox10.Text = a[2,1].ToString();
			textBox11.Text = a[2,2].ToString();
			textBox12.Text = a[2,3].ToString();
			textBox13.Text = a[3,0].ToString();
			textBox14.Text = a[3,1].ToString();
			textBox15.Text = a[3,2].ToString();
			textBox16.Text = a[3,3].ToString();
		}
	}
}
