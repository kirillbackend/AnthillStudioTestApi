namespace Api.Models.Entity;

public partial class User
{
    public long Id { get; set; }

    public string? NickName { get; set; }

    public string Email { get; set; } = null!;

    public string? Comments { get; set; }

    public DateTime CreateDate { get; set; }
}