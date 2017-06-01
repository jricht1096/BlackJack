' Deck of 52 cards
' inherits from Card
' At the end we get a Stack of 52, shuffled cards
Public Class DeckOfCards
    Inherits Card

    Dim deck(51) As Cards
    Dim shuffledDeck As Stack(Of Cards)

    Public Sub New()
        shuffledDeck = New Stack(Of Cards)
        createDeck()
    End Sub

    Public ReadOnly Property getShuffledDeck() As Stack(Of Cards)
        Get
            Return shuffledDeck
        End Get
    End Property


    Private Sub createDeck()

        For i As Integer = 0 To 12
            For j As Integer = 0 To 3
                Dim index As Integer = i * 4 + j
                deck(index) = New Cards()
                deck(index).cardValue = i + 2
                deck(index).cardValueString = getCardValue(i + 2)

                'Assigns Jack, Queen and King as the value of 10
                'And assigns value of 11 to Ace
                If deck(index).cardValue > 10 And deck(index).cardValue < 14 Then
                    deck(index).cardValue = 10
                ElseIf deck(index).cardValue = 14 Then
                    deck(index).cardValue = 11
                End If

                deck(index).cardSuit = j
            Next
        Next

        shuffleDeck()
    End Sub

    Private Function getCardValue(cardValue As Integer) As String
        Select Case (cardValue)
            Case 11
                Return "Jack"
            Case 12
                Return "Queen"
            Case 13
                Return "King"
            Case 14
                Return "Ace"
            Case Else
                Return cardValue.ToString
        End Select

    End Function

    'Shuffle the deck and call getShuffledStack which creates the stack of cards
   
    Private Sub shuffleDeck()
        Dim rand As New Random()
        Dim cardIndex As Integer

        For i As Integer = 0 To 10000
            For j As Integer = 0 To 51
                cardIndex = rand.Next(0, 52)
                If (j <> cardIndex) Then
                    swapCards(j, cardIndex)
                End If
            Next
        Next

        getShuffledStack()
    End Sub

    Private Sub swapCards(j As Integer, cardIndex As Integer)
        Dim tempCard As Cards

        tempCard = deck(j)
        deck(j) = deck(cardIndex)
        deck(cardIndex) = tempCard
    End Sub

   
    Private Sub getShuffledStack()

        For i As Integer = 0 To 51
            shuffledDeck.Push(deck(51 - i))
        Next
    End Sub

End Class
