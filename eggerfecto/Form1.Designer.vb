<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmbEggs = New System.Windows.Forms.ComboBox()
        Me.lstHamper = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblSubtotalTitle = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.lblGSTitle = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblWeightHeading = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblGST = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblDeliveryCost = New System.Windows.Forms.Label()
        Me.lblDeliveryHeading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbEggs
        '
        Me.cmbEggs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEggs.FormattingEnabled = True
        Me.cmbEggs.Items.AddRange(New Object() {"Red Foiled L 250g $12.00", "Blue Foiled L 250g $12.00", "Gold Foiled L 250g $12.00", "Red Foiled M 150g $8.50", "Blue Foiled M 150g $8.50", "Gold Foiled M 150g $8.50", "Red Foiled S 75g $4.75", "Blue Foiled S 75g $4.75", "Gold Foiled S 75g $4.75", "Mini Solid x12 350g $10.50"})
        Me.cmbEggs.Location = New System.Drawing.Point(12, 41)
        Me.cmbEggs.Name = "cmbEggs"
        Me.cmbEggs.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbEggs.Size = New System.Drawing.Size(135, 21)
        Me.cmbEggs.TabIndex = 2
        Me.cmbEggs.TabStop = False
        '
        'lstHamper
        '
        Me.lstHamper.FormattingEnabled = True
        Me.lstHamper.Location = New System.Drawing.Point(17, 129)
        Me.lstHamper.Name = "lstHamper"
        Me.lstHamper.Size = New System.Drawing.Size(264, 121)
        Me.lstHamper.Sorted = True
        Me.lstHamper.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Location = New System.Drawing.Point(206, 294)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'numQuantity
        '
        Me.numQuantity.Location = New System.Drawing.Point(164, 41)
        Me.numQuantity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(135, 20)
        Me.numQuantity.TabIndex = 8
        Me.numQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblSubtotalTitle
        '
        Me.lblSubtotalTitle.BackColor = System.Drawing.Color.Yellow
        Me.lblSubtotalTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotalTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalTitle.Location = New System.Drawing.Point(12, 297)
        Me.lblSubtotalTitle.Name = "lblSubtotalTitle"
        Me.lblSubtotalTitle.Size = New System.Drawing.Size(71, 32)
        Me.lblSubtotalTitle.TabIndex = 9
        Me.lblSubtotalTitle.Text = "SubTotal"
        Me.lblSubtotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.BackColor = System.Drawing.Color.Yellow
        Me.lblTotalTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTitle.Location = New System.Drawing.Point(12, 394)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(71, 32)
        Me.lblTotalTitle.TabIndex = 10
        Me.lblTotalTitle.Text = "Total"
        Me.lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGSTitle
        '
        Me.lblGSTitle.BackColor = System.Drawing.Color.Yellow
        Me.lblGSTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGSTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGSTitle.Location = New System.Drawing.Point(12, 345)
        Me.lblGSTitle.Name = "lblGSTitle"
        Me.lblGSTitle.Size = New System.Drawing.Size(71, 32)
        Me.lblGSTitle.TabIndex = 11
        Me.lblGSTitle.Text = "GST"
        Me.lblGSTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.White
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(89, 74)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(25, 18)
        Me.lblWeight.TabIndex = 16
        Me.lblWeight.Text = "0g"
        '
        'lblWeightHeading
        '
        Me.lblWeightHeading.AutoSize = True
        Me.lblWeightHeading.BackColor = System.Drawing.Color.White
        Me.lblWeightHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeightHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightHeading.Location = New System.Drawing.Point(17, 74)
        Me.lblWeightHeading.Name = "lblWeightHeading"
        Me.lblWeightHeading.Size = New System.Drawing.Size(55, 18)
        Me.lblWeightHeading.TabIndex = 15
        Me.lblWeightHeading.Text = "Weight:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblGST
        '
        Me.lblGST.BackColor = System.Drawing.Color.Yellow
        Me.lblGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGST.Location = New System.Drawing.Point(89, 345)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(86, 32)
        Me.lblGST.TabIndex = 21
        Me.lblGST.Text = "$0.00"
        Me.lblGST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Yellow
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(89, 394)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(86, 32)
        Me.lblTotal.TabIndex = 20
        Me.lblTotal.Text = "$0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Yellow
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(89, 297)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(86, 32)
        Me.lblSubTotal.TabIndex = 19
        Me.lblSubTotal.Text = "$0.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Location = New System.Drawing.Point(206, 391)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 35)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.BackColor = System.Drawing.Color.White
        Me.lblRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.Location = New System.Drawing.Point(157, 73)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(110, 18)
        Me.lblRemaining.TabIndex = 17
        Me.lblRemaining.Text = "Remaining Items"
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.White
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(273, 73)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(19, 18)
        Me.lblCount.TabIndex = 22
        Me.lblCount.Text = "4"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(86, -2)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(64, 18)
        Me.lblHead.TabIndex = 1
        Me.lblHead.Text = "Eggerfecto"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(206, 342)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblDeliveryCost
        '
        Me.lblDeliveryCost.AutoSize = True
        Me.lblDeliveryCost.BackColor = System.Drawing.Color.White
        Me.lblDeliveryCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeliveryCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliveryCost.Location = New System.Drawing.Point(116, 108)
        Me.lblDeliveryCost.Name = "lblDeliveryCost"
        Me.lblDeliveryCost.Size = New System.Drawing.Size(41, 18)
        Me.lblDeliveryCost.TabIndex = 25
        Me.lblDeliveryCost.Text = "$0.00"
        '
        'lblDeliveryHeading
        '
        Me.lblDeliveryHeading.AutoSize = True
        Me.lblDeliveryHeading.BackColor = System.Drawing.Color.White
        Me.lblDeliveryHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeliveryHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliveryHeading.Location = New System.Drawing.Point(17, 108)
        Me.lblDeliveryHeading.Name = "lblDeliveryHeading"
        Me.lblDeliveryHeading.Size = New System.Drawing.Size(93, 18)
        Me.lblDeliveryHeading.TabIndex = 24
        Me.lblDeliveryHeading.Text = "Delivery Cost:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Egg Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Quantity:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(304, 441)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDeliveryCost)
        Me.Controls.Add(Me.lblDeliveryHeading)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblGST)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblWeightHeading)
        Me.Controls.Add(Me.lblGSTitle)
        Me.Controls.Add(Me.lblTotalTitle)
        Me.Controls.Add(Me.lblSubtotalTitle)
        Me.Controls.Add(Me.numQuantity)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstHamper)
        Me.Controls.Add(Me.cmbEggs)
        Me.Controls.Add(Me.lblHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Eggerfecto"
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbEggs As System.Windows.Forms.ComboBox
    Friend WithEvents lstHamper As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents numQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSubtotalTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
    Friend WithEvents lblGSTitle As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblWeightHeading As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblDeliveryCost As System.Windows.Forms.Label
    Friend WithEvents lblDeliveryHeading As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
