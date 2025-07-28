using Amortization;

// Property Tax
var propertyTaxRates = new Dictionary<string, double>
{
    {"Alabama", 0.40 },
    {"Alaska", 1.04 },
    {"Arizona",0.63 },
    {"Arkansas",0.64 },
    {"California",0.75 },
    {"Colorado", 0.55},
    {"Connecticut",1.79 },
    {"Delaware",0.61 },
    {"Florida",0.91 },
    {"Georgia", 0.92},
    {"Hawaii",0.32 },
    {"Idaho",0.67 },
    {"Illinois",2.08 },
    {"Indiana",0.84 },
    {"Iowa",1.52 },
    {"Kansas",1.34 },
    {"Kentucky", 0.83},
    {"Louisiana",0.56 },
    {"Maine",1.24 },
    {"Maryland",1.05 },
    {"Massachusetts",1.14 },
    {"Michigan",1.38 },
    {"Minnesota", 1.11},
    {"Mississippi", 0.67},
    {"Missouri",1.01 },
    {"Montana", 0.74},
    {"Nebraska",1.63 },
    {"Nevada",0.59 },
    {"New Hampshire",1.93 },
    {"New Jersey",2.23 },
    {"New Mexico",0.67 },
    {"New York", 1.40},
    {"North Carolina",0.82 },
    {"North Dakota", 0.98 },
    {"Ohio", 1.59},
    {"Oklahoma",0.89 },
    {"Oregon",0.93 },
    {"Pennsylvania", 1.49},
    {"Rhode Island", 1.40},
    {"South Carolina", 0.57},
    {"South Dakota",1.17 },
    {"Tennessee",0.67 },
    {"Texas",1.68 },
    {"Utah", 0.57},
    {"Vermont",1.83 },
    {"Virginia", 0.87},
    {"Washington", 0.87},
    {"West Virginia", 0.57},
    {"Wisconsin",1.61 },
    {"Wyoming",0.56 }
};
// Insurance Rates
var insuranceRates = new Dictionary<string, int>
{
    {"Alabama", 3027},
    {"Alaska", 942 },
    {"Arizona",2309 },
    {"Arkansas",3103 },
    {"California",1976 },
    {"Colorado", 3413},
    {"Connecticut", 1668},
    {"Delaware", 964},
    {"Florida", 5695},
    {"Georgia", 1966},
    {"Hawaii", 1296},
    {"Idaho", 1392},
    {"Illinois", 2174},
    {"Indiana", 1756},
    {"Iowa", 2362},
    {"Kansas", 4415},
    {"Kentucky", 3501},
    {"Louisiana", 6184},
    {"Maine", 1223},
    {"Maryland", 1685},
    {"Massachusetts",1698 },
    {"Michigan",2351 },
    {"Minnesota", 2860},
    {"Mississippi", 3468},
    {"Missouri", 2441},
    {"Montana", 2797},
    {"Nebraska", 6425},
    {"Nevada", 1074},
    {"New Hampshire",1035 },
    {"New Jersey", 1206},
    {"New Mexico", 2222},
    {"New York", 1868},
    {"North Carolina", 2403},
    {"Ohio", 2805},
    {"Oklahoma", 4623},
    {"Oregon", 1066},
    {"Pennsylvania",1247 },
    {"Rhode Island", 2349},
    {"South Carolina", 2562},
    {"South Dakota", 3132},
    {"Tennessee", 2534},
    {"Texas", 4078},
    {"Utah", 1290},
    {"Vermont", 834},
    {"Virginia", 1673},
    {"Washington", 1517},
    {"West Virginia", 1040},
    {"Wisconsin", 1285},
    {"Wyoming", 1306}
};

Mortgage mortgage =  new Mortgage();

Console.WriteLine("Enter the price of the property:");
int principal = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Loan Term in Years:");
int numPayments = int.Parse(Console.ReadLine()) * 12;

Console.WriteLine("Enter your interest rate:");
double rate = double.Parse(Console.ReadLine()) / 12 / 100;

double payment = mortgage.MonthlyPayment(principal, rate, numPayments);
Console.WriteLine($"Your monthly payment is: {payment}");

Console.ReadLine();
