class Formula
{
    static void Main()
    {
        /*
            int inputSeconds = 288970;
        
          
            int min = 60;
            int hour = 60*min;
            int day = 24*hour;

          

            int outputDay = inputSeconds/day;
            int outputHour = (inputSeconds-outputDay*day)/hour;
            int outputMin = (inputSeconds-outputDay*day-outputHour*hour)/min;
            int outputSek  =inputSeconds-outputDay*day-outputHour*hour-outputMin*min;
         

            System.Console.Write(outputDay + " days, " + outputHour + " hours, "+outputMin + " minutes,"   + outputSek +" seconds");

        */
        // Height categories Assignment:

        

        //input value

        double heightInInches = 75;

        //convertation

        double inchToSantimeter = 2.54;
        double heighInsantimeter = heightInInches * inchToSantimeter;



        if (heighInsantimeter < 150)
        {
            System.Console.WriteLine("Dwarf");
        }
        else if (heighInsantimeter > 150 && heighInsantimeter < 165)
        {
            System.Console.WriteLine("Average height");
        }
        else if (heighInsantimeter > 165 && heighInsantimeter < 195)
        {
            System.Console.WriteLine("Tall");
        }
        else
        {
            System.Console.WriteLine("Abnormal height");
        };



        System.Console.ReadKey();

    }
}