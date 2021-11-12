Public Class Form1

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim intNumber As Integer
        intNumber = 27
        intNumber = intNumber + 1
        MessageBox.Show("Value of intNumber + 1 = " & intNumber.ToString, _
           "Variables")
    End Sub
End Class
