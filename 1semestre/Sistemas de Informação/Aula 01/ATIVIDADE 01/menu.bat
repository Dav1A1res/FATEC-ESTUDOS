@echo off 
title ATIVIDADE 01 - SISTEMAS DA INFORMAÇÃO
mode 60,40.
color 0a

:inicio
cls
echo.
echo.
echo ===================
echo MENU PRINCIPAL
echo ===================
echo [1] PACOTE OFFICE
echo [2] APLICATIVOS WINDOWS
echo [3] SERVICOS DE REDE
echo [4] GERENCIAMENTO DA MAQUINA
echo [E] ENCERRAR LOGIN
echo [S] SAIR DO PROGRAMA
echo ===================
set /p opc=Escolha uma opcao: 

if %opc% equ 1 (call office.bat)
if %opc% equ 2 (call apps.bat)
if %opc% equ 3 (call servicos.bat)
if %opc% equ 4 (call gerenciamento.bat)
if %opc% equ e (call login.bat)
if %opc% equ s (exit) else (

echo.
echo.
echo ===================
echo OPCAO INVALIDA !
echo ===================
echo.
echo.
pause
goto inicio )