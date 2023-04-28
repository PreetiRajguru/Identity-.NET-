using Microsoft.AspNetCore.Identity;
using StudentTeacherDemo.Data.DTOs;

namespace StudentTeacherDemo.Services.Interfaces;

public interface IUserAuthenticationRepository
{
    Task<IdentityResult> RegisterUserAsync(UserRegistrationDTO userForRegistration);
    Task<bool> ValidateUserAsync(UserLoginDTO loginDto); 
    /*Task<string> CreateTokenAsync(); */
}

