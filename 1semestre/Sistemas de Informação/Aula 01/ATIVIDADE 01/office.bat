@echo off
title ATIVIDADE 01 - SISTEMAS DA INFORMAÇÃO
mode 60,40
color 0a

:inicio 
cls
echo.
echo.
echo ===================
echo PACOTE OFFICE
echo ===================
echo [W] WORD
echo [E] EXCEL
echo [P] POWERPOINT
echo [A] ACCESS
echo [R] RETORNAR AO MENU
echo ===================
set /p opc=Escolha uma opcao: 

if %opc% equ w (goto:word)
if %opc% equ e (goto:excel)
if %opc% equ p (goto:power)
if %opc% equ a (goto:access)
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

:word
start winword.exe
goto inicio

:excel
start excel.exe
goto inicio

:power
start powerpnt.exe
goto inicio

:access
start msaccess.exe
goto inicio


