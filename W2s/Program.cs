internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the federal tax calculator.");
        W2Form[] w2FormsFromtheUser = GetLotsOfForms();
        TaxCalculator thisTaxCalculator = new TaxCalculator(w2FormsFromtheUser);
        decimal totalFederalTaxes = 0;
        totalFederalTaxes = thisTaxCalculator.computeFedTaxes();
        Console.WriteLine($"Your federal taxes due are {totalFederalTaxes}.");

    }

    public static W2Form[] GetLotsOfForms()
    {
        var userForms = new List<W2Form>();
        bool keepAsk = true;
        while (keepAsk)
        {
            Console.WriteLine("Hello, User, would you like to enter a W2 (y/n)?");
            string userInput = Console.ReadLine();
            Console.WriteLine();
            if (userInput.ToLower() == "n")
            {
                keepAsk = false;
            }
            else
            {
                W2Form newForm = null;
                string newTaxableIncomeString;
                decimal newTaxableIncomeDecimal;
                string newCompanyNameString;

                Console.WriteLine("Please, input your total taxable income from this W2: ");
                newTaxableIncomeString = Console.ReadLine();
                newTaxableIncomeDecimal = Decimal.Parse(newTaxableIncomeString);
                Console.WriteLine("Please, input your company name: ");
                newCompanyNameString = Console.ReadLine();

                newForm = new W2Form(newTaxableIncomeDecimal, newCompanyNameString);
                userForms.Add(newForm);
            }
        }
        return userForms.ToArray();

    }
}

public class TaxCalculator
{
    public const decimal fedTaxRate = 0.17M;
    public W2Form[] incomeStatements { get; private set; }

    public TaxCalculator(W2Form[] newIncomeStatements)
    {
        incomeStatements = newIncomeStatements;
    }

    public decimal computeFedTaxes()
    {
        decimal fedTaxesDue = 0;
        decimal totalIncome = 0;
        foreach (var currIncomeStatement in incomeStatements)
        {
            totalIncome += currIncomeStatement.taxableIncome;
        }
        fedTaxesDue = totalIncome * fedTaxRate;
        return fedTaxesDue;
    }
}
public class W2Form
{
    public decimal taxableIncome { get; private set; }
    public string companyName { get; private set; }

    public W2Form(decimal nexTaxableIncome, string newCompanyName)
    {
        taxableIncome = nexTaxableIncome;
        companyName = newCompanyName;
    }

}