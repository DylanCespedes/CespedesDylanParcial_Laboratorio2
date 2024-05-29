using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlmacenDeComponentes
    {
        //Copiar todo lo que tengo y crear un metodo para serealizar componentes
<<<<<<< HEAD

=======
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
        private List<Componente> componentes;

        public AlmacenDeComponentes(List<Componente> componentes)
        {
            this.componentes = componentes;
        }

        public static bool operator !=(AlmacenDeComponentes a, Componente c)
        {
            return !(a == c);
        }

        public static bool operator ==(AlmacenDeComponentes a, Componente c)
        {
            bool esta = false;

            foreach (Componente componente in a.componentes)
            {
                if (componente == c)
                {
                    esta = true;
                    break;
                }
            }

            return esta;
        }

        public static AlmacenDeComponentes operator +(AlmacenDeComponentes a, Componente c)
        {
            if (a != c)
            {
                a.componentes.Add(c);

            }
            else
            {
                Console.WriteLine("Este producto ya esta agregado\n");
            }

            return a;
        }

        public static AlmacenDeComponentes operator -(AlmacenDeComponentes a, Componente c)
        {
            if (a == c)
            {
                a.componentes.Remove(c);

                Console.WriteLine("El componente fue eliminado del almacen.");
            }
            else
            {
                Console.WriteLine("Este componente no existe en el almacen.");
            }

            return a;
        }

        public static implicit operator List<Componente>(AlmacenDeComponentes a)
        {
            return a.componentes;
        }

        public static explicit operator string(AlmacenDeComponentes c)
        {


            return c.ToString();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Cantidad de componentes: {this.componentes.Count}");

            foreach (Componente item in this.componentes)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }
<<<<<<< HEAD


=======
>>>>>>> 7333da0049bfc9e43ffd321b2e3b5e71319bf970
    }
}
