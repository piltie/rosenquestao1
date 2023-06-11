using rosenquestao1.Models;

var circulo = new Circulo();
var circuloPontos = new List<Ponto> 
        { 
            new Ponto(2,4),
            new Ponto(7,7),
        };

circulo.Pontos = circuloPontos;
Console.WriteLine($"Área do círculo: {circulo.ObterArea()}");

var triangulo = new Triangulo();
var trianguloPontos = new List<Ponto> 
        { 
            new Ponto(-1,1),
            new Ponto(4,0),
            new Ponto(-3,3),
        };

triangulo.Pontos = trianguloPontos;
Console.WriteLine($"Área do triângulo: {triangulo.ObterArea()}");