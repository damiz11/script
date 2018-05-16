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
	  private Salford.VisualClearWin.Combo_Box combo_Box1;
	  private System.Windows.Forms.Label label2;
	  private System.Windows.Forms.Button button1;
	  private Salford.VisualClearWin.Int32_Box int32_Box1;
      private System.ComponentModel.IContainer components=null;

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
		  this.combo_Box1 = new Salford.VisualClearWin.Combo_Box();
		  this.int32_Box1 = new Salford.VisualClearWin.Int32_Box();
		  this.label2 = new System.Windows.Forms.Label();
		  this.button1 = new System.Windows.Forms.Button();
		  this.SuspendLayout();
		  // 
		  // combo_Box1
		  // 
		  this.combo_Box1.Location = new System.Drawing.Point(24, 16);
		  this.combo_Box1.Name = "combo_Box1";
		  this.combo_Box1.Size = new System.Drawing.Size(216, 21);
		  this.combo_Box1.TabIndex = 0;
		  // 
		  // int32_Box1
		  // 
		  this.int32_Box1.Location = new System.Drawing.Point(144, 56);
		  this.int32_Box1.Maximum = 2147483647;
		  this.int32_Box1.Minimum = -2147483648;
		  this.int32_Box1.Name = "int32_Box1";
		  this.int32_Box1.ReadOnly = true;
		  this.int32_Box1.Size = new System.Drawing.Size(24, 20);
		  this.int32_Box1.TabIndex = 2;
		  this.int32_Box1.Text = "";
		  // 
		  // label2
		  // 
		  this.label2.Location = new System.Drawing.Point(88, 60);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(48, 16);
		  this.label2.TabIndex = 4;
		  this.label2.Text = "Selected";
		  // 
		  // button1
		  // 
		  this.button1.Location = new System.Drawing.Point(24, 104);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(48, 24);
		  this.button1.TabIndex = 5;
		  this.button1.Text = "Insert";
		  // 
		  // Form1
		  // 
		  this.AcceptButton = this.button1;
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(266, 88);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.button1,
																	  this.label2,
																	  this.int32_Box1,
																	  this.combo_Box1});
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "ComboBox";
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
