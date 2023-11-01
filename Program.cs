//metoda generująca hasło
//3 argumenty ( dlugosc (int), duze litery (boolean), znaki specjalne (boolean) )
//metoda generuje hasło na podstawie argumentów podanych przez użytkownika

string passwordGen(int length,Boolean capitalLetters, Boolean specialCharacters)
{
    const string characters1 = "0123456789abcdefghijklmnopqrstuvwxyz";
    const string characters2 = "!#$%&()*+,-./0123456789:;<=>?@[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
    const string characters3 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    const string characters4 = "!#$%&()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
    var random = new Random();
    string password = "";

    if(capitalLetters == true && specialCharacters == false)
    {
        for(int i=0;i<length;i++)
        {
            password += characters3[random.Next(characters3.Length)];
        }
    }
    else if(capitalLetters == false && specialCharacters == true)
    {
        for(int i=0;i<length;i++)
        {
            password += characters2[random.Next(characters2.Length)];
        }
    }
    else if(capitalLetters == true && specialCharacters == true)
    {
        for(int i=0;i<length;i++)
        {
            password += characters4[random.Next(characters4.Length)];
        }
    }
    else
    {
        for(int i=0;i<length;i++)
        {
            password += characters1[random.Next(characters1.Length)];
        }
    }

    return password;
}

Console.WriteLine("pass length: ");
int length = Convert.ToInt32(Console.ReadLine());
Boolean capitalLetters;
Boolean znakiSpecjalne;

Console.Write("include capital letters? ");
capitalLetters = Convert.ToBoolean(Console.ReadLine());
Console.Write("include special characters? ");
znakiSpecjalne = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("password: " + passwordGen(length,capitalLetters,znakiSpecjalne));

/*
    for(int i=0;i<length;i++)
    {
        password += characters[random.Next(characters.Length)];
    }
*/