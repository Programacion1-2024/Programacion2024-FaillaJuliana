using CDatos.Contexts;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Metodos
{
    public class CRUDPersona
    {
        public LibreriaContext context = new LibreriaContext();

        public void AgregarPersona(Persona persona)
        {
            Persona personaNueva = new Persona();

            personaNueva.Nombre = persona.Nombre;
            personaNueva.Apellido = persona.Apellido;
            personaNueva.Direccion = persona.Direccion;
            personaNueva.CorreoElectronico = persona.CorreoElectronico;
            personaNueva.Telefono = persona.Telefono;
            personaNueva.Documento = persona.Documento;
            personaNueva.TipoDocumento = persona.TipoDocumento;
           
            personaNueva.Autor = persona.Autor;
            personaNueva.Cliente = persona.Cliente;
            personaNueva.Empleado = persona.Empleado;
            context.Persona.Add(personaNueva);
            context.SaveChanges();
        }

        public void ModificarPersona(Persona personaModificada, Persona persona)
        {
            personaModificada.Nombre = persona.Nombre;
            personaModificada.Apellido = persona.Apellido;
            personaModificada.Direccion = persona.Direccion;
            personaModificada.CorreoElectronico = persona.CorreoElectronico;
            personaModificada.Telefono = persona.Telefono;
            personaModificada.Documento = persona.Documento;
            personaModificada.TipoDocumento = persona.TipoDocumento;
            personaModificada.Autor = persona.Autor;
            personaModificada.Cliente = persona.Cliente;
            personaModificada.Empleado = persona.Empleado;
            context.Persona.Update(personaModificada);
            context.SaveChanges();

        }

        public void EliminarPersona(Persona persona)
        {
            context.Persona.Remove(persona);
            context.SaveChanges();
        }

        private bool IsValid(string nombre)
        {
            return nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }
        
}
