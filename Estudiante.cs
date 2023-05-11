using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacioneEstudiantes
{
    internal class Estudiante
    {
        private string id;
        private string name;

        public Estudiante(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public void setId(string id)
        {
            this.id = name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

    }
}
