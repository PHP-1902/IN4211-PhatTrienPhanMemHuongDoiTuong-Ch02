
namespace EduHub.Domain;

public class Member
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string FullName { get; private set; }

    public string Email { get; private set; }

    public Member(string fullName, string email)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Full name is required.", nameof(fullName));

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email is required.", nameof(email));

        FullName = fullName;
        Email = email;
    }
}
