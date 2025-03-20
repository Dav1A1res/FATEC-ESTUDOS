Dim escolha, cor, resp


call cores_semaforo


sub cores_semaforo()
escolha = cint(inputbox("[1] VERDE" + vbnewline &_
						"[2] AMARELO" + vbnewline &_
						"[3] VERMELHO" + vbnewline &_
						"[0 ou 10] Encerrar","SELECIONE UMA COR"))
select case escolha
	case 1:
		cor = "Verde - Siga"
	case 2:
		cor = "Amarelo - Atenção"
	case 3:
		cor = "Vermelho - Pare"
	case 0,10:
		resp = msgbox("Deseja encerrar?", vbquestion + vbyesno, "ATENÇÃO")
		if resp = vbyes then 
			wscript.quit
		else
			call cores_semaforo
		end if
	case else
		msgbox("Opção inválida!"), vbexclamation + vbokonly, "ATENÇÃO"
		call cores_semaforo
end select 

msgbox("" & cor & ""), vbinformation + vbokonly, "CORES DO SEMÁFORO"
call cores_semaforo

end sub