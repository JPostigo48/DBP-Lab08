using ProjectDB8.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjectService8
{
    public class Service1 : IService1
    {
        public string addAlumno(IList<String> data)
        {
            Alumno a = new Alumno();
            string s = a.addAlumno(data);
            return s;
        }
        public IList<String> getCiudades()
        {
            Ciudad c = new Ciudad();
            IList<String> ciudades = c.getCiudades();
            return ciudades;
        }
    }
}
