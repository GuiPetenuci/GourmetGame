using System;
namespace GourmetGame
{
    public class Game
	{
        List<Food> guessList = new()
        {
            new Food
            {
                 Name = "Lasanha"
            },
            new Food
            {
                 Name = "Bolo de chocolate"
            }
        };

        const string exitLine = "SAIR";
        private bool winner = false;

        public void Begin()
		{
            winner = false;
            Console.Clear();
            Console.WriteLine("---- Gourmet Game ----");
            Console.WriteLine("Digite 'sair' para fechar o jogo.");
            Console.WriteLine("Pense em uma comida e aperte qualquer tecla");

            string? input = Console.ReadLine();
            if (input!.ToUpper() == exitLine)
                Environment.Exit(0);
        }

        public void Guessing()
        {
            foreach (var food in guessList)
            {
                Console.WriteLine($"A comida que voce pensou é: {food.Name}?");
                Console.WriteLine("Digite 'S' ou 'N' para responder");

                string? answer = Console.ReadLine()?.ToUpper();

                if (answer == "S")
                {
                    Console.WriteLine("Acertei!!!");
                    Console.ReadLine();
                    winner = true;
                    break;
                }
            }

            if (!winner)
            {
                Console.WriteLine("Poxa, não consegui acertar, qual comida era?");
                string? foodName = Console.ReadLine();
                if (foodName is null)
                {
                    Console.WriteLine("ERRO: Nome da comida não pode ser nulo!");

                } else
                {
                    guessList.Add(new Food(foodName));
                }
            }
        }
	}
}

