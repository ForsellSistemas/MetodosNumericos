Public Class Form2

    'foi criado uma classe para usar como objeto para manipular cada passo solicitado pelo usuario
    Private Class PassoClass

        Public Property X_direita As Double
        Public Property X_esquerda As Double
        Public Property Y_cima As Double
        Public Property Y_baixo As Double
        Public Property NumeroDePassos As Integer

        'meto para sobrescrever o a função que retorna a descrição da classe
        Public Overrides Function ToString() As String

            Return "X Esquerda" & X_esquerda.ToString & "- X Direita" & X_direita.ToString & " - Y Cima " & Y_cima.ToString & " Y Baixo" & Y_baixo.ToString & " - Passos " & NumeroDePassos

        End Function

    End Class

    'lista global com todos os passos
    Private Property ListaPassos As New List(Of PassoClass)

    'evento que dispara quando o usuario clica para incluir um novo passo
    Private Sub IncluirPassos(ByVal sender As Object, e As EventArgs) Handles cmd_incluir.Click
        'inclui o passo
        Dim _objPassoClass As New PassoClass

        _objPassoClass.X_direita = txt_numero_passos.Text
        _objPassoClass.X_esquerda = txt_x_esquerda.Text
        _objPassoClass.Y_cima = txt_y_cima.Text
        _objPassoClass.Y_baixo = txt_y_baixo.Text
        _objPassoClass.NumeroDePassos = txt_numero_passos.Text

        ListaPassos.Add(_objPassoClass)

        'apaga a lista da tela do usuario
        listbox_passos.Items.Clear()

        'recarrega lista com um array da lista global
        listbox_passos.Items.AddRange(ListaPassos.ToArray)

    End Sub

    'evento que dispara o calculo do resultado e retorna para o textbox par ao usuario
    Private Function RetornaPosicao(ByVal sender As Object, e As EventArgs) Handles cmd_calcular_resultado.Click

        txt_resultado.Text = RetornaResultado()

    End Function


    Private Function RetornaResultado() As String

        'cria uma matriz com o tamanho da lista ou seja com a quantidade de passos criados pelo usuario.
        Dim matrixint As Integer()() = New Integer(ListaPassos.Count - 1)() {}

        'cria duas colunas para serem usadas como x e y
        For i = 0 To matrixint.Length - 1

            matrixint(i) = New Integer(1) {}

        Next

        'faz um loop calculando cada passo e retornando x e y daquele passo já tratando 
        'nesse caso se x esquerda tiver o maior peso, sistema retorna o numero de passos negativos e retorna y como zero
        'ex: x_esquerda = 10% , x_direita = 20% , y_cima = 30%, y_baixo = 5%  e quantidade de passos = 1
        'resultado vai ser x = 0 e y = 1 , ou seja matrixint(i)(0) = 0 e matrixint(i)(1) = + 1

        For i = 0 To ListaPassos.Count - 1

            matrixint(i)(0) = RetornaX(ListaPassos(i))
            matrixint(i)(1) = RetornaY(ListaPassos(i))

        Next

        Dim X_final As Integer = 0
        Dim Y_final As Integer = 0

        'apos tratar os pontos o na matriz acima o sistema soma os x e y pra chegar no resultado final

        For i = 0 To matrixint.Length - 1

            X_final = X_final + matrixint(i)(0)
            Y_final = Y_final + matrixint(i)(1)

        Next

        Return "(" & X_final & "," & Y_final & ")"

    End Function

    Private Function RetornaX(ByVal _listapasso As PassoClass) As Integer

        Return RetornaValorXEsquerda(_listapasso) + RetornaValorXDireita(_listapasso)

    End Function


    Private Function RetornaValorXDireita(ByVal _listapasso As PassoClass) As Integer

        With _listapasso

            If .X_direita > .X_esquerda Then

                If .X_direita > .Y_baixo Then

                    If .X_direita > .Y_cima Then


                        Return _listapasso.NumeroDePassos


                    End If

                End If

            End If

        End With

        Return 0

    End Function

    Private Function RetornaValorXEsquerda(ByVal _listapasso As PassoClass) As Integer

        With _listapasso

            If .X_esquerda > .X_direita Then

                If .X_esquerda > .Y_baixo Then

                    If .X_esquerda > .Y_cima Then


                        Return -_listapasso.NumeroDePassos


                    End If

                End If

            End If

        End With

        Return 0

    End Function

    Private Function RetornaY(ByVal _listapasso As PassoClass) As Integer

        Return RetornaValorYcima(_listapasso) + RetornaValorYbaixo(_listapasso)

    End Function


    Private Function RetornaValorYcima(ByVal _listapasso As PassoClass) As Integer

        With _listapasso

            If .Y_cima > .Y_baixo Then

                If .Y_cima > .X_esquerda Then

                    If .Y_cima > .X_direita Then


                        Return _listapasso.NumeroDePassos


                    End If

                End If

            End If

        End With

        Return 0

    End Function

    Private Function RetornaValorYbaixo(ByRef _listapasso As PassoClass) As Integer

        With _listapasso

            If .Y_baixo > .Y_cima Then

                If .Y_baixo > .X_esquerda Then

                    If .Y_baixo > .X_direita Then


                        Return -_listapasso.NumeroDePassos


                    End If

                End If

            End If

        End With

        Return 0

    End Function

End Class