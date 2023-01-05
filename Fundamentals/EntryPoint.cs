class Entrypoint
{
    static void Main(string[] args)
    {
        MethodLearner ml= new MethodLearner();
        int[] num ={48,5,21,1,74,80,99};
        Console.WriteLine($"Mean: {ml.Mean(num)}");
    }
}