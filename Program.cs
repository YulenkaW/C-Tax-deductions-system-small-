namespace TaxAvoidingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfIncomes;
            double grossIncome = 0, 
                totalDeductions = 0, 
                adjustedGrossIncome, 
                totalTaxOwed = 0;
            const int standardDeduction = 13850;

            Console.WriteLine("Enter the number of W2 incomes:");
            numberOfIncomes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfIncomes; i++)
            {
                Console.WriteLine($"Enter income #{i + 1}:");
                grossIncome += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter your deductions (type '0' to finish):");
            double deduction;
            while ((deduction = double.Parse(Console.ReadLine())) != 0)
            {
                totalDeductions += deduction;
            }
            totalDeductions = totalDeductions > standardDeduction ? totalDeductions : standardDeduction;
            adjustedGrossIncome = grossIncome - totalDeductions;



            if (adjustedGrossIncome <= 11000)
            {
                totalTaxOwed += adjustedGrossIncome * 0.10;
            }
            else if (adjustedGrossIncome <= 44725)
            {
                totalTaxOwed += 11000 * 0.10 + (adjustedGrossIncome - 11000) * 0.12;
            }
            else if (adjustedGrossIncome <= 95375)
            {
                totalTaxOwed += 11000 * 0.10 + (adjustedGrossIncome - 11000) * 0.22;
            }
            else if (adjustedGrossIncome <= 182100)
            {
                totalTaxOwed += 11000 * 0.10 + (adjustedGrossIncome - 11000) * 0.24;
            }
            else if (adjustedGrossIncome <= 231250)
            {
                totalTaxOwed += 11000 * 0.10 + (adjustedGrossIncome - 11000) * 0.32;
            }
            else if (adjustedGrossIncome <= 578125)
            {
                totalTaxOwed += 11000 * 0.10 + (adjustedGrossIncome - 11000) * 0.35;
            }
            else if (adjustedGrossIncome > 578126)
            {
                totalTaxOwed += 11000 * 0.10 + (adjustedGrossIncome - 11000) * 0.37;
            }




            Console.WriteLine($"Total Taxes Owed: {totalTaxOwed:C}");
            Console.WriteLine($"Total Taxes as % of Adj Gross In: {totalTaxOwed / adjustedGrossIncome * 100:F2}%");
            Console.WriteLine($"Total Taxes as % of Gross Income: {totalTaxOwed / grossIncome * 100:F2}%");

        }
    }
}