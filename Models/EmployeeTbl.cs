using System;
using System.Collections.Generic;

namespace RepositoryPatternInMVC.Models;

public partial class EmployeeTbl
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? Gender { get; set; }

    public int? Salary { get; set; }

    public string? Dept { get; set; }
}
