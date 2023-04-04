Option Strict On

Public Class Form1

    Private _decSong As Decimal = 2.99D
    Private _decHourlyRate As Decimal = 8.99D
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(1500)
        ClearForm()
    End Sub
    Private Function ValidateInput() As Boolean
        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            intNumber = Convert.ToInt32(txtHours.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
            End If
        Catch ex As FormatException
            MsgBox("Please enter a valid amount", , "Error")
        Catch ex As OverflowException
            MsgBox("Please enter a reasonable amount", , "Error")
        Catch ex As SystemException
            MsgBox("Invalid entry. Please enter a valid number representing the number in your party", , "Error")
        End Try
        txtHours.Focus()
        txtHours.Clear()
        Return blnValid

    End Function
    Private Function ComputeSongCost(ByVal intPass As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = intPass * _decSong
        Return decPassCost
    End Function
    Private Function ComputeRoomCost(ByVal intPass As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = intPass * _decHourlyRate
        Return decTicketCost
    End Function
    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        Dim blnAmountValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        blnAmountValid = ValidateInput()
        If blnAmountValid = True Then
            intValue = Convert.ToInt32(txtHours.Text)
            If cboKaraoke.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            Else
                decTotal = ComputeRoomCost(intValue)
            End If

            lblTotal.Visible = True
            lblTotal.Text = "Total Cost of Karaoke Night - " & decTotal.ToString("C")
        End If
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        ClearForm()
    End Sub
    Private Sub ClearForm()
        cboKaraoke.SelectedIndex = -1
        lblHours.Visible = False
        txtHours.Visible = False
        btnTotalCost.Visible = False
        btnClearForm.Visible = False
        lblTotal.Visible = False
        txtHours.Clear()
    End Sub

    Private Sub cboKaraoke_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKaraoke.SelectedIndexChanged
        If cboKaraoke.SelectedIndex = 0 Then
            lblHours.Text = "Number of Karaoke Songs"
            lblHours.Visible = True
            txtHours.Visible = True
            btnTotalCost.Visible = True
            btnClearForm.Visible = True
            txtHours.Focus()
        End If
        If cboKaraoke.SelectedIndex = 1 Then
            lblHours.Text = "Hourly Rental of Karaoke Room:"
            lblHours.Visible = True
            txtHours.Visible = True
            btnTotalCost.Visible = True
            btnClearForm.Visible = True
            txtHours.Focus()
        End If

    End Sub
End Class


