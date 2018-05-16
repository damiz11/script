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
	  private System.Windows.Forms.TextBox textBox1;
	  private System.Windows.Forms.Button button2;
	  private Salford.VisualClearWin.Decimal_UpDown decimal_UpDown1;
	  private Salford.VisualClearWin.List_Box list_Box1;
	  private System.Windows.Forms.Button button1;
	  private System.Windows.Forms.Label label1;
	  private Salford.VisualClearWin.Int32_Box int32_Box1;
	  private System.Windows.Forms.ToolTip toolTip1;
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
		  this.components = new System.ComponentModel.Container();
		  this.textBox1 = new System.Windows.Forms.TextBox();
		  this.button2 = new System.Windows.Forms.Button();
		  this.decimal_UpDown1 = new Salford.VisualClearWin.Decimal_UpDown();
		  this.list_Box1 = new Salford.VisualClearWin.List_Box();
		  this.button1 = new System.Windows.Forms.Button();
		  this.label1 = new System.Windows.Forms.Label();
		  this.int32_Box1 = new Salford.VisualClearWin.Int32_Box();
		  this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown1)).BeginInit();
		  this.SuspendLayout();
		  // 
		  // textBox1
		  // 
		  this.textBox1.Location = new System.Drawing.Point(88, 16);
		  this.textBox1.Name = "textBox1";
		  this.textBox1.Size = new System.Drawing.Size(80, 20);
		  this.textBox1.TabIndex = 0;
		  this.textBox1.Text = "";
		  this.toolTip1.SetToolTip(this.textBox1, "Item to insert.");
		  // 
		  // button2
		  // 
		  this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.button2.Location = new System.Drawing.Point(24, 224);
		  this.button2.Name = "button2";
		  this.button2.Size = new System.Drawing.Size(80, 24);
		  this.button2.TabIndex = 9;
		  this.button2.Text = "Insert";
		  // 
		  // decimal_UpDown1
		  // 
		  this.decimal_UpDown1.Location = new System.Drawing.Point(176, 16);
		  this.decimal_UpDown1.Maximum = new System.Decimal(new int[] {
																		1,
																		0,
																		0,
																		-2147483648});
		  this.decimal_UpDown1.Minimum = new System.Decimal(new int[] {
																		1,
																		0,
																		0,
																		-2147483648});
		  this.decimal_UpDown1.Name = "decimal_UpDown1";
		  this.decimal_UpDown1.Size = new System.Drawing.Size(32, 20);
		  this.decimal_UpDown1.TabIndex = 12;
		  this.toolTip1.SetToolTip(this.decimal_UpDown1, "Index of selected item.");
		  this.decimal_UpDown1.Value = new System.Decimal(new int[] {
																	  1,
																	  0,
																	  0,
																	  -2147483648});
		  // 
		  // list_Box1
		  // 
		  this.list_Box1.Location = new System.Drawing.Point(24, 48);
		  this.list_Box1.Name = "list_Box1";
		  this.list_Box1.Size = new System.Drawing.Size(216, 160);
		  this.list_Box1.Sorted = true;
		  this.list_Box1.TabIndex = 13;
		  this.list_Box1.Val = -1;
		  // 
		  // button1
		  // 
		  this.button1.Enabled = false;
		  this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  this.button1.Location = new System.Drawing.Point(160, 224);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(80, 24);
		  this.button1.TabIndex = 14;
		  this.button1.Text = "Remove";
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(24, 20);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(56, 16);
		  this.label1.TabIndex = 16;
		  this.label1.Text = "New Item";
		  // 
		  // int32_Box1
		  // 
		  this.int32_Box1.Location = new System.Drawing.Point(224, 16);
		  this.int32_Box1.Maximum = 2147483647;
		  this.int32_Box1.Minimum = -2147483648;
		  this.int32_Box1.Name = "int32_Box1";
		  this.int32_Box1.ReadOnly = true;
		  this.int32_Box1.Size = new System.Drawing.Size(16, 20);
		  this.int32_Box1.TabIndex = 17;
		  this.int32_Box1.Text = "";
		  this.toolTip1.SetToolTip(this.int32_Box1, "Index of last item inserted.");
		  // 
		  // Form1
		  // 
		  this.AcceptButton = this.button2;
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(266, 264);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.int32_Box1,
																	  this.label1,
																	  this.button1,
																	  this.list_Box1,
																	  this.decimal_UpDown1,
																	  this.button2,
																	  this.textBox1});
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "ListBox";
		  ((System.ComponentModel.ISupportInitialize)(this.decimal_UpDown1)).EndInit();
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
