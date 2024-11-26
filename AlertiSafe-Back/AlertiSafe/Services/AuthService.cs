using AlertiSafe.Modelo;
using Microsoft.EntityFrameworkCore;

namespace AlertiSafe.Services;

public class AuthService
{
    private readonly IdentifierContext _context;

    public AuthService(IdentifierContext context)
    {
        _context = context;
    }

    public async Task<bool> ValidateCredentials(string username, string password)
    {
        // Busca un usuario con el nombre y contraseña especificados
        var user = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Email == username && u.contrasenia == password);

        return user != null; // Retorna true si el usuario existe
    }
}