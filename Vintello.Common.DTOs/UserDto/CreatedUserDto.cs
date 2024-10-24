using System.ComponentModel.DataAnnotations;
using Vintello.Common.EntityModel.PostgreSql;

namespace Vintello.Common.DTOs;

public class CreatedUserDto
{
    [Required(ErrorMessage = "Имя обязательно!")]
    [RegularExpression(@"^[А-ЯЁ][а-яё]*$", ErrorMessage = "Имя должно начинатся с заглавной буквы!")]
    public string FirstName { get; set; } = null!;
    [RegularExpression(@"^[А-ЯЁ][а-яё]*$", ErrorMessage = "Фамилия должна начинатся с заглавной буквы!")]
    public string? LastName { get; set; }
    [EmailAddress(ErrorMessage = "Введеная почта не является почтой:)!")]
    public string Email { get; set; } = null!;
    [RegularExpression(@"^(([0-9])|(\+[0-9]))[0-9]{10}$", ErrorMessage = "Номер телефона не валиден!")]
    public string? Phone { get; set; }
    public string Password { get; set; } = null!;
    public string? Location { get; set; }
    public string? ProfilePic { get; set; }

    public static User CreateUser(CreatedUserDto createdUserDto)
    {
        return new User
        {
            Role = RolesEnum.Client,
            FirstName = createdUserDto.FirstName,
            LastName = createdUserDto.LastName,
            Email = createdUserDto.Email,
            Phone = createdUserDto.Phone,
            Password = createdUserDto.Password,
            Location = createdUserDto.Location,
            ProfilePic = createdUserDto.ProfilePic,
            CreatedAt = DateTime.Now
        };
    }
}