class Sample
{
    static void Main()
    {
        //local constant variable
        const string developerName = "Paata";
        
        //assignment 
        const OrganizationName = "Harsha Inc.";

        //create referance variables
        Product product1, product2, product3;

        //create  objects
        product1 = new Product();
        Product.TotalNoProducts++;
        product2 = new Product();
        Product.TotalNoProducts++;
        product3 = new Product();
        Product.TotalNoProducts++;

        Employee employee1, employee2,employee3,employee4,employee5,employee6,employee7, employee8,employee9,employee10;



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



        System.Console.ReadKey();
    }
}