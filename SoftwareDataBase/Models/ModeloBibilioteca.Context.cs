﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftwareDataBase.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BibliotecaOKEntities : DbContext
    {
        public BibliotecaOKEntities()
            : base("name=BibliotecaOKEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Autore> Autores { get; set; }
        public virtual DbSet<Editoriale> Editoriales { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }
    
        public virtual int proce_edit_autor(Nullable<int> iD, string apellido, string nombre, Nullable<System.DateTime> fechaNac, Nullable<int> idPais)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var fechaNacParameter = fechaNac.HasValue ?
                new ObjectParameter("FechaNac", fechaNac) :
                new ObjectParameter("FechaNac", typeof(System.DateTime));
    
            var idPaisParameter = idPais.HasValue ?
                new ObjectParameter("IdPais", idPais) :
                new ObjectParameter("IdPais", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proce_edit_autor", iDParameter, apellidoParameter, nombreParameter, fechaNacParameter, idPaisParameter);
        }
    
        public virtual int procAltaAutor(string apellido, string nombre, Nullable<System.DateTime> fechaNacimiento, Nullable<int> idPais)
        {
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var idPaisParameter = idPais.HasValue ?
                new ObjectParameter("idPais", idPais) :
                new ObjectParameter("idPais", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procAltaAutor", apellidoParameter, nombreParameter, fechaNacimientoParameter, idPaisParameter);
        }
    
        public virtual int procBorrarAutor(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procBorrarAutor", idParameter);
        }
    }
}
