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
	  private Salford.VisualClearWin.Property_Grid property_Grid1;
	  private Salford.VisualClearWin.Drawing_Panel drawing_Panel1;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown1;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown2;
	  private System.Windows.Forms.Label label1;
	  private System.Windows.Forms.Label label2;
	  private System.Windows.Forms.Label label3;
	  private System.Windows.Forms.Label label4;
	  private System.Windows.Forms.GroupBox groupBox1;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown4;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown3;
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
		  this.property_Grid1 = new Salford.VisualClearWin.Property_Grid();
		  this.drawing_Panel1 = new Salford.VisualClearWin.Drawing_Panel();
		  this.decimal_UpDown1 = new Salford.VisualClearWin.Decimal_UpDown();
		  this.decimal_UpDown2 = new Salford.VisualClearWin.Decimal_UpDown();
		  this.label1 = new System.Windows.Forms.Label();
		  this.label2 = new System.Windows.Forms.Label();
		  this.label3 = new System.Windows.Forms.Label();
		  this.label4 = new System.Windows.Forms.Label();
		  this.groupBox1 = new System.Windows.Forms.GroupBox();
		  this.decimal_UpDown4 = new Salford.VisualClearWin.Decimal_UpDown();
		  this.decimal_UpDown3 = new Salford.VisualClearWin.Decimal_UpDown();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown1)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown2)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown4)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown3)).BeginInit();
		  this.SuspendLayout();
		  // 
		  // property_Grid1
		  // 
		  this.property_Grid1.CommandsVisibleIfAvailable = true;
		  this.property_Grid1.GridAttributes = new string[] {
															  "Title|System.String|Attributes|The title",
															  "Filled|System.Boolean|Attributes|True if the figured is filled",
															  "Colour|System.Drawing.Color|Attributes|The colour of the figure",
															  "Font|System.Drawing.Font|Attributes|The font for the title"};
		  this.property_Grid1.LargeButtons = false;
		  this.property_Grid1.LineColor = System.Drawing.SystemColors.ScrollBar;
		  this.property_Grid1.Location = new System.Drawing.Point(16, 16);
		  this.property_Grid1.Name = "property_Grid1";
		  this.property_Grid1.Size = new System.Drawing.Size(256, 184);
		  this.property_Grid1.TabIndex = 0;
		  this.property_Grid1.Text = "property_Grid1";
		  this.property_Grid1.ViewBackColor = System.Drawing.SystemColors.Window;
		  this.property_Grid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
		  // 
		  // drawing_Panel1
		  // 
		  this.drawing_Panel1.BackColor = System.Drawing.SystemColors.Window;
		  this.drawing_Panel1.BitmapSize = new System.Drawing.Size(0, 0);
		  this.drawing_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		  this.drawing_Panel1.FillColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.LineColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.Location = new System.Drawing.Point(285, 16);
		  this.drawing_Panel1.Name = "drawing_Panel1";
		  this.drawing_Panel1.Size = new System.Drawing.Size(272, 266);
		  this.drawing_Panel1.StringColor = System.Drawing.Color.Black;
		  this.drawing_Panel1.TabIndex = 1;
		  // 
		  // decimal_UpDown1
		  // 
		  this.decimal_UpDown1.Increment = new System.Decimal(new int[] {
																		  5,
																		  0,
																		  0,
																		  0});
		  this.decimal_UpDown1.Location = new System.Drawing.Point(56, 221);
		  this.decimal_UpDown1.Maximum = new System.Decimal(new int[] {
																		400,
																		0,
																		0,
																		0});
		  this.decimal_UpDown1.Name = "decimal_UpDown1";
		  this.decimal_UpDown1.Size = new System.Drawing.Size(48, 20);
		  this.decimal_UpDown1.TabIndex = 2;
		  this.decimal_UpDown1.Value = new System.Decimal(new int[] {
																	  40,
																	  0,
																	  0,
																	  0});
		  // 
		  // decimal_UpDown2
		  // 
		  this.decimal_UpDown2.Increment = new System.Decimal(new int[] {
																		  5,
																		  0,
																		  0,
																		  0});
		  this.decimal_UpDown2.Location = new System.Drawing.Point(56, 253);
		  this.decimal_UpDown2.Maximum = new System.Decimal(new int[] {
																		400,
																		0,
																		0,
																		0});
		  this.decimal_UpDown2.Name = "decimal_UpDown2";
		  this.decimal_UpDown2.Size = new System.Drawing.Size(48, 20);
		  this.decimal_UpDown2.TabIndex = 3;
		  this.decimal_UpDown2.Value = new System.Decimal(new int[] {
																	  80,
																	  0,
																	  0,
																	  0});
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(32, 229);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(16, 16);
		  this.label1.TabIndex = 6;
		  this.label1.Text = "x:";
		  // 
		  // label2
		  // 
		  this.label2.Location = new System.Drawing.Point(32, 253);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(16, 16);
		  this.label2.TabIndex = 7;
		  this.label2.Text = "y:";
		  // 
		  // label3
		  // 
		  this.label3.Location = new System.Drawing.Point(144, 229);
		  this.label3.Name = "label3";
		  this.label3.Size = new System.Drawing.Size(40, 16);
		  this.label3.TabIndex = 8;
		  this.label3.Text = "Width:";
		  // 
		  // label4
		  // 
		  this.label4.Location = new System.Drawing.Point(144, 253);
		  this.label4.Name = "label4";
		  this.label4.Size = new System.Drawing.Size(40, 16);
		  this.label4.TabIndex = 9;
		  this.label4.Text = "Height:";
		  // 
		  // groupBox1
		  // 
		  this.groupBox1.Location = new System.Drawing.Point(16, 205);
		  this.groupBox1.Name = "groupBox1";
		  this.groupBox1.Size = new System.Drawing.Size(256, 78);
		  this.groupBox1.TabIndex = 10;
		  this.groupBox1.TabStop = false;
		  // 
		  // decimal_UpDown4
		  // 
		  this.decimal_UpDown4.Increment = new System.Decimal(new int[] {
																		  5,
																		  0,
																		  0,
																		  0});
		  this.decimal_UpDown4.Location = new System.Drawing.Point(192, 253);
		  this.decimal_UpDown4.Maximum = new System.Decimal(new int[] {
																		400,
																		0,
																		0,
																		0});
		  this.decimal_UpDown4.Name = "decimal_UpDown4";
		  this.decimal_UpDown4.Size = new System.Drawing.Size(48, 20);
		  this.decimal_UpDown4.TabIndex = 5;
		  this.decimal_UpDown4.Value = new System.Decimal(new int[] {
																	  100,
																	  0,
																	  0,
																	  0});
		  // 
		  // decimal_UpDown3
		  // 
		  this.decimal_UpDown3.Increment = new System.Decimal(new int[] {
																		  5,
																		  0,
																		  0,
																		  0});
		  this.decimal_UpDown3.Location = new System.Drawing.Point(192, 221);
		  this.decimal_UpDown3.Maximum = new System.Decimal(new int[] {
																		400,
																		0,
																		0,
																		0});
		  this.decimal_UpDown3.Name = "decimal_UpDown3";
		  this.decimal_UpDown3.Size = new System.Drawing.Size(48, 20);
		  this.decimal_UpDown3.TabIndex = 4;
		  this.decimal_UpDown3.Value = new System.Decimal(new int[] {
																	  200,
																	  0,
																	  0,
																	  0});
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(574, 296);
		  this.Controls.Add(this.label4);
		  this.Controls.Add(this.label3);
		  this.Controls.Add(this.label2);
		  this.Controls.Add(this.label1);
		  this.Controls.Add(this.decimal_UpDown4);
		  this.Controls.Add(this.decimal_UpDown3);
		  this.Controls.Add(this.decimal_UpDown2);
		  this.Controls.Add(this.decimal_UpDown1);
		  this.Controls.Add(this.drawing_Panel1);
		  this.Controls.Add(this.property_Grid1);
		  this.Controls.Add(this.groupBox1);
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Property Grid";
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown1)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown2)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown4)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown3)).EndInit();
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
