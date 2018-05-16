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
	  private System.Windows.Forms.Label label2;
	  private System.Windows.Forms.Label label3;
	  private System.Windows.Forms.Button button1;
	  private System.Windows.Forms.Button button2;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown1;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown2;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown3;
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
		  this.label2 = new System.Windows.Forms.Label();
		  this.label3 = new System.Windows.Forms.Label();
		  this.button1 = new System.Windows.Forms.Button();
		  this.button2 = new System.Windows.Forms.Button();
		  this.decimal_UpDown1 = new Salford.VisualClearWin.Decimal_UpDown();
		  this.decimal_UpDown2 = new Salford.VisualClearWin.Decimal_UpDown();
		  this.decimal_UpDown3 = new Salford.VisualClearWin.Decimal_UpDown();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown1)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown2)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown3)).BeginInit();
		  this.SuspendLayout();
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(48, 31);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(40, 16);
		  this.label1.TabIndex = 0;
		  this.label1.Text = "Red";
		  // 
		  // label2
		  // 
		  this.label2.Location = new System.Drawing.Point(48, 52);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(40, 16);
		  this.label2.TabIndex = 2;
		  this.label2.Text = "Green";
		  // 
		  // label3
		  // 
		  this.label3.Location = new System.Drawing.Point(48, 73);
		  this.label3.Name = "label3";
		  this.label3.Size = new System.Drawing.Size(40, 16);
		  this.label3.TabIndex = 4;
		  this.label3.Text = "Blue";
		  // 
		  // button1
		  // 
		  this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
		  this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.button1.Location = new System.Drawing.Point(16, 112);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(64, 24);
		  this.button1.TabIndex = 3;
		  this.button1.Text = "OK";
		  // 
		  // button2
		  // 
		  this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		  this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.button2.Location = new System.Drawing.Point(96, 112);
		  this.button2.Name = "button2";
		  this.button2.Size = new System.Drawing.Size(56, 24);
		  this.button2.TabIndex = 4;
		  this.button2.Text = "Cancel";
		  // 
		  // decimal_UpDown1
		  // 
		  this.decimal_UpDown1.Location = new System.Drawing.Point(96, 24);
		  this.decimal_UpDown1.Maximum = new System.Decimal(new int[] {
																		255,
																		0,
																		0,
																		0});
		  this.decimal_UpDown1.Name = "decimal_UpDown1";
		  this.decimal_UpDown1.Size = new System.Drawing.Size(48, 20);
		  this.decimal_UpDown1.TabIndex = 0;
		  // 
		  // decimal_UpDown2
		  // 
		  this.decimal_UpDown2.Location = new System.Drawing.Point(96, 48);
		  this.decimal_UpDown2.Maximum = new System.Decimal(new int[] {
																		255,
																		0,
																		0,
																		0});
		  this.decimal_UpDown2.Name = "decimal_UpDown2";
		  this.decimal_UpDown2.Size = new System.Drawing.Size(48, 20);
		  this.decimal_UpDown2.TabIndex = 1;
		  // 
		  // decimal_UpDown3
		  // 
		  this.decimal_UpDown3.Location = new System.Drawing.Point(96, 72);
		  this.decimal_UpDown3.Maximum = new System.Decimal(new int[] {
																		255,
																		0,
																		0,
																		0});
		  this.decimal_UpDown3.Name = "decimal_UpDown3";
		  this.decimal_UpDown3.Size = new System.Drawing.Size(48, 20);
		  this.decimal_UpDown3.TabIndex = 2;
		  // 
		  // Form2
		  // 
		  this.AcceptButton = this.button1;
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.CancelButton = this.button2;
		  this.ClientSize = new System.Drawing.Size(176, 150);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.decimal_UpDown3,
																	  this.decimal_UpDown2,
																	  this.decimal_UpDown1,
																	  this.button2,
																	  this.button1,
																	  this.label3,
																	  this.label2,
																	  this.label1});
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form2";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		  this.Text = "Edit Colours";
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown1)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown2)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown3)).EndInit();
		  this.ResumeLayout(false);

		}
		#endregion

	}
}
