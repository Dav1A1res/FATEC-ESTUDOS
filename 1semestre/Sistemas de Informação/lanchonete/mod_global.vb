Module mod_global
    Public qtde_atual_lanche, qtde_atual_bebidas, qtde_atual_doces, qtde_atual_tortas As Integer
    Public qtde_nova_lanche, qtde_nova_bebidas, qtde_nova_doces, qtde_nova_tortas As Integer
    Public tt_adm, tt_cliente As Integer
    Public ttl_carrinho As Double
    Public qtde_estoque, qtde_estoquerenovado, proximocod As Integer
    Public sql, aux_cpf, aux_cod, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public caminho_banco As String = Application.StartupPath & "\banco\lanchonete.mdb"
    Public cont As Integer

    Sub Conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco)
            MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub Carregar_dados()
        Try
            sql = "select * from tb_estoque order by COD asc"
            rs = db.Execute(sql)
            With Form_pedidos.dgv_produtos
                .Rows.Clear()
                Do While rs.EOF = False 'Enquanto existir registro no banco
                    .Rows.Add(rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub
    Sub Carregar_dados2()
        Try
            sql = "select * from tb_estoque order by COD asc"
            rs = db.Execute(sql)
            With Form_cozinheiro.dgv_produtosc
                .Rows.Clear()
                Do While rs.EOF = False 'Enquanto existir registro no banco
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

    Sub carregar_clientes()
        Try
            sql = "select * from tb_contas order by cpf asc"
            rs = db.Execute(sql)
            With Form_dono.dgv_contas
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

    Sub carregar_funcionarios()
        Try
            sql = "select * from tb_funcionarios order by tipo asc"
            rs = db.Execute(sql)
            With Form_dono.dgv_contas
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub



    Sub limpar_login()
        Try
            With Form_login
                .txt_cpf.Clear()
                .txt_senha.Clear()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Sub limpar_login_adm()
        Try
            With Form_login
                .txt_cpf_adm.Clear()
                .txt_senha_adm.Clear()
                .cmb_tipo_func.ResetText()
            End With
        Catch ex As Exception

        End Try
    End Sub


    Sub Carregar_tipo()
        Try
            With Form_pedidos.cmb_tipo.Items
                .Add("LANCHE")
                .Add("DOCE")
                .Add("TORTA")
                .Add("BEBIDAS")
                Form_pedidos.cmb_tipo.SelectedIndex = 1
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
    End Try
End Sub

    Sub Carregar_tipo_cozinha()
        Try
            With Form_cozinheiro.cmb_tipo.Items
                .Add("LANCHE")
                .Add("DOCE")
                .Add("TORTA")
                .Add("BEBIDAS")
                Form_cozinheiro.cmb_tipo.SelectedIndex = 1
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Sub Carregar_categoria()
        Try
            With Form_cozinheiro.cmb_categoria.Items
                .Add("LANCHE")
                .Add("DOCE")
                .Add("TORTA")
                .Add("BEBIDAS")
                Form_cozinheiro.cmb_categoria.SelectedIndex = 1
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Sub Carregar_estoque()
        Try
            With Form_pedidos.cmb_lanches.Items
                .Add("Misto quente")
                .Add("Pão de leite")
                .Add("Pão de parmesão na chapa")
                .Add("X-salada")
                .Add("X-burger")
                .Add("X-tudão")
                .Add("Cachorro quente")
                .Add("Croissant de presunto e queijo")
                .Add("Pão australiano")
                .Add("Esfiha de queijo")
            End With

            With Form_pedidos.cmb_tortas.Items
                .Add("Torta de frango")
                .Add("Torta de palmito")
                .Add("Torta de maçã")
                .Add("Torta de limão")
                .Add("Torta de morango")
                .Add("Quindim")
                .Add("Torta de chocolate")
                .Add("Torta de pêssego")
                .Add("Torta de cereja")
                .Add("Torta de nozes")
            End With

            With Form_pedidos.cmb_doces.Items
                .Add("Panqueca")
                .Add("Waffles")
                .Add("Brownie")
                .Add("Brigadeiro")
                .Add("Pudim de leite")
                .Add("Churros recheado")
                .Add("Sonho")
                .Add("Pão de mel")
                .Add("Cocada")
                .Add("Pão de coco")
            End With

            With Form_pedidos.cmb_bebidas.Items
                .Add("Café expresso")
                .Add("Café com leite")
                .Add("Capuccino")
                .Add("Suco natural de laranja")
                .Add("Suco de maracujá")
                .Add("Suco de manga")
                .Add("Refrigerante")
                .Add("Chá gelado")
                .Add("Água mineral")
                .Add("Água de coco")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
End Sub
End Module
