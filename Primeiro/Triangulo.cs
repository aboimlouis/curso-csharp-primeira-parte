using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Triangulo
    {
        private double _lado1;
        private double _lado2;
        private double _lado3;
        private double _area;
        public int id;
        static int quantidade;


        public Triangulo()
        {
            quantidade++;
            this.id = quantidade;
        }
        public Triangulo(string[] inputLados) : this()
        {
            this._lado1 = double.Parse(inputLados[0]);
            this._lado2 = double.Parse(inputLados[1]);
            this._lado3 = double.Parse(inputLados[2]);
        }
        public Triangulo(params double[] inputLados) : this()
        {
            _lado1 = inputLados[0];
            _lado2 = inputLados[1];
            _lado3 = inputLados[2];
        }

        static int retornarQuantidade()
        {
            return quantidade;
        }
        public double GetArea()
        {
            if (_area != 0)
            {
                return _area;
            }
            else
            {
                double p = (_lado1 + _lado2 + _lado3) / 2;
                _area = Math.Sqrt(p * (p - _lado1) * (p - _lado2) * (p - _lado3));
                return _area;
            }
        }
    }
}
