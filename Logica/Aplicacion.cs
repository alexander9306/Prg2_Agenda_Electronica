using System;
using System.Collections;
using Entidades;

namespace Logica
{
    public class Aplicacion
    {
        private ArrayList listPersonas = new ArrayList();

        public void CrearPersona(string nombre, string apellido, string edad, DateTime fechaNac, string direccion, string provincia,
            string pais, string telefono, string celular)
        {
            var p = new Persona();
            try
            {
                p.nombre = nombre;
                p.apellido = apellido;
                p.edad = edad;
                p.fechaNac = fechaNac;
                p.direccion = direccion;
                p.provincia = provincia;
                p.pais = pais;
                p.telefono = telefono;
                p.celular = celular;

                listPersonas.Add(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Persona GetPersona(int id)
        {
            return (Persona)listPersonas[id];
        }

        public int GetArrayCount()
        {
            return listPersonas.Count;
        }

        public void EliminarPersona(int id)
        {
            listPersonas.RemoveAt(id);
        }
    }
}
