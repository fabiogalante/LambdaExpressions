using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8};

            var listaFiltrada = lista.Where(x => x > 4); //Lambda Expression

            var listaChamandoFunction = lista.Where(Filtro);

            //var listaFiltrada = lista.Where(

            //            public static bool Filtro(int x)
            //            {
            //                Console.WriteLine($"Testando - {x}");
            //                return x > 4;
            //            }

            //    )

                        //vou removendo cada ítem, o C# já sabe quais são esta informações
                        // a função é executada dentro do Where, então não preciso do modificador
                        //C# já sabe que o retorno é um bool, então eu removo.
                        //C# já sabe que o parâmetro é um inteiro, removo a palavra int
                        //Como ela vai ser executda somente uma vez, eu não preciso do nome dela.
                        //Se eu tenho uma função com somente uma linha, eu não preciso das chaves.
                        //Removo o retorno porque é a minha única linha que eu retorno
                        //Quando tenho somente um parâmetro eu não preciso do parentes
                        //x = x > 4; parâmetro e execução
                        //para diferenciar entra a setinha x => x > 4

        }


        public static bool Filtro(int x)
        {
            Console.WriteLine($"Testando - {x}");
            return x > 4;
        }
    }


}
