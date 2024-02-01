using System.Reflection;
using EmployeeManagementSystem;

Type employeeType = typeof(Employee);

Console.WriteLine($"Type Information for Employee Class: {employeeType}");

// Show properties
PropertyInfo[] properties = employeeType.GetProperties();
foreach (var property in properties)
{
    Console.WriteLine($"Property: {property.Name}, Type: {property.PropertyType}");
}

// Show fields
FieldInfo[] fields = employeeType.GetFields();
foreach (var field in fields)
{
    Console.WriteLine($"Field: {field.Name}, Type: {field.FieldType}");
}

// Show methods
MethodInfo[] methods = employeeType.GetMethods();
foreach (var method in methods)
{
    Console.WriteLine($"Method: {method.Name}");
}

// Check for SalaryValidationAttribute on Salary property
var salaryProperty = employeeType.GetProperty("Salary");
var validationAttribute = salaryProperty.GetCustomAttributes(typeof(SalaryValidationAttribute), true)
    .FirstOrDefault() as SalaryValidationAttribute;

if (validationAttribute != null)
{
    // Validate salary
    double salaryValue = 50000; // Replace with the salary value
    if (salaryValue >= validationAttribute.MinimumSalary && salaryValue <= validationAttribute.MaximumSalary)
    {
        Console.WriteLine("Salary is within the specified range.");
    }
    else
    {
        Console.WriteLine("Salary is outside the specified range.");
    }
}
else
{
    Console.WriteLine("SalaryValidationAttribute not found on Salary property.");
}
