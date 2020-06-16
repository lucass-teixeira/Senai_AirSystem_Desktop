using Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Repositories
{
    
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;
        //Contador - id do usuário
        private static int contador = 1; 

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();


                //Dados previamente adicionados na lista para facilitar teste do editar e excluir
                usuarios.Add(new Usuario
                {
                    codigo = 1,
                    nome = "Erik",
                    sobrenome = "Algum",
                    dataNasc = Convert.ToDateTime("13/02/2002"),
                    usuario = "evitelli",
                    senha = "1234",
                    confSenha = "1234"
                }
              ); 
                contador++;
                usuarios.Add(new Usuario
                {
                    codigo = 2,
                    nome = "Erika",
                    sobrenome = "nenhum",
                    dataNasc = Convert.ToDateTime("03/02/2002"),
                    usuario = "evitelli",
                    senha = "1234",
                    confSenha = "1234"
                }
                );
                contador++;
            }
        }
        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }

        public void adicionar(Usuario usuario)
        {
            usuario.codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void editar(Usuario usuario)
        {

            
            Usuario u = usuarios.Find(x => x.codigo == usuario.codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public void deletar(int codigo)
        {
            // recupero o usuário atraves do código
            Usuario usuario = usuarios.Find(x => x.codigo == codigo);

            // removo o usuário da lista;
            usuarios.Remove(usuario);
        }



    }
}
