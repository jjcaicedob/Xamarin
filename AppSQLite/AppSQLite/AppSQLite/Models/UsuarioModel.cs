using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace AppSQLite.Models
{
    [Table("Usuarios")]
    public class UsuarioModel
    {
        [PrimaryKey]
        [AutoIncrement]
        public int UsuarioId { get; set; }

        [MaxLength(30)]
        public string Nombres { get; set; }

        [MaxLength(30)]
        public string Apellidos { get; set; }

        public int Sexo { get; set; }

        [MaxLength(256)]
        public string CorreoElectronico { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [MaxLength(15)]
        public string Contrasena { get; set; }
    }
}
