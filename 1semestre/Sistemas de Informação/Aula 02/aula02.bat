chcp 65001
@echo off
title Aula 02 - SI
mode 60,40
color 0a
::comentário
set /a cont=0
::set palavra=oi
:inicio
cls
echo.
echo.
echo ========================
echo Menu Principal 
echo ========================
echo [C] CALCULADORA
echo [N] NAVEGAR WEB
echo [Y] CONTEÚDO YOUTUBE
echo [G] GERAR ARQUIVOS DIVERSOS
echo [O] ORGANIZAR ARQUIVOS
echo [S] SORTEAR NÚMEROS
echo [E] ENCERRAR PROGRAMA
echo ========================
set /p o=Digite uma opção: 

::condicionais

if /i %o% equ c (goto:calculadora)
if /i %o% equ n (goto:navegar)
if /i %o% equ y (goto:youtube)
if /i %o% equ g (goto:arquivos)
if /i %o% equ o (goto:organizar)
if /i %o% equ s (goto:sorteio)
if /i %o% equ e (exit) else (
	echo.
	echo ================
	echo OPÇÃO INVÁLIDA!
	echo ================
	echo.
	pause
	goto inicio)	
	
:calculadora
start calc.exe
goto inicio

:navegar
echo.
set /p site=Digite o endereço da página web: 
start chrome.exe %site%
goto inicio

:youtube
echo.
set /p busca=Digite o conteúdo a ser pesquisado: 
start chrome.exe https://www.youtube.com/results?search_query=%busca%
goto inicio

:arquivos
echo.
set /p nome=Digite o nome a ser gerado: 
set /p qtde=Digite a quantidade de arquivos a ser gerada: 
set /p tipo=Digite o tipo de arquivo a ser gerado: 
For /L %%n in (1,1,%qtde%) do echo fatec são caetano > %nome%%%n.%tipo%
echo.
echo Arquivos gerados com sucesso!
echo.
pause
goto inicio

:organizar
echo.
set /p pasta=Digite a pasta a ser criada: 
set /p tipo=Digite o tipo de arquivo a ser movido: 
md %pasta%
move *.%tipo% C:\Users\aluno2\Desktop\%pasta%
::ou (*.*) para mover todos os tipos
echo.
echo Arquivos organizados com sucesso!
echo.
pause
goto inicio

:sorteio
echo.
cls
set /a numero=(%random% %%100) + 1
set /a cont=%cont% + 1
echo.
echo ==============================
echo Número sorteado: %numero%
echo Quantidade de sorteios: %cont%
echo ==============================
echo.
set /p rep=Deseja sortear novo número [S/N]: 
if /i %rep% equ s (goto:sorteio) else (goto:inicio)

