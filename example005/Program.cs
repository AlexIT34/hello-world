Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "alex")
{
    Console.WriteLine("Ура, это Alex");
}        
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}