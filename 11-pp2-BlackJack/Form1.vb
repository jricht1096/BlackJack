Public Class frmBlackJack
    Dim deck As DeckOfCards 'shuffled deck (array)
    Dim shuffledDeck As Stack(Of Card.Cards) 'shuffled stack of cards
    Dim playerHand(4) As Card.Cards 'player hand 
    Dim dealerHand(4) As Card.Cards 'dealer hand 
    Dim playerSum As Integer = 0
    Dim dealerSum As Integer = 0
    Dim numOfPlayerCards As Integer = 0
    Dim numOfDealerCards As Integer = 0


    ' Creates new deck and shuffled deck 

    Private Sub btnNewHand_Click(sender As Object, e As EventArgs) Handles btnNewHand.Click
        deck = New DeckOfCards()
        shuffledDeck = deck.getShuffledDeck()

        For i As Integer = 0 To 4
            playerHand(i) = New Card.Cards
            dealerHand(i) = New Card.Cards
        Next

        btnHit.Enabled = False
        btnHold.Enabled = False
        btnNewHand.Enabled = True
        lstPlayerHand.Items.Clear()
        lstDealerHand.Items.Clear()
        txtMsg.Clear()
        numOfPlayerCards = 0
        numOfDealerCards = 0
        playerSum = 0
        dealerSum = 0

        Timer.Enabled = True
        txtMsg.Text = "Shuffling"

    End Sub

    ' Creates a small animated effect when shuffling the cards
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If txtMsg.Text <> "Shuffling..." Then
            txtMsg.Text += "."
        Else
            txtMsg.Text += "DONE"
            Timer.Enabled = False
            btnHit.Enabled = True
            btnHold.Enabled = True
            btnNewHand.Enabled = False
            dealCards()
        End If
    End Sub



    ' Deals the inital cards 2 for player and 1 for Dealer
    Private Sub dealCards()
        playerHand(0) = shuffledDeck.Peek
        shuffledDeck.Pop()
        playerHand(1) = shuffledDeck.Peek
        shuffledDeck.Pop()

        dealerHand(0) = shuffledDeck.Peek
        shuffledDeck.Pop()

        lstPlayerHand.Items.Add(playerHand(0).cardValueString & " of " & playerHand(0).cardSuit.ToString)
        lstPlayerHand.Items.Add(playerHand(1).cardValueString & " of " & playerHand(1).cardSuit.ToString)
        lstDealerHand.Items.Add(dealerHand(0).cardValueString & " of " & dealerHand(0).cardSuit.ToString)

        numOfPlayerCards = 2
        numOfDealerCards = 1

        displayScores()
    End Sub

    ''' <summary>
    ''' calculate and display the total value of all cards on player's and dealer's hand
    ''' </summary>
    Private Sub displayScores()

        calculateSums()
        checkAceValue()

        txtPlayerTotal.Text = playerSum.ToString
        txtDealerTotal.Text = dealerSum.ToString
    End Sub


    ' Calculates the sum of all card values for player and dealer

    Private Sub calculateSums()
        playerSum = 0
        dealerSum = 0

        For Each item As Card.Cards In playerHand
            playerSum += item.cardValue
        Next

        For Each item As Card.Cards In dealerHand
            dealerSum += item.cardValue
        Next
    End Sub

    ' Checks if any of the cards is an Ace
    ' Then, assignes the ace the value 1 or 11 depending on what is currently the best option

    Private Sub checkAceValue()
        For i As Integer = 0 To 4
            If playerHand(i).cardValueString = "Ace" Then
                If playerSum > 21 Then
                    playerHand(i).cardValue = 1
                    calculateSums()
                End If
            End If

            If dealerHand(i).cardValueString = "Ace" Then
                If dealerSum > 21 Then
                    dealerHand(i).cardValue = 1
                    calculateSums()
                End If
            End If
        Next
    End Sub

    ' When player clicks Hit Me button, the top card from the stack is added to Player's hand
    Private Sub btnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        numOfPlayerCards += 1
        If numOfPlayerCards <= 5 Then
            playerHand(numOfPlayerCards - 1) = shuffledDeck.Peek
            shuffledDeck.Pop()

            lstPlayerHand.Items.Add(playerHand(numOfPlayerCards - 1).cardValueString & " of " & playerHand(numOfPlayerCards - 1).cardSuit.ToString)
            displayScores()

            If numOfPlayerCards = 5 Then
                btnHold_Click(Nothing, Nothing)
            End If

        End If

        If playerSum > 21 Then
            btnHold_Click(Nothing, Nothing)
        End If
    End Sub

    ' Once player clicks Hold button, the dealer's hand is assembled
    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        btnHit.Enabled = False
        btnHold.Enabled = False
        Dim scoreToReach As Integer

        If playerSum > 21 Then
            scoreToReach = 11
        Else
            scoreToReach = playerSum
        End If

        While dealerSum < scoreToReach And numOfDealerCards < 5
            numOfDealerCards += 1
            dealerHand(numOfDealerCards - 1) = shuffledDeck.Peek
            shuffledDeck.Pop()

            lstDealerHand.Items.Add(dealerHand(numOfDealerCards - 1).cardValueString & " of " & dealerHand(numOfDealerCards - 1).cardSuit.ToString)
            displayScores()

            If dealerSum > 21 Then
                txtMsg.Text = " Dealer's Hand is over 21, PLAYER WINS"
                btnNewHand.Enabled = True
                btnHold.Enabled = False
                Exit Sub
            End If
        End While

        btnHold.Enabled = False
        gameOver()
    End Sub


    ' Determining the winner and displaying end-of-game messages
   
    Private Sub gameOver()
        If playerSum > 21 Then
            txtMsg.Text = "Player's hand os over 21, DEALER WINS!"
            btnNewHand.Enabled = True
            Exit Sub
        End If

        If playerSum = dealerSum Then
            If numOfDealerCards <= numOfPlayerCards Then
                txtMsg.Text = " Player has " & playerSum & " and " & numOfPlayerCards & " cards. Dealer has " & dealerSum & " and " & numOfDealerCards &
                    " cards. DEALER WINS!"
            Else
                txtMsg.Text = "Player has " & playerSum & " and " & numOfPlayerCards & " cards. Dealer has " & dealerSum & " and " & numOfDealerCards &
                   " cards. PLAYER WINS!"
            End If
            btnNewHand.Enabled = True
            Exit Sub
        End If

        If playerSum > dealerSum Then
            txtMsg.Text = "Player has " & playerSum & " and dealer has " & dealerSum & ". PLAYER WINS!"
        Else
            txtMsg.Text = "Player has " & playerSum & " and dealer has " & dealerSum & ". DEALER WINS!"
        End If
        btnNewHand.Enabled = True
    End Sub

End Class
