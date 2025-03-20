dim n, i, nome(5)

call carregar_nomes
call carregar_voz

sub carregar_voz()
set audio = CreateObject("SAPI.SPVOICE")
audio.volume=100
audio.rate=1
end sub

sub carregar_nomes()
nome(1) = "Jurema"
nome(2) = "Rafaela"
nome(3) = "Raquel"
nome(4) = "Eduardo"
nome(5) = "davi"

'Estrutura de repetição FOR 

For i=1 to 5 step 1 'ou  For i=5 to 1 step -1
	msgbox(nome(i))	
next
msgbox("Fim da leitura")

'i = 1
'do while i <= 5
'	msgbox(nome(i))
'	i = i+1
'loop
'msgbox("Fim da leitura")


end sub