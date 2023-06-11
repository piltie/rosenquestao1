using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rosenquestao1.Models
{
    public class Ponto
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Ponto(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
