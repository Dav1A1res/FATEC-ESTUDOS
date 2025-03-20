Dim num, ant, suc, audio, resp

call carregar_voz
call calculo

sub carregar_voz()
set audio=CreateObject("SAPI.SPVOICE")
audio.volume=100
audio.rate=1
end sub

sub calculo()

num = cint(inputbox("Insira um número qualquer: "))
ant = num - 1
suc = num + 1

call opcao_voz
end sub

sub opcao_voz()
escolha = cint(inputbox("[1] RECEBER OS RESULTADOS POR VOZ" + vbnewline &_
						"[2] RECEBER OS RESULTADOS POR MENSAGEM"))
						
select case escolha

	case 1:
audio.speak("O número antecessor do número escolhido é igual a "& ant &"" + vbnewline &_
			"O número sucessor do número escolhido é igual a "& suc &"")
	case 2:
msgbox("O número antecessor do número escolhido é igual a "& ant &"" + vbnewline &_
	   "O número sucessor do número escolhido é igual a "& suc &"")
	case else
		msgbox("Opção inválida!"), vbexclamation + vbokonly, "ATENÇÃO"
		call opcao_voz
end select 

resp = msgbox("Novo cálculo?", vbquestion + vbyesno,"CÁLCULO DE ANTECESSOR E SUCESSOR")

if resp = vbyes then 
	call calculo
else
	wscript.quit

end if
end sub