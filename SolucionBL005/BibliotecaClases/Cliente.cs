using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cliente
    {
        private string _rut;
        private string _nombres;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set {
                _fechaNacimiento = value;
            }
        }
        public string Apellidos
        {
            get { return _apellidos; }
            set {
                _apellidos = value;
            }
        }
        public string Nombres
        {
            get { return _nombres; }
            set {
                _nombres = value;
            }
        }
        public string Rut
        {
            get { return _rut; }
            set {
                _rut = value;
            }
        }

        public Cliente()
        {

        }
    }
}
