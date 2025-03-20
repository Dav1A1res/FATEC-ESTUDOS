chcp 65001
@echo off
title Aula 01 - Sistemas de Informacao
color 0a
:inicio
cls

echo  ▄▄▄▄    ▄▄▄     ▄▄▄█████▓ ▄████▄   ██░ ██ 
echo ▓█████▄ ▒████▄   ▓  ██▒ ▓▒▒██▀ ▀█  ▓██░ ██▒
echo ▒██▒ ▄██▒██  ▀█▄ ▒ ▓██░ ▒░▒▓█    ▄ ▒██▀▀██░
echo ▒██░█▀  ░██▄▄▄▄██░ ▓██▓ ░ ▒▓▓▄ ▄██▒░▓█ ░██ 
echo ░▓█  ▀█▓ ▓█   ▓██▒ ▒██▒ ░ ▒ ▓███▀ ░░▓█▒░██▓
echo ░▒▓███▀▒ ▒▒   ▓▒█░ ▒ ░░   ░ ░▒ ▒  ░ ▒ ░░▒░▒
echo ▒░▒   ░   ▒   ▒▒ ░   ░      ░  ▒    ▒ ░▒░ ░
echo ░    ░   ░   ▒    ░      ░         ░  ░░ ░
echo ░            ░  ░        ░ ░       ░  ░  ░
echo      ░                   ░                

echo.
echo ╔══════════════════════════╗
echo ║ ▒▒▓██  ( O   O )         ║
echo ╠═════Ooo== (_) ==ooO=====
echo          Tela 02
echo =========================
echo [G] Gerar Arquivos Diversos
echo [O] Organizar Arquivos
echo [R] Retornar ao Menu
echo ===========================
set /p op=Digite a opção desejada :
if /i %op% equ g (goto:gerar)
if /i %op% equ o (goto:organizar)
if /i %op% equ r (call aula01.bat) else (
   echo.
   echo -------------------
   echo  Opcao Invalida !
   echo -------------------
   echo.
   pause
   goto inicio)

:gerar
echo.
set /p nome=Digite o nome do arquivo a ser gerado:
set /p qtde=Digite a quantidade de arquivos a serem gerados:
set /p ext=Digite a extensao do tipo do arquivo:
for /L %%n in (1,1,%qtde%) do echo Fatec SCS > %nome%%%n.%ext%
echo.
echo Arquivos Gerados com Sucesso!
echo.
pause
goto inicio

:organizar
echo.
c:
cd\Users\Aluno\Desktop
set /p pasta=Digite a pasta a ser gerada :
set /p ext=Digite a extensao do tipo do arquivo:
md %pasta%
move *.%ext% c:\Users\Aluno\Desktop\%pasta%
echo.
echo Arquivos organizados com Sucesso!
echo.
pause
goto inicio
