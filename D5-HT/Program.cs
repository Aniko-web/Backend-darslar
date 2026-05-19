//string name;

//Console.Write("Ismingizni kiriting: ");
//name = Console.ReadLine();

//Console.WriteLine($"Siz kiritdingiz: {name}");

//char firstChar = char.ToUpper(name[0]);
//string rest = name.Substring(1).ToLower();

//string result = firstChar + rest;
//Console.WriteLine($"Biz qabul qildik: {result}");


//string password = "ADMIN",upperPassword, inputPassword;

//Console.Write("Parolni kiriting: ");
//inputPassword = Console.ReadLine();

//upperPassword = inputPassword.ToUpper();

//if (upperPassword == password)
//{
//    Console.WriteLine("Xush kelibsiz!");
//}
//else
//{
//    Console.WriteLine("Parol noto'g'ri!");
//}



//string something;

//Console.Write("Nimadir kiriting: ");
//something = Console.ReadLine();

//string[] wordNumber = something.Split(' ');

//Console.WriteLine($"Siz {wordNumber.Length} ta so'z kiritdingiz.");


//string email;

//Console.Write("Email manzilingizni kiriting: ");
//email = Console.ReadLine();

//if (!email.Contains("@"))
//{
//    Console.WriteLine("Emailingizda '@'ni qoymagansiz!");
//}
//if (!email.EndsWith(".com"))
//{
//    Console.WriteLine("Emailingiz '.com' bilan tugamagan!");
//}
//else if (email.EndsWith(".com") && email.Contains("@"))
//{
//    Console.WriteLine("Emailingiz to'g'ri!");
//}


//string password, outputPassword;

//Console.Write("Parolni kiriting: ");
//password = Console.ReadLine();

//outputPassword = new string('*', password.Length);
//Console.WriteLine($"Siz kiritdingiz: {outputPassword}");

//string names, joined = " ";

//Console.Write("Ismlarni kiriting (',' bilan): ");
//names = Console.ReadLine();

//string[] result = names.Split(',', ' ');

//for (int i = 0; i < result.Length; i++)
//{
//    // Har bir ismni tozalash (bo'shliqlar)
//    string name = names?.Trim() ?? "";

//    if (!string.IsNullOrEmpty(name))
//    {
//        Console.WriteLine($"{i + 1}. {name}");
//    }
//}


//string word;

//Console.Write("So'z kiriting: ");
//word = Console.ReadLine();

//char[] harflar = word.ToCharArray();

//string ters = new string(harflar.Reverse().ToArray());

//Console.WriteLine($"So'zning tersi: {ters}");
