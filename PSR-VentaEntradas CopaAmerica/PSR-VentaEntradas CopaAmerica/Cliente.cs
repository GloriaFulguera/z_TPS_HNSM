using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSR_VentaEntradas_CopaAmerica
{
    public class Cliente
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
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public bool MayorDeEdad
        {
            get { return _mayorDeEdad; }
            set { _mayorDeEdad = value; }
        }
        public string MedioDePago
        {
            get { return _medioDePago; }
            set { _medioDePago = value; }
        }

    }
}
