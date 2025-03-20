Dim n1, n2, media, situacao 'declaração de variáveis
Dim resp, audio

call carregar_voz
call entrada_notas

sub carregar_voz()
set audio=CreateObject("SAPI.SPVOICE")
audio.volume=100
audio.rate=1
end sub

sub entrada_notas()

'cdbl = conversão de variáveis alfanuméricas para double(números reais/decimais) "cint" para números inteiros
n1 = cdbl(inputbox("Digite a nota 1: ","Rendimento do aluno"))
n2 = cdbl(inputbox("Digite a nota 2: ","Rendimento do aluno"))

'Processamento
media = round((n1 + n2) / 2, 1)

if media < 4 then
	situacao = "Reprovado"
elseif media >= 4 and media < 6 then
	situacao = "Recuperação"
elseif media > 10 then
	audio.speak("Valores excessivos, por favor insira os valores de nota corretos")
	msgbox("Valores excessivos, por favor insira os valores de nota corretos")
	call entrada_notas
else 
	situacao = "Aprovado"
end if

'Saída de dados por audio
audio.speak("Média do aluno " & media & " " + vbnewline &_
			"Situação final do aluno " & situacao & "")

'Saída de dados por mensagem
resp = msgbox("Média do aluno: " & media & " " + vbnewline &_
			  "Situação Aluno : " & situacao & " " + vbnewline &_
			  "Novo calculo?", vbquestion + vbyesno,"Rendimento do Aluno")
if resp = vbyes then 
	call entrada_notas
else
	wscript.quit
end if
end sub