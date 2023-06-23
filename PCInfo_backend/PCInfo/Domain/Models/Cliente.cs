namespace PCInfo_backend.PCInfo.Domain.Models;

public class Cliente
{
    public int idCliente { get; set; }
    public string DNI { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    
    //Relationships
    public string idUser { get; set; }
    public User user { get; set; }
}