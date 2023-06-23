using PCInfo_backend.PCInfo.Domain.Models;

namespace PCInfo_backend.PCInfo.Resources;

public class ClienteResource
{
    public int id { get; set; }
    public string DNI { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public User user { get; set; }
}