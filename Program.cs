using Amortization;

// Property Tax
var propertyTaxRates = new Dictionary<string, double>
{
    {"alabama", 0.40 },
    {"alaska", 1.04 },
    {"arizona",0.63 },
    {"arkansas",0.64 },
    {"california",0.75 },
    {"colorado", 0.55},
    {"connecticut",1.79 },
    {"delaware",0.61 },
    {"florida",0.91 },
    {"georgia", 0.92},
    {"hawaii",0.32 },
    {"idaho",0.67 },
    {"illinois",2.08 },
    {"indiana",0.84 },
    {"iowa",1.52 },
    {"kansas",1.34 },
    {"kentucky", 0.83},
    {"louisiana",0.56 },
    {"maine",1.24 },
    {"maryland",1.05 },
    {"massachusetts",1.14 },
    {"michigan",1.38 },
    {"minnesota", 1.11},
    {"mississippi", 0.67},
    {"missouri",1.01 },
    {"montana", 0.74},
    {"nebraska",1.63 },
    {"nevada",0.59 },
    {"new nampshire",1.93 },
    {"new jersey",2.23 },
    {"new mexico",0.67 },
    {"new york", 1.40},
    {"north carolina",0.82 },
    {"north dakota", 0.98 },
    {"ohio", 1.59},
    {"oklahoma",0.89 },
    {"oregon",0.93 },
    {"pennsylvania", 1.49},
    {"rhode island", 1.40},
    {"aouth carolina", 0.57},
    {"south dakota",1.17 },
    {"tennessee",0.67 },
    {"texas",1.68 },
    {"utah", 0.57},
    {"vermont",1.83 },
    {"virginia", 0.87},
    {"washington", 0.87},
    {"west virginia", 0.57},
    {"wisconsin",1.61 },
    {"wyoming",0.56 }
};
// Insurance Rates
var insuranceRates = new Dictionary<string, int>
{
    {"alabama", 3027},
    {"alaska", 942 },
    {"arizona",2309 },
    {"arkansas",3103 },
    {"california",1976 },
    {"colorado", 3413},
    {"connecticut", 1668},
    {"delaware", 964},
    {"florida", 5695},
    {"georgia", 1966},
    {"hawaii", 1296},
    {"idaho", 1392},
    {"illinois", 2174},
    {"indiana", 1756},
    {"iowa", 2362},
    {"kansas", 4415},
    {"kentucky", 3501},
    {"louisiana", 6184},
    {"maine", 1223},
    {"maryland", 1685},
    {"massachusetts",1698 },
    {"michigan",2351 },
    {"minnesota", 2860},
    {"mississippi", 3468},
    {"missouri", 2441},
    {"montana", 2797},
    {"nebraska", 6425},
    {"nevada", 1074},
    {"new hampshire",1035 },
    {"new jersey", 1206},
    {"new mexico", 2222},
    {"new york", 1868},
    {"north carolina", 2403},
    {"ohio", 2805},
    {"oklahoma", 4623},
    {"oregon", 1066},
    {"pennsylvania",1247 },
    {"rhode island", 2349},
    {"south carolina", 2562},
    {"south dakota", 3132},
    {"tennessee", 2534},
    {"texas", 4078},
    {"utah", 1290},
    {"vermont", 834},
    {"virginia", 1673},
    {"washington", 1517},
    {"west virginia", 1040},
    {"wisconsin", 1285},
    {"wyoming", 1306}
};



Mortgage mortgage =  new Mortgage();

Console.WriteLine("Please enter your state of residency: ");
string stateID = Console.ReadLine().Trim().ToLower();

Console.WriteLine("Enter the price of the property:");
int principal = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the down payment amount:");
int downPayment = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Loan Term in Years:");
int numPayments = int.Parse(Console.ReadLine()) * 12;

Console.WriteLine("Enter your interest rate:");
double interestRate = double.Parse(Console.ReadLine()) / 12 / 100;

double taxRate = propertyTaxRates[stateID];
double insuranceCost = insuranceRates[stateID];


double payment = mortgage.MonthlyPayment(principal, interestRate, numPayments, downPayment, taxRate, insuranceCost);
Console.WriteLine($"Your monthly payment is: {payment}");

Console.ReadLine();
