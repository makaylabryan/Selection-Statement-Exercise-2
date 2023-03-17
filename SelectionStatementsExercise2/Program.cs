namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower()) 
            {
                case "math":
                    Console.WriteLine("Mine Two!");
                    break;
                case "science":
                    Console.WriteLine("That's just the Reaction I was hoping for");
                    break;
                case "history":
                    Console.WriteLine("Four Score and Seven years ago...");
                    break;
                case "english":
                    Console.WriteLine("To be or not to be?");
                    break;
                case "languages":
                    Console.WriteLine("Hola!");
                    break;
                case "lunch":
                    Console.WriteLine("How original...");
                    break;
                case "PE":
                    Console.WriteLine("I too like to meander around a racing track");
                    break;
                default: Console.WriteLine("Hmm, interesting. I'll have to look into that.");
                        break;


            }
        }
    }
}