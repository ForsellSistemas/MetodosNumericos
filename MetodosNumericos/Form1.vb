Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_inicial.TextChanged

        txt_resultado.Text = RetornaPrimos(txt_valor_inicial.Text, txt_valor_final.Text)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_final.TextChanged

        txt_resultado.Text = RetornaPrimos(txt_valor_inicial.Text, txt_valor_final.Text)

    End Sub

    Private Function RetornaPrimos(ByVal valorInicial As String, ByVal valorFinal As String) As String

        Dim resultado As String = ""

        'se o valor inicial e final não estiverem preenchidos o sistema retorna vazio

        If txt_valor_inicial.Text.Trim = "" OrElse txt_valor_final.Text.Trim = "" Then

            Return resultado

        End If

        'se o valor inicial ou o valor final não são inteiros então dispara uma mensagem para o usúario alertando e retorna vazio

        If Integer.TryParse(txt_valor_inicial.Text.Trim, Nothing) = False OrElse Integer.TryParse(txt_valor_final.Text.Trim, Nothing) = False Then

            MsgBox("valores iniciais e finais devem ser inteiros")
            Return resultado

        End If

        'se o valor final for menor ou igual a um significa que não é primo o sistema por padrão assume o valor final como dois

        If valorFinal <= 1 Then

            valorFinal = 2

        End If

        'se o valor final for menor ou igual a um significa que não é frimo e o sistema assume o valor inicial por padrao com dois

        If valorInicial <= 1 Then

            valorInicial = 2

        End If

        ' caso o valor inicial seja menor que o valor final o sistema começa a calcular do menor para o maior

        If valorInicial <= valorFinal Then

            'o sistema faz um loop do valor inicial até o valor final para realizar o teste com cada um deles

            For i = Integer.Parse(valorInicial) To Integer.Parse(valorFinal)

                'cria uma variavel booleanda inicial considerando que esse valor ja é primo antes do teste
                Dim ehprimo As Boolean = True

                ' faz um loop do numero 2 até o valor final especificado pelo usurario

                For j = 2 To Integer.Parse(valorFinal)

                    ' caso o j analisado que é o denominador do teste for igual ao numero que está sendo analisado
                    ' o sistema passa para proxima iteração desconsiderando o número atual

                    If j = i Then Continue For

                    ' o sistema divide o numero que esta sendo testado pelo "j" da vez e caso esse número seja um inteiro significa 
                    ' que o "i" consegue ser dividido por outro número, atribuindo assim false a variável ehprimo e finalizando o loop

                    If Integer.TryParse(i / j, Nothing) = True Then

                        ehprimo = False
                        Exit For

                    End If

                Next

                'caso o loop "j" dos testes tenha sido finalizado, significa que os testes com "i" foram finalizados
                'a variável que armazena os resulados então acrescenta o número caso ele seja primo.

                If ehprimo Then

                    resultado += i.ToString & " , "

                End If

            Next

        End If

        Return resultado

    End Function

End Class
