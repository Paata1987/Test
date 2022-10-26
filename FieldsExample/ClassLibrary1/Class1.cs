public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public int quantityStock; 
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;



    //constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
}


//create child class for product class
public class domesticProduct:Product
{

}

public class OtherClass2
{

}

public class Employee
{
    public int EmpID; 
    public string EmpName;
    public double SalaryPerHour;
    public double NoOfWorkingHours;
    public double NetSalary;
    public static OrganizationName;
    public const string TypeOfEmployee =  "Contract Based" ;
    public readonly  string DepartmentName;

    
    public Employee()
    {
        DepartmentName = "Finance Department" ;
    }

}