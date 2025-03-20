Public Class Form_cadastro
    Private Sub Form_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try
            sql = "select * from tb_contas where CPF='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_contas values ('" & txt_cpf.Text & "', " &
                                                      "'" & txt_nome.Text & "', " &
                                                      "'" & txt_email.Text & "', " &
                                                      "'" & txt_senha.Text & "', " &
                                                      "' CLIENTE ')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                MsgBox("Esta conta já existe.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If
            Form_login.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class