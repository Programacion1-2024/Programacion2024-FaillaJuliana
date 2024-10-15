using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

using Microsoft.AspNetCore.StaticFiles; // Asegúrate de incluir esta referencia

namespace CLogica.Implementations
{
    public class ImagenLogic : IImagenLogic
    {
        private readonly IIImagenRepository _imagenRepository;
        private readonly FileExtensionContentTypeProvider _provider;

        public ImagenLogic(IIImagenRepository imagenRepository)
        {
            _imagenRepository = imagenRepository;
            _provider = new FileExtensionContentTypeProvider(); // Inicializa el proveedor de tipos MIME
        }

        public void GuardarImagenEnBaseDeDatos(string rutaArchivo, string formulario_usuarioOrigen)
        {
            if (!File.Exists(rutaArchivo))
            {
                throw new FileNotFoundException("El archivo no existe en la ruta especificada.", rutaArchivo);
            }

            string tipoMime;
            if (!_provider.TryGetContentType(rutaArchivo, out tipoMime))
            {
                tipoMime = "application/octet-stream"; // Tipo MIME por defecto si no se encuentra
            }

            // Crear una instancia de la clase Imagen
            Imagen nuevaImagen = new Imagen
            {
                Nombre = Path.GetFileName(rutaArchivo),       // Nombre del archivo
                URL = rutaArchivo,                           // Ruta completa del archivo
                Tamanio = new FileInfo(rutaArchivo).Length,  // Tamaño del archivo en bytes
                TipoMime = tipoMime,                         // Obtener el tipo MIME
                FormularioOrigen = formulario_usuarioOrigen  // Formulario o Usuario al que pertenece el archivo
            };

            try
            {
                // Buscar si existe una imagen para el mismo formulario/usuario
                Imagen? imagenExistente = _imagenRepository
                    .FindByCondition(img => img.FormularioOrigen == formulario_usuarioOrigen)
                    .FirstOrDefault();

                if (imagenExistente == null)
                {
                    _imagenRepository.Create(nuevaImagen);
                }
                else
                {
                    imagenExistente.Nombre = nuevaImagen.Nombre;
                    imagenExistente.URL = nuevaImagen.URL;
                    imagenExistente.Tamanio = nuevaImagen.Tamanio;
                    imagenExistente.TipoMime = nuevaImagen.TipoMime;

                    _imagenRepository.Update(imagenExistente);
                }

                // Guardar los cambios en la base de datos
                _imagenRepository.Save();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al guardar la imagen en la base de datos.", ex);
            }
        }

        public List<Imagen> ObtenerImagenesPorOrigen(string formularioOrigen)
        {
            return _imagenRepository.GetByFormName(formularioOrigen);
        }
    }
}

