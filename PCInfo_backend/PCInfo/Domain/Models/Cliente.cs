namespace PCInfo_backend.PCInfo.Domain.Models;

public class Cliente
{
    public string DNI { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    
    //Relationships
    public string IDuser { get; set; }
    public User user { get; set; }
}