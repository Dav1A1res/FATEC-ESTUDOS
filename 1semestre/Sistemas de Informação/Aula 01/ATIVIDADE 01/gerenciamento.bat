@echo off
mode 60,40
color 0a

:inicio
cls

echo.
echo.
echo ==========================
echo GERENCIAMENTO DA MAQUINA
echo ==========================
echo [RM] REINICIAR MAQUINA
echo [DM] DESLIGAR MAQUINA
echo [R] RETORNAR AO MENU
echo ==========================
set /p opc=Esolha uma opcao: 

if %opc% equ rm (goto:reiniciar)
if %opc% equ dm (goto:desligar)
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

:reiniciar
shutdown -r
goto inicio

:desliggar
shutdown -s
goto inicio