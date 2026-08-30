namespace Exercises;

public record User(int Id, string Name, string Email);

public record Product(string Name, decimal Price);

public record Employee(string Name, string Department, decimal Salary);

public record Department(string Name, List<Employee> Employees);

public record Book(string Title, int Year, decimal Price);

public record Person(string Name, int Age);

public record Student(int Id, string Name);

public record Course(int StudentId, string Name);

public record EmployeeRecord(string Name, int DepartmentId);

public record DepartmentInfo(int Id, string Name);
