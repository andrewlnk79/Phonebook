
using Phonebook;
using System.Security.Cryptography;



var phoneBook = new Dictionary<string, Contact>();
phoneBook.TryAdd("Andrey", new Contact("Андрей", "+ 79990000001"));

phoneBook.TryAdd("Igor", new Contact("Игорь", "+79990000000"));
phoneBook.TryAdd("Sergey", new Contact("Аврора", "+79991111111"));


var sort = phoneBook.OrderBy(s => s.Value.SurName).ThenBy(s => s.Key);
foreach (var item in sort)
{
    Console.WriteLine(item.Key);
}



