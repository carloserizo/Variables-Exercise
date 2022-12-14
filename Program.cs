namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName; //Declaration syntax

            dogName = "Rex"; //Initialized --- assigning a value

            int dogAge = 5; //Declaring and initializing

            char firstInitial = 'R';

            bool isHungry = true;

            double dogWeight = 54.3;

            decimal dogHeight = 14.7m;

            Console.WriteLine($"Hello. My dog's name is {dogName}, his initial is {firstInitial}, and he is {dogAge} years old.");
            Console.WriteLine($"He weighs {dogWeight} pounds and he is {dogHeight} inches tall.");
            Console.WriteLine($"It is {isHungry. ToString(). ToLower()} he is always hungry.");
        }
    }
}
