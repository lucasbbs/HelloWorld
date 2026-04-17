using System.Data.SqlTypes;

namespace HelloWorld;
class Program
{


    static void Main()
    {
        while (true)
        {
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                var welcomeMessage = new WelcomeMessage();
                var message = welcomeMessage.GetWelcomeMessage(name);
                Console.WriteLine(message);
                break;
            }
        }

        while (true)
        {
            Console.Write("Digite seu primeiro e último nome: ");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                continue;
            var names = input.Split(" ");
            var listNames = new List<string>();
            foreach (var name in names)
            {
                listNames.Add(name);
            }
            Console.Write("Nome informado: ");
            Console.WriteLine(
                string.Join(" ", listNames)
                );
            break;
        }

        string sentence;
        do
        {
            Console.Write("Digite uma ou mais palavras: ");
            sentence = Console.ReadLine();
            var characterCount = new CharacterCount();
            var countLettersPerWord = characterCount.GetCharacterCountWithStatus(sentence);

            if (!countLettersPerWord.Success)
            {
                Console.WriteLine("Nada foi informado, terminando operação");
                break;
            }
            Console.WriteLine(
                string.Join(" ", countLettersPerWord.Counts)
                );
        } while (!string.IsNullOrEmpty(sentence));


        Console.Write("Digite uma placa de carro brasileira válida até 2018: ");
        var plate = Console.ReadLine();
        var isPlateCarValid = new IsPlateCarValid();
        var isAlphaNumeric = isPlateCarValid.GetIsPlateCarValid(plate);
        if (isAlphaNumeric)
            Console.WriteLine("Verdadeiro");
        else
            Console.WriteLine("Falso");

        /*
        5. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
            - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
            - Apenas a data no formato "01/03/2024".
            - Apenas a hora no formato de 24 horas.
            - A data com o mês por extenso.
         */


        DateFormat? formatOption = null;

        do
        {
            Console.WriteLine(@"Selecione um dos seguintes formatos para exibir a data atual

1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)
2 - Apenas a data no formato ""01/03/2024""
3 - Apenas a hora no formato de 24 horas
4 - A data com o mês por extenso
5 - Sair");

            string? selectedOption = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(selectedOption))
            {
                continue;
            }

            switch (selectedOption)
            {
                case "1":
                    formatOption = DateFormat.DateAndTime;
                    break;
                case "2":
                    formatOption = DateFormat.DateOnly;
                    break;
                case "3":
                    formatOption = DateFormat.TimeOnly;
                    break;
                case "4":
                    formatOption = DateFormat.LongMonthDate;
                    break;
                case "5":
                    return;
                default:
                    continue;
            }

            Console.WriteLine(ShowDate.GetDate(formatOption.Value));

        } while (true);

    }


}
enum DateFormat
{
    DateAndTime,
    DateOnly,
    TimeOnly,
    LongMonthDate
}
static class ShowDate
{
    static public string GetDate(DateFormat format)
    {
        var now = DateTime.Now;
        switch (format)
        {
            case DateFormat.DateAndTime:
                return now.ToString();
            case DateFormat.DateOnly:
                return now.ToString("dd/MM/yyyy");
            case DateFormat.TimeOnly:
                return now.ToString("HH");
            case DateFormat.LongMonthDate:
                return now.ToString("MMMM dd, yyyy");
        }
        return "";
    }
}