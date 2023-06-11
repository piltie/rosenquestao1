using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace rosenquestao1.Models
{
    public abstract class Forma2D
    {
        protected float Pi { get; } = 3.1415926F;
        private Cor Cor { get; set; }
        public abstract float ObterArea();
    }
}
