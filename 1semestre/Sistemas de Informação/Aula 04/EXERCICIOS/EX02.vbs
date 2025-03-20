Dim lados,area,perimetro,resp,audio

call carregar_voz
call calculo_area_perimetro
						
sub carregar_voz()
set audio = CreateObject("SAPI.SPVOICE")
audio.volume=100
audio.rate=1
end sub

sub calculo_area_perimetro
lados = cdbl(inputbox("Insira a medida dos lados do quadrado: "))
area = round((lados * lados))
perimetro = round((lados * 4))

call opcao_voz
end sub
sub opcao_voz()
escolha = cint(inputbox("[1] RECEBER OS RESULTADOS POR VOZ" + vbnewline &_
						"[2] RECEBER OS RESULTADOS POR MENSAGEM"))
						
select case escolha
	case 1:
audio.speak("A �rea do quadrado � igual a "& area &"" + vbnewline &_
			"O per�metro do quadrado � igual a "& perimetro &"")
	case 2:
msgbox("A �rea do quadrado � igual a "& area &"" + vbnewline &_
	   "O per�metro do quadrado � igual a "& perimetro &"")
	case else
		msgbox("Op��o inv�lida!"), vbexclamation + vbokonly, "ATEN��O"
		call opcao_voz
end select 

resp = msgbox("Novo c�lculo?", vbquestion + vbyesno,"CALCULO DE QUADRADO")
if resp = vbyes then 
	call calculo_area_perimetro
else
	wscript.quit
end if
end sub