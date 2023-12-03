using System.Security.Cryptography.X509Certificates;

namespace TesteScan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrianguloTeste();
        }



        public static void TrianguloTeste() 
        {
            List<float> triangulo = new List<float>();
            while (triangulo.Count < 3)
            {
                try
                {
                    Console.WriteLine("Digite valor do lado do triângulo");
                    var lado = float.Parse(Console.ReadLine());
                    triangulo.Add(lado);
                }
                catch
                {
                    Console.WriteLine("Só é permitido digitar números. Por favor tente novamente");
                }

            }

            var invalidTri = triangulo.FindAll(triangulo => triangulo == 0);

            if (invalidTri.Count == 0)
            {
                var valDistict = triangulo.Distinct().Count();

                switch (valDistict)
                {
                    case 1:
                        Console.WriteLine("Triângulo Equilátero");
                        break;
                    case 2:
                        Console.WriteLine("Trângulo Isóceles");
                        break;
                    case 3:
                        Console.WriteLine("Triângulo Escaleno");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Valor Invalido");
            }


        }


    }
}
 
            
           

