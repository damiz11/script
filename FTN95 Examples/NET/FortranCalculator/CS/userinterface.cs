using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace CS_Calculator
{
	///	<summary>
	///	Summary	description	for	Form1.
	///	</summary>
	public class CS_Calculator : System.Windows.Forms.Form
	{
		private enum Operation
		{
			NONE, ADD, SUBTRACT, MULTIPLY, DIVIDE
		};
		private Operation currentOperation;
		private bool clearValue;
		private string lastValue;
		private System.Windows.Forms.Button number0Button;
		private System.Windows.Forms.Button number1Button;
		private System.Windows.Forms.Button number2Button;
		private System.Windows.Forms.Button number3Button;
		private System.Windows.Forms.Button number4Button;
		private System.Windows.Forms.Button number5Button;
		private System.Windows.Forms.Button number6Button;
		private System.Windows.Forms.Button number7Button;
		private System.Windows.Forms.Button number8Button;
		private System.Windows.Forms.Button number9Button;
		private System.Windows.Forms.Button signButton;
		private System.Windows.Forms.Button decimalPointButton;
		private System.Windows.Forms.Button subtractButton;
		private System.Windows.Forms.Button multiplyButton;
		private System.Windows.Forms.Button divideButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button sqrtButton;
		private System.Windows.Forms.Button equalsButton;
		private System.Windows.Forms.Button backspaceButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button piButton;
		private System.Windows.Forms.Button logButton;
		private System.Windows.Forms.TextBox textBox;
		///	<summary>
		///	Required designer variable.
		///	</summary>
		private	System.ComponentModel.Container	components = null;

		public CS_Calculator()
		{
			//
			// Required	for	Windows	Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after	InitializeComponent	call
			//
			currentOperation = Operation.NONE;
			clearValue = false;
			lastValue = textBox.Text;
		}

		///	<summary>
		///	Clean up any resources being used.
		///	</summary>
		protected override void	Dispose( bool disposing	)
		{
			if(	disposing )
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing	);
		}

		#region	Windows	Form Designer generated	code
		///	<summary>
		///	Required method	for	Designer support - do not modify
		///	the	contents of	this method	with the code editor.
		///	</summary>
		private	void InitializeComponent()
		{
			this.number6Button = new System.Windows.Forms.Button();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.number4Button = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.logButton = new System.Windows.Forms.Button();
			this.number1Button = new System.Windows.Forms.Button();
			this.divideButton = new System.Windows.Forms.Button();
			this.number9Button = new System.Windows.Forms.Button();
			this.number7Button = new System.Windows.Forms.Button();
			this.backspaceButton = new System.Windows.Forms.Button();
			this.piButton = new System.Windows.Forms.Button();
			this.sqrtButton = new System.Windows.Forms.Button();
			this.number2Button = new System.Windows.Forms.Button();
			this.decimalPointButton = new System.Windows.Forms.Button();
			this.number5Button = new System.Windows.Forms.Button();
			this.equalsButton = new System.Windows.Forms.Button();
			this.signButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.number3Button = new System.Windows.Forms.Button();
			this.number0Button = new System.Windows.Forms.Button();
			this.subtractButton = new System.Windows.Forms.Button();
			this.number8Button = new System.Windows.Forms.Button();
			this.textBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			//
			// number6Button
			//
			this.number6Button.Location = new System.Drawing.Point(134, 138);
			this.number6Button.Name = "number6Button";
			this.number6Button.Size = new System.Drawing.Size(48, 37);
			this.number6Button.TabIndex = 1;
			this.number6Button.Text = "6";
			this.number6Button.Click += new System.EventHandler(this.number6Button_Click);
			//
			// multiplyButton
			//
			this.multiplyButton.Location = new System.Drawing.Point(192, 138);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(48, 37);
			this.multiplyButton.TabIndex = 1;
			this.multiplyButton.Text = "*";
			this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
			//
			// number4Button
			//
			this.number4Button.Location = new System.Drawing.Point(19, 138);
			this.number4Button.Name = "number4Button";
			this.number4Button.Size = new System.Drawing.Size(48, 37);
			this.number4Button.TabIndex = 1;
			this.number4Button.Text = "4";
			this.number4Button.Click += new System.EventHandler(this.number4Button_Click);
			//
			// addButton
			//
			this.addButton.Location = new System.Drawing.Point(192, 231);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(48, 37);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "+";
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			//
			// logButton
			//
			this.logButton.Location = new System.Drawing.Point(250, 185);
			this.logButton.Name = "logButton";
			this.logButton.Size = new System.Drawing.Size(48, 37);
			this.logButton.TabIndex = 1;
			this.logButton.Text = "Log";
			this.logButton.Click += new System.EventHandler(this.logButton_Click);
			//
			// number1Button
			//
			this.number1Button.Location = new System.Drawing.Point(19, 185);
			this.number1Button.Name = "number1Button";
			this.number1Button.Size = new System.Drawing.Size(48, 37);
			this.number1Button.TabIndex = 1;
			this.number1Button.Text = "1";
			this.number1Button.Click += new System.EventHandler(this.number1Button_Click);
			//
			// divideButton
			//
			this.divideButton.Location = new System.Drawing.Point(192, 92);
			this.divideButton.Name = "divideButton";
			this.divideButton.Size = new System.Drawing.Size(48, 37);
			this.divideButton.TabIndex = 1;
			this.divideButton.Text = "/";
			this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
			//
			// number9Button
			//
			this.number9Button.Location = new System.Drawing.Point(134, 92);
			this.number9Button.Name = "number9Button";
			this.number9Button.Size = new System.Drawing.Size(48, 37);
			this.number9Button.TabIndex = 1;
			this.number9Button.Text = "9";
			this.number9Button.Click += new System.EventHandler(this.number9Button_Click);
			//
			// number7Button
			//
			this.number7Button.Location = new System.Drawing.Point(19, 92);
			this.number7Button.Name = "number7Button";
			this.number7Button.Size = new System.Drawing.Size(48, 37);
			this.number7Button.TabIndex = 1;
			this.number7Button.Text = "7";
			this.number7Button.Click += new System.EventHandler(this.number7Button_Click);
			//
			// backspaceButton
			//
			this.backspaceButton.Location = new System.Drawing.Point(115, 55);
			this.backspaceButton.Name = "backspaceButton";
			this.backspaceButton.Size = new System.Drawing.Size(87, 28);
			this.backspaceButton.TabIndex = 1;
			this.backspaceButton.Text = "Backspace";
			this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
			//
			// piButton
			//
			this.piButton.Location = new System.Drawing.Point(250, 138);
			this.piButton.Name = "piButton";
			this.piButton.Size = new System.Drawing.Size(48, 37);
			this.piButton.TabIndex = 1;
			this.piButton.Text = "pi";
			this.piButton.Click += new System.EventHandler(this.piButton_Click);
			//
			// sqrtButton
			//
			this.sqrtButton.Location = new System.Drawing.Point(250, 92);
			this.sqrtButton.Name = "sqrtButton";
			this.sqrtButton.Size = new System.Drawing.Size(48, 37);
			this.sqrtButton.TabIndex = 1;
			this.sqrtButton.Text = "sqrt";
			this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
			//
			// number2Button
			//
			this.number2Button.Location = new System.Drawing.Point(77, 185);
			this.number2Button.Name = "number2Button";
			this.number2Button.Size = new System.Drawing.Size(48, 37);
			this.number2Button.TabIndex = 1;
			this.number2Button.Text = "2";
			this.number2Button.Click += new System.EventHandler(this.number2Button_Click);
			//
			// decimalPointButton
			//
			this.decimalPointButton.Location = new System.Drawing.Point(134, 231);
			this.decimalPointButton.Name = "decimalPointButton";
			this.decimalPointButton.Size = new System.Drawing.Size(48, 37);
			this.decimalPointButton.TabIndex = 1;
			this.decimalPointButton.Text = ".";
			this.decimalPointButton.Click += new System.EventHandler(this.decimalPointButton_Click);
			//
			// number5Button
			//
			this.number5Button.Location = new System.Drawing.Point(77, 138);
			this.number5Button.Name = "number5Button";
			this.number5Button.Size = new System.Drawing.Size(48, 37);
			this.number5Button.TabIndex = 1;
			this.number5Button.Text = "5";
			this.number5Button.Click += new System.EventHandler(this.number5Button_Click);
			//
			// equalsButton
			//
			this.equalsButton.Location = new System.Drawing.Point(250, 231);
			this.equalsButton.Name = "equalsButton";
			this.equalsButton.Size = new System.Drawing.Size(48, 37);
			this.equalsButton.TabIndex = 1;
			this.equalsButton.Text = "=";
			this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
			//
			// signButton
			//
			this.signButton.Location = new System.Drawing.Point(77, 231);
			this.signButton.Name = "signButton";
			this.signButton.Size = new System.Drawing.Size(48, 37);
			this.signButton.TabIndex = 1;
			this.signButton.Text = "+/-";
			this.signButton.Click += new System.EventHandler(this.signButton_Click);
			//
			// cancelButton
			//
			this.cancelButton.Location = new System.Drawing.Point(221, 55);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(77, 28);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			//
			// number3Button
			//
			this.number3Button.Location = new System.Drawing.Point(134, 185);
			this.number3Button.Name = "number3Button";
			this.number3Button.Size = new System.Drawing.Size(48, 37);
			this.number3Button.TabIndex = 1;
			this.number3Button.Text = "3";
			this.number3Button.Click += new System.EventHandler(this.number3Button_Click);
			//
			// number0Button
			//
			this.number0Button.Location = new System.Drawing.Point(19, 231);
			this.number0Button.Name = "number0Button";
			this.number0Button.Size = new System.Drawing.Size(48, 37);
			this.number0Button.TabIndex = 1;
			this.number0Button.Text = "0";
			this.number0Button.Click += new System.EventHandler(this.number0Button_Click);
			//
			// subtractButton
			//
			this.subtractButton.Location = new System.Drawing.Point(192, 185);
			this.subtractButton.Name = "subtractButton";
			this.subtractButton.Size = new System.Drawing.Size(48, 37);
			this.subtractButton.TabIndex = 1;
			this.subtractButton.Text = "-";
			this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
			//
			// number8Button
			//
			this.number8Button.Location = new System.Drawing.Point(77, 92);
			this.number8Button.Name = "number8Button";
			this.number8Button.Size = new System.Drawing.Size(48, 37);
			this.number8Button.TabIndex = 1;
			this.number8Button.Text = "8";
			this.number8Button.Click += new System.EventHandler(this.number8Button_Click);
			//
			// textBox
			//
			this.textBox.BackColor = System.Drawing.SystemColors.Window;
			this.textBox.Enabled = false;
			this.textBox.Location = new System.Drawing.Point(19, 18);
			this.textBox.MaxLength = 64;
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.Size = new System.Drawing.Size(288, 22);
			this.textBox.TabIndex = 0;
			this.textBox.Text = "0";
			this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			// CS_Calculator
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(324, 289);
			this.Controls.Add(this.backspaceButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.logButton);
			this.Controls.Add(this.piButton);
			this.Controls.Add(this.sqrtButton);
			this.Controls.Add(this.equalsButton);
			this.Controls.Add(this.subtractButton);
			this.Controls.Add(this.multiplyButton);
			this.Controls.Add(this.divideButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.decimalPointButton);
			this.Controls.Add(this.signButton);
			this.Controls.Add(this.number3Button);
			this.Controls.Add(this.number2Button);
			this.Controls.Add(this.number0Button);
			this.Controls.Add(this.number1Button);
			this.Controls.Add(this.number6Button);
			this.Controls.Add(this.number5Button);
			this.Controls.Add(this.number4Button);
			this.Controls.Add(this.number9Button);
			this.Controls.Add(this.number8Button);
			this.Controls.Add(this.number7Button);
			this.Controls.Add(this.textBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "CS_Calculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C# .NET Calculator";
			this.ResumeLayout(false);

		}
		#endregion

		///	<summary>
		///	The	main entry point for the application.
		///	</summary>
		[STAThread]
		static void	Main()
		{
			Application.Run(new	CS_Calculator());
		}



		private void number1Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('1');
		}

		private void number2Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('2');
		}

		private void number3Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('3');
		}

		private void number4Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('4');
		}

		private void number5Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('5');
		}

		private void number6Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('6');
		}

		private void number7Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('7');
		}

		private void number8Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('8');
		}

		private void number9Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('9');
		}

		private void number0Button_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('0');
		}

		private void decimalPointButton_Click(object sender, System.EventArgs e)
		{
			appendCharacterToTextBox ('.');
		}




		private void appendCharacterToTextBox (char character)
		{
			int decimalPointIndex = textBox.Text.IndexOf('.');

			// don't allow multiple decimal points
			if (character == '.')
				if (decimalPointIndex != -1)
					return;

			if (clearValue)
			{
				lastValue = textBox.Text;
				textBox.Text = "";
				clearValue = false;
			}

			if (textBox.Text.Length > 0)
			{
				// trim off all 0's from the beginning of the line
				int preceedingZeros = 0;
				while (preceedingZeros < textBox.Text.Length && textBox.Text[preceedingZeros] == '0')
					preceedingZeros++;
				textBox.Text = textBox.Text.Remove (0, preceedingZeros);
			}

			textBox.Text += character;
		}



		private void performPendingOperation ()
		{
			double lastValue = Double.Parse(this.lastValue);
			double thisValue = Double.Parse(textBox.Text);
			switch (currentOperation)
			{
				case Operation.ADD:
					textBox.Text = Calculator.Add(lastValue, thisValue).ToString();
					break;
				case Operation.SUBTRACT:
					textBox.Text = Calculator.Subtract(lastValue, thisValue).ToString();
					break;
				case Operation.MULTIPLY:
					textBox.Text = Calculator.Multiply(lastValue, thisValue).ToString();
					break;
				case Operation.DIVIDE:
					textBox.Text = Calculator.Divide(lastValue, thisValue).ToString();
					break;
			}
			currentOperation = Operation.NONE;
		}


		private void setOperation (Operation operation)
		{
			if (currentOperation != Operation.NONE)
				performPendingOperation ();
			currentOperation = operation;
			clearValue = true;
		}


		private void addButton_Click(object sender, System.EventArgs e)
		{
			setOperation (Operation.ADD);
		}

		private void subtractButton_Click(object sender, System.EventArgs e)
		{
			setOperation (Operation.SUBTRACT);
		}

		private void multiplyButton_Click(object sender, System.EventArgs e)
		{
			setOperation (Operation.MULTIPLY);
		}

		private void divideButton_Click(object sender, System.EventArgs e)
		{
			setOperation (Operation.DIVIDE);
		}

		private void sqrtButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				textBox.Text = Calculator.SqRoot (Double.Parse(textBox.Text)).ToString();
				clearValue = false;
			}
			catch (System.Exception exception)
			{
				clearValue = false;
				MessageBox.Show("Invalid Calculation: "+exception.Message, "Error");
			}
		}


		private void backspaceButton_Click(object sender, System.EventArgs e)
		{
			if (textBox.Text.Length > 0)
				textBox.Text = textBox.Text.Substring(0, textBox.Text.Length-1);
			if (textBox.Text == "")
				textBox.Text = "0";
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			textBox.Text = "0";
			lastValue = textBox.Text;
			clearValue = false;
		}

		private void equalsButton_Click(object sender, System.EventArgs e)
		{
			if (currentOperation != Operation.NONE)
				performPendingOperation();
			clearValue = true;
		}

		private void piButton_Click(object sender, System.EventArgs e)
		{
			textBox.Text = Calculator.PiValue().ToString();
			lastValue = textBox.Text;
			clearValue = false;
		}

		private void signButton_Click(object sender, System.EventArgs e)
		{
			if (textBox.Text.Length > 0 && textBox.Text[0] == '-')
				textBox.Text = textBox.Text.Substring(1, textBox.Text.Length-1);
			else
				textBox.Text = "-" + textBox.Text;
		}

		private void logButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				textBox.Text = Calculator.Log (Double.Parse(textBox.Text)).ToString();
				clearValue = false;
			}
			catch (System.Exception exception)
			{
				clearValue = false;
				MessageBox.Show("Invalid Calculation: "+exception.Message, "Error");
			}
		}
	}
}