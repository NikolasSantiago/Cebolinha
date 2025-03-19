string fraseDigitada; 
string fraseLeet;

 Console.Clear();

  Console.Write(" Digite uma frase para o Cebola :");

   fraseDigitada = Console.ReadLine()!;

    fraseLeet = fraseDigitada 
    .Replace("r", "l") .Replace("R", "L");

     Console.WriteLine(fraseLeet);
