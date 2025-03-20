<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.check_c = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_logar = New System.Windows.Forms.Button()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Gp_adm = New System.Windows.Forms.GroupBox()
        Me.check_a = New System.Windows.Forms.CheckBox()
        Me.btn_logar_adm = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_tipo_func = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_senha_adm = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf_adm = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_adm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.check_c)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_logar)
        Me.GroupBox1.Controls.Add(Me.btn_cadastro)
        Me.GroupBox1.Controls.Add(Me.txt_senha)
        Me.GroupBox1.Controls.Add(Me.txt_cpf)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.logo)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(611, 285)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN"
        '
        'check_c
        '
        Me.check_c.AutoSize = True
        Me.check_c.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_c.Location = New System.Drawing.Point(377, 141)
        Me.check_c.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.check_c.Name = "check_c"
        Me.check_c.Size = New System.Drawing.Size(126, 18)
        Me.check_c.TabIndex = 12
        Me.check_c.Text = "Visualizar senha"
        Me.check_c.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(224, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Já possui uma conta em nosso estabelecimento?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Se sim, preencha os seguintes camp" &
    "os:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(223, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(223, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SENHA"
        '
        'btn_logar
        '
        Me.btn_logar.BackColor = System.Drawing.Color.Brown
        Me.btn_logar.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_logar.ForeColor = System.Drawing.Color.White
        Me.btn_logar.Location = New System.Drawing.Point(223, 159)
        Me.btn_logar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_logar.Name = "btn_logar"
        Me.btn_logar.Size = New System.Drawing.Size(139, 24)
        Me.btn_logar.TabIndex = 8
        Me.btn_logar.Text = "LOGAR"
        Me.btn_logar.UseVisualStyleBackColor = False
        '
        'btn_cadastro
        '
        Me.btn_cadastro.BackColor = System.Drawing.Color.Brown
        Me.btn_cadastro.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_cadastro.ForeColor = System.Drawing.Color.White
        Me.btn_cadastro.Location = New System.Drawing.Point(223, 231)
        Me.btn_cadastro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(141, 22)
        Me.btn_cadastro.TabIndex = 7
        Me.btn_cadastro.Text = "CADASTRO"
        Me.btn_cadastro.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(223, 137)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(139, 23)
        Me.txt_senha.TabIndex = 5
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(223, 88)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(141, 23)
        Me.txt_cpf.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(220, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(346, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ainda não possui uma conta em nosso estabelecimento? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Se cadastre agora!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(223, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BEM VINDO(a)!"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(4, 34)
        Me.logo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(192, 182)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'Gp_adm
        '
        Me.Gp_adm.Controls.Add(Me.check_a)
        Me.Gp_adm.Controls.Add(Me.btn_logar_adm)
        Me.Gp_adm.Controls.Add(Me.Label9)
        Me.Gp_adm.Controls.Add(Me.cmb_tipo_func)
        Me.Gp_adm.Controls.Add(Me.Label6)
        Me.Gp_adm.Controls.Add(Me.Label7)
        Me.Gp_adm.Controls.Add(Me.Button3)
        Me.Gp_adm.Controls.Add(Me.txt_senha_adm)
        Me.Gp_adm.Controls.Add(Me.txt_cpf_adm)
        Me.Gp_adm.Controls.Add(Me.PictureBox1)
        Me.Gp_adm.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_adm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Gp_adm.Location = New System.Drawing.Point(8, 297)
        Me.Gp_adm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Gp_adm.Name = "Gp_adm"
        Me.Gp_adm.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Gp_adm.Size = New System.Drawing.Size(611, 232)
        Me.Gp_adm.TabIndex = 11
        Me.Gp_adm.TabStop = False
        Me.Gp_adm.Text = "LOGIN FUNCIONÁRIOS"
        Me.Gp_adm.Visible = False
        '
        'check_a
        '
        Me.check_a.AutoSize = True
        Me.check_a.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_a.Location = New System.Drawing.Point(377, 103)
        Me.check_a.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.check_a.Name = "check_a"
        Me.check_a.Size = New System.Drawing.Size(126, 18)
        Me.check_a.TabIndex = 13
        Me.check_a.Text = "Visualizar senha"
        Me.check_a.UseVisualStyleBackColor = True
        '
        'btn_logar_adm
        '
        Me.btn_logar_adm.BackColor = System.Drawing.Color.Brown
        Me.btn_logar_adm.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_logar_adm.ForeColor = System.Drawing.Color.White
        Me.btn_logar_adm.Location = New System.Drawing.Point(221, 173)
        Me.btn_logar_adm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_logar_adm.Name = "btn_logar_adm"
        Me.btn_logar_adm.Size = New System.Drawing.Size(139, 24)
        Me.btn_logar_adm.TabIndex = 12
        Me.btn_logar_adm.Text = "LOGAR"
        Me.btn_logar_adm.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(223, 135)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 14)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "FUNÇÃO"
        '
        'cmb_tipo_func
        '
        Me.cmb_tipo_func.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_func.FormattingEnabled = True
        Me.cmb_tipo_func.Items.AddRange(New Object() {"Dono", "Recepcionista", "Cozinheiro"})
        Me.cmb_tipo_func.Location = New System.Drawing.Point(223, 150)
        Me.cmb_tipo_func.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_tipo_func.Name = "cmb_tipo_func"
        Me.cmb_tipo_func.Size = New System.Drawing.Size(139, 23)
        Me.cmb_tipo_func.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(223, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CPF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(223, 84)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 14)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "SENHA"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Brown
        Me.Button3.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(223, 246)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 21)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "CADASTRO"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_senha_adm
        '
        Me.txt_senha_adm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_adm.Location = New System.Drawing.Point(223, 99)
        Me.txt_senha_adm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_senha_adm.Name = "txt_senha_adm"
        Me.txt_senha_adm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_adm.Size = New System.Drawing.Size(141, 23)
        Me.txt_senha_adm.TabIndex = 5
        '
        'txt_cpf_adm
        '
        Me.txt_cpf_adm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_adm.Location = New System.Drawing.Point(223, 50)
        Me.txt_cpf_adm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cpf_adm.Mask = "999,999,999-99"
        Me.txt_cpf_adm.Name = "txt_cpf_adm"
        Me.txt_cpf_adm.Size = New System.Drawing.Size(141, 23)
        Me.txt_cpf_adm.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(626, 567)
        Me.Controls.Add(Me.Gp_adm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_login"
        Me.Text = "LOGIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_adm.ResumeLayout(False)
        Me.Gp_adm.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents btn_logar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Gp_adm As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents txt_senha_adm As MaskedTextBox
    Friend WithEvents txt_cpf_adm As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_tipo_func As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_logar_adm As Button
    Friend WithEvents check_c As CheckBox
    Friend WithEvents check_a As CheckBox
End Class
