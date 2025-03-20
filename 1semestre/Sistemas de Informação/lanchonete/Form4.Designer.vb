<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_dono
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_dono))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_voltar = New System.Windows.Forms.ToolStripButton()
        Me.btn_clientes = New System.Windows.Forms.ToolStripButton()
        Me.btn_funcionarios = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_senha_func = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_tipo_func = New System.Windows.Forms.ComboBox()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.btn_editar_func = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_email_func = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nome_func = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cpf_func = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo_conta = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_buscar = New System.Windows.Forms.ToolStripButton()
        Me.dgv_contas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_voltar, Me.btn_clientes, Me.btn_funcionarios})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(754, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_voltar
        '
        Me.btn_voltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(28, 28)
        Me.btn_voltar.Text = "VOLTAR LOGIN"
        '
        'btn_clientes
        '
        Me.btn_clientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_clientes.Image = CType(resources.GetObject("btn_clientes.Image"), System.Drawing.Image)
        Me.btn_clientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(28, 28)
        Me.btn_clientes.Text = "CLIENTES"
        '
        'btn_funcionarios
        '
        Me.btn_funcionarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_funcionarios.Image = CType(resources.GetObject("btn_funcionarios.Image"), System.Drawing.Image)
        Me.btn_funcionarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_funcionarios.Name = "btn_funcionarios"
        Me.btn_funcionarios.Size = New System.Drawing.Size(28, 28)
        Me.btn_funcionarios.Text = "FUNCIONÁRIOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_senha)
        Me.GroupBox1.Controls.Add(Me.btn_editar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_cpf)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 272)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(738, 151)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EDIÇÃO DE CLIENTES"
        Me.GroupBox1.Visible = False
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(507, 84)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(217, 23)
        Me.txt_senha.TabIndex = 21
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Brown
        Me.btn_editar.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(296, 117)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(141, 22)
        Me.btn_editar.TabIndex = 20
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(505, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 14)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "SENHA (máximo de 20 caracteres)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(256, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "E-mail"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_email.Location = New System.Drawing.Point(259, 83)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(217, 23)
        Me.txt_email.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(2, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nome.Location = New System.Drawing.Point(5, 83)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(217, 23)
        Me.txt_nome.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.Enabled = False
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(5, 37)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(99, 23)
        Me.txt_cpf.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_senha_func)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmb_tipo_func)
        Me.GroupBox2.Controls.Add(Me.btn_cadastro)
        Me.GroupBox2.Controls.Add(Me.btn_editar_func)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_email_func)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_nome_func)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_cpf_func)
        Me.GroupBox2.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 443)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(738, 154)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EDIÇÃO / CADASTRO DE FUNCIONÁRIOS"
        Me.GroupBox2.Visible = False
        '
        'txt_senha_func
        '
        Me.txt_senha_func.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_senha_func.Location = New System.Drawing.Point(505, 83)
        Me.txt_senha_func.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_senha_func.Name = "txt_senha_func"
        Me.txt_senha_func.Size = New System.Drawing.Size(217, 23)
        Me.txt_senha_func.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(137, 21)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 14)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Tipo"
        '
        'cmb_tipo_func
        '
        Me.cmb_tipo_func.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_func.FormattingEnabled = True
        Me.cmb_tipo_func.Items.AddRange(New Object() {"RECEPCIONISTA", "COZINHEIRO"})
        Me.cmb_tipo_func.Location = New System.Drawing.Point(139, 37)
        Me.cmb_tipo_func.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_tipo_func.Name = "cmb_tipo_func"
        Me.cmb_tipo_func.Size = New System.Drawing.Size(116, 23)
        Me.cmb_tipo_func.TabIndex = 2
        '
        'btn_cadastro
        '
        Me.btn_cadastro.BackColor = System.Drawing.Color.Brown
        Me.btn_cadastro.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_cadastro.ForeColor = System.Drawing.Color.White
        Me.btn_cadastro.Location = New System.Drawing.Point(377, 118)
        Me.btn_cadastro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(141, 22)
        Me.btn_cadastro.TabIndex = 21
        Me.btn_cadastro.Text = "CADASTRAR"
        Me.btn_cadastro.UseVisualStyleBackColor = False
        '
        'btn_editar_func
        '
        Me.btn_editar_func.BackColor = System.Drawing.Color.Brown
        Me.btn_editar_func.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_editar_func.ForeColor = System.Drawing.Color.White
        Me.btn_editar_func.Location = New System.Drawing.Point(216, 118)
        Me.btn_editar_func.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_editar_func.Name = "btn_editar_func"
        Me.btn_editar_func.Size = New System.Drawing.Size(141, 22)
        Me.btn_editar_func.TabIndex = 20
        Me.btn_editar_func.Text = "EDITAR"
        Me.btn_editar_func.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(505, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 14)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "SENHA (máximo de 20 caracteres)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(256, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "E-mail"
        '
        'txt_email_func
        '
        Me.txt_email_func.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_email_func.Location = New System.Drawing.Point(259, 83)
        Me.txt_email_func.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_email_func.Name = "txt_email_func"
        Me.txt_email_func.Size = New System.Drawing.Size(217, 23)
        Me.txt_email_func.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(2, 67)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nome"
        '
        'txt_nome_func
        '
        Me.txt_nome_func.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nome_func.Location = New System.Drawing.Point(5, 83)
        Me.txt_nome_func.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nome_func.Name = "txt_nome_func"
        Me.txt_nome_func.Size = New System.Drawing.Size(217, 23)
        Me.txt_nome_func.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(5, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 14)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CPF"
        '
        'txt_cpf_func
        '
        Me.txt_cpf_func.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpf_func.Location = New System.Drawing.Point(5, 37)
        Me.txt_cpf_func.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cpf_func.Mask = "999,999,999-99"
        Me.txt_cpf_func.Name = "txt_cpf_func"
        Me.txt_cpf_func.Size = New System.Drawing.Size(99, 23)
        Me.txt_cpf_func.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ToolStrip2)
        Me.GroupBox3.Controls.Add(Me.dgv_contas)
        Me.GroupBox3.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(8, 51)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(738, 183)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONSULTA DE CONTAS"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.cmb_tipo_conta, Me.btn_buscar})
        Me.ToolStrip2.Location = New System.Drawing.Point(2, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(734, 31)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(145, 28)
        Me.ToolStripLabel2.Text = "Escolha o tipo de conta"
        '
        'cmb_tipo_conta
        '
        Me.cmb_tipo_conta.AutoCompleteCustomSource.AddRange(New String() {"CLIENTE", "FUNCIONÁRIO"})
        Me.cmb_tipo_conta.Items.AddRange(New Object() {"CLIENTE", "FUNCIONÁRIO"})
        Me.cmb_tipo_conta.Name = "cmb_tipo_conta"
        Me.cmb_tipo_conta.Size = New System.Drawing.Size(101, 31)
        '
        'btn_buscar
        '
        Me.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(28, 28)
        Me.btn_buscar.Text = "ToolStripButton1"
        '
        'dgv_contas
        '
        Me.dgv_contas.AllowUserToAddRows = False
        Me.dgv_contas.AllowUserToDeleteRows = False
        Me.dgv_contas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_contas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column6})
        Me.dgv_contas.Location = New System.Drawing.Point(4, 42)
        Me.dgv_contas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_contas.Name = "dgv_contas"
        Me.dgv_contas.RowHeadersWidth = 62
        Me.dgv_contas.RowTemplate.Height = 28
        Me.dgv_contas.Size = New System.Drawing.Size(730, 135)
        Me.dgv_contas.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "CPF"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "TIPO"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOME"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "EMAIL"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "SENHA"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "EDITAR"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "EXCLUIR"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Form_dono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 606)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_dono"
        Me.Text = "GERENCIAMENTO DE CONTAS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_voltar As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_clientes As ToolStripButton
    Friend WithEvents btn_funcionarios As ToolStripButton
    Friend WithEvents btn_editar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_editar_func As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_email_func As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nome_func As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cpf_func As MaskedTextBox
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents dgv_contas As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_tipo_func As ComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipo_conta As ToolStripComboBox
    Friend WithEvents txt_senha_func As TextBox
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents btn_buscar As ToolStripButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
