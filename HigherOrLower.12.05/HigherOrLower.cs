class HigherOrLower
{
    private bool isRunning = true ;
    private int ccore = 0 ;
    private int cardInHand = 0 ;
    private int nextCard = 0 ;
    
    private Random rng = new Random();
    
    public void Run()
    {
        Console.WriteLine("Hi! Time to bet whether your next card is higher or lower than the next card!");
        cardInHand = rng.Next(1, 14);
        Console.WriteLine("Your card is: " + cardInHand);
    }
}