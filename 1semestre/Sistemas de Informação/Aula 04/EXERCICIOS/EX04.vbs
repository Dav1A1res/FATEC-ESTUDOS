Dim num1, num2, num3, num4, maior, menor, audio

call carregar_voz
call atividade

sub carregar_voz()
set audio = CreateObject("SAPI.SPVOICE")
audio.volume=100
audio.rate=1
end sub

sub atividade()

num1 = cint(inputbox("Insira um número inteiro qualquer"))
num2 = cint(inputbox("Insira um número inteiro qualquer"))
num3 = cint(inputbox("Insira um número inteiro qualquer"))
num4 = cint(inputbox("Insira um número inteiro qualquer"))

call opcao_voz
end Sub
sub opcao_voz()
escolha = cint(inputbox("[1] RECEBER OS RESULTADOS POR VOZ" + vbnewline &_
						"[2] RECEBER OS RESULTADOS POR MENSAGEM"))
						
select case escolha
	case 1:
if num1 > num2 and num1 > num3 and num1 > num4 Then
	maior = num1
	audio.speak("O MAIOR NÚMERO É O NÚMERO "& maior &"")
	
elseif num2 > num1 and num2 > num3 and num2 > num4 Then
	maior = num2
	audio.speak("O MAIOR NÚMERO É O NÚMERO "& maior &"")
	
elseif num3 > num1 and num3 > num2 and num3 > num4 Then
	maior = num3
	audio.speak("O MAIOR NÚMERO É O NÚMERO "& maior &"")
	
elseif num4 > num1 and num4 > num2 and num4 > num3 Then
	maior = num4
	audio.speak("O MAIOR NÚMERO É O NÚMERO "& maior &"")
end if

if num1 < num2 and num1 < num3 and num1 < num4 Then
	menor = num1
	audio.speak("O MENOR NÚMERO É O NÚMERO "& menor &"")
	
elseif num2 < num1 and num2 < num3 and num2 < num4 Then
	menor = num2
	audio.speak("O MENOR NÚMERO É O NÚMERO "& menor &"")
	
elseif num3 < num1 and num3 < num2 and num3 < num4 Then
	menor = num3
	audio.speak("O MENOR NÚMERO É O NÚMERO "& menor &"")
	
elseif num4 < num1 and num4 < num2 and num4 < num3 Then
	menor = num4
	audio.speak("O MENOR NÚMERO É O NÚMERO "& menor &"")
end if





	case 2:
if num1 > num2 and num1 > num3 and num1 > num4 Then
	maior = num1
	msgbox("O MAIOR NÚMERO É O NÚMERO "& maior &"")
	
elseif num2 > num1 and num2 > num3 and num2 > num4 Then
	maior = num2
	msgbox("O MAIOR NÚMERO É O NÚMERO "& maior &"")
	
elseif num3 > num1 and num3 > num2 and num3 > num4 Then
	maior = num3
	msgbox("O MAIOR NÚMERO É O NÚMERO "& maior &"")
	
elseif num4 > num1 and num4 > num2 and num4 > num3 Then
	maior = num4
	msgbox("O MAIOR NÚMERO É O NÚMERO "& maior &"")
end if

if num1 < num2 and num1 < num3 and num1 < num4 Then
	menor = num1
	msgbox("O MENOR NÚMERO É O NÚMERO "& menor &"")
	
elseif num2 < num1 and num2 < num3 and num2 < num4 Then
	menor = num2
	msgbox("O MENOR NÚMERO É O NÚMERO "& menor &"")
	
elseif num3 < num1 and num3 < num2 and num3 < num4 Then
	menor = num3
	msgbox("O MENOR NÚMERO É O NÚMERO "& menor &"")
	
elseif num4 < num1 and num4 < num2 and num4 < num3 Then
	menor = num4
	msgbox("O MENOR NÚMERO É O NÚMERO "& menor &"")
end if
end select
resp = msgbox("Novo cálculo?", vbquestion + vbyesno,"CÁLCULO DE MAIOR E MENOR")
if resp = vbyes then 
	call atividade
else
	wscript.quit
end if
end sub