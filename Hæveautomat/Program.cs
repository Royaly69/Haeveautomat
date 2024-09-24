using System.ComponentModel.Design;

double bal;
string ans;
double ansD;



Bal();
Menu();
return;


void Bal()
{
    Console.WriteLine("Input Balance:");
    try
    {
        bal = Convert.ToDouble(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Input Error! \n");
        Bal();
    }
}


void Menu()
{
    Console.WriteLine("Select Operation\n1. Withdraw\n2. Deposit\n3. Exit");
    ans = Console.ReadLine();
    if (ans == "1")
    {
        Withdraw();
    }
    else if(ans == "2")
    {
        Deposit();
    }
    else if (ans == "3")
    {
         Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Select Operation Example Input: ''1'' to Withdraw.");
        Menu();
    }
}
void Withdraw()
{
    Console.WriteLine("you balance is: " + bal + "\nInput withdrawl amount.");
    try
    {
        ansD = Convert.ToDouble(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Input Error! \n");
        Withdraw();
    }
    if (ansD > bal)
    {
        Console.WriteLine("Withdrawl amount cannot exceed Balance.");
        for (int i = 0; i!=10; ++i)
        {
            Console.WriteLine("Du har ikke nok penge!\n");
        }
        Withdraw();
    }
    else if (ansD < 0)
    {
        Console.WriteLine("Withdrawl amount cannot be negative.");
        Withdraw();
    }
    else
    {
        bal = bal - ansD;
        Console.WriteLine("You withdrew " + ansD +". Your new balance is " + bal + ".");
        Menu();
    }

}

void Deposit()
{
    Console.WriteLine("you balance is: " + bal + "\nInput Deposit amount.");
    try
    {
        ansD = Convert.ToDouble(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Input Error! \n");
        Withdraw();
    }
    if (ansD < 0)
    {
        Console.WriteLine("Deposit amount cannot be negative.");
        Withdraw();
    }
    else
    {
        bal = bal + ansD;
        Console.WriteLine("You deposited " + ansD + ". Your new balance is " + bal + ".");
        Menu();
    }
}

