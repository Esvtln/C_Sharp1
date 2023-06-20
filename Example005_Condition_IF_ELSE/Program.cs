Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine ();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hurray!Masha!");
}
else
{
    Console.Write("Hi there!");
    Console.WriteLine(username);
}