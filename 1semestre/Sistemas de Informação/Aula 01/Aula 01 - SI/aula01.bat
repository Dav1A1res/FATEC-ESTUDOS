@echo off
title Aula 01 - Sistemas de Informacao
color 0f
:inicio
cls
echo.
echo         ( O   O )
echo =====Ooo== (_) ==ooO=====
echo      Menu Principal
echo =========================
echo [W] Executar o Word
echo [E] Executar o Excel
echo [P] Executar o PowerPoint
echo [A] Executar o Access
echo [C] Calculadora
echo [T] Teclado Virtual
echo [N] Navegar na Web
echo [R] Testar Conexao Rede
echo [Y] Buscar Conteudo Youtube
echo [O] Outra Tela
echo [F] Finalizar Programa
echo ===========================
set /p op=Digite a opcao desejada :
if /i %op% equ w (goto:word)
if /i %op% equ e (goto:excel)
if /i %op% equ p (goto:slides)
if /i %op% equ a (goto:banco)
if /i %op% equ c (goto:calculo)
if /i %op% equ t (goto:teclado)
if /i %op% equ n (goto:web)
if /i %op% equ r (goto:conexao)
if /i %op% equ y (goto:conteudo)
if /i %op% equ o (call tela2.bat)
if /i %op% equ f (exit) else (
   echo.
   echo -------------------
   echo  Opcao Invalida !
   echo -------------------
   echo.
   pause
   goto inicio)

:word
start winword.exe
goto inicio

:excel
start excel.exe
goto inicio

:slides
start powerpnt.exe
goto inicio

:banco
start msaccess.exe
goto inicio

:calculo
start calc.exe
goto inicio

:teclado
start osk.exe
goto inicio

:web
echo.
set /p site=Digite o endereco da pagina web :
start chrome.exe %site%
goto inicio

:conexao
echo.
set /p teste=Digite o IP da maquina ou endereco web:
ping %teste% -t
goto inicio

:conteudo
echo.
set /p busca=Digite o conteudo a ser pesquisado:
start chrome.exe https://www.youtube.com/results?search_query=%busca%
goto inicio















