using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyControlInv
{
    class Producto
    {
        //codigo, nombre, cantidad, costo
        private int _codigo;
        public int codigo { get { return _codigo; } }

        private string _nombre;
        public string nombre { get { return _nombre; } }

        private int _cantidad;
        public int cantidad { get { return _cantidad; } }

        private int _costo;
        public int costo { get { return _costo; } }

        public Producto(int codigo, string nombre, int cantidad, int costo)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _costo = costo;
        }

        public override string ToString()
        {
            return codigo.ToString() + Environment.NewLine + nombre + Environment.NewLine + cantidad.ToString() + " pza(s)" + Environment.NewLine + "$" + costo.ToString();
        }
    }
}
