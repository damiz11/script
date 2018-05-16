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
	  private Salford.VisualClearWin.Tree_View tree_View1;
	  private System.Windows.Forms.Splitter splitter1;
	  private System.Windows.Forms.ImageList imageList1;
	  private Salford.VisualClearWin.Explorer_Box explorer_Box1;
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
		  System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
		  this.tree_View1 = new Salford.VisualClearWin.Tree_View();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.splitter1 = new System.Windows.Forms.Splitter();
		  this.explorer_Box1 = new Salford.VisualClearWin.Explorer_Box();
		  this.SuspendLayout();
		  // 
		  // tree_View1
		  // 
		  this.tree_View1.Dock = System.Windows.Forms.DockStyle.Left;
		  this.tree_View1.HideSelection = false;
		  this.tree_View1.ImageIndex = 2;
		  this.tree_View1.ImageList = this.imageList1;
		  this.tree_View1.Location = new System.Drawing.Point(0, 0);
		  this.tree_View1.Name = "tree_View1";
		  this.tree_View1.SelectedImageIndex = 2;
		  this.tree_View1.Size = new System.Drawing.Size(208, 446);
		  this.tree_View1.TabIndex = 0;
		  // 
		  // imageList1
		  // 
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // splitter1
		  // 
		  this.splitter1.Location = new System.Drawing.Point(208, 0);
		  this.splitter1.Name = "splitter1";
		  this.splitter1.Size = new System.Drawing.Size(4, 446);
		  this.splitter1.TabIndex = 1;
		  this.splitter1.TabStop = false;
		  // 
		  // explorer_Box1
		  // 
		  this.explorer_Box1.Dock = System.Windows.Forms.DockStyle.Fill;
		  this.explorer_Box1.Location = new System.Drawing.Point(212, 0);
		  this.explorer_Box1.Name = "explorer_Box1";
		  this.explorer_Box1.Size = new System.Drawing.Size(532, 446);
		  this.explorer_Box1.TabIndex = 2;
		  this.explorer_Box1.URL = "mk:@MSITStore:vcw.chm::/s0.htm";
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(744, 446);
		  this.Controls.Add(this.explorer_Box1);
		  this.Controls.Add(this.splitter1);
		  this.Controls.Add(this.tree_View1);
		  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Visual ClearWin";
		  this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
