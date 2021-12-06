using System;

public class Deck
{
    private Card[] deck; 
    private int currentCard; 
    private const int cardNumbers = 52;
    private Random randomNumber; // For shuffle function

    public Deck()
    {
        //To populate the entire deck 
        string[] face = {"Ace", "King", "Queen", "Jack", "Ten", "Nine", "Eight", "Seven", "Six", "Five", "Four", "Three", "Two"};
        string[] suit = {"Spades", "Diamonds", "Hearts", "Clubs"};

        deck = new Card[cardNumbers]; // create a new deck
        currentCard = 0;
        randomNumber = new Random();

        for(int count = 0;count < deck.Length; count++)
        //setting the deck location i.e 0 and return the faces and suites 
        deck[count]=new Card(face[count % 11],suit[count / 13]);
    }

    public void Shuffle()
    {
        currentCard = 0;
        for(int first = 0;first < deck.Length;first++)
        {
            int second = randomNumber.Next(cardNumbers);
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
    }

    public Card ShowCard()
    {
        if(currentCard < deck.Length)
            return deck[currentCard++];
        else
            return null;
    }
}