@echo off
title MANIPULACAO DE DADOS EM LISTA
mode 60,40
color 0a

:inicio
cls
echo.
echo =============================
echo    CADASTRO DE CLIENTES
echo =============================
echo [N] NOVO CLIENTE
echo [L] LISTAGEM GERAL
echo [P] PESQUISAR CLIENTES
echo [E] EXCLUIR CLIENTE
echo [S] SAIR DO PROGRAMA
echo =============================
set /p o=Digite a opcao desejada: 

if  /i %o% equ n (goto:nvc)
if  /i %o% equ l (goto:ltg)
if  /i %o% equ p (goto:pc)
if  /i %o% equ e (goto:exc)
if  /i %o% equ s (exit) else (
echo =============================
echo       OPCAO INVALIDA
echo =============================
pause
goto inicio)

:nvc
cls
echo.
set /p cpf=Digite o CPF do cliente: 
set /p nome=Digite o nome do cliente: 

echo %date%    %time%    %cpf%    %nome% >> lista.txt
echo.
echo =================================
echo   CLIENTE GRAVADO COM SUCESSO !
echo =================================
echo.
set /p resp=Deseja adicionar novo cliente [S/N]: 
if %resp% equ s (goto:nvc) else (goto:inicio)

:ltg
mode 120,40
cls
echo.
echo ============= LISTAGEM GERAL DE CLIENTES ==================
echo     DATA    HORA    CPF CLIENTE    NOME CLIENTE
echo ===========================================================
type lista.txt
echo.
pause
goto inicio

:pc
mode 120,40
cls
echo.
set /p contato=Digite o nome ou o CPF do Cliente: 
echo.
echo ============= CONSULTA INDIVIDUAL DE CLIENTES =============
echo     DATA    HORA    CPF CLIENTE    NOME CLIENTE
echo ===========================================================
Findstr /i "%contato%" lista.txt
echo ===========================================================
set /p resp=Deseja realizar uma nova pesquisa [S/N]: 
if /i %resp% equ s (goto:pc) else (goto:inicio)

:exc 
mode 120:40
cls
set /p contato=Digite o CPF ou nome do Cliente: 
Findstr /i "%contato%" lista.txt

::errorlevel igual 0 (existe informação)
::errorlevel igual 1 (não existe informação)

if %errorlevel% equ 0 (
Findstr /i /v "%contato%" lista.txt > lixo.txt
del lista.txt 
rename lixo.txt lista.txt
echo.
echo =================================
echo   CLIENTE EXCLUIDO COM SUCESSO!
echo =================================
echo.
pause
goto inicio) else (
echo.
echo ================================
echo   CLIENTE NAO LOCALIZADO!
echo ================================
echo.
pause 
goto inicio)