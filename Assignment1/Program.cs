namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float floatResult = float.Parse(stringForFloat);
            int intResult = Int32.Parse(stringForInt);

            Console.WriteLine("float result: " + floatResult);
            Console.WriteLine("integer result: " + intResult);
            Console.Read();
        }
    }
}