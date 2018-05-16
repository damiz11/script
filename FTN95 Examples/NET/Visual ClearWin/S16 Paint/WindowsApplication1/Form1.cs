using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Resources7
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private Salford.VisualClearWin.Drawing_Panel drawingPanel1;
	  private Salford.VisualClearWin.Color_Picker color_Picker1;
	  private System.Windows.Forms.ToolBar toolBar1;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.ToolBarButton toolBarButton1;
	  private System.Windows.Forms.ToolBarButton toolBarButton2;
	  private System.Windows.Forms.ToolBarButton toolBarButton3;
	  private System.Windows.Forms.ToolBarButton toolBarButton4;
	  private System.Windows.Forms.ToolBarButton toolBarButton5;
	  private System.Windows.Forms.ToolBarButton toolBarButton6;
	  private System.Windows.Forms.ToolBarButton toolBarButton7;
	  private System.Windows.Forms.ToolTip toolTip1;
	  private System.Windows.Forms.ToolBarButton toolBarButton8;
	  private System.Windows.Forms.ToolBarButton toolBarButton9;
	  private System.Windows.Forms.ToolBarButton toolBarButton10;
	  private System.Windows.Forms.ToolBarButton toolBarButton11;
	  private System.Windows.Forms.ContextMenu contextMenu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem2;
	  private System.Windows.Forms.MenuItem menuItem3;
	  private System.Windows.Forms.MenuItem menuItem4;
	  private System.Windows.Forms.ContextMenu contextMenu2;
	  private System.Windows.Forms.MenuItem menuItem10;
	  private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	  private System.Windows.Forms.OpenFileDialog openFileDialog1;
	  private System.Windows.Forms.ToolBarButton toolBarButton19_DrawingDelete;
	  private System.Windows.Forms.MenuItem menuItem8_DrawingDelete;
	  private System.Windows.Forms.MenuItem menuItem11_DrawingCopyTo;
	  private System.Windows.Forms.MenuItem menuItem12_DrawingPasteFrom;
	  private System.Windows.Forms.StatusBar statusBar1;
	  private System.Windows.Forms.MainMenu mainMenu1;
	  private System.Windows.Forms.MenuItem menuItem8;
	  private System.Windows.Forms.MenuItem menuItem9_New;
	  private System.Windows.Forms.MenuItem menuItem11_Open;
	  private System.Windows.Forms.MenuItem menuItem12_Save;
	  private System.Windows.Forms.MenuItem menuItem13_SaveAs;
	  private System.Windows.Forms.MenuItem menuItem14;
	  private System.Windows.Forms.MenuItem menuItem15_Exit;
	  private System.Windows.Forms.PrintDialog printDialog1;
	  private System.Drawing.Printing.PrintDocument printDocument1;
	  private System.Windows.Forms.MenuItem menuItem11_Print;
	  private System.Windows.Forms.MenuItem menuItem11;
	  private System.Windows.Forms.StatusBarPanel statusBarPanel1;
	  private System.Windows.Forms.StatusBarPanel statusBarPanel2;
	  private System.Windows.Forms.ToolBarButton toolBarButton16_DrawingCut;
	  private System.Windows.Forms.ToolBarButton toolBarButton17_DrawingCopy;
	  private System.Windows.Forms.ToolBarButton toolBarButton18_DrawingPaste;
	  private System.Windows.Forms.MenuItem menuItem5_DrawingCut;
	  private System.Windows.Forms.MenuItem menuItem6_DrawingCopy;
	  private System.Windows.Forms.MenuItem menuItem7_DrawingPaste;
	  private System.Windows.Forms.MenuItem menuItem9_DrawingSelectAll;
	  private System.Windows.Forms.ToolBarButton toolBarButton0;
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
		  this.components = new System.ComponentModel.Container();
		  System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
		  this.drawingPanel1 = new Salford.VisualClearWin.Drawing_Panel();
		  this.color_Picker1 = new Salford.VisualClearWin.Color_Picker();
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton0 = new System.Windows.Forms.ToolBarButton();
		  this.contextMenu1 = new System.Windows.Forms.ContextMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem2 = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton16_DrawingCut = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton17_DrawingCopy = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton18_DrawingPaste = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton19_DrawingDelete = new System.Windows.Forms.ToolBarButton();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
		  this.contextMenu2 = new System.Windows.Forms.ContextMenu();
		  this.menuItem5_DrawingCut = new System.Windows.Forms.MenuItem();
		  this.menuItem6_DrawingCopy = new System.Windows.Forms.MenuItem();
		  this.menuItem7_DrawingPaste = new System.Windows.Forms.MenuItem();
		  this.menuItem8_DrawingDelete = new System.Windows.Forms.MenuItem();
		  this.menuItem9_DrawingSelectAll = new System.Windows.Forms.MenuItem();
		  this.menuItem10 = new System.Windows.Forms.MenuItem();
		  this.menuItem11_DrawingCopyTo = new System.Windows.Forms.MenuItem();
		  this.menuItem12_DrawingPasteFrom = new System.Windows.Forms.MenuItem();
		  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		  this.statusBar1 = new System.Windows.Forms.StatusBar();
		  this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
		  this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem8 = new System.Windows.Forms.MenuItem();
		  this.menuItem9_New = new System.Windows.Forms.MenuItem();
		  this.menuItem11_Open = new System.Windows.Forms.MenuItem();
		  this.menuItem12_Save = new System.Windows.Forms.MenuItem();
		  this.menuItem13_SaveAs = new System.Windows.Forms.MenuItem();
		  this.menuItem14 = new System.Windows.Forms.MenuItem();
		  this.menuItem11_Print = new System.Windows.Forms.MenuItem();
		  this.menuItem11 = new System.Windows.Forms.MenuItem();
		  this.menuItem15_Exit = new System.Windows.Forms.MenuItem();
		  this.printDialog1 = new System.Windows.Forms.PrintDialog();
		  this.printDocument1 = new System.Drawing.Printing.PrintDocument();
		  this.toolBar1.SuspendLayout();
		  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
		  this.SuspendLayout();
		  // 
		  // drawingPanel1
		  // 
		  this.drawingPanel1.BackColor = System.Drawing.Color.White;
		  this.drawingPanel1.BitmapSize = new System.Drawing.Size(800, 400);
		  this.drawingPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		  this.drawingPanel1.Cursor = System.Windows.Forms.Cursors.Cross;
		  this.drawingPanel1.FillColor = System.Drawing.Color.Red;
		  this.drawingPanel1.LineColor = System.Drawing.Color.Red;
		  this.drawingPanel1.Location = new System.Drawing.Point(3, 30);
		  this.drawingPanel1.Name = "drawingPanel1";
		  this.drawingPanel1.Pivoting = Salford.VisualClearWin.Pivot.Full;
		  this.drawingPanel1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		  this.drawingPanel1.Size = new System.Drawing.Size(604, 315);
		  this.drawingPanel1.StringColor = System.Drawing.Color.Black;
		  this.drawingPanel1.TabIndex = 0;
		  // 
		  // color_Picker1
		  // 
		  this.color_Picker1.ColorPanelLocation = new System.Drawing.Point(23, 3);
		  this.color_Picker1.ColorPanelShow = true;
		  this.color_Picker1.ColorPanelSize = new System.Drawing.Size(4, 17);
		  this.color_Picker1.Colour = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
		  this.color_Picker1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		  this.color_Picker1.Image = ((System.Drawing.Bitmap)(resources.GetObject("color_Picker1.Image")));
		  this.color_Picker1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.color_Picker1.Location = new System.Drawing.Point(180, 0);
		  this.color_Picker1.Name = "color_Picker1";
		  this.color_Picker1.Size = new System.Drawing.Size(32, 23);
		  this.color_Picker1.TabIndex = 10;
		  this.toolTip1.SetToolTip(this.color_Picker1, "Select the drawing colour");
		  this.color_Picker1.Value = -65536;
		  // 
		  // toolBar1
		  // 
		  this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
		  this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarButton0,
																					this.toolBarButton1,
																					this.toolBarButton2,
																					this.toolBarButton3,
																					this.toolBarButton4,
																					this.toolBarButton5,
																					this.toolBarButton6,
																					this.toolBarButton7,
																					this.toolBarButton8,
																					this.toolBarButton9,
																					this.toolBarButton10,
																					this.toolBarButton11,
																					this.toolBarButton16_DrawingCut,
																					this.toolBarButton17_DrawingCopy,
																					this.toolBarButton18_DrawingPaste,
																					this.toolBarButton19_DrawingDelete});
		  this.toolBar1.ButtonSize = new System.Drawing.Size(23, 22);
		  this.toolBar1.Controls.AddRange(new System.Windows.Forms.Control[] {
																			   this.color_Picker1});
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(608, 25);
		  this.toolBar1.TabIndex = 0;
		  // 
		  // toolBarButton0
		  // 
		  this.toolBarButton0.DropDownMenu = this.contextMenu1;
		  this.toolBarButton0.ImageIndex = 11;
		  this.toolBarButton0.Pushed = true;
		  this.toolBarButton0.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
		  this.toolBarButton0.ToolTipText = "Draw pixels";
		  // 
		  // contextMenu1
		  // 
		  this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem1,
																					 this.menuItem2,
																					 this.menuItem3,
																					 this.menuItem4});
		  // 
		  // menuItem1
		  // 
		  this.menuItem1.Checked = true;
		  this.menuItem1.Index = 0;
		  this.menuItem1.Text = "1 pixel";
		  // 
		  // menuItem2
		  // 
		  this.menuItem2.Index = 1;
		  this.menuItem2.Text = "2 pixels";
		  // 
		  // menuItem3
		  // 
		  this.menuItem3.Index = 2;
		  this.menuItem3.Text = "3 pixels";
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 3;
		  this.menuItem4.Text = "4 pixels";
		  // 
		  // toolBarButton1
		  // 
		  this.toolBarButton1.ImageIndex = 0;
		  this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
		  this.toolBarButton1.ToolTipText = "Draw line";
		  // 
		  // toolBarButton2
		  // 
		  this.toolBarButton2.ImageIndex = 1;
		  this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
		  this.toolBarButton2.ToolTipText = "Draw filled rectangle";
		  // 
		  // toolBarButton3
		  // 
		  this.toolBarButton3.ImageIndex = 2;
		  this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
		  this.toolBarButton3.ToolTipText = "Draw filled ellipse";
		  // 
		  // toolBarButton4
		  // 
		  this.toolBarButton4.ImageIndex = 3;
		  this.toolBarButton4.ToolTipText = "Draw rectangle";
		  // 
		  // toolBarButton5
		  // 
		  this.toolBarButton5.ImageIndex = 4;
		  this.toolBarButton5.ToolTipText = "Draw ellipse";
		  // 
		  // toolBarButton6
		  // 
		  this.toolBarButton6.ImageIndex = 6;
		  this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
		  this.toolBarButton6.ToolTipText = "Select a rectangle";
		  // 
		  // toolBarButton7
		  // 
		  this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton8
		  // 
		  this.toolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton9
		  // 
		  this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton10
		  // 
		  this.toolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton11
		  // 
		  this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton16_DrawingCut
		  // 
		  this.toolBarButton16_DrawingCut.ImageIndex = 7;
		  this.toolBarButton16_DrawingCut.ToolTipText = "Cut";
		  // 
		  // toolBarButton17_DrawingCopy
		  // 
		  this.toolBarButton17_DrawingCopy.ImageIndex = 8;
		  this.toolBarButton17_DrawingCopy.ToolTipText = "Copy";
		  // 
		  // toolBarButton18_DrawingPaste
		  // 
		  this.toolBarButton18_DrawingPaste.ImageIndex = 9;
		  this.toolBarButton18_DrawingPaste.ToolTipText = "Paste";
		  // 
		  // toolBarButton19_DrawingDelete
		  // 
		  this.toolBarButton19_DrawingDelete.ImageIndex = 10;
		  this.toolBarButton19_DrawingDelete.ToolTipText = "Delete";
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.White;
		  // 
		  // contextMenu2
		  // 
		  this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem5_DrawingCut,
																					 this.menuItem6_DrawingCopy,
																					 this.menuItem7_DrawingPaste,
																					 this.menuItem8_DrawingDelete,
																					 this.menuItem9_DrawingSelectAll,
																					 this.menuItem10,
																					 this.menuItem11_DrawingCopyTo,
																					 this.menuItem12_DrawingPasteFrom});
		  // 
		  // menuItem5_DrawingCut
		  // 
		  this.menuItem5_DrawingCut.Index = 0;
		  this.menuItem5_DrawingCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
		  this.menuItem5_DrawingCut.Text = "Cut";
		  // 
		  // menuItem6_DrawingCopy
		  // 
		  this.menuItem6_DrawingCopy.Index = 1;
		  this.menuItem6_DrawingCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
		  this.menuItem6_DrawingCopy.Text = "Copy";
		  // 
		  // menuItem7_DrawingPaste
		  // 
		  this.menuItem7_DrawingPaste.Index = 2;
		  this.menuItem7_DrawingPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
		  this.menuItem7_DrawingPaste.Text = "Paste";
		  // 
		  // menuItem8_DrawingDelete
		  // 
		  this.menuItem8_DrawingDelete.Index = 3;
		  this.menuItem8_DrawingDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
		  this.menuItem8_DrawingDelete.Text = "Delete";
		  // 
		  // menuItem9_DrawingSelectAll
		  // 
		  this.menuItem9_DrawingSelectAll.Index = 4;
		  this.menuItem9_DrawingSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
		  this.menuItem9_DrawingSelectAll.Text = "Select All";
		  // 
		  // menuItem10
		  // 
		  this.menuItem10.Index = 5;
		  this.menuItem10.Text = "-";
		  // 
		  // menuItem11_DrawingCopyTo
		  // 
		  this.menuItem11_DrawingCopyTo.Index = 6;
		  this.menuItem11_DrawingCopyTo.Text = "Copy To";
		  // 
		  // menuItem12_DrawingPasteFrom
		  // 
		  this.menuItem12_DrawingPasteFrom.Index = 7;
		  this.menuItem12_DrawingPasteFrom.Text = "Paste From";
		  // 
		  // saveFileDialog1
		  // 
		  this.saveFileDialog1.DefaultExt = "bmp";
		  this.saveFileDialog1.Filter = "Bitmap files|*.bmp|All files|*.*";
		  this.saveFileDialog1.Title = "Copy To";
		  // 
		  // openFileDialog1
		  // 
		  this.openFileDialog1.DefaultExt = "bmp";
		  this.openFileDialog1.Filter = "Bitmap files|*.bmp|All files|*.*";
		  this.openFileDialog1.Title = "Paste From";
		  // 
		  // statusBar1
		  // 
		  this.statusBar1.Location = new System.Drawing.Point(0, 347);
		  this.statusBar1.Name = "statusBar1";
		  this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					  this.statusBarPanel1,
																					  this.statusBarPanel2});
		  this.statusBar1.ShowPanels = true;
		  this.statusBar1.Size = new System.Drawing.Size(608, 24);
		  this.statusBar1.TabIndex = 0;
		  // 
		  // statusBarPanel1
		  // 
		  this.statusBarPanel1.Width = 400;
		  // 
		  // statusBarPanel2
		  // 
		  this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
		  this.statusBarPanel2.Text = "(0,0)";
		  this.statusBarPanel2.Width = 192;
		  // 
		  // mainMenu1
		  // 
		  this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem8});
		  // 
		  // menuItem8
		  // 
		  this.menuItem8.Index = 0;
		  this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem9_New,
																				  this.menuItem11_Open,
																				  this.menuItem12_Save,
																				  this.menuItem13_SaveAs,
																				  this.menuItem14,
																				  this.menuItem11_Print,
																				  this.menuItem11,
																				  this.menuItem15_Exit});
		  this.menuItem8.Text = "File";
		  // 
		  // menuItem9_New
		  // 
		  this.menuItem9_New.Index = 0;
		  this.menuItem9_New.Text = "New";
		  // 
		  // menuItem11_Open
		  // 
		  this.menuItem11_Open.Index = 1;
		  this.menuItem11_Open.Text = "Open";
		  // 
		  // menuItem12_Save
		  // 
		  this.menuItem12_Save.Index = 2;
		  this.menuItem12_Save.Text = "Save";
		  // 
		  // menuItem13_SaveAs
		  // 
		  this.menuItem13_SaveAs.Index = 3;
		  this.menuItem13_SaveAs.Text = "Save As";
		  // 
		  // menuItem14
		  // 
		  this.menuItem14.Index = 4;
		  this.menuItem14.Text = "-";
		  // 
		  // menuItem11_Print
		  // 
		  this.menuItem11_Print.Index = 5;
		  this.menuItem11_Print.Text = "Print";
		  // 
		  // menuItem11
		  // 
		  this.menuItem11.Index = 6;
		  this.menuItem11.Text = "-";
		  // 
		  // menuItem15_Exit
		  // 
		  this.menuItem15_Exit.Index = 7;
		  this.menuItem15_Exit.Text = "Exit";
		  // 
		  // printDialog1
		  // 
		  this.printDialog1.Document = this.printDocument1;
		  // 
		  // Form1
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(608, 371);
		  this.ContextMenu = this.contextMenu2;
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.statusBar1,
																	  this.toolBar1,
																	  this.drawingPanel1});
		  this.Menu = this.mainMenu1;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Paint";
		  this.toolBar1.ResumeLayout(false);
		  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
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
