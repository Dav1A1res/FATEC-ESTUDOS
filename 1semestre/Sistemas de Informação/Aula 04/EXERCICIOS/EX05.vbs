Dim sm, qtd_sm, sbru, sl

sm = 1412.00

call carregar_voz

sub carregar_voz()
set audio = CreateObject("SAPI.SPVOICE")
audio.volume=100
audio.rate=1
end sub

call folha_pagamento

sub folha_pagamento
	qtd_sm = inputbox("Qual o seu sal�rio bruto? (Sua quantidade de sal�rios m�nimos)")
		sbru = sm * qtd_sm
		if sbru >= sm * 2 then
			sl = sbru - sbru * 0.11
		end if

call opcao_voz
end sub
sub opcao_voz()
escolha = cint(inputbox("[1] RECEBER OS RESULTADOS POR VOZ" + vbnewline &_
						"[2] RECEBER OS RESULTADOS POR MENSAGEM"))
						
select case escolha
	case 1:
audio.speak("Seu sal�rio l�quido � "& sl &"")
	case 2:
	MsgBox ("Seu sal�rio l�quido � de: R$"& sl &"")
end select
	
	resp = msgbox("Novo c�lculo?", vbquestion + vbyesno,"Folha de pagamento")
		if resp = vbyes then 
			call folha_pagamento
		else
			wscript.quit
		end if
end sub