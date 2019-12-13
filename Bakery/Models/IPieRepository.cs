using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public interface IPieRepository
    {
        // why only get? because the data is hardcoded, probably. 
        List<Pie> AllPies { get; }

        //List<Pie> PiesOfTheWeek { get; }

        Pie GetPieByID(int pieid);


    }
}
