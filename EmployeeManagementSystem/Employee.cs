namespace EmployeeManagementSystem;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    [SalaryValidation(1000, 5000)]
    public double Salary { get; set; }


    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }
}
