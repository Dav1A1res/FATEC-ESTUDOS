@echo off
title ATIVIDADE 01 - SISTEMAS DA INFORMAÇÃO
mode 60,40
color 0a

:inicio
cls

echo.
echo.
echo ===================
echo APLICATIVOS WINDOWS
echo ===================
echo [B] BLOCO DE NOTAS
echo [P] PAINT
echo [T] TECLADO VIRTUAL 
echo [PC] PAINEL DE CONTROLE
echo [W] WINDOWS EXPLORER
echo [R] RETORNAR AO MENU
echo ===================
set /p opc=Escolha uma opcao: 

if %opc% equ b (goto:bloco)
if %opc% equ p (goto:paint)
if %opc% equ t (goto:teclado)
if %opc% equ pc (goto:painel)
if %opc% equ w (goto:explore)
if %opc% equ r (call menu.bat) else (
echo.
echo.
echo ===================
echo OPCAO INVALIDA !
echo ===================
echo.
echo.
pause
goto inicio )

:bloco 
start notepad.exe
goto inicio

:paint 
start mspaint.exe
goto inicio

:teclado
start osk.exe
goto inicio

:painel
start control.exe
goto inicio

:explore 
start explorer.exe
goto inicio