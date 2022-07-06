using System;
using System.ComponentModel.DataAnnotations;

namespace GRC.Autenticacion.Entidades
{
    public class EtidadBase
    {
        private int _Id = 0;
        
        [Key]
        public int Id { get => _Id; set => _Id = value; }
        
        private String _UsuAlta = String.Empty;
        public String UsuAlta { get => _UsuAlta; set => _UsuAlta = value; }
       
        private DateTime _FechaAlta = System.DateTime.Now;
        public DateTime FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }
        
        private String _UsuCambio = String.Empty;
        public String UsuCambio { get => _UsuCambio; set => _UsuCambio = value; }
        
        private DateTime _FechaCambio = System.DateTime.Now;
        public DateTime FechaCambio { get => _FechaCambio; set => _FechaCambio = value; }
    }
}
