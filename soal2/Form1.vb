Public Class Form1

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim nilaiPraktek As Integer
        Dim nilaiKuis As Integer
        Dim nilaiRata As Double

        nilaiPraktek = CInt(nilPraktekInput.Text)
        nilaiKuis = CInt(nilKuisInput.Text)

        nilaiRata = ((nilaiPraktek + nilaiKuis) / 2)
        nilaiRataOutput.Text = nilaiRata

        If nilaiRata >= 65 Then
            keteranganOutput.Text = "LULUS"
        Else
            keteranganOutput.Text = "TIDAK LULUS"
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnUlangi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlangi.Click
        namaInput.Text = " "
        nilPraktekInput.Text = " "
        nilKuisInput.Text = " "
        nilaiRataOutput.Text = " "
        keteranganOutput.Text = " "
        namaInput.Focus()
    End Sub
End Class
