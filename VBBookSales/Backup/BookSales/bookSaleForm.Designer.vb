<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookSaleForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.titleTextBox = New System.Windows.Forms.TextBox
        Me.quantityTextBox = New System.Windows.Forms.TextBox
        Me.priceTextBox = New System.Windows.Forms.TextBox
        Me.extendedPriceTextBox = New System.Windows.Forms.TextBox
        Me.discountTextBox = New System.Windows.Forms.TextBox
        Me.discountedPriceTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.calculateButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Extended Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "15% Discount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Discounted Price"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(74, 16)
        Me.titleTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(188, 20)
        Me.titleTextBox.TabIndex = 7
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(74, 44)
        Me.quantityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(76, 20)
        Me.quantityTextBox.TabIndex = 8
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(74, 72)
        Me.priceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(76, 20)
        Me.priceTextBox.TabIndex = 9
        '
        'extendedPriceTextBox
        '
        Me.extendedPriceTextBox.Location = New System.Drawing.Point(190, 16)
        Me.extendedPriceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.extendedPriceTextBox.Name = "extendedPriceTextBox"
        Me.extendedPriceTextBox.ReadOnly = True
        Me.extendedPriceTextBox.Size = New System.Drawing.Size(76, 20)
        Me.extendedPriceTextBox.TabIndex = 10
        Me.extendedPriceTextBox.TabStop = False
        Me.extendedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'discountTextBox
        '
        Me.discountTextBox.Location = New System.Drawing.Point(190, 43)
        Me.discountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.discountTextBox.Name = "discountTextBox"
        Me.discountTextBox.ReadOnly = True
        Me.discountTextBox.Size = New System.Drawing.Size(76, 20)
        Me.discountTextBox.TabIndex = 11
        Me.discountTextBox.TabStop = False
        Me.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'discountedPriceTextBox
        '
        Me.discountedPriceTextBox.Location = New System.Drawing.Point(190, 70)
        Me.discountedPriceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.discountedPriceTextBox.Name = "discountedPriceTextBox"
        Me.discountedPriceTextBox.ReadOnly = True
        Me.discountedPriceTextBox.Size = New System.Drawing.Size(76, 20)
        Me.discountedPriceTextBox.TabIndex = 12
        Me.discountedPriceTextBox.TabStop = False
        Me.discountedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.priceTextBox)
        Me.GroupBox1.Controls.Add(Me.quantityTextBox)
        Me.GroupBox1.Controls.Add(Me.titleTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 41)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(280, 113)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.discountedPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.discountTextBox)
        Me.GroupBox2.Controls.Add(Me.extendedPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 155)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(278, 104)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(11, 280)
        Me.calculateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(110, 35)
        Me.calculateButton.TabIndex = 15
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(125, 280)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(110, 35)
        Me.clearButton.TabIndex = 16
        Me.clearButton.Text = "C&lear Sale"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(239, 280)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(110, 35)
        Me.exitButton.TabIndex = 17
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'bookSaleForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(362, 343)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "bookSaleForm"
        Me.Text = "R 'n R for Reading 'n Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents titleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents extendedPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents discountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents discountedPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
