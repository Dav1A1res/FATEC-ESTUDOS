chcp 65001
@echo off
title EXERCÍCIO - PEDRA PAPEL SPOCK
mode 60,70
color 0a

:jogo
cls
echo.
echo.
echo ╔═════════════════════════════════╗
echo ╠ ▓▓▓ ♣ PEDRA PAPEL E SPOCK ♣ ▓▓▓ ╣
echo ╚═════════════════════════════════╝
echo.
echo.
set /p player=Digite seu nome: 
echo.

set /a vit=0
set /a derr=0
set /a emp=0

:computador
set /a comp=(%random% %%5) + 1

:menu
cls

echo.
echo.
echo ╔═════════════════════════════════╗
echo ╠ ▓▓▓ ♣ PEDRA PAPEL E SPOCK ♣ ▓▓▓ ╣
echo ╚═════════════════════════════════╝
echo.
echo.
echo ========================
echo Menu Principal 
echo ========================
echo [1] PEDRA
echo [2] PAPEL
echo [3] TESOURA
echo [4] SPOCK
echo [5] LARGATIXA
echo [R] REGRAS
echo [RE] REINICIAR PLACAR
echo [E] ENCERRAR JOGO
echo ========================
set /p o=%player% digite uma opção: 

if %o% equ 1 (if %comp% equ 1 (goto:pxp))
if %o% equ 1 (if %comp% equ 2 (goto:pxpa))
if %o% equ 1 (if %comp% equ 3 (goto:pxt))
if %o% equ 1 (if %comp% equ 4 (goto:pxs))
if %o% equ 1 (if %comp% equ 5 (goto:pxl))

if %o% equ 2 (if %comp% equ 1 (goto:paxp))
if %o% equ 2 (if %comp% equ 2 (goto:paxpa))
if %o% equ 2 (if %comp% equ 3 (goto:paxt))
if %o% equ 2 (if %comp% equ 4 (goto:paxs))
if %o% equ 2 (if %comp% equ 5 (goto:paxl))

if %o% equ 3 (if %comp% equ 1 (goto:txp))
if %o% equ 3 (if %comp% equ 2 (goto:txpa))
if %o% equ 3 (if %comp% equ 3 (goto:txt))
if %o% equ 3 (if %comp% equ 4 (goto:txs))
if %o% equ 3 (if %comp% equ 5 (goto:txl))

if %o% equ 4 (if %comp% equ 1 (goto:sxp))
if %o% equ 4 (if %comp% equ 2 (goto:sxpa))
if %o% equ 4 (if %comp% equ 3 (goto:sxt))
if %o% equ 4 (if %comp% equ 4 (goto:sxs))
if %o% equ 4 (if %comp% equ 5 (goto:sxl))

if %o% equ 5 (if %comp% equ 1 (goto:lxp))
if %o% equ 5 (if %comp% equ 2 (goto:lxpa))
if %o% equ 5 (if %comp% equ 3 (goto:lxt))
if %o% equ 5 (if %comp% equ 4 (goto:lxs))
if %o% equ 5 (if %comp% equ 5 (goto:lxl))


if %o% equ re (goto:jogo)
if %o% equ r (goto:regras)
if %o% equ e (exit) else (

echo.
echo ================
echo OPÇÃO INVÁLIDA!
echo ================
echo.
pause
goto menu)	

::====================================================================================================================================================
:pxp
echo.
echo QUE PENA ... FOI UM EMPATE!
echo.
echo %player% escolheu PEDRA
echo COMPUTADOR escolheu PEDRA
echo.
set /a emp=%emp% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:pxpa
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu PEDRA
echo COMPUTADOR escolheu PAPEL
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:pxt
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu PEDRA
echo COMPUTADOR escolheu TESOURA
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:pxs
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu PEDRA
echo COMPUTADOR escolheu SPOCK
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:pxl
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu PEDRA
echo COMPUTADOR escolheu LARGATIXA
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 
::====================================================================================================================================================
:paxpa
echo.
echo QUE PENA ... FOI UM EMPATE!
echo.
echo %player% escolheu PAPEL
echo COMPUTADOR escolheu PAPEL
echo.
set /a emp=%emp% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:paxt
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu PAPEL
echo COMPUTADOR escolheu TESOURA
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:paxp
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu PAPEL
echo COMPUTADOR escolheu PEDRA
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:paxl
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu PAPEL
echo COMPUTADOR escolheu LARGATIXA
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:paxs
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu PAPEL
echo COMPUTADOR escolheu SPOCK
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 
::====================================================================================================================================================
:txt
echo.
echo QUE PENA ... FOI UM EMPATE!
echo.
echo %player% escolheu TESOURA
echo COMPUTADOR escolheu TESOURA
echo.
set /a emp=%emp% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:txp
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu TESOURA
echo COMPUTADOR escolheu PEDRA
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:txpa
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu TESOURA
echo COMPUTADOR escolheu PAPEL
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:txs
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu TESOURA
echo COMPUTADOR escolheu SPOCK
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:txl
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu TESOURA
echo COMPUTADOR escolheu LARGATIXA
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 
::====================================================================================================================================================
:sxs
echo.
echo QUE PENA ... FOI UM EMPATE!
echo.
echo %player% escolheu SPOCK
echo COMPUTADOR escolheu SPOCK
echo.
set /a emp=%emp% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:sxpa
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu SPOCK
echo COMPUTADOR escolheu PAPEL
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:sxt
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu SPOCK
echo COMPUTADOR escolheu TESOURA
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:sxl
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu SPOCK
echo COMPUTADOR escolheu LARGATIXA
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:sxp
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu SPOCK
echo COMPUTADOR escolheu PEDRA
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 
::====================================================================================================================================================
:lxl
echo.
echo QUE PENA ... FOI UM EMPATE!
echo.
echo %player% escolheu LARGATIXA
echo COMPUTADOR escolheu LARGATIXA
echo.
set /a emp=%emp% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:lxt
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu LARGATIXA
echo COMPUTADOR escolheu TESOURA
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:lxpa
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu LARGATIXA
echo COMPUTADOR escolheu PAPEL
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:lxp
echo.
echo QUE PENA ... FOI UMA DERROTA!
echo.
echo %player% escolheu LARGATIXA
echo COMPUTADOR escolheu PEDRA
echo.
set /a derr=%derr% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador 

:lxs
echo.
echo MUITO BEM, ISSO FOI UMA VITÓRIA!
echo.
echo %player% escolheu LARGATIXA
echo COMPUTADOR escolheu SPOCK
echo.
set /a vit=%vit% + 1
echo ==== PLACAR DE JOGO ====
echo VITÓRIAS : %vit%
echo DERROTAS : %derr%
echo EMPATES : %emp%
echo ========================
pause
goto computador
::====================================================================================================================================================
:regras
cls
echo.
echo ==================
echo      REGRAS
echo ==================
echo.
echo Pedra:
echo       Empata com pedra, esmaga a tesoura e a largatixa, é coberta por papel e vaporizada por spock.
echo.
echo Papel:
echo       Empata com papel, cobre a pedra e refuta o spock, é comida pela largatixa e cortada pela tesoura.
echo.
echo Tesoura:
echo         Empata com a tesoura, corta o papel e mata a largatixa, é quebrada pelo spock e pela pedra.
echo.
echo Spock: 
echo       Empata com o spock, quebra a tesoura e vaporiza a pedra, é envenenado pela largatixa e refutado pelo papel.
echo.
echo Largatixa:
echo           Empata com a largatixa, envenena o spock e come o papel, é esmagada pela pedra e morta pela tesoura.
echo.
pause
goto menu