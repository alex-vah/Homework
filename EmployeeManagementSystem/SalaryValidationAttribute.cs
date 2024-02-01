namespace EmployeeManagementSystem;

[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public class SalaryValidationAttribute:System.Attribute
{
    public double MinimumSalary { get; }
    public double MaximumSalary { get; }

    public SalaryValidationAttribute(double minimum, double maximum)
    {
        MinimumSalary = minimum;
        MaximumSalary = maximum;
    }
}
