Public Class Form1
    'variables to determine weight,total,delivery cost and Confirmation flag
    Dim Weight As Integer
    Dim Weight2 As Integer
    Dim Total As Single
    Dim Total2 As Single
    Dim Delivery As Single
    Dim dCost As Boolean = False
    Dim dLImit As Boolean = False
    Dim New232 As Integer = 4
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'if there is nothing in the text box a message box appears

        'checks if delivery cost message box has been "OKED"
        If cmbEggs.Text = "" Then
            MsgBox("Please select an item from the drop down box")
        Else
            If dCost = False Then
                If Weight < 1500 Then 'case selects for each item and their respective weight, and price
                    Select Case cmbEggs.SelectedItem
                        Case "Red Foiled L 250g $12.00", "Blue Foiled L 250g $12.00", "Gold Foiled L 250g $12.00" : Total2 += 12.0 * numQuantity.Value
                            Weight2 += 250 * numQuantity.Value
                        Case "Red Foiled M 150g $8.50", "Blue Foiled M 150g $8.50", "Gold Foiled M 150g $8.50" : Total2 += 8.5 * numQuantity.Value
                            Weight2 += 150 * numQuantity.Value
                        Case "Red Foiled S 75g $4.75", "Blue Foiled S 75g $4.75", "Gold Foiled S 75g $4.75" : Total2 += 4.75 * numQuantity.Value
                            Weight2 += 75 * numQuantity.Value
                        Case "Mini Solid x12 350g $10.50" : Total2 += 10.5 * numQuantity.Value
                            Weight2 += 350 * numQuantity.Value
                    End Select
                    If Weight + Weight2 > 1500 Then 'if the weight is greater than 1500(after multiply by quantity) shows confirmation box
                        Dim answer As Integer = MsgBox("The weight is has exceeded 1500g, the delivery cost will be $6.45, do you want to continue?", MsgBoxStyle.YesNo)
                        If answer = DialogResult.Yes Then 'turns delivery to 6.45, removes item from combo box and into list box
                            'total is confirmed adds weight/total 2 into actual totals and resets total/weight2 to 0
                            Delivery = 6.45
                            lstHamper.Items.Add(cmbEggs.SelectedItem + " x " + CStr(numQuantity.Value))
                            cmbEggs.Items.Remove(cmbEggs.SelectedItem)
                            numQuantity.Value = 1
                            dCost = True
                            Total += Total2
                            Weight += Weight2
                            Total2 = 0
                            Weight2 = 0
                        ElseIf answer = DialogResult.No Then 'if no the weight2/total2 is returned to their original values
                            Weight2 = 0
                            Total2 = 0
                            cmbEggs.Text = ""
                            numQuantity.Value = 1
                            dCost = False
                        End If
                    ElseIf Weight + Weight2 < 1500 Then 'if the weight + weight2 is below 1500 continue as usual
                        Select Case cmbEggs.SelectedItem
                            Case "Red Foiled L 250g $12.00", "Blue Foiled L 250g $12.00", "Gold Foiled L 250g $12.00" : Total += 12.0 * numQuantity.Value
                                Weight += 250 * numQuantity.Value
                            Case "Red Foiled M 150g $8.50", "Blue Foiled M 150g $8.50", "Gold Foiled M 150g $8.50" : Total += 8.5 * numQuantity.Value
                                Weight += 150 * numQuantity.Value
                            Case "Red Foiled S 75g $4.75", "Blue Foiled S 75g $4.75", "Gold Foiled S 75g $4.75" : Total += 4.75 * numQuantity.Value
                                Weight += 75 * numQuantity.Value
                            Case "Mini Solid x12 350g $10.50" : Total += 10.5 * numQuantity.Value
                                Weight += 350 * numQuantity.Value
                        End Select
                        lstHamper.Items.Add(cmbEggs.SelectedItem + " x " + CStr(numQuantity.Value))
                        cmbEggs.Items.Remove(cmbEggs.SelectedItem)
                        Weight2 = 0 'weight/total 2 is reset to 0
                        Total2 = 0
                    End If
                Else
                    Weight2 = 0 'more resetting variables
                    Total2 = 0
                End If
            Else 'if the "msgbox flag" is tripped a case select is used for each item for price, weight etc then removed from combo box and into listbox
                Select Case cmbEggs.SelectedItem
                    Case "Red Foiled L 250g $12.00", "Blue Foiled L 250g $12.00", "Gold Foiled L 250g $12.00" : Total += 12.0 * numQuantity.Value
                        Weight += 250 * numQuantity.Value
                    Case "Red Foiled M 150g $8.50", "Blue Foiled M 150g $8.50", "Gold Foiled M 150g $8.50" : Total += 8.5 * numQuantity.Value
                        Weight += 150 * numQuantity.Value
                    Case "Red Foiled S 75g $4.75", "Blue Foiled S 75g $4.75", "Gold Foiled S 75g $4.75" : Total += 4.75 * numQuantity.Value
                        Weight += 75 * numQuantity.Value
                    Case "Mini Solid x12 350g $10.50" : Total += 10.5 * numQuantity.Value
                        Weight += 350 * numQuantity.Value
                End Select
                lstHamper.Items.Add(cmbEggs.SelectedItem + " x " + CStr(numQuantity.Value))
                cmbEggs.Items.Remove(cmbEggs.SelectedItem)
                numQuantity.Value = 1
            End If
        End If
        'once 4 items has been reached the user is alerted.
        If dLImit = False Then
            If lstHamper.Items.Count = 4 Then
                Dim msgboxAnswer As Integer = MsgBox("You have reached the limit(4)")
                If DialogResult.OK Then
                    dLImit = True
                End If
            End If
        End If
        numQuantity.Value = 1 'More resetting
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'remaining items is equal to 4 - the amount of items in the listbox
        lblCount.Text = 4 - lstHamper.Items.Count

        'for every item in the listbox, the backcolour of remaining items label is changed
        If lstHamper.Items.Count = 0 Then
            lblCount.BackColor = Color.White
        ElseIf lstHamper.Items.Count = 1 Then
            lblCount.BackColor = Color.Khaki
        ElseIf lstHamper.Items.Count = 2 Then
            lblCount.BackColor = Color.Orange
        ElseIf lstHamper.Items.Count = 3 Then
            lblCount.BackColor = Color.Red
        ElseIf lstHamper.Items.Count = 4 Then
            lblCount.BackColor = Color.Maroon
        End If
        'if the list count returns > or = to 1 the delivery is 3.95 otherwise its 0
        If lstHamper.Items.Count >= 1 Then
            Delivery = 3.95
        Else
            Delivery = 0
        End If
        'if the weight is greater than 1500 the delivery cost is 6.45
        If Weight > 1500 Then
            Delivery = 6.45
        End If
        'once the max items is reached, the add button is disabled
        If lstHamper.Items.Count = 4 Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
        'if nothing is selected in the listbox, the delete and edit button are disabled
        If Not lstHamper.SelectedIndex = -1 Then
            btnDelete.Enabled = True
            btnEdit.Enabled = True
        Else
            btnDelete.Enabled = False
            btnEdit.Enabled = False
        End If
        'all variables are shown in labels
        lblDeliveryCost.Text = FormatCurrency(Delivery)
        lblWeight.Text = CStr(Weight) + "g"
        lblSubTotal.Text = FormatCurrency(Total + Delivery)
        lblGST.Text = FormatCurrency((Total + Delivery) * 0.1)
        lblTotal.Text = FormatCurrency((Total + Delivery) * 1.1)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strArray() As String 'local string array
        Dim Multipler As Integer 'index of to use with m.vb.left
        Multipler = lstHamper.SelectedItem.IndexOf(" x ") 'find the index of " x "
        strArray = lstHamper.SelectedItem.split(" ") 'split the selected item by each " "
        'find the number needed and converted so it can be deducted from subtotal, weight etc.
        Weight -= CInt(strArray(strArray.Length - 4).Replace("g", "") * strArray(strArray.Length - 1))
        Weight2 -= CInt(strArray(strArray.Length - 4).Replace("g", "") * strArray(strArray.Length - 1))
        Total -= strArray(strArray.Length - 3) * strArray(strArray.Length - 1)
        Total2 -= strArray(strArray.Length - 3) * strArray(strArray.Length - 1)

        'if there is something selected, add the selected item in the listbox into the combo box with some elements 
        'and finally removes from listbox
        If Not lstHamper.SelectedIndex = -1 Then
            cmbEggs.Items.Add(Microsoft.VisualBasic.Left(lstHamper.SelectedItem, Multipler))
            lstHamper.Items.Remove(lstHamper.SelectedItem)
        End If
        New232 += 1
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'more or less the same as the delete button, only its getting the quantity from the selected item and put into the numerical up down
        Dim strArray() As String
        Dim Multipler As Integer
        Multipler = lstHamper.SelectedItem.IndexOf(" x ")
        If Not lstHamper.SelectedIndex = -1 Then
            strArray = lstHamper.SelectedItem.Split(" ")
            numQuantity.Value = CInt(strArray.Last)
            Weight -= CInt(strArray(strArray.Length - 4).Replace("g", "") * strArray(strArray.Length - 1))
            Weight2 -= CInt(strArray(strArray.Length - 4).Replace("g", "") * strArray(strArray.Length - 1))
            Total -= strArray(strArray.Length - 3) * strArray(strArray.Length - 1)
            Total2 -= strArray(strArray.Length - 3) * strArray(strArray.Length - 1)
            cmbEggs.Items.Add(Microsoft.VisualBasic.Left(lstHamper.SelectedItem, Multipler))
            cmbEggs.Text = Microsoft.VisualBasic.Left(lstHamper.SelectedItem, Multipler)
            lstHamper.Items.Remove(lstHamper.SelectedItem)
        Else
            MsgBox("Please select one of your added items")
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'once the form/program is terminated, each line in the listbox is read and written into a text file found in 
        '.\debug directory with the Subtotal, GST, Total, Weight and delivery Cost written to be used for a receipt and overwrites the text file
        Using Receipt As New IO.StreamWriter("Receipt.txt", False)
            For Each str As String In lstHamper.Items
                Receipt.WriteLine(str)
            Next
            Receipt.WriteLine("Subtotal = " + lblSubTotal.Text)
            Receipt.WriteLine("GST = " + lblGST.Text)
            Receipt.WriteLine("Total = " + lblTotal.Text)
            Receipt.WriteLine("Weight = " + lblWeight.Text)
            Receipt.WriteLine("Delivery Cost = " + CStr(FormatCurrency(Delivery)))
            Receipt.Close()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Using Clear As New IO.StreamWriter("cmbEggs.Items", True)
            For Each Str As String In lstHamper.Items
                Clear.WriteLine(Str)
            Next
        End Using
    End Sub

    Private Sub cmbEggs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEggs.KeyPress
        New232 -= 1
        If e.KeyChar = "Enter" = False Then
            e.Handled = True
            If cmbEggs.Text = "" Then
                MsgBox("Please select an item from the drop down box")
            Else
                If dCost = False Then
                    If Weight < 1500 Then 'case selects for each item and their respective weight, and price
                        Select Case cmbEggs.SelectedItem
                            Case "Red Foiled L 250g $12.00", "Blue Foiled L 250g $12.00", "Gold Foiled L 250g $12.00" : Total2 += 12.0 * numQuantity.Value
                                Weight2 += 250 * numQuantity.Value
                            Case "Red Foiled M 150g $8.50", "Blue Foiled M 150g $8.50", "Gold Foiled M 150g $8.50" : Total2 += 8.5 * numQuantity.Value
                                Weight2 += 150 * numQuantity.Value
                            Case "Red Foiled S 75g $4.75", "Blue Foiled S 75g $4.75", "Gold Foiled S 75g $4.75" : Total2 += 4.75 * numQuantity.Value
                                Weight2 += 75 * numQuantity.Value
                            Case "Mini Solid x12 350g $10.50" : Total2 += 10.5 * numQuantity.Value
                                Weight2 += 350 * numQuantity.Value
                        End Select
                        If Weight + Weight2 > 1500 Then 'if the weight is greater than 1500(after multiply by quantity) shows confirmation box
                            Dim answer As Integer = MsgBox("The weight is has exceeded 1500g, the delivery cost will be $6.45, do you want to continue?", MsgBoxStyle.YesNo)
                            If answer = DialogResult.Yes Then 'turns delivery to 6.45, removes item from combo box and into list box
                                'total is confirmed adds weight/total 2 into actual totals and resets total/weight2 to 0
                                Delivery = 6.45
                                lstHamper.Items.Add(cmbEggs.SelectedItem + " x " + CStr(numQuantity.Value))
                                cmbEggs.Items.Remove(cmbEggs.SelectedItem)
                                numQuantity.Value = 1
                                dCost = True
                                Total += Total2
                                Weight += Weight2
                                Total2 = 0
                                Weight2 = 0
                            ElseIf answer = DialogResult.No Then 'if no the weight2/total2 is returned to their original values
                                Weight2 = 0
                                Total2 = 0
                                cmbEggs.Text = ""
                                numQuantity.Value = 1
                                dCost = False
                            End If
                        ElseIf Weight + Weight2 < 1500 Then 'if the weight + weight2 is below 1500 continue as usual
                            Select Case cmbEggs.SelectedItem
                                Case "Red Foiled L 250g $12.00", "Blue Foiled L 250g $12.00", "Gold Foiled L 250g $12.00" : Total += 12.0 * numQuantity.Value
                                    Weight += 250 * numQuantity.Value
                                Case "Red Foiled M 150g $8.50", "Blue Foiled M 150g $8.50", "Gold Foiled M 150g $8.50" : Total += 8.5 * numQuantity.Value
                                    Weight += 150 * numQuantity.Value
                                Case "Red Foiled S 75g $4.75", "Blue Foiled S 75g $4.75", "Gold Foiled S 75g $4.75" : Total += 4.75 * numQuantity.Value
                                    Weight += 75 * numQuantity.Value
                                Case "Mini Solid x12 350g $10.50" : Total += 10.5 * numQuantity.Value
                                    Weight += 350 * numQuantity.Value
                            End Select
                            lstHamper.Items.Add(cmbEggs.SelectedItem + " x " + CStr(numQuantity.Value))
                            cmbEggs.Items.Remove(cmbEggs.SelectedItem)
                            Weight2 = 0 'weight/total 2 is reset to 0
                            Total2 = 0
                        End If
                    Else
                        Weight2 = 0 'more resetting variables
                        Total2 = 0
                    End If
                Else 'if the "msgbox flag" is tripped a case select is used for each item for price, weight etc then removed from combo box and into listbox
                    Select Case cmbEggs.SelectedItem
                        Case "Red Foiled L 250g $12.00", "Blue Foiled L 250g $12.00", "Gold Foiled L 250g $12.00" : Total += 12.0 * numQuantity.Value
                            Weight += 250 * numQuantity.Value
                        Case "Red Foiled M 150g $8.50", "Blue Foiled M 150g $8.50", "Gold Foiled M 150g $8.50" : Total += 8.5 * numQuantity.Value
                            Weight += 150 * numQuantity.Value
                        Case "Red Foiled S 75g $4.75", "Blue Foiled S 75g $4.75", "Gold Foiled S 75g $4.75" : Total += 4.75 * numQuantity.Value
                            Weight += 75 * numQuantity.Value
                        Case "Mini Solid x12 350g $10.50" : Total += 10.5 * numQuantity.Value
                            Weight += 350 * numQuantity.Value
                    End Select
                    lstHamper.Items.Add(cmbEggs.SelectedItem + " x " + CStr(numQuantity.Value))
                    cmbEggs.Items.Remove(cmbEggs.SelectedItem)
                    numQuantity.Value = 1
                End If
            End If
            'once 4 items has been reached the user is alerted.
            If dLImit = False Then
                If lstHamper.Items.Count = 4 Then
                    Dim msgboxAnswer As Integer = MsgBox("You have reached the limit(4)")
                    If DialogResult.OK Then
                        dLImit = True
                    End If
                End If
            End If
            numQuantity.Value = 1 'More resetting
        End If
    End Sub
End Class
