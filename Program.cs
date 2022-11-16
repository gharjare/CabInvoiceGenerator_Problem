namespace CabInvoiceGenerator
{
    class program
    {
        enum Month
        {
            January,
            February,
            March,
        }
        public static void Main(string[] args)
        {
            int val = (int)Month.February;
            Console.WriteLine(val);
        }
    }
}
