namespace EmployeeManagementSystem;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    [SalaryValidation(50000, 1000000)]//Applying SalaryValidationAttribute to the Salary property
    public double Salary { get; set; }


    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }
}
