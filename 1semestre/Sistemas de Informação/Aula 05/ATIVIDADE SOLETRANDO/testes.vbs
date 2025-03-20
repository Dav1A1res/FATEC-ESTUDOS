Dim p1(5), p2(5), p3(5), resp1(5), resp2(5), resp3(5), audio, i, message, ja_ouviu, pulo_p

call carregar_voz

sub carregar_voz()
    Set audio = CreateObject("SAPI.SPVOICE")
    audio.Volume = 100
    audio.Rate = 1
end sub

call nivel_basico

sub ouvir_novamente(p)
    audio.Speak p
    if not ja_ouviu then 
        message = MsgBox("Deseja ouvir a palavra novamente?", vbQuestion + vbYesNo, "SOLETRA��O")
        If message = vbYes Then
            audio.Speak p
            ja_ouviu = True
        End If
    End If
End sub

sub pular_palavra()
    If Not pulo_p Then
        message = MsgBox("Deseja pular esta palavra? Voc� s� pode fazer isto uma vez.", vbQuestion + vbYesNo, "SOLETRA��O")
        If message = vbYes Then
            pulo_p = True
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
        
        If Not pulo_p Then
            pular_palavra
            If pulo_p Then
                resp1(i) = p1(i)
            Else
                resp1(i) = LCase(inputbox("Solete a palavra: ", "N�VEL B�SICO"))
            End If
        Else
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
end sub

