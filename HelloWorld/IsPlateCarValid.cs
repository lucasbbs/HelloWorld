namespace HelloWorld;

/*    4. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;

    Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
*/
public class IsPlateCarValid
{
    public bool GetIsPlateCarValid(string plateNumber)
    {
        var alphabeticPart = plateNumber.Substring(0, 3);
        foreach (char c in alphabeticPart)
        {
            if (!char.IsLetter(c))
                return false;
        }
        var numericPart = plateNumber.Substring(3);
        foreach (char c in numericPart)
        {
            if (!char.IsNumber(c))
                return false;
        }
        return true;
    }
}