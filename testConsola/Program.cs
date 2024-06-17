using Entidades;

namespace testConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = Usuario.DesealizarUsuariosJson();

            foreach (Usuario usuario in lista)
            {
                Console.WriteLine(usuario);
            }

            Console.ReadLine();
        }
    }
}
