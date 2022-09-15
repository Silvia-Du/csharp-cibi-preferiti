// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] favouriteFoods = { "pesche", "smoothie", "biscotti saraceno", "pizza", "sogliole", "humus" };

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

