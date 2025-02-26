using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class Customer
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string CompanyName { get; set; } = null!;
    public ContactPerson Contact {  get; set; } = new ContactPerson();
   
}
