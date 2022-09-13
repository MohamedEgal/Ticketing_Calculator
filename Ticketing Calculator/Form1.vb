Public Class Form1

	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
		Dim totalCost
		lstResults.Items.Clear()
		If rbRugby.Checked Then
			If rbAdult.Checked Then
				totalCost = 175
				If rbGrade1.Checked Then
					totalCost += 150
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next

							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade2.Checked Then
					totalCost += 120
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade3.Checked Then
					totalCost += 87.5
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				Else
					MessageBox.Show("Please choose which seat grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			ElseIf rbChild.Checked Then
				totalCost = 85
				If rbGrade1.Checked Then
					totalCost += 150
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade2.Checked Then
					totalCost += 120
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade3.Checked Then
					totalCost += 87.5
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				Else
					MessageBox.Show("Please choose which seat grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			ElseIf rbSenior.Checked Then
				totalCost = 105
				If rbGrade1.Checked Then
					totalCost += 150
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade2.Checked Then
					totalCost += 120
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade3.Checked Then
					totalCost += 87.5
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If

					End If
				Else
					MessageBox.Show("Please choose which seat grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			Else
				MessageBox.Show("Please choose ticket type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		ElseIf rbFootball.Checked Then
			If rbAdult.Checked Then
				totalCost = 450
				If rbGrade1.Checked Then
					totalCost += 150
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade2.Checked Then
					totalCost += 120
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade3.Checked Then
					totalCost += 87.5
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				Else
					MessageBox.Show("Please choose which seat grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			ElseIf rbChild.Checked Then
				totalCost = 275
				If rbGrade1.Checked Then
					totalCost += 150
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade2.Checked Then
					totalCost += 120
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade3.Checked Then
					totalCost += 87.5
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				Else
					MessageBox.Show("Please choose which seat grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			ElseIf rbSenior.Checked Then
				totalCost = 295
				If rbGrade1.Checked Then
					totalCost += 150
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade2.Checked Then
					totalCost += 120
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Else
						MessageBox.Show("Please choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
				ElseIf rbGrade3.Checked Then
					totalCost += 87.5
					If rbCreditCard.Checked Then
						totalCost = totalCost * 1.0375
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					ElseIf rbDebitCard.Checked Or rbCash.Checked Then
						If rbMemberYes.Checked Then
							totalCost = totalCost * 0.88
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

							End If
						ElseIf rbMemberNo.Checked Then
							If rbInstalmentsYes.Checked Then
								totalCost = totalCost / 12
								For instalments As Integer = 1 To 12
									lstResults.Items.Add("Payment" & " " & instalments & " " & "is" & " £" & Math.Round(totalCost * 100) / 100)
								Next
							ElseIf rbInstalmentsNo.Checked Then
								lstResults.Items.Add("Total cost is £" & totalCost)
							Else
								MessageBox.Show("Please choose if instalments are yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
							End If
						Else
							MessageBox.Show("Please choose if buyer is a member or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If

					End If
				Else
					MessageBox.Show("Please choose which seat grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			Else
				MessageBox.Show("Please choose which ticket type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		Else
			MessageBox.Show("Please choose the type of sport", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		lstResults.Items.Clear()
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub


End Class
