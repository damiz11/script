using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Resources
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label1;
	  private System.Windows.Forms.Label label2;
	  private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
		  this.button1 = new System.Windows.Forms.Button();
		  this.label1 = new System.Windows.Forms.Label();
		  this.label2 = new System.Windows.Forms.Label();
		  this.label3 = new System.Windows.Forms.Label();
		  this.SuspendLayout();
		  // 
		  // button1
		  // 
		  this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
		  this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.button1.Location = new System.Drawing.Point(80, 136);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(72, 24);
		  this.button1.TabIndex = 0;
		  this.button1.Text = "OK";
		  // 
		  // label1
		  // 
		  this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.label1.ForeColor = System.Drawing.Color.Black;
		  this.label1.Location = new System.Drawing.Point(10, 16);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(204, 24);
		  this.label1.TabIndex = 1;
		  this.label1.Text = "Factoriser";
		  this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		  // 
		  // label2
		  // 
		  this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.label2.ForeColor = System.Drawing.Color.Black;
		  this.label2.Location = new System.Drawing.Point(10, 64);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(204, 16);
		  this.label2.TabIndex = 2;
		  this.label2.Text = " Program written to demonstrate";
		  this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // label3
		  // 
		  this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.label3.ForeColor = System.Drawing.Color.OrangeRed;
		  this.label3.Location = new System.Drawing.Point(10, 96);
		  this.label3.Name = "label3";
		  this.label3.Size = new System.Drawing.Size(204, 24);
		  this.label3.TabIndex = 3;
		  this.label3.Text = "Visual ClearWin";
		  this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		  // 
		  // Form2
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(224, 174);
		  this.ControlBox = false;
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.label3,
																	  this.label2,
																	  this.label1,
																	  this.button1});
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.Name = "Form2";
		  this.ShowInTaskbar = false;
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		  this.Text = "About Factoriser";
		  this.Load += new System.EventHandler(this.Form2_Load);
		  this.ResumeLayout(false);

		}
		#endregion

      private void Form2_Load(object sender, System.EventArgs e)
      {
      
      }

	}
}
