Public Class frmBookSale
    ' NAME:   student name
    ' DATE:   
    ' PURPOSE: to learn about arithmetic and variables
    '          to learn how to create a SplashScreen
    '          to fill the SplashScreen with company name



    ' Close the program
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' Clear all text boxes and focus
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtTitle.Clear()
        txtDiscount.Clear()
        txtFullPrice.Clear()
        txtPurchasePrice.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        txtTitle.Focus()
    End Sub

    ' Use the entries to determine the cost of the books
    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        'LOCAL VARIABLES
        Dim fullPrice, discount, purchasePrice As Decimal
        Dim quantity As Integer
        Dim price As Decimal

        'GET data from the form
        quantity = Val(txtQuantity.Text)
        price = Val(txtPrice.Text)


        'compute the data for the customer
        fullPrice = quantity * price
        discount = 0.15 * fullPrice
        purchasePrice = fullPrice - discount

        'display the answers
        txtFullPrice.Text = fullPrice.ToString("c")
        txtDiscount.Text = discount.ToString("c")
        txtPurchasePrice.Text = purchasePrice.ToString("c")
    End Sub
    'Make sure all text boxes are cleared
    Private Sub frmBookSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear_Click(sender, e)
    End Sub
End Class
