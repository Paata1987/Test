class Formula
{
    static void Main()
    {

        int inputNumber = 3852;  //input
        

        decimal decimaInputNumber = inputNumber;

        

        decimal lastDigits = decimaInputNumber / 1000;
        decimal firstDigits = inputNumber / 1000;
        decimal compareValue = (lastDigits - firstDigits) * 1000;


        int thouseequalntCounter = inputNumber / 1000 * 1000;
        int moreOrEqualFhundred = (compareValue >= 500) ? 1000 : 0 ;
        int lessThanFhundred = (inputNumber < 500) ? 1000 : 0 ;

        int finalRoundedResult = thouseequalntCounter + moreOrEqualFhundred + lessThanFhundred;

        System.Console.WriteLine(finalRoundedResult);
        System.Console.ReadKey();
    
    }
}