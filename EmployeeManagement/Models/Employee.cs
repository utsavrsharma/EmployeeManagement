using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? Name { get; set; }

    public int? Salary { get; set; }

    public int? DeptId { get; set; }

    public virtual Department? Dept { get; set; }
}
