using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeBall.DataModels
{
    public class Player
    {
        public int Id                       { get; set; }
        public string Name                  { get; set; }
        public string Picture               { get; set; }
        public int TeamId                   { get; set; }
        public virtual Team Team            { get; set; }
    }
}
