Console.WriteLine("введите имя");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, Привет МАША!");
}
else
{
    Console.WriteLine("Здравствуйте,", username);
}