using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Diagnostics;

class Contact
{
    string _name;
    string _surname;
    string _organization;
    string _phoneNumber;
    string _email;
    DateTime Birthday { get; set; }

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
    public string Organization
    {
        get { return _organization; }
        set
        {
            if (value.Length == 0) throw new ArgumentException("An empty string is passed in the field.");
            _organization = value;
        }
    }
    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            if (value.Length < 7) throw new ArgumentException("The phone number is not correct.");
            _phoneNumber = value;
        }
    }
    public string Email
    {
        get { return _email; }
        set
        {
            IsValidEmail(value);
            _email = value;
        }
    }

    public Contact()
    {
        Name = "Name";
        Surname = "Surname";
        Organization = "TUSUR";
        PhoneNumber = "8 (3822) 51-05-30";
        Email = "office@tusur.ru";
        Birthday = new DateTime(1962, 4, 21);
    }

    public Contact(string name, string surname, string organization, string phoneNumber, string email, DateTime birthday)
    {
        Name = name;
        Surname = surname;
        Organization = organization;
        PhoneNumber = phoneNumber;
        Email = email;
        Birthday = birthday;
    }

    // https://learn.microsoft.com/ru-ru/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
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