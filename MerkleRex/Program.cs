
using System.Configuration.Assemblies;
using System.Net;
using System.Reflection;

class Program {
    static void Main(string[] args) {
        bool displayMenu = true;
        while (displayMenu)
        {
            PrintMenu();
            int userInput = GetUserInput();
            ProcessUserInput(userInput);
            displayMenu = Exit(userInput);
        }
    }
    static void PrintMenu() {
        Console.WriteLine("1) Option 1");
        Console.WriteLine("2) Option 2");
        Console.WriteLine("3) Option 3");
        Console.WriteLine("4) Option 4");
        Console.WriteLine("5) Option 5");
        Console.WriteLine("6) Option 6");
        Console.WriteLine("7) Exit");
    }
    static void ProcessUserInput(int userInput) {
        switch (userInput)
        {
            case 1: Console.WriteLine("Printing Option 1"); break;
            case 2: Console.WriteLine("Printing Option 2"); break;
            case 3: Console.WriteLine("Printing Option 3"); break;
            case 4: Console.WriteLine("Printing Option 4"); break;
            case 5: Console.WriteLine("Printing Option 5"); break;
            case 6: Console.WriteLine("Printing Option 6"); break;
            default: PrintMenu(); break;
        }
    }
    static int GetUserInput() {
        int userInput = int.Parse(Console.ReadLine());
        return userInput;
    }
    static bool Exit(int userInput) {
        if (userInput == 7){
            Console.Clear();
            Console.WriteLine("Clossing app...");
            return false;
        } 
        else return true;
    }
}

enum OrderBookType{ ask, bid };
class OrderBookEntry {
    public string Timestamp { get; set; }
    public string Product { get; set; }
    public OrderBookType OrderType { get; set; }
    public double Price { get; set; }
    public double Amount { get; set; }
    public OrderBookEntry(string timestamp, string product, OrderBookType orderType, double price, double amount) {
        Timestamp = timestamp;
    }

}

