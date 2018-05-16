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
	  private System.Windows.Forms.Label label1;
	  private Salford.VisualClearWin.Combo_Box combo_Box1;
	  private System.Windows.Forms.Button button1;
	  private System.Windows.Forms.Button button2;
	  private System.Windows.Forms.Button button3;
	  private Salford.VisualClearWin.Check_Box check_Box1;
	  private Salford.VisualClearWin.Check_Box check_Box2;
	  private Salford.VisualClearWin.Check_Box check_Box3;
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
		  this.label1 = new System.Windows.Forms.Label();
		  this.combo_Box1 = new Salford.VisualClearWin.Combo_Box();
		  this.button1 = new System.Windows.Forms.Button();
		  this.button2 = new System.Windows.Forms.Button();
		  this.button3 = new System.Windows.Forms.Button();
		  this.check_Box1 = new Salford.VisualClearWin.Check_Box();
		  this.check_Box2 = new Salford.VisualClearWin.Check_Box();
		  this.check_Box3 = new Salford.VisualClearWin.Check_Box();
		  this.SuspendLayout();
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(16, 16);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(56, 16);
		  this.label1.TabIndex = 0;
		  this.label1.Text = "Find what:";
		  // 
		  // combo_Box1
		  // 
		  this.combo_Box1.Location = new System.Drawing.Point(79, 13);
		  this.combo_Box1.Name = "combo_Box1";
		  this.combo_Box1.Persists = true;
		  this.combo_Box1.Size = new System.Drawing.Size(184, 21);
		  this.combo_Box1.TabIndex = 1;
		  // 
		  // button1
		  // 
		  this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.button1.Location = new System.Drawing.Point(272, 13);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(80, 24);
		  this.button1.TabIndex = 2;
		  this.button1.Text = "Find Next";
		  // 
		  // button2
		  // 
		  this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.button2.Location = new System.Drawing.Point(272, 48);
		  this.button2.Name = "button2";
		  this.button2.Size = new System.Drawing.Size(80, 24);
		  this.button2.TabIndex = 3;
		  this.button2.Text = "Close";
		  // 
		  // button3
		  // 
		  this.button3.Location = new System.Drawing.Point(272, 128);
		  this.button3.Name = "button3";
		  this.button3.Size = new System.Drawing.Size(80, 24);
		  this.button3.TabIndex = 4;
		  this.button3.Text = "Enter";
		  // 
		  // check_Box1
		  // 
		  this.check_Box1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.check_Box1.Location = new System.Drawing.Point(16, 48);
		  this.check_Box1.Name = "check_Box1";
		  this.check_Box1.Persists = true;
		  this.check_Box1.Size = new System.Drawing.Size(120, 16);
		  this.check_Box1.TabIndex = 5;
		  this.check_Box1.Text = "Match case";
		  // 
		  // check_Box2
		  // 
		  this.check_Box2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.check_Box2.Location = new System.Drawing.Point(16, 72);
		  this.check_Box2.Name = "check_Box2";
		  this.check_Box2.Persists = true;
		  this.check_Box2.Size = new System.Drawing.Size(120, 16);
		  this.check_Box2.TabIndex = 6;
		  this.check_Box2.Text = "Match whole word";
		  // 
		  // check_Box3
		  // 
		  this.check_Box3.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.check_Box3.Location = new System.Drawing.Point(16, 96);
		  this.check_Box3.Name = "check_Box3";
		  this.check_Box3.Persists = true;
		  this.check_Box3.Size = new System.Drawing.Size(120, 16);
		  this.check_Box3.TabIndex = 7;
		  this.check_Box3.Text = "Seach up";
		  // 
		  // Form2
		  // 
		  this.AcceptButton = this.button3;
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(368, 128);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.check_Box3,
																	  this.check_Box2,
																	  this.check_Box1,
																	  this.button3,
																	  this.button2,
																	  this.button1,
																	  this.combo_Box1,
																	  this.label1});
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form2";
		  this.ShowInTaskbar = false;
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Find";
		  this.ResumeLayout(false);

		}
		#endregion
	}
}
