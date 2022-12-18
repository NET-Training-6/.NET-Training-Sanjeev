class EntryPoint
{
    public static void Main()
    {
       /*  var input = Console.ReadLine();
        
        var number = int.Parse(input);

        if(number % 2 == 0)
        {
            Console.WriteLine(number + "is even");
        }
        else
        {
            Console.WriteLine(number + "is odd");
        } */
    
        // CW - Find simple interest for principal amount, time and rate given by user

        int t;
        double p,r, i, total_amt;
        Console.Write("Enter The Capital Amount : ");
        p = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter The Number of Years : ");
        t = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the Rate Of Interest : ");
        r = Convert.ToDouble(Console.ReadLine());
        i = p * t * r / 100;
        total_amt = p + i;
        Console.WriteLine("Total Amount : {0}", total_amt);
        Console.ReadLine();
    }
}