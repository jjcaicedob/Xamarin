using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSQLite.Data
{
    public class UsuarioData
    {
        static object locker = new object();

        public void Crear()
        {
            App.Database.CreateTable<Models.UsuarioModel>();
        }

        public IEnumerable<Models.UsuarioModel> Listar()
        {
            lock (locker)
            {
                return App.Database.Query<Models.UsuarioModel>("SELECT * FROM Usuarios").ToList();
            }
        }

        public int Insertar(Models.UsuarioModel Item)
        {
            lock (locker)
            {
                return App.Database.Insert(Item);
            }
        }

        public int Actualizar(Models.UsuarioModel Item)
        {
            lock (locker)
            {
                return App.Database.Insert(Item);
            }
        }
    }
}
