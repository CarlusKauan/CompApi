using Dapper.Contrib.Extensions;

namespace CompApi.Models
{
    
    public class Participante
    {   
     
       public int Id { get; set; }
       public int TipoId { get; set; }
       public string Nome { get; set; }
       public string Cpf { get; set; }
       public string Email { get; set; }
    }
}