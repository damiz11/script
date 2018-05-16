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
	  private Salford.VisualClearWin.Int32_Box int32_Box1;
	  private Salford.VisualClearWin.Double_Box double_Box1;
	  private System.Windows.Forms.Label label1;
	  private System.Windows.Forms.Label label2;
	  private Salford.VisualClearWin.Text_Box text_Box1;
	  private System.Windows.Forms.Label label3;
	  private System.Windows.Forms.Label label5;
	  private Salford.VisualClearWin.Int32_Box int32_Box3;
	  private System.Windows.Forms.GroupBox groupBox1;
	  private System.Windows.Forms.Label label6;
	  private Salford.VisualClearWin.Text_Box text_Box2;
	  private Salford.VisualClearWin.Check_Box check_Box1;
	  private Salford.VisualClearWin.Int32_Box int32_Box2;
	  private Salford.VisualClearWin.Int32_Box int32_Box4;
	  private System.Windows.Forms.Label label4;
	  private System.Windows.Forms.TextBox textBox1;
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
		  this.int32_Box1 = new Salford.VisualClearWin.Int32_Box();
		  this.double_Box1 = new Salford.VisualClearWin.Double_Box();
		  this.label1 = new System.Windows.Forms.Label();
		  this.label2 = new System.Windows.Forms.Label();
		  this.text_Box1 = new Salford.VisualClearWin.Text_Box();
		  this.label3 = new System.Windows.Forms.Label();
		  this.label5 = new System.Windows.Forms.Label();
		  this.int32_Box3 = new Salford.VisualClearWin.Int32_Box();
		  this.groupBox1 = new System.Windows.Forms.GroupBox();
		  this.textBox1 = new System.Windows.Forms.TextBox();
		  this.check_Box1 = new Salford.VisualClearWin.Check_Box();
		  this.label6 = new System.Windows.Forms.Label();
		  this.text_Box2 = new Salford.VisualClearWin.Text_Box();
		  this.int32_Box2 = new Salford.VisualClearWin.Int32_Box();
		  this.int32_Box4 = new Salford.VisualClearWin.Int32_Box();
		  this.label4 = new System.Windows.Forms.Label();
		  this.groupBox1.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // property_Grid1
		  // 
		  this.property_Grid1.CommandsVisibleIfAvailable = true;
		  this.property_Grid1.GridAttributes = new string[] {
															  "Integer|System.Int32|Numbers|Help for integer",
															  "Double|System.Double|Numbers|Help for double",
															  "String|System.String|Attributes|Help for string",
															  "Logical|System.Boolean|Attributes|Help for logical",
															  "Colour|System.Drawing.Color|Attributes|Help for colour",
															  "Font|System.Drawing.Font|Attributes|Help for font",
															  "Point|System.Drawing.Point|Attributes|Help for point|10,20"};
		  this.property_Grid1.LargeButtons = false;
		  this.property_Grid1.LineColor = System.Drawing.SystemColors.ScrollBar;
		  this.property_Grid1.Location = new System.Drawing.Point(16, 16);
		  this.property_Grid1.Name = "property_Grid1";
		  this.property_Grid1.Size = new System.Drawing.Size(272, 264);
		  this.property_Grid1.TabIndex = 0;
		  this.property_Grid1.Text = "property_Grid1";
		  this.property_Grid1.ViewBackColor = System.Drawing.SystemColors.Window;
		  this.property_Grid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
		  // 
		  // int32_Box1
		  // 
		  this.int32_Box1.Location = new System.Drawing.Point(416, 64);
		  this.int32_Box1.Maximum = 2147483647;
		  this.int32_Box1.Minimum = -2147483648;
		  this.int32_Box1.Name = "int32_Box1";
		  this.int32_Box1.Size = new System.Drawing.Size(72, 20);
		  this.int32_Box1.TabIndex = 1;
		  this.int32_Box1.Text = "";
		  // 
		  // double_Box1
		  // 
		  this.double_Box1.ExpFigs = 2;
		  this.double_Box1.Location = new System.Drawing.Point(416, 96);
//		  this.double_Box1.Maximum = 1E+60;
//		  this.double_Box1.Minimum = 1E+60;
		  this.double_Box1.Name = "double_Box1";
		  this.double_Box1.Size = new System.Drawing.Size(72, 20);
		  this.double_Box1.TabIndex = 2;
		  this.double_Box1.Text = "0";
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(352, 70);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(48, 14);
		  this.label1.TabIndex = 3;
		  this.label1.Text = "Integer";
		  // 
		  // label2
		  // 
		  this.label2.Location = new System.Drawing.Point(352, 101);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(48, 14);
		  this.label2.TabIndex = 4;
		  this.label2.Text = "Double";
		  // 
		  // text_Box1
		  // 
		  this.text_Box1.Location = new System.Drawing.Point(416, 128);
		  this.text_Box1.Name = "text_Box1";
		  this.text_Box1.Size = new System.Drawing.Size(112, 20);
		  this.text_Box1.TabIndex = 5;
		  this.text_Box1.Text = "";
		  // 
		  // label3
		  // 
		  this.label3.Location = new System.Drawing.Point(352, 133);
		  this.label3.Name = "label3";
		  this.label3.Size = new System.Drawing.Size(48, 14);
		  this.label3.TabIndex = 6;
		  this.label3.Text = "String";
		  // 
		  // label5
		  // 
		  this.label5.Location = new System.Drawing.Point(352, 188);
		  this.label5.Name = "label5";
		  this.label5.Size = new System.Drawing.Size(48, 16);
		  this.label5.TabIndex = 10;
		  this.label5.Text = "Colour";
		  // 
		  // int32_Box3
		  // 
		  this.int32_Box3.Digits = 3;
		  this.int32_Box3.Location = new System.Drawing.Point(464, 184);
		  this.int32_Box3.Maximum = 255;
		  this.int32_Box3.Minimum = -999;
		  this.int32_Box3.Name = "int32_Box3";
		  this.int32_Box3.Size = new System.Drawing.Size(32, 20);
		  this.int32_Box3.TabIndex = 9;
		  this.int32_Box3.Text = "255";
		  this.int32_Box3.Value = 255;
		  // 
		  // groupBox1
		  // 
		  this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				this.textBox1,
																				this.check_Box1});
		  this.groupBox1.Location = new System.Drawing.Point(336, 48);
		  this.groupBox1.Name = "groupBox1";
		  this.groupBox1.Size = new System.Drawing.Size(256, 232);
		  this.groupBox1.TabIndex = 11;
		  this.groupBox1.TabStop = false;
		  // 
		  // textBox1
		  // 
		  this.textBox1.Enabled = false;
		  this.textBox1.Location = new System.Drawing.Point(80, 200);
		  this.textBox1.Name = "textBox1";
		  this.textBox1.ReadOnly = true;
		  this.textBox1.Size = new System.Drawing.Size(160, 20);
		  this.textBox1.TabIndex = 1;
		  this.textBox1.Text = "";
		  // 
		  // check_Box1
		  // 
		  this.check_Box1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
		  this.check_Box1.Location = new System.Drawing.Point(16, 112);
		  this.check_Box1.Name = "check_Box1";
		  this.check_Box1.Size = new System.Drawing.Size(78, 16);
		  this.check_Box1.TabIndex = 0;
		  this.check_Box1.Text = "Logical";
		  // 
		  // label6
		  // 
		  this.label6.Location = new System.Drawing.Point(352, 220);
		  this.label6.Name = "label6";
		  this.label6.Size = new System.Drawing.Size(48, 13);
		  this.label6.TabIndex = 13;
		  this.label6.Text = "Font";
		  // 
		  // text_Box2
		  // 
		  this.text_Box2.Location = new System.Drawing.Point(416, 216);
		  this.text_Box2.Name = "text_Box2";
		  this.text_Box2.Size = new System.Drawing.Size(160, 20);
		  this.text_Box2.TabIndex = 12;
		  this.text_Box2.Text = "";
		  // 
		  // int32_Box2
		  // 
		  this.int32_Box2.Digits = 3;
		  this.int32_Box2.Location = new System.Drawing.Point(416, 184);
		  this.int32_Box2.Maximum = 255;
		  this.int32_Box2.Minimum = -999;
		  this.int32_Box2.Name = "int32_Box2";
		  this.int32_Box2.Size = new System.Drawing.Size(32, 20);
		  this.int32_Box2.TabIndex = 14;
		  this.int32_Box2.Text = "0";
		  // 
		  // int32_Box4
		  // 
		  this.int32_Box4.Digits = 3;
		  this.int32_Box4.Location = new System.Drawing.Point(512, 184);
		  this.int32_Box4.Maximum = 255;
		  this.int32_Box4.Minimum = -999;
		  this.int32_Box4.Name = "int32_Box4";
		  this.int32_Box4.Size = new System.Drawing.Size(32, 20);
		  this.int32_Box4.TabIndex = 15;
		  this.int32_Box4.Text = "0";
		  // 
		  // label4
		  // 
		  this.label4.Location = new System.Drawing.Point(352, 252);
		  this.label4.Name = "label4";
		  this.label4.Size = new System.Drawing.Size(48, 13);
		  this.label4.TabIndex = 16;
		  this.label4.Text = "Size";
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(618, 304);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.label4,
																	  this.int32_Box4,
																	  this.int32_Box2,
																	  this.label3,
																	  this.label6,
																	  this.text_Box2,
																	  this.label5,
																	  this.int32_Box3,
																	  this.text_Box1,
																	  this.label2,
																	  this.label1,
																	  this.double_Box1,
																	  this.int32_Box1,
																	  this.property_Grid1,
																	  this.groupBox1});
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Property Grid";
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

	}
}
