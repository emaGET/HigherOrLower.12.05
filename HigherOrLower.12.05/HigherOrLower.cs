class HigherOrLower
{
    private bool isRunning = true ;
    private int score = 0 ;
    private int cardInHand = 0 ;
    private int nextCard = 0 ;
    
    private Random rng = new Random();
        
    public void Run()
    {
        
        Console.WriteLine("Hi! Time to bet whether your next card is higher or lower than the next card!");

        while (isRunning)
        {
            cardInHand = rng.Next(1, 14);
            nextCard = rng.Next(1, 14);
            
            Console.WriteLine("Your card is: " + cardInHand);
            Console.WriteLine("Will the next card be Higher (1) or Lower (2) ?");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose " + choice);
            
            if ( choice == 1 && cardInHand < nextCard )
            {
                Console.WriteLine($"Your card is {cardInHand}, and the next card is {nextCard}. Higher, you won!");
            }
            else if ( choice == 2 && cardInHand > nextCard)
            {
                Console.WriteLine($"Your card is {cardInHand}, and the next card is {nextCard}. Lower, you won!");
            }
            else if ( cardInHand == nextCard)
            {
                Console.WriteLine($"Your card is {cardInHand}, and the next card is {nextCard}. That's a tie!");
            }
            else
            {
                Console.WriteLine($"Your card is {cardInHand}, and the next card is {nextCard}. Whoops, you lose this time!");
            }
            
            Console.WriteLine("Press Q to quit, or anything else to continue.");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "q")
            {
                isRunning = false ;
            }
            
        }
        
        Console.WriteLine("Thank you for gambling!");
        
    }
    
}