using System;
using System.Collections.Generic;

namespace NguyenHuuTuan_2310900112.Models;

public partial class NhtEmployee
{
    public int NhtEmpId { get; set; }

    public string? NhtEmpName { get; set; }

    public string? NhtEmpLevel { get; set; }

    public DateOnly? NhtEmpStartDate { get; set; }

    public bool? NhtEmpStatus { get; set; }
}
