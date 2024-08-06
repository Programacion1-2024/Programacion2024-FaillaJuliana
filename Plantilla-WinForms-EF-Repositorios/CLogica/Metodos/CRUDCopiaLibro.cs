using CDatos.Contexts;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Metodos
{
    public class CRUDCopiaLibro
    {
        public LibreriaContext context = new LibreriaContext();
        
        public void AgregarCopiaLibro(CopiaLibro copiaLibro)
        {
            CopiaLibro copiaLibroNueva = new CopiaLibro();  
            
            copiaLibroNueva.PrecioPrestamo = copiaLibro.PrecioPrestamo;
            copiaLibroNueva.Prestamos = copiaLibro.Prestamos;
            copiaLibroNueva.Libro = copiaLibro.Libro;
            context.CopiaLibro.Add(copiaLibroNueva);
            context.SaveChanges();
        }

        public void ModificarCopiaLibro(CopiaLibro copiaLibroModificado, CopiaLibro copiaLibro)
        {
            copiaLibroModificado.PrecioPrestamo = copiaLibro.PrecioPrestamo;
            copiaLibroModificado.Prestamos = copiaLibro.Prestamos;
            copiaLibroModificado.Libro = copiaLibro.Libro;
            context.CopiaLibro.Add(copiaLibroModificado);
            context.SaveChanges();

        }
        
        public void EliminarCopiaLibro(CopiaLibro copiaLibro)
        {
            context.CopiaLibro.Remove(copiaLibro);
            context.SaveChanges();
        }
    }
}
