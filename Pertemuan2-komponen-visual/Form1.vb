Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnTampilan_Click(sender As Object, e As EventArgs) Handles btnTampilan.Click
        MessageBox.Show("Halo Selmat Datang !" & vbCrLf &
                        "Nama   : " & txtNama.Text & vbCrLf &
                        "NIM    : " & txtNIM.Text & vbCrLf &
                        "KOM    : " & TextBox1.Text
        )
    End Sub

    Private Sub txtHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Clear()
        txtNIM.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub
End Class
