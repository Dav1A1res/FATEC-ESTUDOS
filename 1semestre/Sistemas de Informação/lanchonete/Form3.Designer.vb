<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_pedidos))
        Me.dgv_produtos = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_lanches = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_buscar = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_lanche = New System.Windows.Forms.Label()
        Me.Label_torta = New System.Windows.Forms.Label()
        Me.cmb_tortas = New System.Windows.Forms.ComboBox()
        Me.Label_bebida = New System.Windows.Forms.Label()
        Me.cmb_bebidas = New System.Windows.Forms.ComboBox()
        Me.Label_doce = New System.Windows.Forms.Label()
        Me.cmb_doces = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_produtos
        '
        Me.dgv_produtos.AllowUserToAddRows = False
        Me.dgv_produtos.AllowUserToDeleteRows = False
        Me.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_produtos.BackgroundColor = System.Drawing.Color.Brown
        Me.dgv_produtos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column4})
        Me.dgv_produtos.GridColor = System.Drawing.Color.Black
        Me.dgv_produtos.Location = New System.Drawing.Point(4, 45)
        Me.dgv_produtos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.ReadOnly = True
        Me.dgv_produtos.RowHeadersWidth = 62
        Me.dgv_produtos.RowTemplate.Height = 28
        Me.dgv_produtos.Size = New System.Drawing.Size(619, 174)
        Me.dgv_produtos.TabIndex = 0
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
        'cmb_lanches
        '
        Me.cmb_lanches.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_lanches.FormattingEnabled = True
        Me.cmb_lanches.Location = New System.Drawing.Point(8, 127)
        Me.cmb_lanches.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_lanches.Name = "cmb_lanches"
        Me.cmb_lanches.Size = New System.Drawing.Size(143, 23)
        Me.cmb_lanches.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.dgv_produtos)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 207)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(627, 222)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTA DE PRODUTOS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmb_tipo, Me.btn_buscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(623, 31)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(251, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BEM VINDO(a)!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(205, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Realize aqui o seu pedido!"
        '
        'Label_lanche
        '
        Me.Label_lanche.AutoSize = True
        Me.Label_lanche.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_lanche.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label_lanche.Location = New System.Drawing.Point(8, 108)
        Me.Label_lanche.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_lanche.Name = "Label_lanche"
        Me.Label_lanche.Size = New System.Drawing.Size(74, 19)
        Me.Label_lanche.TabIndex = 10
        Me.Label_lanche.Text = "Lanches"
        '
        'Label_torta
        '
        Me.Label_torta.AutoSize = True
        Me.Label_torta.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_torta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label_torta.Location = New System.Drawing.Point(8, 155)
        Me.Label_torta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_torta.Name = "Label_torta"
        Me.Label_torta.Size = New System.Drawing.Size(63, 19)
        Me.Label_torta.TabIndex = 16
        Me.Label_torta.Text = "Tortas"
        '
        'cmb_tortas
        '
        Me.cmb_tortas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tortas.FormattingEnabled = True
        Me.cmb_tortas.Location = New System.Drawing.Point(8, 175)
        Me.cmb_tortas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_tortas.Name = "cmb_tortas"
        Me.cmb_tortas.Size = New System.Drawing.Size(143, 23)
        Me.cmb_tortas.TabIndex = 15
        '
        'Label_bebida
        '
        Me.Label_bebida.AutoSize = True
        Me.Label_bebida.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_bebida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label_bebida.Location = New System.Drawing.Point(199, 155)
        Me.Label_bebida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_bebida.Name = "Label_bebida"
        Me.Label_bebida.Size = New System.Drawing.Size(71, 19)
        Me.Label_bebida.TabIndex = 18
        Me.Label_bebida.Text = "Bebidas"
        '
        'cmb_bebidas
        '
        Me.cmb_bebidas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bebidas.FormattingEnabled = True
        Me.cmb_bebidas.Location = New System.Drawing.Point(199, 175)
        Me.cmb_bebidas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_bebidas.Name = "cmb_bebidas"
        Me.cmb_bebidas.Size = New System.Drawing.Size(143, 23)
        Me.cmb_bebidas.TabIndex = 17
        '
        'Label_doce
        '
        Me.Label_doce.AutoSize = True
        Me.Label_doce.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_doce.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label_doce.Location = New System.Drawing.Point(199, 108)
        Me.Label_doce.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_doce.Name = "Label_doce"
        Me.Label_doce.Size = New System.Drawing.Size(56, 19)
        Me.Label_doce.TabIndex = 20
        Me.Label_doce.Text = "Doces"
        '
        'cmb_doces
        '
        Me.cmb_doces.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_doces.FormattingEnabled = True
        Me.cmb_doces.Location = New System.Drawing.Point(199, 127)
        Me.cmb_doces.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_doces.Name = "cmb_doces"
        Me.cmb_doces.Size = New System.Drawing.Size(143, 23)
        Me.cmb_doces.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(500, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Valor a pagar"
        '
        'btn_encerrar
        '
        Me.btn_encerrar.BackColor = System.Drawing.Color.Brown
        Me.btn_encerrar.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btn_encerrar.ForeColor = System.Drawing.Color.White
        Me.btn_encerrar.Location = New System.Drawing.Point(500, 155)
        Me.btn_encerrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(125, 21)
        Me.btn_encerrar.TabIndex = 23
        Me.btn_encerrar.Text = "ENCERRAR"
        Me.btn_encerrar.UseVisualStyleBackColor = False
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(500, 129)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(126, 23)
        Me.txt_total.TabIndex = 24
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 97)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Clique duas vezes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "na categoria do " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "produto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para adicionar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ele ao carrinho."
        '
        'Form_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(643, 443)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.btn_encerrar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label_doce)
        Me.Controls.Add(Me.cmb_doces)
        Me.Controls.Add(Me.Label_bebida)
        Me.Controls.Add(Me.cmb_bebidas)
        Me.Controls.Add(Me.Label_torta)
        Me.Controls.Add(Me.cmb_tortas)
        Me.Controls.Add(Me.Label_lanche)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmb_lanches)
        Me.Location = New System.Drawing.Point(750, 198)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_pedidos"
        Me.Text = "PEDIDOS"
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents cmb_lanches As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents btn_buscar As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_lanche As Label
    Friend WithEvents Label_torta As Label
    Friend WithEvents cmb_tortas As ComboBox
    Friend WithEvents Label_bebida As Label
    Friend WithEvents cmb_bebidas As ComboBox
    Friend WithEvents Label_doce As Label
    Friend WithEvents cmb_doces As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
