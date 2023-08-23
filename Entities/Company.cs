class Company : Taxpayer
{
  public int NumberOfEmployees { get; set; }

  public Company(string name, double anualIncome, int numberOfEmployees)
    : base(name, anualIncome)
  {
    NumberOfEmployees = numberOfEmployees;
  }

  public override double TotalTaxes()
  {
    if (NumberOfEmployees > 10)
      return AnualIncome * 0.14;
    else
      return AnualIncome * 0.16;
  }
}