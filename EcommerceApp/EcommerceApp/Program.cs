using System;

namespace EcommerceApp
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Starting Process");

            Customer piyush = new Customer("Piyush", "9367318064");

            Seller dailyNeedsGrocery = new Seller("Daily Needs", "123456789");

            Seller fashionPoint = new Seller("FashionPoint", "123456");

            Seller digitalElectronics = new Seller("DigiElectro", "1234");

            Category electronics = new Category("electronics");

            Category cosmetics = new Category("cosmetics");

            Category grocery = new Category("grocery");

            Category clothing = new Category("clothing");

            MyFlipKart myFlipKart = new MyFlipKart();

  
            myFlipKart.productsCatalog.addCategory(clothing);
            myFlipKart.productsCatalog.addCategory(grocery);
            myFlipKart.productsCatalog.addCategory(cosmetics);
            myFlipKart.productsCatalog.addCategory(electronics);

            digitalElectronics.RegisterNewProduct(myFlipKart.productsCatalog,
                new Product("Mobile","Latest tech",10000.00,"electronics",));
            digitalElectronics.registerProduct(myFlipKart.productsCatalog,
        new Product(Mobile, Latest Technology, 10000.00, electronics, 5));

            Seller Digi Electronics adding Camera to myFlipKart catalog
        digiElectronics.registerProduct(myFlipKart.productsCatalog,
        new Product(Camera, Advanced Technology, 50000.00, electronics, 10));

            Seller FashionPoint adding Wearbles to myFlipKart catalog
        fashionPoint.registerProduct(myFlipKart.productsCatalog,
        new Product(Mens Jackets, XL - Size, 1000.00, clothing, 10));

            fashionPoint.registerProduct(myFlipKart.productsCatalog,
            new Product(Jackets, XL - Size, 1000.00, clothing, 10));

            Seller FashionPoint adding Cosmetics to myFlipKart catalog
        fashionPoint.registerProduct(myFlipKart.productsCatalog,
        new Product(Nail Paint, Red Color, 500.00, cosmetics, 25));

            Seller dailyNeedsGrocery adding grocery to myFlipKart catalog
        dailyNeedsGrocery.registerProduct(myFlipKart.productsCatalog,
        new Product(Sugar, Fine quality, 40.00, grocery, 1000));

            Seller dailyNeedsGrocery adding grocery to myFlipKart catalog
        dailyNeedsGrocery.registerProduct(myFlipKart.productsCatalog,
        new Product(Milk, 100 % Pure, 50.00, grocery, 250));

            dailyNeedsGrocery.registerProduct(myFlipKart.productsCatalog,
            new Product(Toned Milk, Hygenic and Pure, 45.00, grocery, 250));

            dailyNeedsGrocery.registerProduct(myFlipKart.productsCatalog,
            new Product(Milk Cream, Natural, 145.00, grocery, 100));


            Customer searching for product-- milk
   
           ArrayListProduct milkResults = myFlipKart.productsCatalog.searchProduct(Milk);
           System.out.println(milkResults);

            Customer searching for all the products in grocery
   
           ArrayListProduct groceryProducts = myFlipKart.productsCatalog.searchCategory(Groceries);
            System.out.println(groceryProducts);

            Customer adding 10 packets of milk to cart
           Item milkTenPackets = new Item(milkResults.get(0), 10);
            piyush.addItemToCart(milkTenPackets);

            Printing current cart status
        piyush.printCartItems();

            Customer searching for another product --camera
   
           ArrayListProduct cameraResults = myFlipKart.productsCatalog.searchProduct(CaMeRa);
            System.out.println(cameraResults);

            Customer adding 1 camera to cart
           Item oneCamera = new Item(cameraResults.get(0), 1);
            piyush.addItemToCart(oneCamera);

            Printing current cart status
        piyush.printCartItems();

            Customer updating quantity of milk packets from 10 to 15
        piyush.updateItemCount(milkTenPackets, 15);

            Printing current cart status
        piyush.printCartItems();

            Customer placing the order
        piyush.placeOrder();

            Customer cart is empty after checkout
        piyush.printCartItems();

            Printing the current Order of customer
        System.out.println(piyush.getCurrentOrder());

            Customer order is moved to shipment
           Shipment s = piyush.getCurrentOrder().moveToShipment();

            Printing the shipment details
        System.out.println(s);

        }
    }
}
