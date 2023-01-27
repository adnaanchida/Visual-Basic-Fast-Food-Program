'Adnaan Chida
'To get the cost of fast food buying using visual basic

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblContactInfo.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'will clear the labels of the receipt

        lblfinaldollarcost.Text = ""
        lblsubtotalcost.Text = ""
        lbltaxcost.Text = ""
    End Sub

    Private Sub picCheeseburger_Click(sender As Object, e As EventArgs) Handles picCheeseburger.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'will close the program
        Close()
    End Sub

    Private Sub radDCheeseburger_CheckedChanged(sender As Object, e As EventArgs) Handles radDCheeseburger.CheckedChanged
        'will show only the cheeseburger and hide all the other pictures

        picCheeseburger.Visible = True
        picChickenMcNuggets.Visible = False
        picChickenSandwich.Visible = False
        picChickTenders.Visible = False
        picMandSBurger.Visible = False

    End Sub

    Private Sub radChickenSandwich_CheckedChanged(sender As Object, e As EventArgs) Handles radChickenSandwich.CheckedChanged
        'will show only the Chicken Sandwich and hide all the other pictures
        picCheeseburger.Visible = False
        picChickenMcNuggets.Visible = False
        picChickenSandwich.Visible = True
        picChickTenders.Visible = False
        picMandSBurger.Visible = False
    End Sub

    Private Sub radMcNuggets_CheckedChanged(sender As Object, e As EventArgs) Handles radMcNuggets.CheckedChanged
        'will show only the Chicken McNuggets and hide all the other pictures
        picCheeseburger.Visible = False
        picChickenMcNuggets.Visible = True
        picChickenSandwich.Visible = False
        picChickTenders.Visible = False
        picMandSBurger.Visible = False
    End Sub

    Private Sub radTenders_CheckedChanged(sender As Object, e As EventArgs) Handles radTenders.CheckedChanged
        'will show only the Chicken Tenders and hide all the other pictures
        picCheeseburger.Visible = False
        picChickenMcNuggets.Visible = False
        picChickenSandwich.Visible = False
        picChickTenders.Visible = True
        picMandSBurger.Visible = False
    End Sub

    Private Sub radMandSwissBurer_CheckedChanged(sender As Object, e As EventArgs) Handles radMandSwissBurer.CheckedChanged
        'will show only the Mushroom and swiss burger and hide all the other pictures
        picCheeseburger.Visible = False
        picChickenMcNuggets.Visible = False
        picChickenSandwich.Visible = False
        picChickTenders.Visible = False
        picMandSBurger.Visible = True
    End Sub

    Private Sub radFries_CheckedChanged(sender As Object, e As EventArgs) Handles radFries.CheckedChanged
        'will show only the fries and hide all the other pictures
        picFries.Visible = True
        picYogurt.Visible = False
        picPoutine.Visible = False
        picParfait.Visible = False
        picAppleSlices.Visible = False


    End Sub

    Private Sub radAppleSlices_CheckedChanged(sender As Object, e As EventArgs) Handles radAppleSlices.CheckedChanged
        'will show only the apple slices and hide all the other pictures
        picFries.Visible = False
        picYogurt.Visible = False
        picPoutine.Visible = False
        picParfait.Visible = False
        picAppleSlices.Visible = True
    End Sub

    Private Sub radYogurt_CheckedChanged(sender As Object, e As EventArgs) Handles radYogurt.CheckedChanged
        'will show only the yogurt and hide all the other pictures
        picFries.Visible = False
        picYogurt.Visible = True
        picPoutine.Visible = False
        picParfait.Visible = False
        picAppleSlices.Visible = False
    End Sub

    Private Sub radParfait_CheckedChanged(sender As Object, e As EventArgs) Handles radParfait.CheckedChanged
        'will show only the Parfait and hide all the other pictures
        picFries.Visible = False
        picYogurt.Visible = False
        picPoutine.Visible = False
        picParfait.Visible = True
        picAppleSlices.Visible = False
    End Sub

    Private Sub radPoutine_CheckedChanged(sender As Object, e As EventArgs) Handles radPoutine.CheckedChanged
        'will show only the poutione and hide all the other pictures
        picFries.Visible = False
        picYogurt.Visible = False
        picPoutine.Visible = True
        picParfait.Visible = False
        picAppleSlices.Visible = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'will clear the labels of the receipt

        lblfinaldollarcost.Text = ""
        lblsubtotalcost.Text = ""
        lbltaxcost.Text = ""
    End Sub

    Private Sub radCocaCola_CheckedChanged(sender As Object, e As EventArgs) Handles radCocaCola.CheckedChanged
        'will show only the Coco cola pic and hide all the other pic

        piccocalcola.Visible = True
        picHotchocolate.Visible = False
        picMIX.Visible = False
        picMocha.Visible = False
        picCappaccino.Visible = False
    End Sub

    Private Sub radHotChocolate_CheckedChanged(sender As Object, e As EventArgs) Handles radHotChocolate.CheckedChanged
        'will show only the Hot Chocolate pic and hide all the other pic
        piccocalcola.Visible = False
        picHotchocolate.Visible = True
        picMIX.Visible = False
        picMocha.Visible = False
        picCappaccino.Visible = False
    End Sub

    Private Sub radMIXSprite_CheckedChanged(sender As Object, e As EventArgs) Handles radMIXSprite.CheckedChanged
        'will show only the MIX pic and hide all the other pic
        piccocalcola.Visible = False
        picHotchocolate.Visible = False
        picMIX.Visible = True
        picMocha.Visible = False
        picCappaccino.Visible = False
    End Sub

    Private Sub radCapaccino_CheckedChanged(sender As Object, e As EventArgs) Handles radCapaccino.CheckedChanged
        'will show only the Capaccinno pic and hide all the other pic
        piccocalcola.Visible = False
        picHotchocolate.Visible = False
        picMIX.Visible = False
        picMocha.Visible = False
        picCappaccino.Visible = True
    End Sub

    Private Sub radMocha_CheckedChanged(sender As Object, e As EventArgs) Handles radMocha.CheckedChanged
        'will show only the Mocha pic and hide all the other pic
        picHotchocolate.Visible = False
        picMIX.Visible = False
        picMocha.Visible = True
        picCappaccino.Visible = False
    End Sub

    Private Sub picMocha_Click(sender As Object, e As EventArgs) Handles picMocha.Click

    End Sub

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        'declaration
        Dim dec3dollar As Decimal = 3D
        Dim dec1dollar As Decimal = 1D
        Dim dec2dollar As Decimal = 2D
        Dim dectax As Decimal = 0.0825D
        Dim decsubtotal As Decimal
        Dim decfinaltotal As Decimal
        Dim decTaxCost As Decimal

        'will calculate and display the cost

        If radDCheeseburger.Checked Then
            decsubtotal = dec3dollar
        ElseIf radChickenSandwich.Checked Then
            decsubtotal = dec3dollar
        ElseIf radMcNuggets.Checked Then
            decsubtotal = dec3dollar
        ElseIf radTenders.Checked Then
            decsubtotal = dec3dollar
        ElseIf radMandSwissBurer.Checked Then
            decsubtotal = dec3dollar
        ElseIf radFries.Checked Then
            decsubtotal = dec2dollar
        ElseIf radAppleSlices.Checked Then
            decsubtotal = dec2dollar
        ElseIf radYogurt.Checked Then
            decsubtotal = dec2dollar
        ElseIf radPoutine.Checked Then
            decsubtotal = dec2dollar
        ElseIf radParfait.Checked Then
            decsubtotal = dec2dollar
        ElseIf radCocaCola.Checked Then
            decsubtotal = dec1dollar
        ElseIf radHotChocolate.Checked Then
            decsubtotal = dec1dollar
        ElseIf radMIXSprite.Checked Then
            decsubtotal = dec1dollar
        ElseIf radCapaccino.Checked Then
            decsubtotal = dec1dollar
        ElseIf radMocha.Checked Then
            decsubtotal = dec1dollar
        End If

        'will display the results and the tax
        'Subtotal

        lblsubtotalcost.Text = decsubtotal.ToString("c")

        'Tax
        decTaxCost = dectax
        lbltaxcost.Text = decTaxCost.ToString("c")

        'Final Cost

        decfinaltotal = decsubtotal + dectax
        lblfinaldollarcost.Text = decfinaltotal.ToString("c")


        'display a msg box for a negative number in the name field
        MsgBox("Please enter you correct name so your order can be received to you only", , "Invalid Number")


        'display a msg box if nothing is selected
        MsgBox("Please select a food item from the menu", , "Enjoy your food")


        'Display a msgbox if number is written in the name field

        MsgBox("Please enter only your name so that someone else doesn't take your order that you paid for", , "Invalid Number")


    End Sub
End Class
