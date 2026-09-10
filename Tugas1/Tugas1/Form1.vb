Public Class FrmLogin
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Staff")
        cmbRole.Items.Add("Manager")
        cmbRole.SelectedIndex = 0
        ' prefer project resource if present; fall back to generated avatar
        Try
            Dim staffObj = My.Resources.Resources.ResourceManager.GetObject("Staff")
            Dim managerObj = My.Resources.Resources.ResourceManager.GetObject("Manager")
            Dim manajerObj = My.Resources.Resources.ResourceManager.GetObject("Manajer")
            If staffObj IsNot Nothing AndAlso TypeOf staffObj Is Image Then
                picImage.Image = CType(staffObj, Image)
            ElseIf managerObj IsNot Nothing AndAlso TypeOf managerObj Is Image Then
                picImage.Image = CType(managerObj, Image)
            ElseIf manajerObj IsNot Nothing AndAlso TypeOf manajerObj Is Image Then
                picImage.Image = CType(manajerObj, Image)
            Else
                picImage.Image = CreateFallbackAvatar("Staff")
            End If
        Catch
            picImage.Image = CreateFallbackAvatar("Staff")
        End Try

        ' set tab order explicitly
        cmbRole.TabIndex = 1
        txtNama.TabIndex = 2
        txtNIM.TabIndex = 3
        btnLogin.TabIndex = 4
        ' make picture circular
        Try
            Dim gp As New Drawing2D.GraphicsPath()
            gp.AddEllipse(0, 0, picImage.Width - 1, picImage.Height - 1)
            picImage.Region = New Region(gp)
        Catch
        End Try
        ' style button
        Try
            btnLogin.FlatStyle = FlatStyle.Flat
            btnLogin.BackColor = Color.FromArgb(52, 152, 219)
            btnLogin.ForeColor = Color.White
            btnLogin.FlatAppearance.BorderSize = 0
        Catch
        End Try
        ' no additional tooltips or hover handlers in simple layout
    End Sub


    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        Dim path As String = IO.Path.Combine(Application.StartupPath, "Image")
        If cmbRole.SelectedItem Is Nothing Then
            picImage.Image = Nothing
            Return
        End If

        Dim fileName As String = String.Empty
        If cmbRole.SelectedItem.ToString() = "Staff" Then
            fileName = IO.Path.Combine(path, "staff.png")
        ElseIf cmbRole.SelectedItem.ToString() = "Manager" Then
            fileName = IO.Path.Combine(path, "manager.png")
        End If

        If String.IsNullOrEmpty(fileName) Then
            picImage.Image = Nothing
            Return
        End If

        ' Prefer embedded resources (if you added images via Project Resources)
        Try
            Dim roleKey = cmbRole.SelectedItem.ToString()
            Dim candidates As String()
            If String.Equals(roleKey, "Staff", StringComparison.OrdinalIgnoreCase) Then
                candidates = New String() {"Staff"}
            Else
                ' accept both English and Indonesian resource keys
                candidates = New String() {"Manajer", "Manager", "manajer", "manager"}
            End If

            For Each key In candidates
                Dim obj = My.Resources.Resources.ResourceManager.GetObject(key)
                If obj IsNot Nothing AndAlso TypeOf obj Is Image Then
                    picImage.Image = CType(obj, Image)
                    Return
                End If
            Next
        Catch ex As Exception
            ' ignore resource lookup errors and continue to file lookup
        End Try

        ' Then try image files in Image folder
        ' Try to find a matching file in Image folder ignoring case and small name variations
        If IO.Directory.Exists(path) Then
            Dim desired As String = IO.Path.GetFileNameWithoutExtension(fileName)
            Dim candidates = IO.Directory.GetFiles(path)
            Dim match As String = candidates.FirstOrDefault(Function(f) String.Equals(IO.Path.GetFileNameWithoutExtension(f), desired, StringComparison.OrdinalIgnoreCase) OrElse String.Equals(IO.Path.GetFileName(f), desired & IO.Path.GetExtension(f), StringComparison.OrdinalIgnoreCase))
            If match IsNot Nothing Then
                fileName = match
            End If
        End If

        If IO.File.Exists(fileName) Then
            Try
                picImage.Image = Image.FromFile(fileName)
            Catch ex As Exception
                picImage.Image = Nothing
            End Try
        Else
            picImage.Image = Nothing
        End If
    End Sub

    Private Function CreateFallbackAvatar(role As String) As Image
        Dim size As Integer = 120
        Dim bmp As New Bitmap(size, size, Imaging.PixelFormat.Format32bppArgb)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.Clear(Color.Transparent)

            ' background circle
            Dim pad As Integer = 6
            Dim bg As Color = If(String.Equals(role, "Manager", StringComparison.OrdinalIgnoreCase), Color.FromArgb(255, 200, 200), Color.FromArgb(170, 230, 210))
            Using brush As New SolidBrush(bg)
                g.FillEllipse(brush, pad, pad, size - pad * 2, size - pad * 2)
            End Using

            ' head
            Dim headSize = size * 0.42F
            Dim headX = (size - headSize) / 2.0F
            Dim headY = size * 0.18F
            Using skin As New SolidBrush(Color.FromArgb(255, 230, 200))
                g.FillEllipse(skin, headX, headY, headSize, headSize)
            End Using

            ' hair / cap
            Dim hairColor As Color = If(String.Equals(role, "Manager", StringComparison.OrdinalIgnoreCase), Color.FromArgb(80, 110, 140), Color.FromArgb(105, 80, 150))
            Using hair As New SolidBrush(hairColor)
                g.FillEllipse(hair, headX - headSize * 0.05F, headY - headSize * 0.18F, headSize * 1.1F, headSize * 0.6F)
            End Using

            ' shoulders / torso (soft ellipse)
            Dim torsoW = size * 0.62F
            Dim torsoH = size * 0.34F
            Dim torsoX = (size - torsoW) / 2.0F
            Dim torsoY = headY + headSize * 0.85F
            Using body As New SolidBrush(Color.FromArgb(60, 90, 150))
                g.FillEllipse(body, torsoX, torsoY, torsoW, torsoH)
            End Using
        End Using
        Return bmp
    End Function

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim role = If(cmbRole.SelectedItem, "").ToString().Trim()
        Dim name = txtNama.Text.Trim()
        Dim nim = txtNIM.Text.Trim()

        If String.IsNullOrEmpty(role) OrElse String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(nim) Then
            MessageBox.Show("Please fill role, name and NIM.")
            If String.IsNullOrEmpty(nim) Then txtNIM.Focus()
            Return
        End If

        Dim tmp As Long
        If Not Long.TryParse(nim, tmp) Then
            MessageBox.Show("NIM must be numeric.")
            txtNIM.Focus()
            Return
        End If

        Dim ok As Boolean = False
        If String.Equals(role, "Staff", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(name, "Nadya", StringComparison.OrdinalIgnoreCase) AndAlso nim = "241712051" Then ok = True
        If String.Equals(role, "Manager", StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(name, "Shata Diyaul Haq", StringComparison.OrdinalIgnoreCase) AndAlso nim = "241712061" Then ok = True

        If ok Then
            Dim f As New FrmPajak()
            f.Show()
            Me.Hide()
            txtNama.Clear()
            txtNIM.Clear()
        Else
            MessageBox.Show("Masukkan Akun dengan Benar", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' keep user on login and return focus to name input
            txtNama.Focus()
            txtNama.SelectAll()
        End If
    End Sub

    Private Sub picImage_Click(sender As Object, e As EventArgs)

    End Sub
End Class
