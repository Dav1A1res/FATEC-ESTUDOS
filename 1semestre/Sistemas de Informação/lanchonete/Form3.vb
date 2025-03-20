Imports System.IO

Public Class Form_pedidos
    Private Sub Form_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_tipo()
        Carregar_estoque()
        ttl_carrinho = 0
    End Sub

    Private Sub Label_lanche_Click(sender As Object, e As EventArgs) Handles Label_lanche.Click
        Try
            sql = "select * from tb_estoque where nome_produto ='" & cmb_lanches.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If rs.Fields(3).Value = 0 Then
                    MsgBox("Produto fora de estoque.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    qtde_atual_lanche = rs.Fields(3).Value
                    qtde_nova_lanche = qtde_atual_lanche - 1

                    ttl_carrinho = ttl_carrinho + rs.Fields(2).Value
                    txt_total.Text = ttl_carrinho.ToString()
                    sql = "update tb_estoque set qtde='" & qtde_nova_lanche & "' where nome_produto= '" & cmb_lanches.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Produto adicionado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                End If
            End If
        Catch ex As Exception
            MsgBox("Produto não localizado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try

    End Sub

    Private Sub Label_doce_Click(sender As Object, e As EventArgs) Handles Label_doce.Click
        Try
            sql = "select * from tb_estoque where nome_produto ='" & cmb_doces.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If rs.Fields(3).Value = 0 Then
                    MsgBox("Produto fora de estoque.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    qtde_atual_doces = rs.Fields(3).Value
                    qtde_nova_doces = qtde_atual_doces - 1

                    ttl_carrinho = ttl_carrinho + rs.Fields(2).Value
                    txt_total.Text = ttl_carrinho.ToString()

                    sql = "update tb_estoque set qtde='" & qtde_nova_doces & "' where nome_produto= '" & cmb_doces.Text & "'"
                    rs = db.Execute(sql)

                    MsgBox("Produto adicionado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                End If
            End If
        Catch ex As Exception
            MsgBox("Produto não localizado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Label_bebida_Click(sender As Object, e As EventArgs) Handles Label_bebida.Click
        Try
            sql = "select * from tb_estoque where nome_produto ='" & cmb_bebidas.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If rs.Fields(3).Value = 0 Then
                    MsgBox("Produto fora de estoque.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    qtde_atual_bebidas = rs.Fields(3).Value
                    qtde_nova_bebidas = qtde_atual_bebidas - 1

                    ttl_carrinho = ttl_carrinho + rs.Fields(2).Value
                    txt_total.Text = ttl_carrinho.ToString()

                    sql = "update tb_estoque set qtde='" & qtde_nova_bebidas & "' where nome_produto= '" & cmb_bebidas.Text & "'"
                    rs = db.Execute(sql)

                    MsgBox("Produto adicionado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                End If
            End If
        Catch ex As Exception
            MsgBox("Produto não localizado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Label_torta_Click(sender As Object, e As EventArgs) Handles Label_torta.Click
        Try
            sql = "select * from tb_estoque where nome_produto ='" & cmb_tortas.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If rs.Fields(3).Value = 0 Then
                    MsgBox("Produto fora de estoque.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    qtde_atual_tortas = rs.Fields(3).Value
                    qtde_nova_tortas = qtde_atual_tortas - 1

                    ttl_carrinho = ttl_carrinho + rs.Fields(2).Value
                    txt_total.Text = ttl_carrinho.ToString()

                    sql = "update tb_estoque set qtde='" & qtde_nova_tortas & "' where nome_produto= '" & cmb_tortas.Text & "'"
                    rs = db.Execute(sql)

                    MsgBox("Produto adicionado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                End If
            End If
        Catch ex As Exception
            MsgBox("Produto não localizado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            With Me.dgv_produtos
                .Rows.Clear()
                sql = "select * from tb_estoque where tipo LIKE '" & cmb_tipo.Text & "%' order by cod asc"
                rs = db.Execute(sql)
                Do While rs.EOF = False 'Enquanto existir registro no banco
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_encerrar_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
        Try

            Dim data As String = DateTime.Now.ToString("dd-MM-yyyy")
            Dim hora As String = DateTime.Now.ToString("HH:mm")

            sql = "insert into tb_compras (VALOR, DATA, HORA) values ('" & txt_total.Text & "', '" & data & "', '" & hora & "')"
            rs = db.Execute(sql)

            MsgBox("Compra realizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

        Catch ex As Exception
            MsgBox("Erro ao realizar compra!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try

        Me.Close()
        limpar_login()
        Form_login.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class