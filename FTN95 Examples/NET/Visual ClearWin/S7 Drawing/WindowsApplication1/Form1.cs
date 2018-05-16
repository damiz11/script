using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Resources6
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private Salford.VisualClearWin.Drawing_Panel drawingPanel1;
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
		  this.drawingPanel1 = new Salford.VisualClearWin.Drawing_Panel();
		  this.SuspendLayout();
		  // 
		  // drawingPanel1
		  // 
		  this.drawingPanel1.BackColor = System.Drawing.SystemColors.Control;
		  this.drawingPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		  this.drawingPanel1.FillColor = System.Drawing.Color.White;
		  this.drawingPanel1.LineColor = System.Drawing.Color.Red;
		  this.drawingPanel1.Location = new System.Drawing.Point(8, 8);
		  this.drawingPanel1.Name = "drawingPanel1";
		  this.drawingPanel1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.drawingPanel1.Size = new System.Drawing.Size(176, 96);
		  this.drawingPanel1.StringColor = System.Drawing.Color.Magenta;
		  this.drawingPanel1.TabIndex = 4;
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(192, 118);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.drawingPanel1});
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Graphics";
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
