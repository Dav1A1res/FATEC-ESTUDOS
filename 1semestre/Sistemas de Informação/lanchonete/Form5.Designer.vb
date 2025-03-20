<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_cozinheiro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_cozinheiro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_buscar = New System.Windows.Forms.ToolStripButton()
        Me.dgv_produtosc = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btn_voltar = New System.Windows.Forms.ToolStripButton()
        Me.btn_add = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.txt_preco2 = New System.Windows.Forms.TextBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_categoria2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_renovar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nome2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_estoque = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_produtosc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.dgv_produtosc)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 41)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(671, 203)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTA DE PRODUTOS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmb_tipo, Me.btn_buscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(667, 31)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(161, 28)
        Me.ToolStripLabel1.Text = "Escolha o tipo de produto"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(82, 31)
        '
        'btn_buscar
        '
        Me.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(28, 28)
        Me.btn_buscar.Text = "BUSCAR"
        '
        'dgv_produtosc
        '
        Me.dgv_produtosc.AllowUserToAddRows = False
        Me.dgv_produtosc.AllowUserToDeleteRows = False
        Me.dgv_produtosc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_produtosc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_produtosc.BackgroundColor = System.Drawing.Color.White
        Me.dgv_produtosc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_produtosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtosc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column2, Me.Column1, Me.Column4, Me.Column3})
        Me.dgv_produtosc.GridColor = System.Drawing.Color.Black
        Me.dgv_produtosc.Location = New System.Drawing.Point(4, 45)
        Me.dgv_produtosc.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_produtosc.Name = "dgv_produtosc"
        Me.dgv_produtosc.ReadOnly = True
        Me.dgv_produtosc.RowHeadersWidth = 62
        Me.dgv_produtosc.RowTemplate.Height = 28
        Me.dgv_produtosc.Size = New System.Drawing.Size(663, 154)
        Me.dgv_produtosc.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.HeaderText = "CÓDIGO DO PRODUTO"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 157
        '
        'Column2
        '
        Me.Column2.HeaderText = "TIPO DO PRODUTO"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 137
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOME PRODUTO"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 124
        '
        'Column4
        '
        Me.Column4.HeaderText = "PREÇO"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "RENOVAR ESTOQUE"
        Me.Column3.Image = CType(resources.GetObject("Column3.Image"), System.Drawing.Image)
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 127
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_voltar, Me.btn_add})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(687, 31)
        Me.ToolStrip2.TabIndex = 8
        Me.ToolStrip2.Text = "ToolStrip2"
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
        'btn_add
        '
        Me.btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(28, 28)
        Me.btn_add.Text = "ADICIONAR PRODUTO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_preco)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_qtde)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_categoria)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_adicionar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_nome)
        Me.GroupBox2.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 259)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(289, 224)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NOVO PRODUTO"
        Me.GroupBox2.Visible = False
        '
        'txt_preco
        '
        Me.txt_preco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_preco.Location = New System.Drawing.Point(4, 136)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(113, 23)
        Me.txt_preco.TabIndex = 30
        Me.txt_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(1, 166)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 14)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Quantitade em estoque"
        '
        'txt_qtde
        '
        Me.txt_qtde.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_qtde.Location = New System.Drawing.Point(4, 182)
        Me.txt_qtde.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(76, 23)
        Me.txt_qtde.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(1, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 14)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Preço do Produto"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(4, 90)
        Me.cmb_categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(137, 23)
        Me.cmb_categoria.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(1, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 14)
        Me.Label3.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(1, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 14)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Categoria do Produto"
        '
        'btn_adicionar
        '
        Me.btn_adicionar.BackColor = System.Drawing.Color.Brown
        Me.btn_adicionar.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_adicionar.ForeColor = System.Drawing.Color.White
        Me.btn_adicionar.Location = New System.Drawing.Point(179, 180)
        Me.btn_adicionar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(106, 22)
        Me.btn_adicionar.TabIndex = 20
        Me.btn_adicionar.Text = "ADICIONAR"
        Me.btn_adicionar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(1, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nome do Produto"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nome.Location = New System.Drawing.Point(4, 39)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(217, 23)
        Me.txt_nome.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_estoque)
        Me.GroupBox3.Controls.Add(Me.btn_editar)
        Me.GroupBox3.Controls.Add(Me.txt_preco2)
        Me.GroupBox3.Controls.Add(Me.txt_cod)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmb_categoria2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btn_renovar)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_nome2)
        Me.GroupBox3.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(390, 259)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(289, 224)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RENOVAR ESTOQUE"
        Me.GroupBox3.Visible = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Brown
        Me.btn_editar.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(164, 180)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(122, 22)
        Me.btn_editar.TabIndex = 31
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'txt_preco2
        '
        Me.txt_preco2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_preco2.Location = New System.Drawing.Point(7, 146)
        Me.txt_preco2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_preco2.Name = "txt_preco2"
        Me.txt_preco2.Size = New System.Drawing.Size(113, 23)
        Me.txt_preco2.TabIndex = 30
        Me.txt_preco2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cod
        '
        Me.txt_cod.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cod.Location = New System.Drawing.Point(164, 90)
        Me.txt_cod.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(113, 23)
        Me.txt_cod.TabIndex = 29
        Me.txt_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(161, 74)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 14)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Código do Produto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(4, 131)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 14)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Preço do Produto"
        '
        'cmb_categoria2
        '
        Me.cmb_categoria2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria2.FormattingEnabled = True
        Me.cmb_categoria2.Location = New System.Drawing.Point(7, 90)
        Me.cmb_categoria2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_categoria2.Name = "cmb_categoria2"
        Me.cmb_categoria2.Size = New System.Drawing.Size(137, 23)
        Me.cmb_categoria2.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(1, 123)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 14)
        Me.Label6.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(4, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 14)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Categoria do Produto"
        '
        'btn_renovar
        '
        Me.btn_renovar.BackColor = System.Drawing.Color.Brown
        Me.btn_renovar.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_renovar.ForeColor = System.Drawing.Color.White
        Me.btn_renovar.Location = New System.Drawing.Point(7, 180)
        Me.btn_renovar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_renovar.Name = "btn_renovar"
        Me.btn_renovar.Size = New System.Drawing.Size(141, 22)
        Me.btn_renovar.TabIndex = 20
        Me.btn_renovar.Text = "RENOVAR"
        Me.btn_renovar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(4, 23)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 14)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Nome do Produto"
        '
        'txt_nome2
        '
        Me.txt_nome2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nome2.Location = New System.Drawing.Point(7, 39)
        Me.txt_nome2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome2.Name = "txt_nome2"
        Me.txt_nome2.Size = New System.Drawing.Size(217, 23)
        Me.txt_nome2.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(161, 131)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 14)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Em estoque"
        '
        'txt_estoque
        '
        Me.txt_estoque.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_estoque.Location = New System.Drawing.Point(164, 147)
        Me.txt_estoque.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_estoque.Name = "txt_estoque"
        Me.txt_estoque.Size = New System.Drawing.Size(76, 23)
        Me.txt_estoque.TabIndex = 32
        '
        'Form_cozinheiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 563)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_cozinheiro"
        Me.Text = "GERENCIAMENTO DE ESTOQUE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_produtosc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents btn_buscar As ToolStripButton
    Friend WithEvents dgv_produtosc As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btn_voltar As ToolStripButton
    Friend WithEvents btn_add As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_categoria2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_renovar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nome2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents txt_preco2 As TextBox
    Friend WithEvents btn_editar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_estoque As TextBox
End Class
