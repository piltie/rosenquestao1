using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rosenquestao1.Models
{
    public class Circulo : Forma2D
    {
        private List<Ponto> _pontos;
        public List<Ponto> Pontos
        {
            get
            {
                return _pontos;
            }
            set 
            {
                if (value.Count() == 2)
                {
                    _pontos = value;
                }
                else
                {
                    Console.WriteLine("Lista de pontos inválida.");
                }
            }
        }

        public override float ObterArea()
        {
            if (Pontos.Count() != 2)
            {
                throw new InvalidOperationException("O tamanho da lista de pontos não pode ser maior ou menor que 2.");
            }

            var centro = Pontos[0];
            var pontoMedio = Pontos[1];

            var raio = Math.Sqrt(Math.Pow(pontoMedio.X - centro.X, 2) + Math.Pow(pontoMedio.Y - centro.Y, 2));
            var area = Pi * Math.Pow(raio, 2);

            return (float)area;
        }
    }
}
