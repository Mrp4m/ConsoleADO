using DAY4BootcampV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4BootcampV2.Interfaces
{
    interface ISell
    {
        List<TB_M_Sells> Get();
        TB_M_Sells Get(int id);
        bool Insert(TB_M_Sells sells);

    }
}
