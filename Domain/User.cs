using System.ComponentModel.DataAnnotations;

namespace Domain;

public class User
{
    // уникален номер, идентифициращ потребителя;
    //  първо име (максимум 20 символа);
    //      фамилия (максимум 20 символа);
    //      възраст (положително число, в диапазона [10;80]);
    //  потребителско име (максимум 20 символа)
    //      парола (максимум 70 символа);
    //      имейл (максимум 20 символа);
    //      приятели (списък с потребители);
    //      игри (виж 2) );
    //      Всички изброени характеристики за обекта потребител да бъдат отбелязани като
    // задължителни (без списъците с приятелите и игрите), т.е. да не може да се създаде запис в БД,
    // изпускайки някое от свойствата/колоните.

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(20)]
    public string LastName { get; set; }

    [Required]
    [Range(10, 80)]
    public int age { get; set; }

    [Required]
    [MaxLength(20)]
    public string Username { get; set; }

    [Required]
    [MaxLength(70)]
    public string Password { get; set; }

    [Required]
    [MaxLength(20)]
    public string Email { get; set; }

    public List<User> Friends { get; set; }

    public List<Game> Games { get; set; }
}