using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;



namespace CLogica.Implementations
{
    public class PersonaLogic : IPersonaLogic
    {
        IPersonaRepository _personaRepository;

        public PersonaLogic(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public Persona AltaPersona(Persona personaNueva)
        {
            List<string> camposErroneos = new List<string>();

            // Validaciones
            if (string.IsNullOrEmpty(personaNueva.Nombre) || !IsValidName(personaNueva.Nombre))
                camposErroneos.Add("Nombre");
            if (string.IsNullOrEmpty(personaNueva.Apellido) || !IsValidName(personaNueva.Apellido))
                camposErroneos.Add("Apellido");
            if (!string.IsNullOrEmpty(personaNueva.Documento) && !IsValidDocumento(personaNueva.Documento))
                camposErroneos.Add("Documento");
            if (string.IsNullOrEmpty(personaNueva.Telefono) || !IsValidTelefono(personaNueva.Telefono))
                camposErroneos.Add("Telefono");
            if (string.IsNullOrEmpty(personaNueva.Email) || !IsValidEmail(personaNueva.Email))
                camposErroneos.Add("Email");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException($"Los siguientes campos son inválidos: {String.Join(", ", camposErroneos)}");
            }

            Persona persona = new Persona
            {
                Nombre = personaNueva.Nombre,
                Apellido = personaNueva.Apellido,
                Documento = personaNueva.Documento,
                Nacionalidad = personaNueva.Nacionalidad,
                TipoDocumento = personaNueva.TipoDocumento,
                Telefono = personaNueva.Telefono,
                Email = personaNueva.Email
            };


            _personaRepository.Create(persona);
            _personaRepository.Save();

            return persona;
        }


        public void ActualizacionPersona(Persona personaActualizar)
        {
            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(personaActualizar.Nombre) || !IsValidName(personaActualizar.Nombre))
                camposErroneos.Add("Nombre");
            if (string.IsNullOrEmpty(personaActualizar.Apellido) || !IsValidName(personaActualizar.Apellido))
                camposErroneos.Add("Apellido");
            if (!string.IsNullOrEmpty(personaActualizar.Documento) && !IsValidDocumento(personaActualizar.Documento))
                camposErroneos.Add("Documento");
            if (string.IsNullOrEmpty(personaActualizar.Telefono) || !IsValidTelefono(personaActualizar.Telefono))
                camposErroneos.Add("Telefono");
            if (string.IsNullOrEmpty(personaActualizar.Email) || !IsValidEmail(personaActualizar.Email))
                camposErroneos.Add("Email");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: " + string.Join(", ", camposErroneos));
            }

            Persona? persona = _personaRepository.FindByCondition(p => p.Documento == personaActualizar.Documento).FirstOrDefault();

            if (persona == null)
            {
                throw new ArgumentException("La persona con este documento no fue encontrada");
            }

            persona.Nombre = personaActualizar.Nombre;
            persona.Apellido = personaActualizar.Apellido;
            persona.Telefono = personaActualizar.Telefono;
            persona.Email = personaActualizar.Email;

            _personaRepository.Update(persona);
            _personaRepository.Save();
        }


        public void EliminacionPersona(string documento)
        {

            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentNullException("El domuento ingresado es invalido");
            Persona? persona = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if (persona == null)
            {
                throw new ArgumentException("La persona con este docuemtno no fue encontrada");
            }

            _personaRepository.Delete(persona);
            _personaRepository.Save();
        }

# region Validaciones
        public static bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '<', '>', ',', '`', '~' };
            return caracteres.Any(c => text.Contains(c));
        }

        public static bool IsValidName(string nombre)
        {
            return nombre.Length < 15 && !ContainsInvalidCharacter(nombre);

        }
        public static bool IsValidDocumento(string? documento)
        {
            if (string.IsNullOrEmpty(documento))
            {
                return true; // Acepta nulos o vacíos como válidos
            }

            return documento.Length == 8 && documento.All(c => Char.IsNumber(c));
        }

        public static bool IsValidTelefono(string telefono)
        {
            return telefono.Length == 10 && telefono.All(c => Char.IsNumber(c));

        }
        public static bool IsValidEmail(string email)
        {
            return email.Contains('@') && !ContainsInvalidCharacter(email);

        }

     
        #endregion Validaciones
    }

}
