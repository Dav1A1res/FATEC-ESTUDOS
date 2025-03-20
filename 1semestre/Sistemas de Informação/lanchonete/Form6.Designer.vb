<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_recepcionista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_recepcionista))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_lucros = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_funcionarios = New System.Windows.Forms.PictureBox()
        Me.btn_clientes = New System.Windows.Forms.PictureBox()
        Me.btn_estoque = New System.Windows.Forms.PictureBox()
        CType(Me.btn_lucros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btn_funcionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(249, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 35)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Criação de Relatórios"
        '
        'btn_lucros
        '
        Me.btn_lucros.BackColor = System.Drawing.Color.Brown
        Me.btn_lucros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_lucros.Image = CType(resources.GetObject("btn_lucros.Image"), System.Drawing.Image)
        Me.btn_lucros.Location = New System.Drawing.Point(9, 73)
        Me.btn_lucros.Name = "btn_lucros"
        Me.btn_lucros.Size = New System.Drawing.Size(197, 43)
        Me.btn_lucros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btn_lucros.TabIndex = 10
        Me.btn_lucros.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Listagem de clientes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Listagem de funcionários"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Listagem de estoque"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(5, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Listagem de lucros"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_funcionarios)
        Me.GroupBox1.Controls.Add(Me.btn_clientes)
        Me.GroupBox1.Controls.Add(Me.btn_estoque)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_lucros)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 373)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'btn_funcionarios
        '
        Me.btn_funcionarios.BackColor = System.Drawing.Color.Brown
        Me.btn_funcionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_funcionarios.Image = CType(resources.GetObject("btn_funcionarios.Image"), System.Drawing.Image)
        Me.btn_funcionarios.Location = New System.Drawing.Point(9, 298)
        Me.btn_funcionarios.Name = "btn_funcionarios"
        Me.btn_funcionarios.Size = New System.Drawing.Size(235, 43)
        Me.btn_funcionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btn_funcionarios.TabIndex = 21
        Me.btn_funcionarios.TabStop = False
        '
        'btn_clientes
        '
        Me.btn_clientes.BackColor = System.Drawing.Color.Brown
        Me.btn_clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_clientes.Image = CType(resources.GetObject("btn_clientes.Image"), System.Drawing.Image)
        Me.btn_clientes.Location = New System.Drawing.Point(9, 219)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(197, 52)
        Me.btn_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btn_clientes.TabIndex = 20
        Me.btn_clientes.TabStop = False
        '
        'btn_estoque
        '
        Me.btn_estoque.BackColor = System.Drawing.Color.Brown
        Me.btn_estoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_estoque.Image = CType(resources.GetObject("btn_estoque.Image"), System.Drawing.Image)
        Me.btn_estoque.Location = New System.Drawing.Point(9, 143)
        Me.btn_estoque.Name = "btn_estoque"
        Me.btn_estoque.Size = New System.Drawing.Size(197, 49)
        Me.btn_estoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btn_estoque.TabIndex = 19
        Me.btn_estoque.TabStop = False
        '
        'Form_recepcionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(853, 493)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form_recepcionista"
        Me.Text = "GERENCIAMENTO DE RELATÓRIOS"
        CType(Me.btn_lucros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btn_funcionarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btn_lucros As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_funcionarios As PictureBox
    Friend WithEvents btn_clientes As PictureBox
    Friend WithEvents btn_estoque As PictureBox
End Class
