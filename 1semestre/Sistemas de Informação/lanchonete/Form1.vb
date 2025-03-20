Public Class Form_login
    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Form_cadastro.Show()
        Me.Hide()
    End Sub

    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click
        If txt_cpf.Text = "000.000.000-00" And txt_senha.Text = "adm" Then
            Gp_adm.Visible = True
            GroupBox1.Visible = False
            Gp_adm.Location = New Point((Me.Width - GroupBox1.Width) \ 2, (Me.Height - GroupBox1.Height) \ 2)
            Exit Sub
        End If

        Try
            sql = "select * from tb_contas where cpf='" & txt_cpf.Text & "' AND senha='" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Login bem sucedido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
                Form_pedidos.Show()
            Else
                MsgBox("CPF ou senha incorretos. Por favor tentar novamente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Conta não encontrada. Cadastre-se e tente novamente", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Me.Hide()
        End Try
    End Sub

    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Me.Size = New Size(649, 339)
    End Sub
    Private Sub btn_logar_adm_Click_1(sender As Object, e As EventArgs) Handles btn_logar_adm.Click
        Try
            sql = "select * from tb_funcionarios where cpf='" & txt_cpf_adm.Text & "' AND senha='" & txt_senha_adm.Text & "' AND tipo='" & cmb_tipo_func.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Login bem sucedido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
                If cmb_tipo_func.Text = "Cozinheiro" Then
                    Form_cozinheiro.Show()

                ElseIf cmb_tipo_func.Text = "Recepcionista" Then
                    Form_recepcionista.Show()

                ElseIf cmb_tipo_func.Text = "Dono" Then
                    Form_dono.Show()
                End If
            Else
                MsgBox("CPF ou senha incorretos. Por favor tentar novamente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Dados incorretos / Este funcionário não existe!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub check_c_CheckedChanged(sender As Object, e As EventArgs) Handles check_c.CheckedChanged
        If check_c.Checked = True Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub check_a_CheckedChanged(sender As Object, e As EventArgs) Handles check_a.CheckedChanged
        If check_a.Checked = True Then
            txt_senha_adm.PasswordChar = ""
        Else
            txt_senha_adm.PasswordChar = "*"
        End If
    End Sub

End Class
