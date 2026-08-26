<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblNama = New Label()
        txtNama = New TextBox()
        lblNIM = New Label()
        txtNIM = New TextBox()
        txtKom = New Label()
        TextBox1 = New TextBox()
        btnTampilan = New Button()
        btnHapus = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(209, 141)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(277, 138)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 1
        txtNama.UseSystemPasswordChar = True
        txtNama.WordWrap = False
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(209, 176)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(44, 20)
        lblNIM.TabIndex = 2
        lblNIM.Text = "NIM :"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(277, 173)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(125, 27)
        txtNIM.TabIndex = 3
        ' 
        ' txtKom
        ' 
        txtKom.AutoSize = True
        txtKom.Location = New Point(209, 215)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(48, 20)
        txtKom.TabIndex = 4
        txtKom.Text = "KOM :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(277, 212)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 5
        ' 
        ' btnTampilan
        ' 
        btnTampilan.Location = New Point(221, 245)
        btnTampilan.Name = "btnTampilan"
        btnTampilan.Size = New Size(94, 29)
        btnTampilan.TabIndex = 6
        btnTampilan.Text = "Tampilan"
        btnTampilan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(321, 245)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(277, 280)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(94, 29)
        BtnKeluar.TabIndex = 8
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(821, 450)
        Controls.Add(BtnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnTampilan)
        Controls.Add(TextBox1)
        Controls.Add(txtKom)
        Controls.Add(txtNIM)
        Controls.Add(lblNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtKom As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnTampilan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents BtnKeluar As Button

End Class
