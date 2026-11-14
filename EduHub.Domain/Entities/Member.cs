namespace EduHub.Domain.Entities;

public class Member
{
    // TODO Câu 1b: Các thuộc tính chỉ được sửa bên trong lớp (private set)
    public Guid Id { get; private set; }
    public string Email { get; private set; } = string.Empty;

    // TODO: Constructor private để bắt buộc tạo qua Factory Method
    private Member() { }

    // TODO Câu 1b: Factory method Create kiểm tra email không rỗng và có ký tự @
    public static Member Create(string email)
    {
        // Gợi ý:
        // if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
        //     throw new ArgumentException("Email không hợp lệ.", nameof(email));
        
        throw new NotImplementedException("Bạn hãy viết mã cho Member.Create(...) ở đây");
    }
}
