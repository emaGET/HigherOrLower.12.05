class HigherOrLower
{
    private bool isRunning = true ;
    private int score = 0 ;
    private int cardInHand = 0 ;
    private int nextCard = 0 ;
    
    private Random rng = new Random();
        
    public void Run()
    {
        while (isRunning)
        {
            
            Console.WriteLine("Hi! Time to bet whether your next card is higher or lower than the next card!");
            cardInHand = rng.Next(1, 14);
            Console.WriteLine("Your card is: " + cardInHand);
            Console.WriteLine("Press Q to quit, or anything else to continue.");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "Q")
            {
                isRunning = false ;
            }
        }
        
        Console.WriteLine("Thank you for gambling!");
        
    }
    
}