using System.Formats.Asn1;

namespace Account_Class;

class Program
{
    static void Main(string[] args)
    {
        //did this for a commit
        Account acc1 = new Account("Susan", 100);
        Account acc2 = new Account("Bonnie", 100);
        acc1.Show();
        acc1.Withdraw(acc1.GetBalance(), 150);
        acc1.Show();
        acc1.Deposit(acc1.GetBalance(), 200);
        acc1.Show();
        acc1.Withdraw(acc1.GetBalance(), 150);
        acc1.Show();
        acc2.Show();
        acc1.Transfer(acc2, acc1.GetBalance(), 50);
        acc1.Show();
        acc2.Show();

        //testing that balance getter is working(100)
        Console.WriteLine(acc1.Balance);

        //testing that the balance setter is working(500)
        acc1.Balance = 500;
        Console.WriteLine(acc1.Balance);

        //testing that it doesn't work for negative values(500)
        acc1.Balance = -100;
        Console.WriteLine(acc1.Balance);

        //testing that owner getter is working(susan)
        Console.WriteLine(acc1.owner);

        //testing that owner setter doesn't work which it doesn't because it creates a syntax error
        //acc1.owner = "Alice";*/


        Account a1 = new Account("bob", 100);
        Account a2 = new Account("fred", 200);


        a1 = a2;
        a1.Show();
        a2.Show();
        a1.Withdraw(a1.Balance, 10);
        a2.Withdraw(a2.Balance, 20);
        a1.Show();
        a2.Show();
        int x = 5, y = 10;
        x = y;
        x++;
        Console.WriteLine(x);
        Console.WriteLine(y);

        // in main
        int totalAssets = 1000;
        doIt(a1, totalAssets);
        Console.WriteLine("after doIt:");
        a1.Show();
        Console.WriteLine($"total assets is now {totalAssets}"); }


        // another method in the file with main (part of the Main class)
        public static void doIt(Account a, int total)
        {
            a.Withdraw(a.Balance, 50);
            total--; 
        }








}



