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

        // int t;
        // double p,r, i, total_amt;
        // Console.Write("Enter The Capital Amount : ");
        // p = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Enter The Number of Years : ");
        // t = Convert.ToInt16(Console.ReadLine());
        // Console.Write("Enter the Rate Of Interest : ");
        // r = Convert.ToDouble(Console.ReadLine());
        // i = p * t * r / 100;
        // total_amt = p + i;
        // Console.WriteLine("Total Amount : {0}", total_amt);
        // Console.ReadLine();

// Find if user supplied number is multiple of 3 and 5
        // Console.WriteLine("\nInput any number:");  
        // int x = Convert.ToInt32(Console.ReadLine());
        // if (x > 0)
        // {
        //     Console.WriteLine(x % 3 == 0 || x % 5 == 0);
        // }

// Ask user to enter height and weight in metric unit and calculate BMI index for that user.
        int weight;
		int height;
		int bmi;
		
		
		Console.WriteLine("Please Enter your height in inches: "); //Asks user for their height in inches
		height = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter your weight in pounds: "); //Asks user for their weight in pounds
		weight = Convert.ToInt32(Console.ReadLine());

		
		bmi = (weight * 703)/(height * height); //Actual BMI calculation
		
	    if (bmi >= 18 && bmi <= 30 ) //Tests the users input, tells the user what their BMI is 
		{
			
		Console.WriteLine("Your BMI is {0}. Please follow the chart below to see if you are underweight, normal, overweight or obese.",bmi);	//Tells user BMI score and provides the chart to display the information
		Console.WriteLine("\nUnderweight: less than 18.5\nNormal: between 18.5 and 24.9\nOverweight: between 25 and 29.9\nObese: 30 or greater.");
		}	
    }
}