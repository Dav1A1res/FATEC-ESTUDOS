Imports Microsoft.Office.Core

Public Class Form_cozinheiro
    Private Sub Form_cozinheiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_dados2()
        Carregar_tipo_cozinha()
        Carregar_categoria()

        cont = 1
        qtde_estoque = 0

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            With Me.dgv_produtosc
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

    Private Sub dgv_produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtosc.CellContentClick
        With dgv_produtosc
            If .CurrentRow.Cells(4).Selected = True Then
                aux_cod = .CurrentRow.Cells(0).Value
                GroupBox3.Visible = True
                Me.Size = New Size(700, 550)
                sql = "Select * from tb_estoque where cod=" & aux_cod
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    txt_nome2.Text = rs.Fields(1).Value.ToString()
                    cmb_categoria2.Text = rs.Fields(4).Value.ToString()
                    txt_preco2.Text = rs.Fields(2).Value.ToString()
                    txt_cod.Text = rs.Fields(0).Value.ToString()
                    txt_estoque.Text = rs.Fields(3).Value.ToString()
                End If
            End If
        End With
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        limpar_login_adm()
        Form_login.Show()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If GroupBox2.Visible = False Then
            GroupBox2.Visible = True
            Me.Size = New Size(700, 550)
        End If
    End Sub

    Private Sub btn_renovar_Click(sender As Object, e As EventArgs) Handles btn_renovar.Click
        Try
            aux_cod = txt_cod.Text
            sql = "Select * from tb_estoque where cod=" & aux_cod
            rs = db.Execute(sql)

            qtde_estoque = rs.Fields(3).Value
            qtde_estoquerenovado = qtde_estoque + 10

            sql = "update tb_estoque Set qtde='" & qtde_estoquerenovado & "' where cod=" & aux_cod
            rs = db.Execute(sql)
            MsgBox("Estoque do produto renovado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        Try
            sql = "select MAX(cod) from tb_estoque"
            rs = db.Execute(sql)

            If rs.Fields(0).Value Is DBNull.Value Then
                proximocod = 1
            Else
                proximocod = rs.Fields(0).Value + 1
            End If

            sql = "insert into tb_estoque values ('" & proximocod & "', " &
                                                          "'" & txt_nome.Text & "', " &
                                                          "'" & txt_preco.Text & "', " &
                                                          "'" & txt_qtde.Text & "', " &
                                                          "'" & cmb_categoria.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Produto adicionado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            btn_buscar.PerformClick()
        Catch ex As Exception
            MsgBox("Erro ao adicionar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            aux_cod = txt_cod.Text
            sql = "select * from tb_estoque where cod=" & aux_cod
            rs = db.Execute(sql)

            If rs.EOF = False Then
                sql = "update tb_estoque set nome_produto='" & txt_nome2.Text & "', " &
                                                                        "tipo ='" & cmb_categoria2.Text & "', " &
                                                                        "preco_produto ='" & txt_preco2.Text & "' where cod=" & aux_cod
                rs = db.Execute(sql)
                MsgBox("Produto alterado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                btn_buscar.PerformClick()
            End If
        Catch ex As Exception

        End Try


        MsgBox("Erro ao editar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
    End Sub
End Class