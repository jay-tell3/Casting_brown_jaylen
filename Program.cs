namespace Casting_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number whole plz.... or else >:)");
           int wholeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("is this the number you chose? " + wholeNumber + " True or False" );
           bool isTrue = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("it is " + isTrue);
                
           

        }
    }
}
