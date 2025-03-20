Public Class Form_dono
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        limpar_login_adm()
        Form_login.Show()
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        GroupBox1.Location = New Point(8, 250)
        Me.Size = New Size(770, 470)
    End Sub

    Private Sub btn_funcionarios_Click(sender As Object, e As EventArgs) Handles btn_funcionarios.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Location = New Point(8, 250)
        Me.Size = New Size(770, 470)
    End Sub

    Private Sub Form_dono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(770, 308)
        Conectar_banco()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            sql = "select * from tb_contas where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_contas set nome='" & txt_nome.Text & "', " &
                                                                        "email ='" & txt_email.Text & "', " &
                                                                        "senha ='" & txt_senha.Text & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                carregar_clientes()
            End If
        Catch ex As Exception
            MsgBox("Erro ao editar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_editar_func_Click(sender As Object, e As EventArgs) Handles btn_editar_func.Click
        Try
            sql = "select * from tb_funcionarios where cpf='" & txt_cpf_func.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_funcionarios set nome='" & txt_nome_func.Text & "', " &
                                                                        "email ='" & txt_email_func.Text & "', " &
                                                                        "senha ='" & txt_senha_func.Text & "' where cpf='" & txt_cpf_func.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                carregar_funcionarios()
            End If
        Catch ex As Exception
            MsgBox("Erro ao editar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try
            sql = "select * from tb_funcionarios where cpf='" & txt_cpf_func.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_funcionarios values ('" & txt_cpf_func.Text & "', " &
                                                      "'" & txt_nome_func.Text & "', " &
                                                      "'" & txt_email_func.Text & "', " &
                                                      "'" & txt_senha_func.Text & "', " &
                                                      "'" & cmb_tipo_func.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Funcionário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                MsgBox("Erro ao cadastrar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            dgv_contas.Rows.Clear()
            If cmb_tipo_conta.Text = "CLIENTE" Then
                carregar_clientes()
            ElseIf cmb_tipo_conta.Text = "FUNCIONÁRIO" Then
                carregar_funcionarios()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick
        If cmb_tipo_conta.Text = "CLIENTE" Then
            Try
                With dgv_contas
                    If .CurrentRow.Cells(6).Selected = True Then
                        aux_cpf = .CurrentRow.Cells(0).Value
                        resp = MsgBox("Deseja realmente excluir o" + vbNewLine &
                                  "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÂO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete from tb_contas where cpf='" & aux_cpf & "'"
                            rs = db.Execute(sql)
                            carregar_clientes()
                        End If
                    ElseIf .CurrentRow.Cells(5).Selected = True Then
                        GroupBox1.Visible = True
                        GroupBox2.Visible = False
                        GroupBox1.Location = New Point(8, 250)
                        Me.Size = New Size(770, 470)
                        aux_cpf = .CurrentRow.Cells(0).Value
                        sql = "select * from tb_contas where cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        If rs.EOF = False Then
                            txt_cpf.Text = rs.Fields(0).Value
                            txt_nome.Text = rs.Fields(1).Value
                            txt_email.Text = rs.Fields(2).Value
                            txt_senha.Text = rs.Fields(3).Value
                        End If
                    End If
                End With
            Catch ex As Exception

            End Try
        ElseIf cmb_tipo_conta.Text = "FUNCIONÁRIO" Then

            Try
                With dgv_contas
                    If .CurrentRow.Cells(6).Selected = True Then
                        aux_cpf = .CurrentRow.Cells(0).Value
                        resp = MsgBox("Deseja realmente excluir o" + vbNewLine &
                                  "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÂO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete from tb_funcionarios where cpf='" & aux_cpf & "'"
                            rs = db.Execute(sql)
                            carregar_funcionarios()
                        End If
                    ElseIf .CurrentRow.Cells(5).Selected = True Then
                        GroupBox2.Visible = True
                        GroupBox1.Visible = False
                        GroupBox2.Location = New Point(8, 250)
                        Me.Size = New Size(770, 470)
                        aux_cpf = .CurrentRow.Cells(0).Value
                        sql = "select * from tb_funcionarios where cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        If rs.EOF = False Then
                            txt_cpf_func.Text = rs.Fields(0).Value
                            txt_nome_func.Text = rs.Fields(1).Value
                            txt_email_func.Text = rs.Fields(2).Value
                            txt_senha_func.Text = rs.Fields(3).Value
                            cmb_tipo_func.Text = rs.Fields(4).Value
                        End If
                    End If
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class