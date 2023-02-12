using EF_HW2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Models;

public class Libs : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
