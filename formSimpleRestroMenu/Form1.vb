Public Class Form1
    Dim quantity As Integer
    Dim price As Integer = 0
    Dim itemname As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Hotchocolate.Checked Then
            If NumericUpDown1.Value = 0 Then
                NumericUpDown1.Value = 1
            End If
            itemname += "Hot Chocolate"
            quantity += NumericUpDown1.Value
            price += 200 * quantity
            '  MsgBox("Item's Name = " & itemname & vbCrLf &
            '      "Quantity = " & quantity & vbCrLf &
            '     "Total Price = " & "Rs. " & price)
        End If

        If Whitechocolate.Checked Then
            If NumericUpDown2.Value = 0 Then
                NumericUpDown2.Value = 1
            End If
            itemname += " White Chocolate"
            quantity += NumericUpDown2.Value
            price += 250 * quantity
            '  MsgBox("Item's Name = " & itemname & vbCrLf &
            '     "Quantity = " & quantity & vbCrLf &
            '    "Total Price = " & "Rs. " & price)
        End If


        MsgBox("Item's Names: " & vbCrLf &
               itemname & vbCrLf &
                  "Quantity = " & quantity & vbCrLf &
                  "Total Price = " & "Rs. " & price)


        If Vanilatea.Checked Then
            If NumericUpDown3.Value = 0 Then
                NumericUpDown3.Value = 1
            End If
            itemname = "Vanila Tea"
            quantity = NumericUpDown3.Value
            price = 250 * quantity
            MsgBox("Item's Name = " & itemname & vbCrLf &
                   "Quantity = " & quantity & vbCrLf &
                   "Total Price = " & "Rs. " & price)
        End If

        If Hotlemon.Checked Then
            If NumericUpDown4.Value = 0 Then
                NumericUpDown4.Value = 1
            End If
            itemname = "Hot Lemon"
            quantity = NumericUpDown4.Value
            price = 150 * quantity
            MsgBox("Item's Name = " & itemname & vbCrLf &
                   "Quantity = " & quantity & vbCrLf &
                   "Total Price = " & "Rs. " & price)
        End If

    End Sub
End Class
