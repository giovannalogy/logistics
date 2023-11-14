using Logistica.Domain.Entities;

public sealed class User : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserPerfil Perfil { get; set; }
}

