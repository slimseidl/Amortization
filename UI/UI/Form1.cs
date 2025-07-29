using Amortization;
namespace UI
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> propertyTaxRates = new Dictionary<string, double>
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

        private Dictionary<string, double> insuranceRates = new Dictionary<string, double>
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string stateID = cmbState.Text.Trim().ToLower();
                int principal = int.Parse(txtPrice.Text);
                int downPayment = int.Parse(txtDownPmt.Text);
                int loanAmount = principal - downPayment;
                int numPayments = int.Parse(txtTerm.Text) * 12;
                double interestRate = double.Parse(txtInterest.Text) / 12 / 100;

                // Get state-specific values
                double taxRate = propertyTaxRates.ContainsKey(stateID) ? propertyTaxRates[stateID] : 0;
                double insuranceCost = insuranceRates.ContainsKey(stateID) ? insuranceRates[stateID] : 0;

                Mortgage mortgage = new Mortgage();

                double fullPayment = mortgage.MonthlyPayment(principal, interestRate, numPayments, downPayment, taxRate, insuranceCost);
                double basePayment = mortgage.MonthlyPayment(loanAmount, interestRate, numPayments);
                double monthlyIns = Math.Round(insuranceCost / 12, 2);
                double monthlyTax = Math.Round((taxRate / 100 / 12) * principal, 2);

                lblResult.Text = $"Payment Breakdown:\n\n" +
                 $"Base Payment: ${basePayment.ToString("N2")}\n" +
                 $"+ Insurance: ${monthlyIns.ToString("N2")}\n" +
                 $"+ Tax: ${monthlyTax.ToString("N2")}\n" +
                 $"= Total: ${fullPayment.ToString("N2")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbState.Items.AddRange(new string[]
            {
                "Alabama", "Alaska", "Arizona", "Arkansas", "California",
                "Colorado", "Connecticut", "Delaware", "Florida", "Georgia",
                "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa",
                "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland",
                "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri",
                "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey",
                "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio",
                "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
                "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
                "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"
            });

            cmbState.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
