using Amortization;

Mortgage mortgage =  new Mortgage();

Console.WriteLine("Enter your principal amount:");
int principal = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Loan Term in Years:");
int numPayments = int.Parse(Console.ReadLine()) * 12;

Console.WriteLine("Enter your interest rate:");
double rate = double.Parse(Console.ReadLine()) / 12 / 100;

double payment = mortgage.MonthlyPayment(principal, rate, numPayments);
Console.WriteLine($"Your monthly payment is: {payment}");

Console.ReadLine();
