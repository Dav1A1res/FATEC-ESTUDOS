Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Access
Imports System.Runtime.InteropServices


Public Class Form_recepcionista
    Private Sub Form_recepcionista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
    End Sub

    Private Sub btn_lucros_Click(sender As Object, e As EventArgs) Handles btn_lucros.Click
        If mod_global.db.State = 0 Then
            mod_global.Conectar_banco()
        End If

        ' Criar uma instância do Access.Application
        Dim oAccess As Access.Application = Nothing

        Try
            oAccess = New Access.Application()

            ' Abrir o banco de dados
            oAccess.OpenCurrentDatabase(mod_global.caminho_banco)

            ' Abrir o relatório em modo de visualização
            oAccess.DoCmd.OpenReport("rt_lucros", AcView.acViewPreview)

            ' Tornar a aplicação Access visível
            oAccess.Visible = True


        Catch ex As Exception
            MsgBox("Erro ao abrir o relatório: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")

        Finally
            ' Liberar recursos COM
            If oAccess IsNot Nothing Then
                Marshal.ReleaseComObject(oAccess)
                oAccess = Nothing
            End If
        End Try
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        If mod_global.db.State = 0 Then
            mod_global.Conectar_banco()
        End If

        ' Criar uma instância do Access.Application
        Dim oAccess As Access.Application = Nothing

        Try
            oAccess = New Access.Application()

            ' Abrir o banco de dados
            oAccess.OpenCurrentDatabase(mod_global.caminho_banco)

            ' Abrir o relatório em modo de visualização
            oAccess.DoCmd.OpenReport("rt_estoque", AcView.acViewPreview)

            ' Tornar a aplicação Access visível
            oAccess.Visible = True


        Catch ex As Exception
            MsgBox("Erro ao abrir o relatório: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")

        Finally
            ' Liberar recursos COM
            If oAccess IsNot Nothing Then
                Marshal.ReleaseComObject(oAccess)
                oAccess = Nothing
            End If
        End Try
    End Sub

    Private Sub btn_funcionarios_Click(sender As Object, e As EventArgs) Handles btn_funcionarios.Click
        If mod_global.db.State = 0 Then
            mod_global.Conectar_banco()
        End If

        ' Criar uma instância do Access.Application
        Dim oAccess As Access.Application = Nothing

        Try
            oAccess = New Access.Application()

            ' Abrir o banco de dados
            oAccess.OpenCurrentDatabase(mod_global.caminho_banco)

            ' Abrir o relatório em modo de visualização
            oAccess.DoCmd.OpenReport("rt_listagemfuncionários", AcView.acViewPreview)

            ' Tornar a aplicação Access visível
            oAccess.Visible = True


        Catch ex As Exception
            MsgBox("Erro ao abrir o relatório: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")

        Finally
            ' Liberar recursos COM
            If oAccess IsNot Nothing Then
                Marshal.ReleaseComObject(oAccess)
                oAccess = Nothing
            End If
        End Try
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        If mod_global.db.State = 0 Then
            mod_global.Conectar_banco()
        End If

        ' Criar uma instância do Access.Application
        Dim oAccess As Access.Application = Nothing

        Try
            oAccess = New Access.Application()

            ' Abrir o banco de dados
            oAccess.OpenCurrentDatabase(mod_global.caminho_banco)

            ' Abrir o relatório em modo de visualização
            oAccess.DoCmd.OpenReport("rt_listagemclientes", AcView.acViewPreview)

            ' Tornar a aplicação Access visível
            oAccess.Visible = True


        Catch ex As Exception
            MsgBox("Erro ao abrir o relatório: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")

        Finally
            ' Liberar recursos COM
            If oAccess IsNot Nothing Then
                Marshal.ReleaseComObject(oAccess)
                oAccess = Nothing
            End If
        End Try
    End Sub
End Class