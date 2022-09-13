<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSport = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rbFootball = New System.Windows.Forms.RadioButton()
        Me.rbRugby = New System.Windows.Forms.RadioButton()
        Me.rbSenior = New System.Windows.Forms.RadioButton()
        Me.rbChild = New System.Windows.Forms.RadioButton()
        Me.rbAdult = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.rbGrade3 = New System.Windows.Forms.RadioButton()
        Me.rbGrade2 = New System.Windows.Forms.RadioButton()
        Me.rbGrade1 = New System.Windows.Forms.RadioButton()
        Me.rbCreditCard = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.rbDebitCard = New System.Windows.Forms.RadioButton()
        Me.rbMemberNo = New System.Windows.Forms.RadioButton()
        Me.rbMemberYes = New System.Windows.Forms.RadioButton()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.rbInstalmentsNo = New System.Windows.Forms.RadioButton()
        Me.rbInstalmentsYes = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.ttSport = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttTicketType = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttSeatGrade = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttPayment = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttMember = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttInstalments = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttCalculate = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttReset = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttExit = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSport
        '
        Me.lblSport.AutoSize = True
        Me.lblSport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSport.Location = New System.Drawing.Point(23, 33)
        Me.lblSport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSport.Name = "lblSport"
        Me.lblSport.Size = New System.Drawing.Size(54, 20)
        Me.lblSport.TabIndex = 0
        Me.lblSport.Text = "Sport:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(119, 33)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rbFootball)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rbRugby)
        Me.ttSport.SetToolTip(Me.SplitContainer1.Panel1, "This is a tooltip")
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbSenior)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbChild)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbAdult)
        Me.ttTicketType.SetToolTip(Me.SplitContainer1.Panel2, "If adult ticket, press ""Adult"". If child ticket, click ""Child"". If senior, press " &
        """Senior""")
        Me.SplitContainer1.Size = New System.Drawing.Size(408, 137)
        Me.SplitContainer1.SplitterDistance = 60
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.TabStop = False
        '
        'rbFootball
        '
        Me.rbFootball.AutoSize = True
        Me.rbFootball.Location = New System.Drawing.Point(208, 4)
        Me.rbFootball.Margin = New System.Windows.Forms.Padding(4)
        Me.rbFootball.Name = "rbFootball"
        Me.rbFootball.Size = New System.Drawing.Size(77, 20)
        Me.rbFootball.TabIndex = 1
        Me.rbFootball.Text = "Football"
        Me.rbFootball.UseVisualStyleBackColor = True
        '
        'rbRugby
        '
        Me.rbRugby.AutoSize = True
        Me.rbRugby.Location = New System.Drawing.Point(101, 4)
        Me.rbRugby.Margin = New System.Windows.Forms.Padding(4)
        Me.rbRugby.Name = "rbRugby"
        Me.rbRugby.Size = New System.Drawing.Size(68, 20)
        Me.rbRugby.TabIndex = 0
        Me.rbRugby.Text = "Rugby"
        Me.rbRugby.UseVisualStyleBackColor = True
        '
        'rbSenior
        '
        Me.rbSenior.Location = New System.Drawing.Point(272, 4)
        Me.rbSenior.Margin = New System.Windows.Forms.Padding(4)
        Me.rbSenior.Name = "rbSenior"
        Me.rbSenior.Size = New System.Drawing.Size(120, 21)
        Me.rbSenior.TabIndex = 1
        Me.rbSenior.TabStop = True
        Me.rbSenior.Text = "Senior"
        Me.rbSenior.UseVisualStyleBackColor = True
        '
        'rbChild
        '
        Me.rbChild.Location = New System.Drawing.Point(144, 4)
        Me.rbChild.Margin = New System.Windows.Forms.Padding(4)
        Me.rbChild.Name = "rbChild"
        Me.rbChild.Size = New System.Drawing.Size(120, 21)
        Me.rbChild.TabIndex = 0
        Me.rbChild.TabStop = True
        Me.rbChild.Text = "Child"
        Me.rbChild.UseVisualStyleBackColor = True
        '
        'rbAdult
        '
        Me.rbAdult.AutoSize = True
        Me.rbAdult.Location = New System.Drawing.Point(13, 4)
        Me.rbAdult.Margin = New System.Windows.Forms.Padding(4)
        Me.rbAdult.Name = "rbAdult"
        Me.rbAdult.Size = New System.Drawing.Size(58, 20)
        Me.rbAdult.TabIndex = 0
        Me.rbAdult.TabStop = True
        Me.rbAdult.Text = "Adult"
        Me.rbAdult.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ticket type:"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(113, 185)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.rbGrade3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.rbGrade2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.rbGrade1)
        Me.ttSeatGrade.SetToolTip(Me.SplitContainer2.Panel1, "If seat grade is 1, press ""Grade 1"". If seat grade is 2, click ""Grade 2"". If seat" &
        " grade is 3, click ""Grade 3""")
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.rbCreditCard)
        Me.SplitContainer2.Panel2.Controls.Add(Me.rbCash)
        Me.SplitContainer2.Panel2.Controls.Add(Me.rbDebitCard)
        Me.ttPayment.SetToolTip(Me.SplitContainer2.Panel2, "If paying with Credit Card, click ""Credit Card"". If paying with Debit card, click" &
        " ""Debit Card"". If paying with cash, click ""Cash""")
        Me.SplitContainer2.Size = New System.Drawing.Size(408, 181)
        Me.SplitContainer2.SplitterDistance = 85
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 3
        Me.SplitContainer2.TabStop = False
        '
        'rbGrade3
        '
        Me.rbGrade3.AutoSize = True
        Me.rbGrade3.Location = New System.Drawing.Point(267, 7)
        Me.rbGrade3.Margin = New System.Windows.Forms.Padding(4)
        Me.rbGrade3.Name = "rbGrade3"
        Me.rbGrade3.Size = New System.Drawing.Size(76, 20)
        Me.rbGrade3.TabIndex = 2
        Me.rbGrade3.Text = "Grade 3"
        Me.rbGrade3.UseVisualStyleBackColor = True
        '
        'rbGrade2
        '
        Me.rbGrade2.AutoSize = True
        Me.rbGrade2.Location = New System.Drawing.Point(160, 6)
        Me.rbGrade2.Margin = New System.Windows.Forms.Padding(4)
        Me.rbGrade2.Name = "rbGrade2"
        Me.rbGrade2.Size = New System.Drawing.Size(76, 20)
        Me.rbGrade2.TabIndex = 1
        Me.rbGrade2.Text = "Grade 2"
        Me.rbGrade2.UseVisualStyleBackColor = True
        '
        'rbGrade1
        '
        Me.rbGrade1.AutoSize = True
        Me.rbGrade1.Location = New System.Drawing.Point(53, 6)
        Me.rbGrade1.Margin = New System.Windows.Forms.Padding(4)
        Me.rbGrade1.Name = "rbGrade1"
        Me.rbGrade1.Size = New System.Drawing.Size(76, 20)
        Me.rbGrade1.TabIndex = 0
        Me.rbGrade1.Text = "Grade 1"
        Me.rbGrade1.UseVisualStyleBackColor = True
        '
        'rbCreditCard
        '
        Me.rbCreditCard.AutoSize = True
        Me.rbCreditCard.Location = New System.Drawing.Point(52, 8)
        Me.rbCreditCard.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCreditCard.Name = "rbCreditCard"
        Me.rbCreditCard.Size = New System.Drawing.Size(95, 20)
        Me.rbCreditCard.TabIndex = 0
        Me.rbCreditCard.Text = "Credit Card"
        Me.rbCreditCard.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Location = New System.Drawing.Point(306, 8)
        Me.rbCash.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(59, 20)
        Me.rbCash.TabIndex = 2
        Me.rbCash.Text = "Cash"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'rbDebitCard
        '
        Me.rbDebitCard.AutoSize = True
        Me.rbDebitCard.Location = New System.Drawing.Point(178, 8)
        Me.rbDebitCard.Margin = New System.Windows.Forms.Padding(4)
        Me.rbDebitCard.Name = "rbDebitCard"
        Me.rbDebitCard.Size = New System.Drawing.Size(92, 20)
        Me.rbDebitCard.TabIndex = 1
        Me.rbDebitCard.Text = "Debit Card"
        Me.rbDebitCard.UseVisualStyleBackColor = True
        '
        'rbMemberNo
        '
        Me.rbMemberNo.Location = New System.Drawing.Point(224, 5)
        Me.rbMemberNo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbMemberNo.Name = "rbMemberNo"
        Me.rbMemberNo.Size = New System.Drawing.Size(120, 21)
        Me.rbMemberNo.TabIndex = 0
        Me.rbMemberNo.TabStop = True
        Me.rbMemberNo.Text = "No"
        Me.rbMemberNo.UseVisualStyleBackColor = True
        '
        'rbMemberYes
        '
        Me.rbMemberYes.AutoSize = True
        Me.rbMemberYes.Location = New System.Drawing.Point(96, 5)
        Me.rbMemberYes.Margin = New System.Windows.Forms.Padding(4)
        Me.rbMemberYes.Name = "rbMemberYes"
        Me.rbMemberYes.Size = New System.Drawing.Size(52, 20)
        Me.rbMemberYes.TabIndex = 0
        Me.rbMemberYes.TabStop = True
        Me.rbMemberYes.Text = "Yes"
        Me.rbMemberYes.UseVisualStyleBackColor = True
        '
        'lblSeat
        '
        Me.lblSeat.AutoSize = True
        Me.lblSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeat.Location = New System.Drawing.Point(3, 185)
        Me.lblSeat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(99, 20)
        Me.lblSeat.TabIndex = 4
        Me.lblSeat.Text = "Seat Grade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 369)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Member:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 455)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Instalments:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 282)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Payment Method:"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.IsSplitterFixed = True
        Me.SplitContainer3.Location = New System.Drawing.Point(112, 369)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.rbMemberNo)
        Me.SplitContainer3.Panel1.Controls.Add(Me.rbMemberYes)
        Me.ttMember.SetToolTip(Me.SplitContainer3.Panel1, "If they are a member, press ""Yes"". If they are not a member, press ""No""")
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.rbInstalmentsNo)
        Me.SplitContainer3.Panel2.Controls.Add(Me.rbInstalmentsYes)
        Me.ttInstalments.SetToolTip(Me.SplitContainer3.Panel2, "If they are paying by instalments, click ""Yes"". If they are not and paying outrig" &
        "ht, click ""No""")
        Me.SplitContainer3.Size = New System.Drawing.Size(408, 148)
        Me.SplitContainer3.SplitterDistance = 70
        Me.SplitContainer3.SplitterWidth = 5
        Me.SplitContainer3.TabIndex = 6
        Me.SplitContainer3.TabStop = False
        '
        'rbInstalmentsNo
        '
        Me.rbInstalmentsNo.Location = New System.Drawing.Point(224, 4)
        Me.rbInstalmentsNo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbInstalmentsNo.Name = "rbInstalmentsNo"
        Me.rbInstalmentsNo.Size = New System.Drawing.Size(120, 21)
        Me.rbInstalmentsNo.TabIndex = 0
        Me.rbInstalmentsNo.TabStop = True
        Me.rbInstalmentsNo.Text = "No"
        Me.rbInstalmentsNo.UseVisualStyleBackColor = True
        '
        'rbInstalmentsYes
        '
        Me.rbInstalmentsYes.AutoSize = True
        Me.rbInstalmentsYes.Location = New System.Drawing.Point(96, 4)
        Me.rbInstalmentsYes.Margin = New System.Windows.Forms.Padding(4)
        Me.rbInstalmentsYes.Name = "rbInstalmentsYes"
        Me.rbInstalmentsYes.Size = New System.Drawing.Size(52, 20)
        Me.rbInstalmentsYes.TabIndex = 0
        Me.rbInstalmentsYes.TabStop = True
        Me.rbInstalmentsYes.Text = "Yes"
        Me.rbInstalmentsYes.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(959, 608)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 37)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.ttExit.SetToolTip(Me.btnExit, "Exit program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(165, 588)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 37)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.ttCalculate.SetToolTip(Me.btnCalculate, "Calculate cost")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(371, 588)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(107, 37)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.ttReset.SetToolTip(Me.btnReset, "Reset fields")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(565, 135)
        Me.lstResults.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(500, 292)
        Me.lstResults.TabIndex = 12
        '
        'ttSport
        '
        Me.ttSport.ToolTipTitle = "Sport"
        '
        'ttTicketType
        '
        Me.ttTicketType.ToolTipTitle = "Ticket type"
        '
        'ttSeatGrade
        '
        Me.ttSeatGrade.ToolTipTitle = "Seat Grade"
        '
        'ttPayment
        '
        Me.ttPayment.ToolTipTitle = "Payment Method"
        '
        'ttMember
        '
        Me.ttMember.ToolTipTitle = "Member"
        '
        'ttInstalments
        '
        Me.ttInstalments.ToolTipTitle = "Instalments "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 657)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSeat)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblSport)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Ticket Application"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSport As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents rbFootball As RadioButton
    Friend WithEvents rbRugby As RadioButton
    Friend WithEvents rbAdult As RadioButton
    Friend WithEvents rbChild As RadioButton
    Friend WithEvents rbSenior As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents rbGrade3 As RadioButton
    Friend WithEvents rbGrade2 As RadioButton
    Friend WithEvents rbGrade1 As RadioButton
    Friend WithEvents rbMemberNo As RadioButton
    Friend WithEvents rbMemberYes As RadioButton
    Friend WithEvents lblSeat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents rbDebitCard As RadioButton
    Friend WithEvents rbCreditCard As RadioButton
    Friend WithEvents rbInstalmentsNo As RadioButton
    Friend WithEvents rbInstalmentsYes As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ttSport As ToolTip
    Friend WithEvents ttTicketType As ToolTip
    Friend WithEvents ttSeatGrade As ToolTip
    Friend WithEvents ttPayment As ToolTip
    Friend WithEvents ttMember As ToolTip
    Friend WithEvents ttInstalments As ToolTip
    Friend WithEvents ttExit As ToolTip
    Friend WithEvents ttCalculate As ToolTip
    Friend WithEvents ttReset As ToolTip
End Class
