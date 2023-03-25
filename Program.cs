// to nervoso

string Frase;
string FraseToNervoso;
string Usuario;


Console.Write("Digite seu Nome:");
Usuario = Console.ReadLine()!; 

Console.Write($"{Usuario}, o que você acha de mim ?");
Frase = Console.ReadLine()!;

FraseToNervoso = $"{Frase.Remove(10)}... NÂO, PERA. \nTô nervoso";

Console.WriteLine(FraseToNervoso);
