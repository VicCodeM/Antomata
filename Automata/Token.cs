using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{

    public class Token
    {
        int clave;
        string contenido;
        public Token(int clave, string contenido)
        {
            this.clave = clave; 
            this.contenido = contenido;
        }
        public string Contenido() 
        { 
            return contenido; 
        }
        public int Clave () 
        { 
            return clave; 
        }
    }
}
