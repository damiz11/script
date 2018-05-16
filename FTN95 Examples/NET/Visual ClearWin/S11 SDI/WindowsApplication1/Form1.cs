using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Resources
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
	  private System.Windows.Forms.MainMenu mainMenu1;
	  private System.Windows.Forms.MenuItem menuItem1;
	  private System.Windows.Forms.StatusBar statusBar1;
	  private System.Windows.Forms.OpenFileDialog openFileDialog1;
	  private System.Windows.Forms.MenuItem menuItem4;
	  private System.Windows.Forms.MenuItem menuItem6;
	  private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	  private System.Windows.Forms.PrintDialog printDialog1;
	  private System.Drawing.Printing.PrintDocument printDocument1;
	  private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
	  private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
	  private System.Windows.Forms.MenuItem menuItem13;
	  private System.Windows.Forms.MenuItem menuItem16;
	  private System.Windows.Forms.MenuItem menuItem15;
	  private System.Windows.Forms.FontDialog fontDialog1;
      private System.Windows.Forms.ImageList imageList1;
      private System.Windows.Forms.ToolBar toolBar1;
      private System.Windows.Forms.ToolBarButton toolBarButton4;
      private Salford.VisualClearWin.Text_Box text_Box1;
      private System.Windows.Forms.ToolBarButton toolBarButton1;
      private System.Windows.Forms.ToolBarButton toolBarButton2;
      private System.Windows.Forms.ToolBarButton toolBarButton3;
      private System.Windows.Forms.ToolBarButton toolBarButton5;
      private System.Windows.Forms.ToolBarButton toolBarButton6;
      private System.Windows.Forms.ToolBarButton toolBarButton7;
      private System.Windows.Forms.ToolBarButton toolBarButton8;
	  private System.Windows.Forms.ComboBox comboBox1;
	  private System.Windows.Forms.ToolBarButton toolBarButton9;
	  private System.Windows.Forms.ToolBarButton toolBarButton10;
	  private System.Windows.Forms.ToolBarButton toolBarButton11;
	  private System.Windows.Forms.ToolBarButton toolBarButton12;
	  private System.Windows.Forms.ToolBarButton toolBarButton13;
	  private System.Windows.Forms.ToolBarButton toolBarButton14;
	  private System.Windows.Forms.ToolBarButton toolBarButton15;
	  private System.Windows.Forms.ToolBarButton toolBarButton16;
	  private System.Windows.Forms.ToolBarButton toolBarButton17;
	  private System.Windows.Forms.ToolBarButton toolBarButton18;
	  private System.Windows.Forms.MenuItem menuItem21;
	  private System.Windows.Forms.MenuItem menuItem5_RecentFiles4;
	  private System.Windows.Forms.ToolBarButton toolBarButton20;
	  private System.Windows.Forms.MenuItem menuItem2_New;
	  private System.Windows.Forms.MenuItem menuItem3_Open;
	  private System.Windows.Forms.MenuItem menuItem8_Save;
	  private System.Windows.Forms.MenuItem menuItem9_SaveAs;
	  private System.Windows.Forms.MenuItem menuItem11_PageSetup;
	  private System.Windows.Forms.MenuItem menuItem12_PrintPreview;
	  private System.Windows.Forms.MenuItem menuItem10_Print;
	  private System.Windows.Forms.MenuItem menuItem7_Exit;
	  private System.Windows.Forms.MenuItem menuItem14_Undo;
	  private System.Windows.Forms.MenuItem menuItem17_Cut;
	  private System.Windows.Forms.MenuItem menuItem18_Copy;
	  private System.Windows.Forms.MenuItem menuItem19_Paste;
	  private System.Windows.Forms.MenuItem menuItem20_WordWrap;
	  private System.Windows.Forms.ToolBarButton toolBarButton1_New;
	  private System.Windows.Forms.ToolBarButton toolBarButton2_Open;
	  private System.Windows.Forms.ToolBarButton toolBarButton3_Save;
	  private System.Windows.Forms.ToolBarButton toolBarButton5_Cut;
	  private System.Windows.Forms.ToolBarButton toolBarButton6_Copy;
	  private System.Windows.Forms.ToolBarButton toolBarButton7_Paste;
	  private System.Windows.Forms.ToolBarButton toolBarButton_Print;
	  private System.Windows.Forms.ToolTip toolTip1;
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
		  this.mainMenu1 = new System.Windows.Forms.MainMenu();
		  this.menuItem1 = new System.Windows.Forms.MenuItem();
		  this.menuItem2_New = new System.Windows.Forms.MenuItem();
		  this.menuItem3_Open = new System.Windows.Forms.MenuItem();
		  this.menuItem8_Save = new System.Windows.Forms.MenuItem();
		  this.menuItem9_SaveAs = new System.Windows.Forms.MenuItem();
		  this.menuItem4 = new System.Windows.Forms.MenuItem();
		  this.menuItem11_PageSetup = new System.Windows.Forms.MenuItem();
		  this.menuItem12_PrintPreview = new System.Windows.Forms.MenuItem();
		  this.menuItem10_Print = new System.Windows.Forms.MenuItem();
		  this.menuItem5_RecentFiles4 = new System.Windows.Forms.MenuItem();
		  this.menuItem6 = new System.Windows.Forms.MenuItem();
		  this.menuItem7_Exit = new System.Windows.Forms.MenuItem();
		  this.menuItem13 = new System.Windows.Forms.MenuItem();
		  this.menuItem14_Undo = new System.Windows.Forms.MenuItem();
		  this.menuItem16 = new System.Windows.Forms.MenuItem();
		  this.menuItem17_Cut = new System.Windows.Forms.MenuItem();
		  this.menuItem18_Copy = new System.Windows.Forms.MenuItem();
		  this.menuItem19_Paste = new System.Windows.Forms.MenuItem();
		  this.menuItem15 = new System.Windows.Forms.MenuItem();
		  this.menuItem20_WordWrap = new System.Windows.Forms.MenuItem();
		  this.menuItem21 = new System.Windows.Forms.MenuItem();
		  this.statusBar1 = new System.Windows.Forms.StatusBar();
		  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		  this.printDialog1 = new System.Windows.Forms.PrintDialog();
		  this.printDocument1 = new System.Drawing.Printing.PrintDocument();
		  this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
		  this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
		  this.fontDialog1 = new System.Windows.Forms.FontDialog();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.toolBar1 = new System.Windows.Forms.ToolBar();
		  this.toolBarButton1_New = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton2_Open = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton3_Save = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton5_Cut = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton6_Copy = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton7_Paste = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton15 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton17 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton18 = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton_Print = new System.Windows.Forms.ToolBarButton();
		  this.toolBarButton20 = new System.Windows.Forms.ToolBarButton();
		  this.text_Box1 = new Salford.VisualClearWin.Text_Box();
		  this.comboBox1 = new System.Windows.Forms.ComboBox();
		  this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
		  this.SuspendLayout();
		  // 
		  // mainMenu1
		  // 
		  this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem1,
																				  this.menuItem13,
																				  this.menuItem15});
		  // 
		  // menuItem1
		  // 
		  this.menuItem1.Index = 0;
		  this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem2_New,
																				  this.menuItem3_Open,
																				  this.menuItem8_Save,
																				  this.menuItem9_SaveAs,
																				  this.menuItem4,
																				  this.menuItem11_PageSetup,
																				  this.menuItem12_PrintPreview,
																				  this.menuItem10_Print,
																				  this.menuItem5_RecentFiles4,
																				  this.menuItem6,
																				  this.menuItem7_Exit});
		  this.menuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
		  this.menuItem1.Text = "&File";
		  // 
		  // menuItem2_New
		  // 
		  this.menuItem2_New.Index = 0;
		  this.menuItem2_New.Text = "New|Creates a new document";
		  // 
		  // menuItem3_Open
		  // 
		  this.menuItem3_Open.Index = 1;
		  this.menuItem3_Open.Text = "&Open|Opens files";
		  // 
		  // menuItem8_Save
		  // 
		  this.menuItem8_Save.Enabled = false;
		  this.menuItem8_Save.Index = 2;
		  this.menuItem8_Save.Text = "Save|Saves the document";
		  // 
		  // menuItem9_SaveAs
		  // 
		  this.menuItem9_SaveAs.Index = 3;
		  this.menuItem9_SaveAs.Text = "Save As|Saves the document with a different name";
		  // 
		  // menuItem4
		  // 
		  this.menuItem4.Index = 4;
		  this.menuItem4.Text = "-";
		  // 
		  // menuItem11_PageSetup
		  // 
		  this.menuItem11_PageSetup.Index = 5;
		  this.menuItem11_PageSetup.Text = "Page Setup|Displays the Page Setup dialog";
		  // 
		  // menuItem12_PrintPreview
		  // 
		  this.menuItem12_PrintPreview.Index = 6;
		  this.menuItem12_PrintPreview.Text = "Print Preview|Displays the Print Preview dialog";
		  // 
		  // menuItem10_Print
		  // 
		  this.menuItem10_Print.Index = 7;
		  this.menuItem10_Print.Text = "Print...|Starts a printing process";
		  // 
		  // menuItem5_RecentFiles4
		  // 
		  this.menuItem5_RecentFiles4.Index = 8;
		  this.menuItem5_RecentFiles4.Text = "Recent files";
		  // 
		  // menuItem6
		  // 
		  this.menuItem6.Index = 9;
		  this.menuItem6.Text = "-";
		  // 
		  // menuItem7_Exit
		  // 
		  this.menuItem7_Exit.Index = 10;
		  this.menuItem7_Exit.Text = "Exit|Exits from the application";
		  // 
		  // menuItem13
		  // 
		  this.menuItem13.Index = 1;
		  this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.menuItem14_Undo,
																				   this.menuItem16,
																				   this.menuItem17_Cut,
																				   this.menuItem18_Copy,
																				   this.menuItem19_Paste});
		  this.menuItem13.Text = "Edit";
		  // 
		  // menuItem14_Undo
		  // 
		  this.menuItem14_Undo.Index = 0;
		  this.menuItem14_Undo.Text = "Undo|Undoes the last edit";
		  // 
		  // menuItem16
		  // 
		  this.menuItem16.Index = 1;
		  this.menuItem16.Text = "-";
		  // 
		  // menuItem17_Cut
		  // 
		  this.menuItem17_Cut.Index = 2;
		  this.menuItem17_Cut.Text = "Cut|Cuts the selection to the clipboard";
		  // 
		  // menuItem18_Copy
		  // 
		  this.menuItem18_Copy.Index = 3;
		  this.menuItem18_Copy.Text = "Copy|Copies the selection to the clipboard";
		  // 
		  // menuItem19_Paste
		  // 
		  this.menuItem19_Paste.Index = 4;
		  this.menuItem19_Paste.Text = "Paste|Pastes the clipboard at the current position";
		  // 
		  // menuItem15
		  // 
		  this.menuItem15.Index = 2;
		  this.menuItem15.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.menuItem20_WordWrap,
																				   this.menuItem21});
		  this.menuItem15.Text = "Format";
		  // 
		  // menuItem20_WordWrap
		  // 
		  this.menuItem20_WordWrap.Index = 0;
		  this.menuItem20_WordWrap.Text = "Word Wrap|Toggles the Word Wrap property";
		  // 
		  // menuItem21
		  // 
		  this.menuItem21.Index = 1;
		  this.menuItem21.Text = "Font...|Displays the Font dialog";
		  // 
		  // statusBar1
		  // 
		  this.statusBar1.Location = new System.Drawing.Point(0, 401);
		  this.statusBar1.Name = "statusBar1";
		  this.statusBar1.Size = new System.Drawing.Size(696, 24);
		  this.statusBar1.TabIndex = 1;
		  this.statusBar1.Text = "Ready";
		  // 
		  // openFileDialog1
		  // 
		  this.openFileDialog1.Filter = "Fotran files (*.f95)|*.f95|All files (*.*)|*.*";
		  // 
		  // saveFileDialog1
		  // 
		  this.saveFileDialog1.Filter = "Fortran files (*.f95)|*.f95|All files (*.*)|*.*";
		  // 
		  // printDialog1
		  // 
		  this.printDialog1.AllowSomePages = true;
		  this.printDialog1.Document = this.printDocument1;
		  // 
		  // printPreviewDialog1
		  // 
		  this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
		  this.printPreviewDialog1.Document = this.printDocument1;
		  this.printPreviewDialog1.Enabled = true;
		  this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
		  this.printPreviewDialog1.Location = new System.Drawing.Point(627, 17);
		  this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
		  this.printPreviewDialog1.Name = "printPreviewDialog1";
		  this.printPreviewDialog1.Opacity = 1;
		  this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
		  this.printPreviewDialog1.Visible = false;
		  // 
		  // pageSetupDialog1
		  // 
		  this.pageSetupDialog1.Document = this.printDocument1;
		  // 
		  // fontDialog1
		  // 
		  this.fontDialog1.ShowColor = true;
		  // 
		  // imageList1
		  // 
		  this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		  this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // toolBar1
		  // 
		  this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
		  this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					this.toolBarButton1_New,
																					this.toolBarButton2_Open,
																					this.toolBarButton3_Save,
																					this.toolBarButton4,
																					this.toolBarButton5_Cut,
																					this.toolBarButton6_Copy,
																					this.toolBarButton7_Paste,
																					this.toolBarButton1,
																					this.toolBarButton2,
																					this.toolBarButton3,
																					this.toolBarButton5,
																					this.toolBarButton6,
																					this.toolBarButton7,
																					this.toolBarButton8,
																					this.toolBarButton9,
																					this.toolBarButton10,
																					this.toolBarButton11,
																					this.toolBarButton12,
																					this.toolBarButton13,
																					this.toolBarButton14,
																					this.toolBarButton15,
																					this.toolBarButton16,
																					this.toolBarButton17,
																					this.toolBarButton18,
																					this.toolBarButton_Print,
																					this.toolBarButton20});
		  this.toolBar1.ButtonSize = new System.Drawing.Size(16, 16);
		  this.toolBar1.DropDownArrows = true;
		  this.toolBar1.ImageList = this.imageList1;
		  this.toolBar1.Name = "toolBar1";
		  this.toolBar1.ShowToolTips = true;
		  this.toolBar1.Size = new System.Drawing.Size(696, 25);
		  this.toolBar1.TabIndex = 4;
		  // 
		  // toolBarButton1_New
		  // 
		  this.toolBarButton1_New.ImageIndex = 0;
		  this.toolBarButton1_New.ToolTipText = "New";
		  // 
		  // toolBarButton2_Open
		  // 
		  this.toolBarButton2_Open.ImageIndex = 1;
		  this.toolBarButton2_Open.ToolTipText = "Open";
		  // 
		  // toolBarButton3_Save
		  // 
		  this.toolBarButton3_Save.ImageIndex = 2;
		  this.toolBarButton3_Save.ToolTipText = "Save";
		  // 
		  // toolBarButton4
		  // 
		  this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton5_Cut
		  // 
		  this.toolBarButton5_Cut.ImageIndex = 4;
		  this.toolBarButton5_Cut.ToolTipText = "Cut";
		  // 
		  // toolBarButton6_Copy
		  // 
		  this.toolBarButton6_Copy.ImageIndex = 5;
		  this.toolBarButton6_Copy.ToolTipText = "Copy";
		  // 
		  // toolBarButton7_Paste
		  // 
		  this.toolBarButton7_Paste.ImageIndex = 6;
		  this.toolBarButton7_Paste.ToolTipText = "Paste";
		  // 
		  // toolBarButton1
		  // 
		  this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  this.toolBarButton1.Text = "comboBox1";
		  // 
		  // toolBarButton2
		  // 
		  this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton3
		  // 
		  this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton5
		  // 
		  this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton6
		  // 
		  this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
		  // toolBarButton12
		  // 
		  this.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton13
		  // 
		  this.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton14
		  // 
		  this.toolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton15
		  // 
		  this.toolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton16
		  // 
		  this.toolBarButton16.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton17
		  // 
		  this.toolBarButton17.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  // 
		  // toolBarButton18
		  // 
		  this.toolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
		  this.toolBarButton18.Text = "comboBox1";
		  // 
		  // toolBarButton_Print
		  // 
		  this.toolBarButton_Print.ImageIndex = 7;
		  this.toolBarButton_Print.ToolTipText = "Print";
		  // 
		  // toolBarButton20
		  // 
		  this.toolBarButton20.ImageIndex = 8;
		  this.toolBarButton20.ToolTipText = "Find";
		  // 
		  // text_Box1
		  // 
		  this.text_Box1.Dock = System.Windows.Forms.DockStyle.Fill;
		  this.text_Box1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.text_Box1.HideSelection = false;
		  this.text_Box1.Location = new System.Drawing.Point(0, 25);
		  this.text_Box1.MaxLength = 0;
		  this.text_Box1.Multiline = true;
		  this.text_Box1.Name = "text_Box1";
		  this.text_Box1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		  this.text_Box1.Size = new System.Drawing.Size(696, 376);
		  this.text_Box1.TabIndex = 0;
		  this.text_Box1.Text = "";
		  // 
		  // comboBox1
		  // 
		  this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		  this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.comboBox1.Items.AddRange(new object[] {
													   "Courier New",
													   "Microsoft Sans Serif"});
		  this.comboBox1.Location = new System.Drawing.Point(150, 4);
		  this.comboBox1.MaxDropDownItems = 16;
		  this.comboBox1.MaxLength = 80;
		  this.comboBox1.Name = "comboBox1";
		  this.comboBox1.Size = new System.Drawing.Size(126, 21);
		  this.comboBox1.TabIndex = 6;
		  this.toolTip1.SetToolTip(this.comboBox1, "Font name");
		  // 
		  // Form1
		  // 
		  this.AllowDrop = true;
		  this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
		  this.ClientSize = new System.Drawing.Size(696, 425);
		  this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.comboBox1,
																	  this.text_Box1,
																	  this.toolBar1,
																	  this.statusBar1});
		  this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		  this.Menu = this.mainMenu1;
		  this.Name = "Form1";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "MyNotes";
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
