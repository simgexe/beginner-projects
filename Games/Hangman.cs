namespace Games {
   public class Hangman{
    public void Start() {
        string word = "hello";
        int maxLives =7;
        int currentLives = maxLives;

        bool win =false;

        List <char> correctGuesses = new List<char>();

        while (currentLives >0 && !win)
            {
                 foreach(char c in word)
                {
                    if(correctGuesses.Contains(c)){
                        Console.Write(c);
                     }
                    else{
                         Console.Write("_");
                     }
                }
    Console.WriteLine("\n Please guess a letter:");
    Console.WriteLine("You have "+ currentLives+ "/" + maxLives + " lives left.");

    char guess =Convert.ToChar(Console.ReadLine().ToLower());

    if(word.Contains(guess)){
        Console.WriteLine("Correct guess!");
        correctGuesses.Add(guess);
    }
    else{
        Console.WriteLine("Incorrect guess!");
        currentLives--;
    }
    correctGuesses.Add(guess);

    bool wordComplete = true;
    foreach (char c in word)
    {
        if(!correctGuesses.Contains(c)){
            wordComplete = false;
            break;
        }
    }
    win = wordComplete;

}
if (win){
    Console.WriteLine("Congratulations! You guessed the word!");
}
else{
    Console.WriteLine("You ran out of lives! The word was: "+ word);
}
}}}