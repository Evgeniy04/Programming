using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Diagnostics;

/// <summary>
/// Представление контакта в телефоне.
/// </summary>
class Contact
{
    /// <summary>
    /// Имя контакта.
    /// </summary>
    string _name;
    /// <summary>
    /// Фамилия контакта.
    /// </summary>
    string _surname;
    /// <summary>
    /// Организация контакта.
    /// </summary>
    string _organization;
    /// <summary>
    /// Номер телефона контакта.
    /// </summary>
    string _phoneNumber;
    /// <summary>
    /// Адрес электронной почты контакта.
    /// </summary>
    string _email;
    /// <summary>
    /// День рождения контакта.
    /// </summary>
    DateTime Birthday { get; set; }

    /// <summary>
    /// Возвращает и изменяет имя контакта. Количество символов больше нуля.
    /// </summary>
    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length == 0) throw new ArgumentException("The name can't be blank.");
            AssertStringContainsOnlyLetters(value);
            _name = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет фамилию контакта. Количество символов больше нуля.
    /// </summary>
    public string Surname
    {
        get { return _surname; }
        set
        {
            if (value.Length == 0) throw new ArgumentException("The surname can't be blank.");
            AssertStringContainsOnlyLetters(value);
            _surname = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет название организации контакта. Количество символов больше нуля.
    /// </summary>
    public string Organization
    {
        get { return _organization; }
        set
        {
            if (value.Length == 0) throw new ArgumentException("An empty string is passed in the field.");
            _organization = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет телефонный номер контакта. Значение должно быть больше 7 символов.
    /// </summary>
    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            if (value.Length < 7) throw new ArgumentException("The phone number is not correct.");
            _phoneNumber = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет адрес электронной почты.
    /// </summary>
    public string Email
    {
        get { return _email; }
        set
        {
            IsValidEmail(value);
            _email = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Contact"/>.
    /// </summary>
    public Contact()
    {
        Name = "Name";
        Surname = "Surname";
        Organization = "TUSUR";
        PhoneNumber = "8 (3822) 51-05-30";
        Email = "office@tusur.ru";
        Birthday = new DateTime(1962, 4, 21);
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Contact"/>.
    /// </summary>
    /// <param name="name">Имя контакта.</param>
    /// <param name="surname">Фамилия контакта.</param>
    /// <param name="organization">Организация контакта.</param>
    /// <param name="phoneNumber">Номер телефона контакта.</param>
    /// <param name="email">Адрес электронной почты контакта.</param>
    /// <param name="birthday">День рождения контакта.</param>
    public Contact(string name, string surname, string organization, string phoneNumber, string email, DateTime birthday)
    {
        Name = name;
        Surname = surname;
        Organization = organization;
        PhoneNumber = phoneNumber;
        Email = email;
        Birthday = birthday;
    }

    /// <summary>
    /// Проверяет, является ли указанная строка правильным адресом электронной почты. Пояснение: https://learn.microsoft.com/ru-ru/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
    /// </summary>
    /// <param name="email">Строка для проверки.</param>
    /// <returns><see langword="true"/>, если адрес электронной почты правильный, в противном случае — <see langword="false"/>.</returns>
    /// <exception cref="ArgumentException">Вызывается, если адрес электронной почты недопустимый.</exception>
    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("E-mail is invalid.");

        try
        {
            // Normalize the domain
            email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
            RegexOptions.None, TimeSpan.FromMilliseconds(200));

            // Examines the domain part of the email and normalizes it.
            string DomainMapper(Match match)
            {
                // Use IdnMapping class to convert Unicode domain names.
                var idn = new IdnMapping();

                // Pull out and process domain name (throws ArgumentException on invalid)
                string domainName = idn.GetAscii(match.Groups[2].Value);

                return match.Groups[1].Value + domainName;
            }
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }

        try
        {
            return Regex.IsMatch(email,
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }

    /// <summary>
    /// Проверяет, содержит ли указанная строка только буквы английского алфавита.
    /// </summary>
    /// <param name="value">Строка для проверки.</param>
    /// <exception cref="ArgumentException">Вызывается, если строка содержит символы, отличные от букв английского алфавита.</exception>
    private void AssertStringContainsOnlyLetters(string value)
    {
        if (Regex.IsMatch(value, "^[a-zA-Z]*$"))
        {
            return;
        }
        else
        {
            throw new ArgumentException($"The {new StackTrace().GetFrame(1).GetMethod().Name} must contain only characters from the English alphabet.");
        }
    }
}