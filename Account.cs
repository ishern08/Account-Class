using Microsoft.VisualBasic;

public class Account
{
    private float balance;
    public float Balance
    {
        get { return balance; }
        set
        {
            if (value > 0)
            {
                balance = value;
            }

        }
    }

    public string owner {get;}


    public Account(string owner, float balance)
    {
        this.owner = owner;
        this.balance = balance;
    }


    public void Show()
    {
        Console.WriteLine($"Owner: {owner}. Balance: ${balance}.");
        Console.WriteLine("Yay!");
        Console.WriteLine(":)");
    }


    public void Deposit(float balance, float amount)
    {
        this.balance = balance;
       this.balance += amount;
    }


    public float GetBalance()
    {
        return balance;
    }


    public bool Withdraw(float balance, float amount)
    {
        this.balance = balance;
        if (balance >= amount)
        {
            this.balance -= amount;
            return true;
        }


        return false;
    }


    public bool Transfer(Account other, float balance, float amount)
    {
        other.balance = other.balance;
        this.balance = balance;
        if (balance >= amount)
        {
            other.balance += amount;
            this.balance -= amount;
            return true;
        }


        return false;
    }




}
