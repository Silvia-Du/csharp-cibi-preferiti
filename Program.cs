// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

//array dispari per il test
//string[] favouriteFoods = { "pesche", "smoothie", "biscotti saraceno", "pizza", "sogliole", "humus" , "pasta al tonno"};
string[] favouriteFoods = { "pesche", "smoothie", "biscotti saraceno", "pizza", "sogliole", "humus"};

int half = favouriteFoods.Length / 2;
//lunghezza dell'array
Console.WriteLine(favouriteFoods.Length);


//stampa degli elementi in ordine all'inerno dell'array
Console.WriteLine(favouriteFoods);
for(int i=0; i< favouriteFoods.Length; i++)
{
    Console.WriteLine(favouriteFoods[i]);
}

//stampa del primo elemento dell'array
Console.WriteLine(favouriteFoods[0]);

//Stampa dell'ultimo elemento dell'array
Console.WriteLine(favouriteFoods[favouriteFoods.Length -1]);

//bonus

if (favouriteFoods.Length % 2 == 0)
{
    Console.WriteLine("l\'array lenght è pari");
    Console.WriteLine(favouriteFoods[half-1]);
    Console.WriteLine(favouriteFoods[half]);

}

else
{
    Console.WriteLine("l'array lenght è dispari");
    Console.WriteLine(favouriteFoods[(favouriteFoods.Length -1)/2]);
}
