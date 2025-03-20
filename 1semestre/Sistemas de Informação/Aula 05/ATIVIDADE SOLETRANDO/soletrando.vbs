Dim p1(5), p2(5), p3(5), resp1(5), resp2(5), resp3(5), audio, i, message, ja_ouviu, pulo_p

call carregar_voz

sub carregar_voz()
    Set audio = CreateObject("SAPI.SPVOICE")
    audio.Volume = 100
    audio.Rate = 1
end sub

call nivel_basico

'Fun��o para saber se o jogador j� ouviu uma palavra novamente
sub ouvir_novamente(p)
    audio.Speak p 'Audio para o caso da fun��o j� ter sido utilizada
    if not ja_ouviu then 'Se ja_ouviu for FALSE ent�o 
        message = MsgBox("Deseja ouvir a palavra novamente?", vbQuestion + vbYesNo, "SOLETRA��O")
        If message = vbYes Then
            audio.Speak p 'Audio para o caso da fun��o n�o ter sido utilizada
            ja_ouviu = True 'Define que ja_ouviu se torne TRUE e impede a fun��o de ser realizada mais de uma vez
        End If
    End If
End sub

'Fun��o para saber se o jogador j� pulou uma palavra
sub pular_palavra()
    If Not pulo_p Then 'Se pulo_p for FALSE ent�o 
        message = MsgBox("Deseja pular esta palavra? Voc� s� pode fazer isto uma vez.", vbQuestion + vbYesNo, "SOLETRA��O")
        If message = vbYes Then
            pulo_p = True 'Define pulo_p como TRUE e impede a fun��o de ser realizada mais de uma vez
            MsgBox "Voc� acabou de usar o seu �nico pulo!"
        End If
    Else
        MsgBox "Voc� j� usou o seu pulo!"
    End If
End sub

sub nivel_basico()
    p1(1) = "quadrado"
    p1(2) = "abelha"
    p1(3) = "xarope"
    p1(4) = "cenoura"
    p1(5) = "f�sforo"
    
    For i = 1 to 5
	
        ouvir_novamente("A palavra n�mero " & i & " � " & p1(i))
        If Not pulo_p Then 'Se pulo_p for FALSE, vai para a fun��o pular_palavra
			pular_palavra
			If pulo_p Then 'Ap�s o fim da fun��o pular_palavra transformar o pulo_p em TRUE:
				resp1(i) = p1(i) 'Define a resposta correta e passa para a pr�xima palavra		
			End if
		Else 'Se pulo_p for TRUE, continua o jogo normalmente
            resp1(i) = LCase(inputbox("Solete a palavra: ", "N�VEL B�SICO"))
        End If
 
        if resp1(i) <> p1(i) then 
            MsgBox "Voc� errou a palavra e perdeu!", vbOKOnly, "SOLETRA��O"
            message = MsgBox("Deseja tentar novamente?", vbQuestion + vbYesNo, "SOLETRA��O")
            if message = vbyes then 
                call nivel_basico
            else 
                wscript.quit
            end if
        end if 
    Next
    
    MsgBox "Parab�ns, voc� passou para a pr�xima fase!"
    call nivel_intermediario
end sub

sub nivel_intermediario()
	p2(1) = "cabeleireiro"
	p2(2) = "caranguejo"
	p2(3) = "c�rebro"
	p2(4) = "periquito"
	p2(5) = "meteorologia"
	
	For i = 1 to 5 
		
		ouvir_novamente("A palavra n�mero " & i & " � " & p2(i))
        
        If Not pulo_p Then
            pular_palavra
        
			If pulo_p Then
				resp2(i) = p2(i)
			End if
		
		Else
            resp2(i) = LCase(inputbox("Solete a palavra: ", "N�VEL B�SICO"))
        End If
 
        if resp2(i) <> p2(i) then 
            MsgBox "Voc� errou a palavra e perdeu!", vbOKOnly, "SOLETRA��O"
            message = MsgBox("Deseja tentar novamente?", vbQuestion + vbYesNo, "SOLETRA��O")
            if message = vbyes then 
                call nivel_basico
            else 
                wscript.quit
            end if
        end if 
    Next
	
	MsgBox "Parab�ns, voc� passou para a pr�xima fase!"
	call nivel_avancado

End sub

sub nivel_avancado()
	p3(1) = "assoreamento"
	p3(2) = "fosforesc�ncia"
	p3(3) = "r�veillon"
	p3(4) = "ascensorista"
	p3(5) = "imunodefici�ncia"
	
	For i = 1 to 5 
	
		ouvir_novamente("A palavra n�mero " & i & " � " & p3(i))
        
        If Not pulo_p Then
            pular_palavra
        
			If pulo_p Then
				resp3(i) = p3(i)
			End if
		
		Else
            resp3(i) = LCase(inputbox("Solete a palavra: ", "N�VEL B�SICO"))
        End If
 
        if resp3(i) <> p3(i) then 
            MsgBox "Voc� errou a palavra e perdeu!", vbOKOnly, "SOLETRA��O"
            message = MsgBox("Deseja tentar novamente?", vbQuestion + vbYesNo, "SOLETRA��O")
            if message = vbyes then 
                call nivel_basico
            else 
                wscript.quit
            end if
        end if 
    Next
	
	MsgBox "Parab�ns, voc� venceu o jogo!"
	
End sub
