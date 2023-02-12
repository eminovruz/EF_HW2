using EF_HW2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Hw2.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
}
