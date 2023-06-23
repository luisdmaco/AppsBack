namespace PCInfo_backend.PCInfo.Domain.Models;

public class User
{
    public string idUser { get; set; }
    public string Usuario { get; set; }
    public string Password { get; set; }

    //Relationships
    public IList<Cliente> Clientes { get; set; } = new List<Cliente>();
}