using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models;

public partial class Login
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Age { get; set; }
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
}
