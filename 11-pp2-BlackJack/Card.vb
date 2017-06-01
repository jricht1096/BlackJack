' Standard deck of cards 
Public Class Card
    Enum Suit
        Hearts
        Diamonds
        Clubs
        Spades
    End Enum

    Public Structure Cards
        Dim cardValue As Integer
        Dim cardValueString As String
        Dim cardSuit As Suit
    End Structure


End Class
