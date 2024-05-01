using System;
using System.Reflection.Metadata.Ecma335;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder (string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public String getNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String getlastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }
public void setNum(String newCardNum)
{
    cardNum = newCardNum;
}
public void setPin(int newPin)
{
    pin = newPin;
}
public void setFirstName(String newFirstName)
{
    firstName = newFirstName;
}
public void setLastName(String newLastName)
{
    lastName = newLastName;
}
public void setBalance(double newBalance)
{
    balance = newBalance; 
}
public static void Main(String[] args)
{
void printOptions()
{
Console.WriteLine("Welcome to the bank.... pick your poision!");
Console.WriteLine("1. Deposit");
Console.WriteLine("2. Withdraw");
Console.WriteLine("3. Show Balance");
Console.WriteLine("4. Exit");
Console.WriteLine("5. Doomsday Button");
}
void deposit(cardHolder currentUser)
{
    Console.WriteLine("How much would you like to deposit?");
    double deposit = Double.Parse(Console.ReadLine());
currentUser.setBalance(currentUser.getBalance() + deposit);
Console.WriteLine("Thank you for your money! Your new balance is " + currentUser.getBalance());
}
void withdraw(cardHolder currentUser)
{
    Console.WriteLine("How much would you like to withdraw: ");
    double withdrawal = Double.Parse(Console.ReadLine());
// Check if the user actually has enough funds
if(cardHolder.getBalance() > withdrawal)
{
    Console.WriteLine("You are too broke to be taking out any money. Insufficient funds: (");
}
else
{
if(cardHolder.getBalance() > withdrawal);
Console.WriteLine("Heres your change, kid");
}

void balance(cardHolder currentUser)
{
    Console.WriteLine("Current Balance: " + currentUser.getBalance());
}

List<cardHolder> cardHolders = new List<cardHolder>();
cardHolders.Add(new cardHolder("4532772818527395", 1234, "Ted", "Bundy", 1505.31));
cardHolders.Add(new cardHolder("4532772818527396", 9999, "John", "Gacey", 3215.13));
cardHolders.Add(new cardHolder("4532772818527397", 1111, "Elvis", "Presley", 1505.59));
cardHolders.Add(new cardHolder("4532772818527398", 1234, "Johnny", "Cash", 8551.84));
cardHolders.Add(new cardHolder("4532772818527399", 1717, "Project", "Pat", 5455555555.27));
cardHolders.Add(new cardHolder("4532772818527390", 1234, "Fox", "Mulder", 150.31));
cardHolders.Add(new cardHolder("4532772818527391", 1234, "Megan", "Thee Stallion", 150.31));
cardHolders.Add(new cardHolder("4532772818527392", 1234, "Gloria", "Korlou", 150.31));
cardHolders.Add(new cardHolder("4532772818527393", 1234, "Dana", "Scully", 1570.31));
cardHolders.Add(new cardHolder("4532772818527394", 1234, "Priscilla", "Presley", 150.31));
// Prompt user

Console.WriteLine("Welcome to the Easy ATM!")
Console.WriteLine("Please insert your debit card: ");
String debitCardNum = "";
cardHolder currentUser;

while(true)
{
    try
    {
        debitCardNum = Console.ReadLine();
        // checking against the database and return the object!
        currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
        if(currentUser != null) { break; }
        else { Console.WriteLine("Card not recognized. Plese try again!");}
    }
    catch {Console.WriteLine("Card not recognized. Plese try again!"); }
}

Console.WriteLine("Please enter your pin: ");
int userPin = 0;
while (true)
{
try
{
userPin = int.Parse(Console.ReadLine());
        // checking against the database and return the object!
        if(currentUser.getPin() == userPin) { break; }
        else { Console.WriteLine("Wrong Pin... Is this really you?");}
        }
    catch {Console.WriteLine("Wrong Pin... Is this really you?"); }
}

Console.WriteLine("Welcome  " + currentUser.getFirstName() + ":)");
int option = 0;
do
{
printOptions();
try
{
    option = int.Parse(Console.ReadLine());
}
catch { }
if(option == 1) { deposit(currentUser); }
else if(option == 2) { withdraw(currentUser); }
else if(option == 3) { balance(currentUser); }
else if(option == 4) { break; }
else { option = 0; }
}
while (option != 5);
Console.WriteLine("You have been Rick Rolled!");
while (option != 4);
Console.WriteLine("Thank you for visiting! Have a nice day :)");
}




}
}