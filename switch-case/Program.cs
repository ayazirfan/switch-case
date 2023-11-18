int month = DateTime.Now.Month;

switch (month)
{
    case 1:
    Console.WriteLine("Ocak Ayındasınız");
    break;
    case 2:
    Console.WriteLine("Şubat Ayındasınız");
    break;

    case 3:
    Console.WriteLine("Mart Ayındasınız");
    break;

    case 4:
    Console.WriteLine("Nisan Ayındasınız");
    break;

    case 5:
    Console.WriteLine("Nisan Ayındasınız");
    break;

    case 6:
    Console.WriteLine("Nisan Ayındasınız");
    break;

    case 7:
    Console.WriteLine("Nisan Ayındasınız");
    break;
    default:
    break;
    

    
    
}

switch (month)
{
    case 12:
    case 2:
    case 3:
        Console.WriteLine("Kış Mevsimindesiniz");
        break;

    case 4:
    case 5:
    case 6:
        Console.WriteLine("İlkbahar Mevsimindesiniz");
        break;
    case 7:
    case 8:
    case 9:
    case 10:
    case 11:
        Console.WriteLine("sonbahar mevsimindesiniz");
        break;

    default:
    break;
}