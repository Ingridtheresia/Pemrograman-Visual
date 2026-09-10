Public Class FrmPajak
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmPajak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnHitung.FlatStyle = FlatStyle.Flat
            btnHitung.BackColor = Color.FromArgb(46, 204, 113)
            btnHitung.ForeColor = Color.White
            btnHitung.FlatAppearance.BorderSize = 0

            btnKeluar.FlatStyle = FlatStyle.Flat
            btnKeluar.BackColor = Color.FromArgb(231, 76, 60)
            btnKeluar.ForeColor = Color.White
            btnKeluar.FlatAppearance.BorderSize = 0

            txtPendapatan.Font = New Font("Segoe UI", 9.0!)
        Catch
        End Try
        Try
            Dim tt As New ToolTip()
            tt.SetToolTip(txtPendapatan, "Masukkan jumlah pendapatan dalam rupiah, angka saja")
            tt.SetToolTip(btnHitung, "Hitung pajak berdasarkan pendapatan")
            tt.SetToolTip(btnKeluar, "Kembali ke form login")

            AddHandler btnHitung.MouseEnter, AddressOf Button_MouseEnter_Pajak
            AddHandler btnHitung.MouseLeave, AddressOf Button_MouseLeave_Pajak
            AddHandler btnKeluar.MouseEnter, AddressOf Button_MouseEnter_Pajak
            AddHandler btnKeluar.MouseLeave, AddressOf Button_MouseLeave_Pajak
        Catch
        End Try
    End Sub

    Private Sub Button_MouseEnter_Pajak(sender As Object, e As EventArgs)
        Dim b = TryCast(sender, Button)
        If b IsNot Nothing Then
            b.BackColor = ControlPaint.Light(b.BackColor)
            b.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub Button_MouseLeave_Pajak(sender As Object, e As EventArgs)
        Dim b = TryCast(sender, Button)
        If b IsNot Nothing Then
            If b Is btnHitung Then
                b.BackColor = Color.FromArgb(46, 204, 113)
            ElseIf b Is btnKeluar Then
                b.BackColor = Color.FromArgb(231, 76, 60)
            End If
            b.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim raw = txtPendapatan.Text.Trim()
        If String.IsNullOrEmpty(raw) Then
            MessageBox.Show("Please enter pendapatan.")
            txtPendapatan.Focus()
            Return
        End If

        Dim pend As Decimal
        If Not Decimal.TryParse(raw, pend) Then
            MessageBox.Show("Pendapatan must be a numeric value.")
            txtPendapatan.Focus()
            Return
        End If

        Dim persen As Decimal = 0D
        If pend <= 5000000D Then
            persen = 0D
        ElseIf pend <= 30000000D Then
            persen = 0.1D
        ElseIf pend <= 100000000D Then
            persen = 0.2D
        Else
            persen = 0.3D
        End If

        Dim pajak = pend * persen
        Dim msg = String.Format("Pendapatan: Rp {0:N0}{1}Pajak ({2:P0}): Rp {3:N0}", pend, vbCrLf, persen, pajak)
        MessageBox.Show(msg, "Hasil Perhitungan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim login = Application.OpenForms().OfType(Of FrmLogin)().FirstOrDefault()
        If login IsNot Nothing Then login.Show()
        Me.Close()
    End Sub
End Class
