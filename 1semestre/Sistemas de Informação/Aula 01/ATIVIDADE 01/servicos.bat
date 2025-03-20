@echo off 
mode 60,70
color 0a

:inicio
cls
echo.
echo.
echo =================
echo SERVICOS DE REDE
echo =================
echo [I] NAVEGAR NA WEB
echo [Y] NAVEGAR NO YOUTUBE
echo [O] OBTER IP DA MAQUINA
echo [T] TESTAR CONEXAO DE REDE
echo [R] RETORNAR AO MENU
echo =================
set /p opc=Escolha uma opcao: 

if %opc% equ i (goto:web)
if %opc% equ y (goto:yt)
if %opc% equ o (goto:ip)
if %opc% equ t (goto:teste)
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

:web 
echo.
set /p site=Digite o endereco do site qual deseja visitar: 
start chrome.exe %site%
goto inicio

:yt
echo.
set yt=youtube.com
start chrome.exe %yt%
goto inicio

:ip
ipconfig/all
pause
goto inicio

:teste
echo.
set /p teste=Digite o IP ou o URL da maquina ou endereco web para pingar: 
ping %teste% -t
goto inicio