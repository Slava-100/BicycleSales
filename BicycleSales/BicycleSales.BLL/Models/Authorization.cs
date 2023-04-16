﻿using BicycleSales.Constants;

namespace BicycleSales.BLL.Models;

public class Authorization
{
    public int Id { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
    public UserStatus? Status { get; set; }
}