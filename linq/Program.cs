// // Given the collections of items shown below, use LINQ to build the requested collection, and then Console.WriteLine() each item in that resulting collection.
using System;
using System.Collections.Generic;
using System.Linq;

// //RESTRICTION/FILTERING OPERATIONS
// // Find the words in the collection that start with the letter 'L'
// List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

// IEnumerable<string> LFruits = from fruit in fruits
//     where fruit.StartsWith("L")
//     select fruit;

//     foreach (string fruit in LFruits)
//     {

//     Console.WriteLine(fruit);
//     }

// // Which of the following names are multiples of 4 or 6
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);

//     Console.WriteLine();
// foreach (int number in fourSixMultiples)
// {
//     Console.WriteLine(number);
// }

// //ORDERING OPERATIONS
// // Order these student names alphabetically, in descending order (Z to A)
// List<string> names = new List<string>()
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre"
// };

// List<string> descend = names.OrderByDescending(n => n).ToList();

// Console.WriteLine();
// foreach (string name in descend)
// {
// Console.WriteLine(name);
// }

// //FOUR
// // Build a collection of these numbers sorted in ascending order
// List<int> numbersList = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// IEnumerable<int> sorted = numbersList.OrderBy(n => n);
//     Console.WriteLine();
// foreach (int number in sorted)
// {
//     Console.WriteLine(number);
// }

// //AGGREGATE OPERATIONS
// // Output how many numbers are in this list
// List<int> bumbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };
// {
//     Console.WriteLine();
//     Console.WriteLine(bumbers.Count);
// }

// // How much money have we made?
// List<double> purchases = new List<double>()
// {
//     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
// };

// double sum = purchases.Sum();
// Console.WriteLine(sum);

// // What is our most expensive product?
// List<double> prices = new List<double>()
// {
//     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
// };

//  double maxValue = prices.Max();
//  Console.WriteLine(maxValue);

//  //PARTITIONING OPERATIONS
//  List<int> wheresSquaredo = new List<int>()
// {
//     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
// };

//     Console.WriteLine();
// List<int> squares = new List<int>();

// foreach (var item in wheresSquaredo)
// {
//     double squareRoot = Math.Sqrt(item);
//     if (squareRoot % 1 == 0)
//     {
//         break;
//     }
//     squares.Add(item);
// }

// foreach (var item in squares)
// {
//     Console.WriteLine(item);
// }
/*
    Store each number in the following List until a perfect square
    is detected.

    Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/

// Build a collection of customers who are millionaires
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        int WFCount = 0;
        int FTBCount = 0;
        int BOACount = 0;
        int CITICount = 0;

        IEnumerable<Customer> millionaires = customers.Where(customer => customer.Balance >= 1000000);
        Console.WriteLine("Millionaires:");
        foreach (Customer customer in millionaires)
        {
            Console.WriteLine(customer.Name);
            if (customer.Bank == "WF")
            {
                WFCount += 1;
            }
            if (customer.Bank == "FTB")
            {
                FTBCount += 1;
            }
            if (customer.Bank == "BOA")
            {
                BOACount += 1;
            }
            if (customer.Bank == "CITI")
            {
                CITICount += 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Millionaires per bank:");
        Console.WriteLine($"WF {WFCount}");
        Console.WriteLine($"FTB {FTBCount}");
        Console.WriteLine($"BOA {BOACount}");
        Console.WriteLine($"CITI {CITICount}");

    }

}

/*
    Given the same customer set, display how many millionaires per bank.
    Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

    Example Output:
    WF 2
    BOA 1
    FTB 1
    CITI 1
*/

//I SKIPPED "CHALLENGE" BECAUSE SHORT ON TIME."