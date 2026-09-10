<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPajak
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblLimaJuta = New System.Windows.Forms.Label()
        Me.lblTigaPuluhJuta = New System.Windows.Forms.Label()
        Me.lblSeratusJuta = New System.Windows.Forms.Label()
        Me.lblPendapatan = New System.Windows.Forms.Label()
        Me.lblRupiah = New System.Windows.Forms.Label()
        Me.txtPendapatan = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLimaJuta
        '
        Me.lblLimaJuta.AutoSize = False
        Me.lblLimaJuta.Location = New System.Drawing.Point(40, 30)
        Me.lblLimaJuta.Name = "lblLimaJuta"
        Me.lblLimaJuta.Size = New System.Drawing.Size(480, 36)
        Me.lblLimaJuta.TabIndex = 0
        Me.lblLimaJuta.Text = "Pendapatan lebih dari 5 juta , 10% Pajak"
        Me.lblLimaJuta.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        Me.lblLimaJuta.TextAlign = ContentAlignment.MiddleCenter
        Me.lblLimaJuta.Anchor = AnchorStyles.Top
        '
        'lblTigaPuluhJuta
        '
        Me.lblTigaPuluhJuta.AutoSize = False
        Me.lblTigaPuluhJuta.Location = New System.Drawing.Point(40, 72)
        Me.lblTigaPuluhJuta.Name = "lblTigaPuluhJuta"
        Me.lblTigaPuluhJuta.Size = New System.Drawing.Size(480, 36)
        Me.lblTigaPuluhJuta.TabIndex = 1
        Me.lblTigaPuluhJuta.Text = "Pendapatan lebih dari 30 juta , 20% Pajak"
        Me.lblTigaPuluhJuta.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        Me.lblTigaPuluhJuta.TextAlign = ContentAlignment.MiddleCenter
        Me.lblTigaPuluhJuta.Anchor = AnchorStyles.Top
        '
        'lblSeratusJuta
        '
        Me.lblSeratusJuta.AutoSize = False
        Me.lblSeratusJuta.Location = New System.Drawing.Point(40, 114)
        Me.lblSeratusJuta.Name = "lblSeratusJuta"
        Me.lblSeratusJuta.Size = New System.Drawing.Size(480, 36)
        Me.lblSeratusJuta.TabIndex = 2
        Me.lblSeratusJuta.Text = "Pendapatan lebih dari 100 juta , 30% Pajak"
        Me.lblSeratusJuta.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        Me.lblSeratusJuta.TextAlign = ContentAlignment.MiddleCenter
        Me.lblSeratusJuta.Anchor = AnchorStyles.Top
        '
        'lblPendapatan (heading)
        '
        Me.lblPendapatan.AutoSize = False
        Me.lblPendapatan.Location = New System.Drawing.Point(40, 160)
        Me.lblPendapatan.Name = "lblPendapatan"
        Me.lblPendapatan.Size = New System.Drawing.Size(480, 36)
        Me.lblPendapatan.TabIndex = 3
        Me.lblPendapatan.Text = "Masukkan Pendapatan"
        Me.lblPendapatan.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        Me.lblPendapatan.TextAlign = ContentAlignment.MiddleCenter
        Me.lblPendapatan.Anchor = AnchorStyles.Top
        '
        'lblRupiah
        '
        Me.lblRupiah.AutoSize = True
        Me.lblRupiah.Location = New System.Drawing.Point(120, 204)
        Me.lblRupiah.Name = "lblRupiah"
        Me.lblRupiah.Size = New System.Drawing.Size(30, 15)
        Me.lblRupiah.TabIndex = 4
        Me.lblRupiah.Text = "Rp."
        Me.lblRupiah.Font = New Font("Segoe UI", 10.0!)
        '
        'txtPendapatan
        '
        Me.txtPendapatan.Location = New System.Drawing.Point(160, 200)
        Me.txtPendapatan.Name = "txtPendapatan"
        Me.txtPendapatan.Size = New System.Drawing.Size(280, 25)
        Me.txtPendapatan.TabIndex = 5
        Me.txtPendapatan.Font = New Font("Segoe UI", 10.0!)
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(240, 240)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(80, 34)
        Me.btnHitung.TabIndex = 6
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        Me.btnHitung.Font = New Font("Segoe UI", 9.0!)
        Me.btnHitung.Anchor = AnchorStyles.Top
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(240, 286)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(80, 34)
        Me.btnKeluar.TabIndex = 7
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        Me.btnKeluar.Font = New Font("Segoe UI", 9.0!)
        Me.btnKeluar.Anchor = AnchorStyles.Top
        '
        'FrmPajak
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 420)
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.Controls.Add(Me.lblLimaJuta)
        Me.Controls.Add(Me.lblTigaPuluhJuta)
        Me.Controls.Add(Me.lblSeratusJuta)
        Me.Controls.Add(Me.lblPendapatan)
        Me.Controls.Add(Me.lblRupiah)
        Me.Controls.Add(Me.txtPendapatan)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.btnKeluar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPajak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pajak"
        Me.AcceptButton = Me.btnHitung
        Me.CancelButton = Me.btnKeluar
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblLimaJuta As System.Windows.Forms.Label
    Friend WithEvents lblTigaPuluhJuta As System.Windows.Forms.Label
    Friend WithEvents lblSeratusJuta As System.Windows.Forms.Label
    Friend WithEvents lblPendapatan As System.Windows.Forms.Label
    Friend WithEvents lblRupiah As System.Windows.Forms.Label
    Friend WithEvents txtPendapatan As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
