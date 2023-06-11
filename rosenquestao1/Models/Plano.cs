using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rosenquestao1.Models
{
    public class Plano
    {
        public Forma2D? Forma2d { get; private set; }

        public bool AttachFigura(Forma2D figura)
        {
            try
            {
                Forma2d = figura;
            }
            catch(Exception ex)
            {
                return false;
            }

            return true;
        }
        public bool DetachFigura(int param1, Forma2D figura)
        {
            try
            {
                Forma2d = null;
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
