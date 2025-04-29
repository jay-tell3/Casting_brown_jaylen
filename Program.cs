namespace Casting_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number whole plz.... or else >:)"); // asking for a number
           int wholeNumber = Convert.ToInt32(Console.ReadLine()); //reads answer and converts answer to int
            Console.WriteLine("is this the number you chose? " + wholeNumber + " True or False" ); //asks if it was the right answer useing the last answer then asking true or false 
           bool isTrue = Convert.ToBoolean(Console.ReadLine()); // coverts the answer to a boolen
            Console.WriteLine("it is " + isTrue); // tells the user the answer
                
           

        }
    }
}
