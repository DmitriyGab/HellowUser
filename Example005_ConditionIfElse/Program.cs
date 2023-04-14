Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
// if (username == "маша")
{
    Console.WriteLine("Да здавствует, Маша !!!");
}

else
{
    Console.Write("Здравствуйте,  ");
    Console.WriteLine(username);
}