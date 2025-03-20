chcp 65001
@echo off
title EXERCÍCIO - JOGO DA ADIVINHAÇÃO
mode 60,40
color 0a

:sorteio
set /a numero=(%random% %%50) + 1
set /a ttotais=5
set /a trest=5
set /a proposta1=51
set /a proposta2=0

:jogo
cls
echo.
echo.
echo ╔═════════════════════════════╗
echo ╠ ▓▓▓ ♣ JOGO DO SORTEIO ♣ ▓▓▓ ╣
echo ╚═════════════════════════════╝
echo.
echo ┌─────────────────────────────────────────┐
echo │Adivinhe um número sorteado entre 1 e 50 │
echo └─────────────────────────────────────────┘
echo.
echo ┌──────────────────────────────┐
echo │Tentativas totais : %ttotais%    
echo │Tentativas restantes : %trest%
echo └──────────────────────────────┘
echo.
set /p resp=Digite o número do seu palpite: 
echo.

if %resp% lss 1 (goto:falha)
if %resp% gtr 50 (goto:falha)

if %resp% lss %numero% (goto:menor)
if %resp% gtr %numero% (goto:maior)
if %resp% equ %numero% (goto:igual) 

:falha
echo ┌─────────────────────────────────────────┐
echo │Número não correspondente com a proposta!│
echo └─────────────────────────────────────────┘
pause
goto jogo

:igual
echo ┌────────────────────────┐
echo │Parabéns! Você ganhou!  │
echo │O número sorteado era %numero%│
echo └────────────────────────┘
echo.
pause
set /p rep=Deseja jogar novamente [S/N]: 
if /i %rep% equ s (goto:sorteio) else (exit)

:maior 
echo ┌────────────────────────────────────┐
echo │Você errou! Digite um número menor !│
echo └────────────────────────────────────┘
pause
set /a trest-=1
if %trest% leq 0 (goto:fim) else (goto:jogo)

:menor
echo ┌────────────────────────────────────┐
echo │Você errou! Digite um número maior !│
echo └────────────────────────────────────┘
pause
set /a trest-=1
if %trest% leq 0 (goto:fim) else (goto:jogo)


:fim
cls
echo.
echo.
echo ╔═════════════════════════════╗
echo ╠ ▓▓▓ ♣ JOGO DO SORTEIO ♣ ▓▓▓ ╣
echo ╚═════════════════════════════╝
echo.
echo ┌─────────────────────────────────────────┐
echo │Adivinhe um número sorteado entre 1 e 50 │
echo └─────────────────────────────────────────┘
echo.
echo ┌──────────────────────────────┐
echo │Tentativas restantes: 0       │
echo └──────────────────────────────┘
echo.
echo.
echo ┌────────────────────────────────────┐
echo │SUAS TENTATIVAS ACABARAM! GAME OVER!│
echo │O NÚMERO SORTEADO ERA %numero%                  
echo └────────────────────────────────────┘
pause
set /p rep=Deseja tentar novamente [S/N]: 
if /i %rep% equ s (goto:sorteio) else (exit)