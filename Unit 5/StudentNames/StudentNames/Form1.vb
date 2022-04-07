Public Class frmStudentNames
    Const intNumNames As Integer = 5
    Dim strStuNames(intNumNames - 1)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For intI As Integer = 0 To strStuNames.Length - 1
            strStuNames(intI) = InputBox("Enter a student name")
        Next

        Dim strReversedArr(strStuNames.Length - 1) As String
        Dim intFor, intBack

        intBack = strStuNames.Length - 1

        For intFor = 0 To strStuNames.Length - 1
            strReversedArr(intFor) = strStuNames(intBack)
            intBack -= 1
        Next

        strStuNames = strReversedArr

        For intI = 0 To strStuNames.Length - 1
            lstStuNames.Items.Add(strStuNames(intI))
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strSearchTerm As String = InputBox("Who ya wanna find?")

        For intPos As Integer = 0 To strStuNames.Length - 1
            If (strStuNames(intPos) = strSearchTerm) Then
                MessageBox.Show("the term " & strSearchTerm & " is found at position " & intPos)
                Return
            End If
        Next

        MessageBox.Show("the term " & strSearchTerm & " is not in the array")
    End Sub
End Class
