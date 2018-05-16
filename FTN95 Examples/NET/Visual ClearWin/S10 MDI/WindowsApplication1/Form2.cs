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
	  private System.Windows.Forms.PrintDialog printDialog1;
	  private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	  private System.Windows.Forms.MainMenu mainMenu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.MenuItem menuItem2;
	  private System.Windows.Forms.MenuItem menuItem17;
	  private System.Windows.Forms.MenuItem menuItem11;
	  private System.Windows.Forms.MenuItem menuItem12;
	  private System.Windows.Forms.MenuItem menuItem6;
	  private System.Windows.Forms.MenuItem menuItem15;
	  private System.Drawing.Printing.PrintDocument printDocument1;
	  private System.Windows.Forms.MenuItem menuItem18;
	  private System.Windows.Forms.MenuItem menuItem21;
	  private System.Windows.Forms.MenuItem menuItem26;
	  private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
	  private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
	  private System.Windows.Forms.MenuItem menuItem30;
	  private System.Windows.Forms.MenuItem menuItem31;
	  private System.Windows.Forms.MenuItem menuItem32;
	  private System.Windows.Forms.FontDialog fontDialog1;
	  private Salford.VisualClearWin.Text_Box text_Box1;
	  private System.Windows.Forms.ImageList imageList1;
	  private System.Windows.Forms.ToolBar toolBar1;
	  private System.Windows.Forms.ToolBarButton toolBarButton1;
	  private System.Windows.Forms.ToolBarButton toolBarButton2__Open;
	  private System.Windows.Forms.ContextMenu contextMenu1;
	  private System.Windows.Forms.MenuItem menuItem4;
	  private System.Windows.Forms.MenuItem menuItem3;
	  private System.Windows.Forms.MenuItem menuItem13_Open;
	  private System.Windows.Forms.MenuItem menuItem8_Close;
	  private System.Windows.Forms.MenuItem menuItem10_Save;
	  private System.Windows.Forms.MenuItem menuItem9_SaveAs;
	  private System.Windows.Forms.MenuItem menuItem29_PageSetup;
	  private System.Windows.Forms.MenuItem menuItem28_PrintPreview;
	  private System.Windows.Forms.MenuItem menuItem7_Print;
	  private System.Windows.Forms.MenuItem menuItem16_Exit;
	  private System.Windows.Forms.MenuItem menuItem19_Undo;
	  private System.Windows.Forms.MenuItem menuItem20_Redo;
	  private System.Windows.Forms.MenuItem menuItem22_Cut;
	  private System.Windows.Forms.MenuItem menuItem23_Copy;
	  private System.Windows.Forms.MenuItem menuItem24_Paste;
	  private System.Windows.Forms.MenuItem menuItem27_SelectAll;
	  private System.Windows.Forms.MenuItem menuItem33_WordWrap;
	  private System.Windows.Forms.MenuItem menuItem34_Font;
	  private System.Windows.Forms.MenuItem menuItem3_Cascade;
	  private System.Windows.Forms.MenuItem menuItem4_TileHorizontal;
	  private System.Windows.Forms.MenuItem menuItem5_TileVertical;
	  private System.Windows.Forms.MenuItem menuItem14_RecentFiles4;
	  private System.Windows.Forms.MenuItem menuItem5_Delete;
	  private System.ComponentModel.IContainer components;

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
		  this.components = new System.ComponentModel.Container();
		  System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
		  this.printDialog1 = new System.Windows.Forms.PrintDialog();
		  this.printDocument1 = new System.Drawing.Printing.PrintDocument();
		  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem6 = new System.Windows.Forms.MenuItem();
		  this.menuItem30 = new System.Windows.Forms.MenuItem();
		  this.menuItem31 = new System.Windows.Forms.MenuItem();
		  this.menuItem13_Open = new System.Windows.Forms.MenuItem();
		  this.menuItem8_Close = new System.Windows.Forms.MenuItem();
		  this.menuItem11 = new System.Windows.Forms.MenuItem();
		  this.menuItem10_Save = new System.Windows.Forms.MenuItem();
		  this.menuItem9_SaveAs = new System.Windows.Forms.MenuItem();
		  this.menuItem12 = new System.Windows.Forms.MenuItem();
		  this.menuItem29_PageSetup = new System.Windows.Forms.MenuItem();
		  this.menuItem28_PrintPreview = new System.Windows.Forms.MenuItem();
		  this.menuItem7_Print = new System.Windows.Forms.MenuItem();
		  this.menuItem14_RecentFiles4 = new System.Windows.Forms.MenuItem();
		  this.menuItem15 = new System.Windows.Forms.MenuItem();
		  this.menuItem16_Exit = new System.Windows.Forms.MenuItem();
		  this.menuItem18 = new System.Windows.Forms.MenuItem();
		  this.menuItem19_Undo = new System.Windows.Forms.MenuItem();
		  this.menuItem20_Redo = new System.Windows.Forms.MenuItem();
		  this.menuItem21 = new System.Windows.Forms.MenuItem();
		  this.menuItem22_Cut = new System.Windows.Forms.MenuItem();
		  this.menuItem23_Copy = new System.Windows.Forms.MenuItem();
		  this.menuItem24_Paste = new System.Windows.Forms.MenuItem();
		  this.menuItem5_Delete = new System.Windows.Forms.MenuItem();
		  this.menuItem26 = new System.Windows.Forms.MenuItem();
		  this.menuItem27_SelectAll = new System.Windows.Forms.MenuItem();
		  this.menuItem32 = new System.Windows.Forms.MenuItem();
		  this.menuItem33_WordWrap = new System.Windows.Forms.MenuItem();
		  this.menuItem34_Font = new System.Windows.Forms.MenuItem();
		  this.menuItem2 = new System.Windows.Forms.MenuItem();
		  this.menuItem3_Cascade = new System.Windows.Forms.MenuItem();
		  this.menuItem4_TileHorizontal = new System.Windows.Forms.MenuItem();
		  this.menuItem5_TileVertical = new System.Windows.Forms.MenuItem();
		  this.menuItem17 = new System.Windows.Forms.MenuItem();
		  this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
		  this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
		  this.fontDialog1 = new System.Windows.Forms.FontDialog();
		  this.text_Box1 = new Salford.VisualClearWin.Text_Box();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
		  this.contextMenu1 = new System.Windows.Forms.ContextMenu();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.menuItem3 = new System.Windows.Forms.MenuItem();
		  this.toolBarButton2__Open = new System.Windows.Forms.ToolBarButton();
		  this.SuspendLayout();
		  // 
		  // printDialog1
		  // 
		  this.printDialog1.AllowSomePages = true;
		  this.printDialog1.Document = this.printDocument1;
		  // 
		  // saveFileDialog1
		  // 
		  this.saveFileDialog1.Filter = "Fortran files (*.f95)|*.f95|All files (*.*)|*.*";
		  // 
		  // mainMenu1
		  // 
		  this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem1,
																				  this.menuItem18,
																				  this.menuItem32,
																				  this.menuItem2});
		  // 
		  // menuItem1
		  // 
		  this.menuItem1.Index = 0;
		  this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem6,
																				  this.menuItem13_Open,
																				  this.menuItem8_Close,
																				  this.menuItem11,
																				  this.menuItem10_Save,
																				  this.menuItem9_SaveAs,
																				  this.menuItem12,
																				  this.menuItem29_PageSetup,
																				  this.menuItem28_PrintPreview,
																				  this.menuItem7_Print,
																				  this.menuItem14_RecentFiles4,
																				  this.menuItem15,
																				  this.menuItem16_Exit});
		  this.menuItem1.MergeType = System.Windows.Forms.MenuMerge.Replace;
		  this.menuItem1.Text = "&File";
		  // 
		  // menuItem6
		  // 
		  this.menuItem6.Index = 0;
		  this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem30,
																				  this.menuItem31});
		  this.menuItem6.Text = "New";
		  // 
		  // menuItem30
		  // 
		  this.menuItem30.Index = 0;
		  this.menuItem30.Text = "Text file";
		  // 
		  // menuItem31
		  // 
		  this.menuItem31.Index = 1;
		  this.menuItem31.Text = "RichText file";
		  // 
		  // menuItem13_Open
		  // 
		  this.menuItem13_Open.Index = 1;
		  this.menuItem13_Open.Text = "&Open";
		  // 
		  // menuItem8_Close
		  // 
		  this.menuItem8_Close.Index = 2;
		  this.menuItem8_Close.Text = "Close";
		  // 
		  // menuItem11
		  // 
		  this.menuItem11.Index = 3;
		  this.menuItem11.Text = "-";
		  // 
		  // menuItem10_Save
		  // 
		  this.menuItem10_Save.Enabled = false;
		  this.menuItem10_Save.Index = 4;
		  this.menuItem10_Save.Text = "Save";
		  // 
		  // menuItem9_SaveAs
		  // 
		  this.menuItem9_SaveAs.Index = 5;
		  this.menuItem9_SaveAs.Text = "Save As";
		  // 
		  // menuItem12
		  // 
		  this.menuItem12.Index = 6;
		  this.menuItem12.Text = "-";
		  // 
		  // menuItem29_PageSetup
		  // 
		  this.menuItem29_PageSetup.Index = 7;
		  this.menuItem29_PageSetup.Text = "Page Setup";
		  // 
		  // menuItem28_PrintPreview
		  // 
		  this.menuItem28_PrintPreview.Index = 8;
		  this.menuItem28_PrintPreview.Text = "Print Preview";
		  // 
		  // menuItem7_Print
		  // 
		  this.menuItem7_Print.Index = 9;
		  this.menuItem7_Print.Text = "Print...";
		  // 
		  // menuItem14_RecentFiles4
		  // 
		  this.menuItem14_RecentFiles4.Index = 10;
		  this.menuItem14_RecentFiles4.Text = "Recent files";
		  // 
		  // menuItem15
		  // 
		  this.menuItem15.Index = 11;
		  this.menuItem15.Text = "-";
		  // 
		  // menuItem16_Exit
		  // 
		  this.menuItem16_Exit.Index = 12;
		  this.menuItem16_Exit.Text = "Exit";
		  // 
		  // menuItem18
		  // 
		  this.menuItem18.Index = 1;
		  this.menuItem18.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.menuItem19_Undo,
																				   this.menuItem20_Redo,
																				   this.menuItem21,
																				   this.menuItem22_Cut,
																				   this.menuItem23_Copy,
																				   this.menuItem24_Paste,
																				   this.menuItem5_Delete,
																				   this.menuItem26,
																				   this.menuItem27_SelectAll});
		  this.menuItem18.Text = "&Edit";
		  // 
		  // menuItem19_Undo
		  // 
		  this.menuItem19_Undo.Index = 0;
		  this.menuItem19_Undo.Text = "Undo";
		  // 
		  // menuItem20_Redo
		  // 
		  this.menuItem20_Redo.Index = 1;
		  this.menuItem20_Redo.Text = "Redo";
		  // 
		  // menuItem21
		  // 
		  this.menuItem21.Index = 2;
		  this.menuItem21.Text = "-";
		  // 
		  // menuItem22_Cut
		  // 
		  this.menuItem22_Cut.Index = 3;
		  this.menuItem22_Cut.Text = "Cut";
		  // 
		  // menuItem23_Copy
		  // 
		  this.menuItem23_Copy.Index = 4;
		  this.menuItem23_Copy.Text = "Copy";
		  // 
		  // menuItem24_Paste
		  // 
		  this.menuItem24_Paste.Index = 5;
		  this.menuItem24_Paste.Text = "Paste";
		  // 
		  // menuItem5_Delete
		  // 
		  this.menuItem5_Delete.Index = 6;
		  this.menuItem5_Delete.Text = "Delete";
		  // 
		  // menuItem26
		  // 
		  this.menuItem26.Index = 7;
		  this.menuItem26.Text = "-";
		  // 
		  // menuItem27_SelectAll
		  // 
		  this.menuItem27_SelectAll.Index = 8;
		  this.menuItem27_SelectAll.Text = "Select All";
		  // 
		  // menuItem32
		  // 
		  this.menuItem32.Index = 2;
		  this.menuItem32.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.menuItem33_WordWrap,
																				   this.menuItem34_Font});
		  this.menuItem32.Text = "Format";
		  // 
		  // menuItem33_WordWrap
		  // 
		  this.menuItem33_WordWrap.Index = 0;
		  this.menuItem33_WordWrap.Text = "Word Wrap";
		  // 
		  // menuItem34_Font
		  // 
		  this.menuItem34_Font.Index = 1;
		  this.menuItem34_Font.Text = "Font";
		  // 
		  // menuItem2
		  // 
		  this.menuItem2.Index = 3;
		  this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem3_Cascade,
																				  this.menuItem4_TileHorizontal,
																				  this.menuItem5_TileVertical,
																				  this.menuItem17});
		  this.menuItem2.Text = "&Window";
		  // 
		  // menuItem3_Cascade
		  // 
		  this.menuItem3_Cascade.Index = 0;
		  this.menuItem3_Cascade.Text = "Cascade";
		  // 
		  // menuItem4_TileHorizontal
		  // 
		  this.menuItem4_TileHorizontal.Index = 1;
		  this.menuItem4_TileHorizontal.Text = "Tile Horizontally";
		  // 
		  // menuItem5_TileVertical
		  // 
		  this.menuItem5_TileVertical.Index = 2;
		  this.menuItem5_TileVertical.Text = "Tile Vertically";
		  // 
		  // menuItem17
		  // 
		  this.menuItem17.Index = 3;
		  this.menuItem17.MdiList = true;
		  this.menuItem17.Text = "Windows";
		  // 
		  // printPreviewDialog1
		  // 
		  this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
		  this.printPreviewDialog1.Document = this.printDocument1;
		  this.printPreviewDialog1.Enabled = true;
		  this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
		  this.printPreviewDialog1.Location = new System.Drawing.Point(491, 18);
		  this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
		  this.printPreviewDialog1.Name = "printPreviewDialog1";
		  this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
		  this.printPreviewDialog1.Visible = false;
		  // 
		  // pageSetupDialog1
		  // 
		  this.pageSetupDialog1.Document = this.printDocument1;
		  // 
		  // fontDialog1
		  // 
		  this.fontDialog1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.fontDialog1.ShowColor = true;
		  // 
		  // text_Box1
		  // 
		  this.text_Box1.Dock = System.Windows.Forms.DockStyle.Fill;
		  this.text_Box1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.text_Box1.Location = new System.Drawing.Point(0, 0);
		  this.text_Box1.Multiline = true;
		  this.text_Box1.Name = "text_Box1";
		  this.text_Box1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		  this.text_Box1.Size = new System.Drawing.Size(208, 69);
		  this.text_Box1.TabIndex = 2;
		  this.text_Box1.Text = "";
		  // 
		  // imageList1
		  // 
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // toolBar1
		  // 
		  this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
		  this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarButton1,
																					this.toolBarButton2__Open});
		  this.toolBar1.ButtonSize = new System.Drawing.Size(16, 16);
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Location = new System.Drawing.Point(0, 0);
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(208, 28);
		  this.toolBar1.TabIndex = 4;
		  // 
		  // toolBarButton1
		  // 
		  this.toolBarButton1.DropDownMenu = this.contextMenu1;
		  this.toolBarButton1.ImageIndex = 0;
		  this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
		  // 
		  // contextMenu1
		  // 
		  this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem4,
																					 this.menuItem3});
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 0;
		  this.menuItem4.Text = "Text file";
		  // 
		  // menuItem3
		  // 
		  this.menuItem3.Index = 1;
		  this.menuItem3.Text = "RichText file";
		  // 
		  // toolBarButton2__Open
		  // 
		  this.toolBarButton2__Open.ImageIndex = 1;
		  // 
		  // Form2
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(208, 69);
		  this.Controls.Add(this.toolBar1);
		  this.Controls.Add(this.text_Box1);
		  this.Menu = this.mainMenu1;
		  this.Name = "Form2";
		  this.Text = "Form2";
		  this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		  this.ResumeLayout(false);

		}
		#endregion

	}
}
