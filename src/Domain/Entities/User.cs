using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public abstract class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Type { get; set; }


 
}
//Cambie el 'username' por 'Id' para q sea mas facil despues buscarlos. preguntar a q se refieren con Type

