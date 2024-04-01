using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSR_VentaEntradas_CopaAmerica
{
    internal class Cliente
    {
        private string _nombre;
        private string _apellido;
        private bool _mayorDeEdad = false;
        private string _medioDePago;
        public Cliente(string nombre, string apellido, bool mayorDeEdad, string medioDePago)
        {
            _nombre = nombre;
            _apellido = apellido;
            _mayorDeEdad = mayorDeEdad;
            _medioDePago = medioDePago;
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
