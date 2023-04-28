﻿using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemo.Data.DTOs;
public class UserLoginDTO
{
    [Required(ErrorMessage = "Username is required")]
    public string? UserName { get; init; }

    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; init; }
}
