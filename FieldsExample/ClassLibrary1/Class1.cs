using System.CodeDom;

public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityStock; 
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;



    //constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    //set method for productID
    public void SetProductId(int value)
    {
        productID = value;
    }

    //get method for productID
    public int GetProductID()
    {
        return productID;
    }
    //set method for productName
    public void SetProductName(string value)
    {
        productName = value;
    }

    //get method for productID
    public string GetProductName()
    {
        return productName;
    }

     //setmethod for cost
    public void SetCost(double value)
    {
        cost = value;
    }

    //get method for cost
    public double GetCost()
    {
        return cost;
    }
   
    //setmethod for tax
    public void SetTax(double value)
    {
        tax = value;
    }

    //get method for tax
    public double GetTax()
    {
        return tax;
    }
    //setmethod for quantityStock
    public void SetQuantityStock(int value)
    {
        quantityStock = value;
    }

    //get method for quantityStock
    public int GetQuantityStock()
    {
        return quantityStock;
    }

    //get method for dateOfPurchase
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }
   














    public void CalculateTax() 
    {
         double t;
        if (cost<=20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100;
        }
        tax = t;
    }
}


//create child class for product class
public class domesticProduct:Product
{

}

public class OtherClass2
{

}


/*
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
*/
