

class Sample
{
    static void Main()
    {
        //local constant variable
        //const string developerName = "Paata";
        
        //assignment 
      
        Employee OrganizationName = "Harsha Inc.";
        System.Console.WriteLine("Organizations Namae: " + OrganizationName);

          
        //Employee employee1, employee2,employee3,employee4,employee5,employee6,employee7, employee8,employee9,employee10;

        for (int i = 0; i < 10; i++)
        {
            string empCount ;
            switch (i)
                {
                     default 1: empCount = "Emplyoye n1 "; break;
                      case 2: empCount = "Emplyoye n2 "; break;
                      case 3: empCount = "Emplyoye n3 "; break;
                      case 4: empCount = "Emplyoye n4 "; break;
                      case 5: empCount = "Emplyoye n5 "; break;
                      case 6: empCount = "Emplyoye n6 "; break;
                      case 7: empCount = "Emplyoye n7 "; break;
                      case 8: empCount = "Emplyoye n8 "; break;
                      case 9: empCount = "Emplyoye n9 "; break;
                      case 10: empCount = "Emplyoye n10 "; break;
                }
            Employee employeVar = new Employee();

            System.Console.Write(empCount);

            System.Console.Write("Employee ID: ");
            employeVar.empID = int.Parse(System.Console.ReadLine());
            System.Console.Write("Employee Name: ");
            employeVar.EmpName = System.Console.ReadLine();
            System.Console.Write("Employee solary Per Hour: ");
            employeVar.SalaryPerHour = int.Parse(System.Console.ReadLine());
            System.Console.Write("Employee Amount Working Hours: ");
            employeVar.NoOfWorkingHours = int.Parse(System.Console.ReadLine());

            employeVar.NetSalary = employeVar.SalaryPerHour * employeVar.NoOfWorkingHours ;

            System.Console.WriteLine("Data Details OF: " + employeVar);
            System.Console.WriteLine("Emplyee' ID: " + employeVar.empID );
            System.Console.WriteLine("Emplyee's Name: " + employeVar.empName );
            System.Console.WriteLine("Wolary Per Hhour: "+ employeVar.SalaryPerHour);
            System.Console.WriteLine("Working Hours: " + employeVar.NoOfWorkingHours);
            System.Console.WriteLine("Net Solary: " +  employeVar.NetSalary);
            System.Console.WriteLine("Organizations Name: " + employeVar.OrganizationName);
            System.Console.WriteLine("Departament's Name: " + employeVar.DepartmentName );
            System.Console.WriteLine("Type Of Employee:" + employeVar.TypeOfEmployee);
            

            System.Console.Write("Continue To Next Employee? Yes/no:  ");
            string answer = System.Console.ReadLine();
            if (!(answer == "Yes" ))
            {
                break;
            }
            System.Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
           
             
        
        }
       System.Console.WriteLine("Done ");
       System.Console.ReadKey();
    }
}

   /*

        //create referance variables
        Product product1, product2, product3;

        //create  objects
        product1 = new Product();
        Product.TotalNoProducts++;
        product2 = new Product();
        Product.TotalNoProducts++;
        product3 = new Product();
        Product.TotalNoProducts++;




        //initialize fields
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 200;
        product1.quantityStock = 1200;

        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 4500;
        product2.quantityStock = 3400;

        product3.productID = 1003;
        product3.productName = "speaker";
        product3.cost = 36000;
        product3.quantityStock = 800;

        //get value from fields
        System.Console.WriteLine(developerName);

        System.Console.WriteLine("Product1: ");
        System.Console.WriteLine("Product ID: " + product1.productID);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Cost: " + product1.cost);
        System.Console.WriteLine("Quantity  in Stock: " + product1.quantityStock);
        System.Console.WriteLine("Date of purchasek: " + product1.dateOfPurchase);

        System.Console.WriteLine("\nProduct2: ");
        System.Console.WriteLine("Product ID: " + product2.productID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Cost: " + product2.cost);
        System.Console.WriteLine("Quantity  in Stock: " + product2.quantityStock);
        System.Console.WriteLine("Date of purchasek: " + product2.dateOfPurchase);

        System.Console.WriteLine("\nProduct3: ");
        System.Console.WriteLine("Product ID: " + product3.productID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Cost: " + product3.cost);
        System.Console.WriteLine("Quantity  in Stock: " + product3.quantityStock);
        System.Console.WriteLine("Date of purchasek: " + product3.dateOfPurchase);

        int totalQuantitty = product1.quantityStock + product2.quantityStock + product3.quantityStock;
        System.Console.WriteLine("Total Quantity" + totalQuantitty);

        System.Console.WriteLine("Total no. of products: " + Product.TotalNoProducts);
        System.Console.WriteLine("Category of products " + Product.CategoryName);

        //Assignment

        */
