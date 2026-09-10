<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picImage = New PictureBox()
        tblLogin = New TableLayoutPanel()
        lblRole = New Label()
        cmbRole = New ComboBox()
        lblNama = New Label()
        txtNama = New TextBox()
        lblNIM = New Label()
        txtNIM = New TextBox()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        tblLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(132, 12)
        picImage.Name = "picImage"
        picImage.Size = New Size(120, 120)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' tblLogin
        ' 
        tblLogin.ColumnCount = 2
        tblLogin.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 80.0F))
        tblLogin.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tblLogin.Controls.Add(lblRole, 0, 0)
        tblLogin.Controls.Add(cmbRole, 1, 0)
        tblLogin.Controls.Add(lblNama, 0, 1)
        tblLogin.Controls.Add(txtNama, 1, 1)
        tblLogin.Controls.Add(lblNIM, 0, 2)
        tblLogin.Controls.Add(txtNIM, 1, 2)
        tblLogin.Location = New Point(30, 140)
        tblLogin.Name = "tblLogin"
        tblLogin.RowCount = 3
        tblLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 36.0F))
        tblLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 36.0F))
        tblLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 36.0F))
        tblLogin.Size = New Size(320, 110)
        tblLogin.TabIndex = 1
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Dock = DockStyle.Fill
        lblRole.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblRole.Location = New Point(3, 0)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(74, 36)
        lblRole.TabIndex = 0
        lblRole.Text = "Role"
        lblRole.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbRole
        ' 
        cmbRole.Dock = DockStyle.Fill
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.Font = New Font("Segoe UI", 9.0F)
        cmbRole.Location = New Point(83, 3)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(234, 28)
        cmbRole.TabIndex = 1
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Dock = DockStyle.Fill
        lblNama.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNama.Location = New Point(3, 36)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(74, 36)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        lblNama.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNama
        ' 
        txtNama.Dock = DockStyle.Fill
        txtNama.Font = New Font("Segoe UI", 9.0F)
        txtNama.Location = New Point(83, 39)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(234, 27)
        txtNama.TabIndex = 3
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Dock = DockStyle.Fill
        lblNIM.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNIM.Location = New Point(3, 72)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(74, 38)
        lblNIM.TabIndex = 4
        lblNIM.Text = "NIM"
        lblNIM.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNIM
        ' 
        txtNIM.Dock = DockStyle.Fill
        txtNIM.Font = New Font("Segoe UI", 9.0F)
        txtNIM.Location = New Point(83, 75)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(234, 27)
        txtNIM.TabIndex = 5
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 9.0F)
        btnLogin.Location = New Point(142, 260)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(100, 30)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 360)
        Controls.Add(tblLogin)
        Controls.Add(picImage)
        Controls.Add(btnLogin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        tblLogin.ResumeLayout(False)
        tblLogin.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents tblLogin As TableLayoutPanel
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblNIM As System.Windows.Forms.Label
    Friend WithEvents txtNIM As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents picImage As PictureBox
End Class
