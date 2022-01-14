using dadosPessoa;
using Interface;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Giovana";
            person.Idade = 18;
            person.Estado = "SP";

            var person2 = new Pessoa();

            person2.Nome = "Julia";
            person2.Idade = 23;
            person2.Estado = "MG";

            Animal animal = new Animal();

            animal.Nome = "Hex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";

            

            Console.WriteLine("Hello World!")
        }
    }
}