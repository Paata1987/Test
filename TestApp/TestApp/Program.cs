class Formula
{
    static void Main()
    {

            int inputSeconds = 288970;
        
          
            int min = 60;
            int hour = 60*min;
            int day = 24*hour;

          

            int outputDay = inputSeconds/day;
            int outputHour = (inputSeconds-outputDay*day)/hour;
            int outputMin = (inputSeconds-outputDay*day-outputHour*hour)/min;
            int outputSek  =inputSeconds-outputDay*day-outputHour*hour-outputMin*min;
         

            System.Console.Write(outputDay + " days, " + outputHour + " hours, "+outputMin + " minutes,"   + outputSek +" seconds");
            System.Console.ReadKey();

    }
}