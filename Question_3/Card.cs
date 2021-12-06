public class Card
{
    private string face;
    private string suit;

//Constructor
    public Card(string cardFace, string cardSuit)
    {
        face = cardFace;
        suit = cardSuit;
    }

//Every class will have a tostring function
//we Override that here 
    public override string ToString()
    {
        return face + "of" + suit;
    }

}