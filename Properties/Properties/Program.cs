// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Employee
{
    //instane fields
    private int _empID;
    private string _empName;
    private string _job;


    //instance property
    public int EmpID
    {
        set 
        { 
            if(value <= 100 )
            {
                _empID = value;
            }
        }
        get { return _empID; }
    }

    public string EmpName
    {
        set 
        {
            if(value.Length <= 20 )
            {
                _empName = value;
            }
        }
        get { return _empName; }
    }

    public string Job
    {
        set { _job = value; }
        get { return _job; }
    }

    //static fields
    private static string _companyName;

    //static property
    public static string CompanyName
    {
        set 
        {
            if(value.Length <= 200)
            {
                _companyName = value;
            }
           
        }
        get { return _companyName; }
    }

    

    
}