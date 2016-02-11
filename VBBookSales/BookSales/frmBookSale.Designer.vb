<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookSale
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
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblFullPrice = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPurchasePrice = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtFullPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.gpbEntryData = New System.Windows.Forms.GroupBox()
        Me.gpbCustomerCost = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gpbEntryData.SuspendLayout()
        Me.gpbCustomerCost.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Jokerman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFormTitle.Location = New System.Drawing.Point(189, 25)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(189, 47)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Book Sales"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(147, 56)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(34, 17)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(38, 20)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Title"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(171, 98)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price"
        '
        'lblFullPrice
        '
        Me.lblFullPrice.AutoSize = True
        Me.lblFullPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullPrice.Location = New System.Drawing.Point(145, 24)
        Me.lblFullPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFullPrice.Name = "lblFullPrice"
        Me.lblFullPrice.Size = New System.Drawing.Size(73, 20)
        Me.lblFullPrice.TabIndex = 4
        Me.lblFullPrice.Text = "Full Price"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(100, 62)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(118, 20)
        Me.lblDiscount.TabIndex = 5
        Me.lblDiscount.Text = "Discount (15%)"
        '
        'lblPurchasePrice
        '
        Me.lblPurchasePrice.AutoSize = True
        Me.lblPurchasePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchasePrice.Location = New System.Drawing.Point(100, 103)
        Me.lblPurchasePrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPurchasePrice.Name = "lblPurchasePrice"
        Me.lblPurchasePrice.Size = New System.Drawing.Size(115, 20)
        Me.lblPurchasePrice.TabIndex = 6
        Me.lblPurchasePrice.Text = "Purchase Price"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(104, 14)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(377, 26)
        Me.txtTitle.TabIndex = 7
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(229, 50)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(87, 26)
        Me.txtQuantity.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(229, 95)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(87, 26)
        Me.txtPrice.TabIndex = 9
        '
        'txtFullPrice
        '
        Me.txtFullPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullPrice.Location = New System.Drawing.Point(229, 17)
        Me.txtFullPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFullPrice.Name = "txtFullPrice"
        Me.txtFullPrice.ReadOnly = True
        Me.txtFullPrice.Size = New System.Drawing.Size(98, 26)
        Me.txtFullPrice.TabIndex = 10
        Me.txtFullPrice.TabStop = False
        Me.txtFullPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(229, 56)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(98, 26)
        Me.txtDiscount.TabIndex = 11
        Me.txtDiscount.TabStop = False
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPurchasePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasePrice.Location = New System.Drawing.Point(229, 97)
        Me.txtPurchasePrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.ReadOnly = True
        Me.txtPurchasePrice.Size = New System.Drawing.Size(98, 26)
        Me.txtPurchasePrice.TabIndex = 12
        Me.txtPurchasePrice.TabStop = False
        Me.txtPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gpbEntryData
        '
        Me.gpbEntryData.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gpbEntryData.Controls.Add(Me.txtPrice)
        Me.gpbEntryData.Controls.Add(Me.txtQuantity)
        Me.gpbEntryData.Controls.Add(Me.txtTitle)
        Me.gpbEntryData.Controls.Add(Me.lblPrice)
        Me.gpbEntryData.Controls.Add(Me.lblTitle)
        Me.gpbEntryData.Controls.Add(Me.lblQuantity)
        Me.gpbEntryData.Location = New System.Drawing.Point(46, 84)
        Me.gpbEntryData.Margin = New System.Windows.Forms.Padding(2)
        Me.gpbEntryData.Name = "gpbEntryData"
        Me.gpbEntryData.Padding = New System.Windows.Forms.Padding(2)
        Me.gpbEntryData.Size = New System.Drawing.Size(498, 140)
        Me.gpbEntryData.TabIndex = 13
        Me.gpbEntryData.TabStop = False
        '
        'gpbCustomerCost
        '
        Me.gpbCustomerCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpbCustomerCost.Controls.Add(Me.txtPurchasePrice)
        Me.gpbCustomerCost.Controls.Add(Me.txtDiscount)
        Me.gpbCustomerCost.Controls.Add(Me.txtFullPrice)
        Me.gpbCustomerCost.Controls.Add(Me.lblPurchasePrice)
        Me.gpbCustomerCost.Controls.Add(Me.lblDiscount)
        Me.gpbCustomerCost.Controls.Add(Me.lblFullPrice)
        Me.gpbCustomerCost.Location = New System.Drawing.Point(46, 239)
        Me.gpbCustomerCost.Margin = New System.Windows.Forms.Padding(2)
        Me.gpbCustomerCost.Name = "gpbCustomerCost"
        Me.gpbCustomerCost.Padding = New System.Windows.Forms.Padding(2)
        Me.gpbCustomerCost.Size = New System.Drawing.Size(498, 142)
        Me.gpbCustomerCost.TabIndex = 14
        Me.gpbCustomerCost.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(46, 441)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(133, 61)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(229, 441)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 61)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "C&lear Sale"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(411, 441)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 61)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBookSale
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(580, 546)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gpbCustomerCost)
        Me.Controls.Add(Me.gpbEntryData)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBookSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reading and Refreshment Book Store"
        Me.gpbEntryData.ResumeLayout(False)
        Me.gpbEntryData.PerformLayout()
        Me.gpbCustomerCost.ResumeLayout(False)
        Me.gpbCustomerCost.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblFullPrice As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblPurchasePrice As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtFullPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchasePrice As System.Windows.Forms.TextBox
    Friend WithEvents gpbEntryData As System.Windows.Forms.GroupBox
    Friend WithEvents gpbCustomerCost As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
