Public Class frmBobsPretzels
    Dim intTotalCheeseCount As Integer
    Dim intTotalNoCheeseCount As Integer
    Dim decTotalSalesCount As Decimal

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Declare Variables
        Dim intNumberPretzelCheese As Integer
        Dim intNumberPretzelNoCheese As Integer
        Dim decIndividualSaleTotal As Decimal


        'Get Inputs
        intNumberPretzelCheese = txtPretzelCheese.Text
        intNumberPretzelNoCheese = txtPretzelNoCheese.Text

        'Do Calculations
        decIndividualSaleTotal = (intNumberPretzelCheese * 5) + (intNumberPretzelNoCheese * 2.5)

        intTotalCheeseCount += intNumberPretzelCheese
        intTotalNoCheeseCount += intNumberPretzelNoCheese
        decTotalSalesCount += decIndividualSaleTotal


        'Display Outputs
        lblIndividualSaleTotal.Text = FormatCurrency(decIndividualSaleTotal)
        lblTotalCheeseSold.Text = intTotalCheeseCount
        lblTotalNoCheeseSold.Text = intTotalNoCheeseCount
        lblTotalSales.Text = FormatCurrency(decTotalSalesCount)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPretzelCheese.Clear()
        txtPretzelNoCheese.Clear()
        lblIndividualSaleTotal.ResetText()
        txtPretzelNoCheese.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

End Class
