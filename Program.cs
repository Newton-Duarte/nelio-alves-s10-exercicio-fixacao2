System.Console.Write("Enter the number of tax payers: ");
int taxPayersCount = int.Parse(Console.ReadLine());
int counter = 1;

List<Taxpayer> taxPayers = new();

while (counter <= taxPayersCount)
{
  System.Console.WriteLine($"Tax payer #{counter} data:");
  System.Console.Write("Individual or company (i/c)? ");
  var type = Console.ReadLine();

  System.Console.Write("Name: ");
  var name = Console.ReadLine();
  
  System.Console.Write("Anual income: ");
  var anualIncome = double.Parse(Console.ReadLine());

  if (type.ToLower() == "i")
  {
    System.Console.Write("Health expenditures: ");
    var healthExpenditures = double.Parse(Console.ReadLine());
    var individual = new Individual(name, anualIncome, healthExpenditures);

    taxPayers.Add(individual);
  }
  else
  {
    System.Console.Write("Number of employees: ");
    var numberOfEmployees = int.Parse(Console.ReadLine());
    var company = new Company(name, anualIncome, numberOfEmployees);

    taxPayers.Add(company);
  }

  counter++;
}

double totalTaxes = 0;
System.Console.WriteLine("TAXES PAID:");
foreach(var taxPayer in taxPayers)
{
  totalTaxes += taxPayer.TotalTaxes();
  System.Console.WriteLine($"{taxPayer.Name}: ${taxPayer.TotalTaxes():F2}");
}

System.Console.WriteLine($"TOTAL TAXES: {totalTaxes:F2}");
