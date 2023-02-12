using EF_HW2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Models;

public class Groups : BaseEntity
{
    public string Name { get; set; }
    public int Id_Facultity { get; set; }
}
