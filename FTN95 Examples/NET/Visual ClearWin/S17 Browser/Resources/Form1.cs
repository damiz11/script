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
	  private System.Windows.Forms.Label label1;
	  private Salford.VisualClearWin.Combo_Box combo_Box1;
	  private System.Windows.Forms.Button button1;
      private System.ComponentModel.IContainer components=null;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.ToolBar toolBar1;
	  private System.Windows.Forms.StatusBar statusBar1;
	  private System.Windows.Forms.ToolBarButton toolBarButton1_GoBack;
	  private System.Windows.Forms.ToolBarButton toolBarButton2_GoForward;
	  private System.Windows.Forms.ToolBarButton toolBarButton4_Refresh;
	  private System.Windows.Forms.ToolBarButton toolBarButton5_WebPrint;
	  private System.Windows.Forms.ToolBarButton toolBarButton3_StopDownload;
	  private Salford.VisualClearWin.Explorer_Box explorer_Box1;

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
		  this.label1 = new System.Windows.Forms.Label();
		  this.combo_Box1 = new Salford.VisualClearWin.Combo_Box();
		  this.button1 = new System.Windows.Forms.Button();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton1_GoBack = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton2_GoForward = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton3_StopDownload = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton4_Refresh = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton5_WebPrint = new System.Windows.Forms.ToolBarButton();
		  this.statusBar1 = new System.Windows.Forms.StatusBar();
		  this.explorer_Box1 = new Salford.VisualClearWin.Explorer_Box();
		  this.SuspendLayout();
		  // 
		  // label1
		  // 
		  this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
		  this.label1.Location = new System.Drawing.Point(12, 32);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(46, 19);
		  this.label1.TabIndex = 0;
		  this.label1.Text = "Address";
		  this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  // 
		  // combo_Box1
		  // 
		  this.combo_Box1.Location = new System.Drawing.Point(65, 32);
		  this.combo_Box1.Name = "combo_Box1";
		  this.combo_Box1.Persists = true;
		  this.combo_Box1.Pivoting = Salford.VisualClearWin.Pivot.Horizontal;
		  this.combo_Box1.Size = new System.Drawing.Size(564, 21);
		  this.combo_Box1.TabIndex = 1;
		  // 
		  // button1
		  // 
		  this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
		  this.button1.Image = ((System.Drawing.Bitmap)(resources.GetObject("button1.Image")));
		  this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.button1.Location = new System.Drawing.Point(633, 32);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(48, 25);
		  this.button1.TabIndex = 5;
		  this.button1.Text = "Go";
		  this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // toolBar1
		  // 
		  this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
		  this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarButton1_GoBack,
																					this.toolBarButton2_GoForward,
																					this.toolBarButton3_StopDownload,
																					this.toolBarButton4_Refresh,
																					this.toolBarButton5_WebPrint});
		  this.toolBar1.ButtonSize = new System.Drawing.Size(30, 30);
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(688, 25);
		  this.toolBar1.TabIndex = 7;
		  this.toolBar1.Wrappable = false;
		  // 
		  // toolBarButton1_GoBack
		  // 
		  this.toolBarButton1_GoBack.ImageIndex = 0;
		  this.toolBarButton1_GoBack.ToolTipText = "Back";
		  // 
		  // toolBarButton2_GoForward
		  // 
		  this.toolBarButton2_GoForward.ImageIndex = 1;
		  this.toolBarButton2_GoForward.ToolTipText = "Forward";
		  // 
		  // toolBarButton3_StopDownload
		  // 
		  this.toolBarButton3_StopDownload.ImageIndex = 2;
		  this.toolBarButton3_StopDownload.ToolTipText = "Stop";
		  // 
		  // toolBarButton4_Refresh
		  // 
		  this.toolBarButton4_Refresh.ImageIndex = 3;
		  this.toolBarButton4_Refresh.ToolTipText = "Refresh";
		  // 
		  // toolBarButton5_WebPrint
		  // 
		  this.toolBarButton5_WebPrint.ImageIndex = 4;
		  this.toolBarButton5_WebPrint.ToolTipText = "Print";
		  // 
		  // statusBar1
		  // 
		  this.statusBar1.Location = new System.Drawing.Point(0, 446);
		  this.statusBar1.Name = "statusBar1";
		  this.statusBar1.Size = new System.Drawing.Size(688, 16);
		  this.statusBar1.TabIndex = 8;
		  // 
		  // explorer_Box1
		  // 
		  this.explorer_Box1.Location = new System.Drawing.Point(0, 56);
		  this.explorer_Box1.Name = "explorer_Box1";
		  this.explorer_Box1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.explorer_Box1.Size = new System.Drawing.Size(688, 385);
		  this.explorer_Box1.TabIndex = 9;
		  // 
		  // Form1
		  // 
		  this.AcceptButton = this.button1;
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(688, 462);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.explorer_Box1,
																	  this.statusBar1,
																	  this.toolBar1,
																	  this.label1,
																	  this.combo_Box1,
																	  this.button1});
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Visual ClearWin Browser";
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
