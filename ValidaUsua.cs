using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
    public class ValidaUsua
    {
        public List<Usuario> Usuarios = new List<Usuario>();

        public void baseUsuarios()
        {
            using (FileStream texto = File.OpenRead(@"./UsuariosAlumnos.txt"))

            using (var Alumnos = new StreamReader(texto))
            {
                string line;

                while ((line = Alumnos.ReadLine()) != null)
                {
                    string dni = line.Split(',')[0];
                    string contraseña = line.Split(',')[1];
                    string nombre = line.Split(',')[2];
                    string apellido = line.Split(',')[3];
                    string registro = line.Split(',')[4];

                    Usuario user1 = new Usuario(dni, contraseña, nombre, apellido, registro);
                    Usuarios.Add(user1);
                }
            }
        }
    }
}