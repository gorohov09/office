using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Офис
{
    class Director : Worker
    {
        string almamater; // альма-матер
        string startyear; // год вступления на должность

        public Director(Director director)
        {
            director.ID = 1000;
            director.jobtitle = "Директор";
        }
    }
}
