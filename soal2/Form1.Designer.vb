<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUlangi = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.nilKuisInput = New System.Windows.Forms.TextBox()
        Me.nilPraktekInput = New System.Windows.Forms.TextBox()
        Me.namaInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nilaiRataOutput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.keteranganOutput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 36)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Penentuan Kelulusan Mata Kuliah"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(437, 465)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 55)
        Me.btnExit.TabIndex = 42
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUlangi
        '
        Me.btnUlangi.Location = New System.Drawing.Point(356, 465)
        Me.btnUlangi.Name = "btnUlangi"
        Me.btnUlangi.Size = New System.Drawing.Size(75, 55)
        Me.btnUlangi.TabIndex = 41
        Me.btnUlangi.Text = "Ulangi"
        Me.btnUlangi.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(275, 465)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 55)
        Me.btnProses.TabIndex = 40
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'nilKuisInput
        '
        Me.nilKuisInput.Location = New System.Drawing.Point(325, 248)
        Me.nilKuisInput.Name = "nilKuisInput"
        Me.nilKuisInput.Size = New System.Drawing.Size(357, 26)
        Me.nilKuisInput.TabIndex = 39
        '
        'nilPraktekInput
        '
        Me.nilPraktekInput.Location = New System.Drawing.Point(325, 183)
        Me.nilPraktekInput.Name = "nilPraktekInput"
        Me.nilPraktekInput.Size = New System.Drawing.Size(357, 26)
        Me.nilPraktekInput.TabIndex = 38
        '
        'namaInput
        '
        Me.namaInput.Location = New System.Drawing.Point(325, 121)
        Me.namaInput.Name = "namaInput"
        Me.namaInput.Size = New System.Drawing.Size(357, 26)
        Me.namaInput.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Nilai Kuis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Nilai Praktek"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nama"
        '
        'nilaiRataOutput
        '
        Me.nilaiRataOutput.Location = New System.Drawing.Point(325, 312)
        Me.nilaiRataOutput.Name = "nilaiRataOutput"
        Me.nilaiRataOutput.Size = New System.Drawing.Size(357, 26)
        Me.nilaiRataOutput.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(119, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Nilai Rata Rata"
        '
        'keteranganOutput
        '
        Me.keteranganOutput.Location = New System.Drawing.Point(325, 376)
        Me.keteranganOutput.Name = "keteranganOutput"
        Me.keteranganOutput.Size = New System.Drawing.Size(357, 26)
        Me.keteranganOutput.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Keterangan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 638)
        Me.Controls.Add(Me.keteranganOutput)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nilaiRataOutput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUlangi)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.nilKuisInput)
        Me.Controls.Add(Me.nilPraktekInput)
        Me.Controls.Add(Me.namaInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnUlangi As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents nilKuisInput As System.Windows.Forms.TextBox
    Friend WithEvents nilPraktekInput As System.Windows.Forms.TextBox
    Friend WithEvents namaInput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nilaiRataOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents keteranganOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
