using ATM_Consol_Final.Users;

User user1 = new()
{
    Id = 0001,

    Name = "MuhammedAli",

    SurName = "Baghirzade",

    Password = 2222
};
User user2 = new()
{
    Id = 0002,

    Name = "Reshad",

    SurName = "Reshidli",

    Password = 0101
};
User user3 = new()
{
    Id = 0003,

    Name = "Ibrahim",

    SurName = "Feteliyev",

    Password = 0258
};





Evvele:

Console.WriteLine("1.Kartinizi Terminala daxil edin.");
Console.WriteLine("2.Exit");
string CardEnter = Console.ReadLine();


if (Convert.ToInt32(CardEnter) == 1)
{

    Console.WriteLine("Zehmet olmasa gozleyin....");
    System.Threading.Thread.Sleep(3000);
    Console.Clear();
    Console.WriteLine("Kart oxuyan cihaz ishlemir. Zehmet olmasa ID-nizi daxil edin:(ID - Kartinizin son 4 reqemi)");
    String checkId = Console.ReadLine();
    string checkpass;
    switch (Convert.ToInt32(checkId))
    {
        case 0001:
            Problem:
            Console.Write(user1.Name + " Zehmet olmasa shifrenisi daxil edin: ");
            checkpass = Console.ReadLine();

            if (Convert.ToInt32(checkpass) == Convert.ToInt32(user1.Password))
            {
                Console.WriteLine("ela");
            }
            else
            {

                Console.WriteLine("Shifrenizi duzgun daxil edin.");
                goto Problem;
            }

            break;
        case 0002:
        Problem1:
            Console.Write(user2.Name + " Zehmet olmasa shifrenisi daxil edin: ");
            checkpass = Console.ReadLine();

            if (Convert.ToInt32(checkpass) == Convert.ToInt32(user2.Password))
            {
                Console.WriteLine("ela");
            }
            else
            {

                Console.WriteLine("Shifrenizi duzgun daxil edin.");
                goto Problem1;
            }

            break;
        case 0003:
        Problem2:
            Console.Write(user3.Name + " Zehmet olmasa shifrenisi daxil edin: ");
            checkpass = Console.ReadLine();

            if (Convert.ToInt32(checkpass) == Convert.ToInt32(user3.Password))
            {
                Console.WriteLine("ela");
            }
            else
            {

                Console.WriteLine("Shifrenizi duzgun daxil edin.");
                goto Problem2;
            }

            break;
    }





}
else if (Convert.ToInt32(CardEnter) == 2)
{
    Console.WriteLine("Sagolun:)");
    System.Threading.Thread.Sleep(1000);

}
else
{
    Console.WriteLine("Zehmet olmasa duzgun daxil edin!!!");
    System.Threading.Thread.Sleep(4000);

    Console.Clear();
    goto Evvele;
}
