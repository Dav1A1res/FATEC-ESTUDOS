@echo off 
title ATIVIDADE 01 - SISTEMAS DA INFORMAÇÃO
mode 60,40.
color 0a

:inicio
cls
echo.
echo.
echo ===================
echo REALIZE O LOGIN
echo ===================
set /p log=Digite o seu e-mail: 
set /p sen=Digite a sua senha: 
echo ===================

if "%log%"=="davi" (if "%sen%"=="123" (call menu.bat) else (    
echo. 
echo.
echo ===================
echo LOGIN INCORRETO
echo ===================
echo.
echo.
pause
goto inicio)
) else (    
echo. 
echo.
echo ===================
echo LOGIN INCORRETO
echo ===================
echo.
echo.
pause
goto inicio)