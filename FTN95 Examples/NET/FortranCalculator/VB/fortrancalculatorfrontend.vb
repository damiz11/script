Public Class VB_Calculator
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private WithEvents canButton As System.Windows.Forms.Button
    Private WithEvents backspaceButton As System.Windows.Forms.Button
    Private WithEvents logButton As System.Windows.Forms.Button
    Private WithEvents piButton As System.Windows.Forms.Button
    Private WithEvents sqrtButton As System.Windows.Forms.Button
    Private WithEvents equalsButton As System.Windows.Forms.Button
    Private WithEvents subtractButton As System.Windows.Forms.Button
    Private WithEvents multiplyButton As System.Windows.Forms.Button
    Private WithEvents divideButton As System.Windows.Forms.Button
    Private WithEvents addButton As System.Windows.Forms.Button
    Private WithEvents decimalPointButton As System.Windows.Forms.Button
    Private WithEvents signButton As System.Windows.Forms.Button
    Private WithEvents number3Button As System.Windows.Forms.Button
    Private WithEvents number2Button As System.Windows.Forms.Button
    Private WithEvents number1Button As System.Windows.Forms.Button
    Private WithEvents number6Button As System.Windows.Forms.Button
    Private WithEvents number5Button As System.Windows.Forms.Button
    Private WithEvents number4Button As System.Windows.Forms.Button
    Private WithEvents number9Button As System.Windows.Forms.Button
    Private WithEvents number8Button As System.Windows.Forms.Button
    Private WithEvents number7Button As System.Windows.Forms.Button
    Protected WithEvents textBox As System.Windows.Forms.TextBox
    Private WithEvents numberButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(VB_Calculator))
        Me.backspaceButton = New System.Windows.Forms.Button
        Me.canButton = New System.Windows.Forms.Button
        Me.logButton = New System.Windows.Forms.Button
        Me.piButton = New System.Windows.Forms.Button
        Me.sqrtButton = New System.Windows.Forms.Button
        Me.equalsButton = New System.Windows.Forms.Button
        Me.subtractButton = New System.Windows.Forms.Button
        Me.multiplyButton = New System.Windows.Forms.Button
        Me.divideButton = New System.Windows.Forms.Button
        Me.addButton = New System.Windows.Forms.Button
        Me.decimalPointButton = New System.Windows.Forms.Button
        Me.signButton = New System.Windows.Forms.Button
        Me.number3Button = New System.Windows.Forms.Button
        Me.number2Button = New System.Windows.Forms.Button
        Me.numberButton = New System.Windows.Forms.Button
        Me.number1Button = New System.Windows.Forms.Button
        Me.number6Button = New System.Windows.Forms.Button
        Me.number5Button = New System.Windows.Forms.Button
        Me.number4Button = New System.Windows.Forms.Button
        Me.number9Button = New System.Windows.Forms.Button
        Me.number8Button = New System.Windows.Forms.Button
        Me.number7Button = New System.Windows.Forms.Button
        Me.textBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'backspaceButton
        '
        Me.backspaceButton.Location = New System.Drawing.Point(106, 55)
        Me.backspaceButton.Name = "backspaceButton"
        Me.backspaceButton.Size = New System.Drawing.Size(86, 28)
        Me.backspaceButton.TabIndex = 1
        Me.backspaceButton.TabStop = False
        Me.backspaceButton.Text = "Backspace"
        '
        'canButton
        '
        Me.canButton.Location = New System.Drawing.Point(211, 55)
        Me.canButton.Name = "canButton"
        Me.canButton.Size = New System.Drawing.Size(77, 28)
        Me.canButton.TabIndex = 1
        Me.canButton.TabStop = False
        Me.canButton.Text = "Cancel"
        '
        'logButton
        '
        Me.logButton.Location = New System.Drawing.Point(240, 185)
        Me.logButton.Name = "logButton"
        Me.logButton.Size = New System.Drawing.Size(48, 37)
        Me.logButton.TabIndex = 1
        Me.logButton.TabStop = False
        Me.logButton.Text = "Log"
        '
        'piButton
        '
        Me.piButton.Location = New System.Drawing.Point(240, 138)
        Me.piButton.Name = "piButton"
        Me.piButton.Size = New System.Drawing.Size(48, 37)
        Me.piButton.TabIndex = 1
        Me.piButton.TabStop = False
        Me.piButton.Text = "pi"
        '
        'sqrtButton
        '
        Me.sqrtButton.Location = New System.Drawing.Point(240, 92)
        Me.sqrtButton.Name = "sqrtButton"
        Me.sqrtButton.Size = New System.Drawing.Size(48, 37)
        Me.sqrtButton.TabIndex = 1
        Me.sqrtButton.TabStop = False
        Me.sqrtButton.Text = "sqrt"
        '
        'equalsButton
        '
        Me.equalsButton.Location = New System.Drawing.Point(240, 231)
        Me.equalsButton.Name = "equalsButton"
        Me.equalsButton.Size = New System.Drawing.Size(48, 37)
        Me.equalsButton.TabIndex = 1
        Me.equalsButton.TabStop = False
        Me.equalsButton.Text = "="
        '
        'subtractButton
        '
        Me.subtractButton.Location = New System.Drawing.Point(182, 185)
        Me.subtractButton.Name = "subtractButton"
        Me.subtractButton.Size = New System.Drawing.Size(48, 37)
        Me.subtractButton.TabIndex = 1
        Me.subtractButton.TabStop = False
        Me.subtractButton.Text = "-"
        '
        'multiplyButton
        '
        Me.multiplyButton.Location = New System.Drawing.Point(182, 138)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(48, 37)
        Me.multiplyButton.TabIndex = 1
        Me.multiplyButton.TabStop = False
        Me.multiplyButton.Text = "*"
        '
        'divideButton
        '
        Me.divideButton.Location = New System.Drawing.Point(182, 92)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(48, 37)
        Me.divideButton.TabIndex = 1
        Me.divideButton.TabStop = False
        Me.divideButton.Text = "/"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(182, 231)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(48, 37)
        Me.addButton.TabIndex = 1
        Me.addButton.TabStop = False
        Me.addButton.Text = "+"
        '
        'decimalPointButton
        '
        Me.decimalPointButton.Location = New System.Drawing.Point(125, 231)
        Me.decimalPointButton.Name = "decimalPointButton"
        Me.decimalPointButton.Size = New System.Drawing.Size(48, 37)
        Me.decimalPointButton.TabIndex = 1
        Me.decimalPointButton.TabStop = False
        Me.decimalPointButton.Text = "."
        '
        'signButton
        '
        Me.signButton.Location = New System.Drawing.Point(67, 231)
        Me.signButton.Name = "signButton"
        Me.signButton.Size = New System.Drawing.Size(48, 37)
        Me.signButton.TabIndex = 1
        Me.signButton.TabStop = False
        Me.signButton.Text = "+/-"
        '
        'number3Button
        '
        Me.number3Button.Location = New System.Drawing.Point(125, 185)
        Me.number3Button.Name = "number3Button"
        Me.number3Button.Size = New System.Drawing.Size(48, 37)
        Me.number3Button.TabIndex = 1
        Me.number3Button.TabStop = False
        Me.number3Button.Text = "3"
        '
        'number2Button
        '
        Me.number2Button.Location = New System.Drawing.Point(67, 185)
        Me.number2Button.Name = "number2Button"
        Me.number2Button.Size = New System.Drawing.Size(48, 37)
        Me.number2Button.TabIndex = 1
        Me.number2Button.TabStop = False
        Me.number2Button.Text = "2"
        '
        'numberButton
        '
        Me.numberButton.Location = New System.Drawing.Point(10, 231)
        Me.numberButton.Name = "numberButton"
        Me.numberButton.Size = New System.Drawing.Size(48, 37)
        Me.numberButton.TabIndex = 1
        Me.numberButton.TabStop = False
        Me.numberButton.Text = "0"
        '
        'number1Button
        '
        Me.number1Button.Location = New System.Drawing.Point(10, 185)
        Me.number1Button.Name = "number1Button"
        Me.number1Button.Size = New System.Drawing.Size(48, 37)
        Me.number1Button.TabIndex = 1
        Me.number1Button.TabStop = False
        Me.number1Button.Text = "1"
        '
        'number6Button
        '
        Me.number6Button.Location = New System.Drawing.Point(125, 138)
        Me.number6Button.Name = "number6Button"
        Me.number6Button.Size = New System.Drawing.Size(48, 37)
        Me.number6Button.TabIndex = 1
        Me.number6Button.TabStop = False
        Me.number6Button.Text = "6"
        '
        'number5Button
        '
        Me.number5Button.Location = New System.Drawing.Point(67, 138)
        Me.number5Button.Name = "number5Button"
        Me.number5Button.Size = New System.Drawing.Size(48, 37)
        Me.number5Button.TabIndex = 1
        Me.number5Button.TabStop = False
        Me.number5Button.Text = "5"
        '
        'number4Button
        '
        Me.number4Button.Location = New System.Drawing.Point(10, 138)
        Me.number4Button.Name = "number4Button"
        Me.number4Button.Size = New System.Drawing.Size(48, 37)
        Me.number4Button.TabIndex = 1
        Me.number4Button.TabStop = False
        Me.number4Button.Text = "4"
        '
        'number9Button
        '
        Me.number9Button.Location = New System.Drawing.Point(125, 92)
        Me.number9Button.Name = "number9Button"
        Me.number9Button.Size = New System.Drawing.Size(48, 37)
        Me.number9Button.TabIndex = 1
        Me.number9Button.TabStop = False
        Me.number9Button.Text = "9"
        '
        'number8Button
        '
        Me.number8Button.Location = New System.Drawing.Point(67, 92)
        Me.number8Button.Name = "number8Button"
        Me.number8Button.Size = New System.Drawing.Size(48, 37)
        Me.number8Button.TabIndex = 1
        Me.number8Button.TabStop = False
        Me.number8Button.Text = "8"
        '
        'number7Button
        '
        Me.number7Button.Location = New System.Drawing.Point(10, 92)
        Me.number7Button.Name = "number7Button"
        Me.number7Button.Size = New System.Drawing.Size(48, 37)
        Me.number7Button.TabIndex = 1
        Me.number7Button.TabStop = False
        Me.number7Button.Text = "7"
        '
        'textBox
        '
        Me.textBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.textBox.Enabled = False
        Me.textBox.Location = New System.Drawing.Point(10, 18)
        Me.textBox.MaxLength = 64
        Me.textBox.Name = "textBox"
        Me.textBox.Size = New System.Drawing.Size(278, 22)
        Me.textBox.TabIndex = 2
        Me.textBox.Text = "0"
        Me.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.textBox.WordWrap = False
        '
        'VB_Calculator
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(297, 273)
        Me.Controls.Add(Me.textBox)
        Me.Controls.Add(Me.backspaceButton)
        Me.Controls.Add(Me.canButton)
        Me.Controls.Add(Me.logButton)
        Me.Controls.Add(Me.piButton)
        Me.Controls.Add(Me.sqrtButton)
        Me.Controls.Add(Me.equalsButton)
        Me.Controls.Add(Me.subtractButton)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.divideButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.decimalPointButton)
        Me.Controls.Add(Me.signButton)
        Me.Controls.Add(Me.number3Button)
        Me.Controls.Add(Me.number2Button)
        Me.Controls.Add(Me.numberButton)
        Me.Controls.Add(Me.number1Button)
        Me.Controls.Add(Me.number6Button)
        Me.Controls.Add(Me.number5Button)
        Me.Controls.Add(Me.number4Button)
        Me.Controls.Add(Me.number9Button)
        Me.Controls.Add(Me.number8Button)
        Me.Controls.Add(Me.number7Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VB_Calculator"
        Me.Text = "VB .NET Calculator"
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "initialise variables"
    Dim dot As Boolean
    Dim frstclk As Boolean
    Dim needini As Boolean
    Dim eqpr As Boolean
    Dim DB1 As Double
    Dim DB2 As Double
    Dim result As Double
    Dim opcode As String
    Dim res As String

    Private Sub initialise()
        textBox.Text = "0"
        dot = False
        frstclk = True
        needini = False
        eqpr = False
        opcode = "none"
        DB1 = 0.0
        DB2 = 0.0
        res = "0.0"
        result = 0.0
    End Sub

    Private Sub reset()
        textBox.Text = "0"
        dot = False
        frstclk = True
        If needini Then
            needini = False
        End If
        If eqpr Then
            eqpr = False
        End If
    End Sub
#End Region

    Private Sub add_digit(ByVal num As Char)
        If needini Then
            initialise()
        End If
        If num = "." And dot Then
            Return
        ElseIf num = "." And Not dot And frstclk Then
            dot = True
            frstclk = False
            textBox.AppendText(".")
        ElseIf num = "." And Not dot Then
            dot = True
            textBox.AppendText(".")
        ElseIf num = "0" And frstclk Then
            frstclk = False
            Return
        ElseIf Not num = "0" And Not num = "." And frstclk Then
            frstclk = False
            textBox.Text = num
        Else
            textBox.AppendText(num)
        End If
    End Sub

    Private Sub checkFlagState()
        If eqpr Then
            eqpr = False
        End If
        If Not needini Then
            needini = True
        End If
        If frstclk Then
            frstclk = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialise()
    End Sub

#Region "Button call to add_digit"

    Private Sub number0Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numberButton.Click
        add_digit("0")
    End Sub

    Private Sub number1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number1Button.Click
        add_digit("1")
    End Sub

    Private Sub number2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number2Button.Click
        add_digit("2")
    End Sub

    Private Sub number3Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number3Button.Click
        add_digit("3")
    End Sub

    Private Sub number4Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number4Button.Click
        add_digit("4")
    End Sub

    Private Sub number5Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number5Button.Click
        add_digit("5")
    End Sub

    Private Sub number6Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number6Button.Click
        add_digit("6")
    End Sub

    Private Sub number7Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number7Button.Click
        add_digit("7")
    End Sub

    Private Sub number8Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number8Button.Click
        add_digit("8")
    End Sub

    Private Sub number9Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number9Button.Click
        add_digit("9")
    End Sub

    Private Sub decimalPointButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decimalPointButton.Click
        add_digit(".")
    End Sub

#End Region

    Private Sub backspaceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backspaceButton.Click
        If textBox.TextLength > 0 Then
            textBox.Text = textBox.Text.Substring(0, textBox.TextLength - 1)
        End If
        If textBox.Text = "" Then
            initialise()
        End If
    End Sub

    Private Sub canButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles canButton.Click
        initialise()
    End Sub

#Region "Operator buttons"

    Private Sub divideButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divideButton.Click
        DB1 = CDbl(textBox.Text)
        opcode = "divide"
        reset()
    End Sub

    Private Sub multiplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplyButton.Click
        DB1 = CDbl(textBox.Text)
        opcode = "multiply"
        reset()
    End Sub

    Private Sub subtractButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtractButton.Click
        DB1 = CDbl(textBox.Text)
        opcode = "subtract"
        reset()
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        DB1 = CDbl(textBox.Text)
        opcode = "add"
        reset()
    End Sub

#End Region

    Private Sub sqrtButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sqrtButton.Click
        Try
            checkFlagState()
            DB1 = CDbl(textBox.Text)
            result = ftncalc.SqRoot(DB1)
            res = (CStr(result))
            textBox.Text = res
        Catch ex As Exception When DB1 < 0
            Beep()
        End Try
    End Sub

    Private Sub piButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piButton.Click
        checkFlagState()
        result = ftncalc.PiVal()
        res = (CStr(result))
        textBox.Text = res
    End Sub

    Private Sub logButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logButton.Click
        Try
            checkFlagState()
            DB1 = CDbl(textBox.Text)
            result = ftncalc.Log(DB1)
            res = (CStr(result))
            textBox.Text = res
        Catch ex As Exception When DB1 < 0
            Beep()
        End Try
    End Sub

    Private Sub equalsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equalsButton.Click
        DB2 = CDbl(textBox.Text)
        Select Case opcode
            Case "add"
                result = ftncalc.Add(DB1, DB2)
                eqpr = True
            Case "subtract"
                result = ftncalc.Subtract(DB1, DB2)
                eqpr = True
            Case "multiply"
                result = ftncalc.Multiply(DB1, DB2)
                eqpr = True
            Case "divide"
                result = ftncalc.Divide(DB1, DB2)
                eqpr = True
            Case Else
                result = DB2
        End Select
        res = (CStr(result))
        textBox.Text = res
        needini = True
    End Sub

    Private Sub signButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signButton.Click
        If frstclk Then
            Return
        ElseIf eqpr Then
            Return
        Else
            Dim tmp As Double = CDbl(textBox.Text)
            If textBox.Text.Chars(0) = "-" And Not tmp = 0 Then
                textBox.Text = textBox.Text.Substring(1)
            ElseIf Not tmp = 0 Then
                textBox.Text = "-" + textBox.Text
            End If
            eqpr = sender.GetType.Equals(equalsButton)
        End If
    End Sub
#Region "KeyBoard implentation"
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Debug.Write(e.KeyChar)
        Dim n As Byte
        If (IsNumeric(e.KeyChar)) Then
            n = CByte(e.KeyChar.ToString)
            Select Case n
                Case 0 : numberButton.PerformClick()
                Case 1 : number1Button.PerformClick()
                Case 2 : number2Button.PerformClick()
                Case 3 : number3Button.PerformClick()
                Case 4 : number4Button.PerformClick()
                Case 5 : number5Button.PerformClick()
                Case 6 : number6Button.PerformClick()
                Case 7 : number7Button.PerformClick()
                Case 8 : number8Button.PerformClick()
                Case 9 : number9Button.PerformClick()
                Case Else : Beep()
            End Select
        Else
            Select Case e.KeyChar
                Case "/" : divideButton.PerformClick()
                Case "*" : multiplyButton.PerformClick()
                Case "+" : addButton.PerformClick()
                Case "-" : subtractButton.PerformClick()
                Case "=" : equalsButton.PerformClick()
                Case "." : decimalPointButton.PerformClick()
                Case ControlChars.Cr : equalsButton.PerformClick() 'Enter
                Case Convert.ToChar(27) : canButton.PerformClick() 'Esc
                Case Convert.ToChar(8) : backspaceButton.PerformClick() 'Back Space
                Case Else : Beep()
            End Select
        End If
    End Sub
#End Region
End Class
