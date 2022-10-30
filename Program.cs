using практическая_работа__4;

peremeshenie_po_datam();
Console.CursorVisible = false;

void peremeshenie_po_datam()
{
    DateOnly date = new DateOnly(2022, 10, 19);
    Note[] notes = zametki();
    int position = 1;
    ConsoleKeyInfo key = Console.ReadKey();
    Console.WriteLine(date);
    do
    {

        if (key.Key == ConsoleKey.RightArrow)
        {
            date = date.AddDays(1);
            Console.Clear();
            Console.WriteLine(date);
        }

        else if (key.Key == ConsoleKey.LeftArrow)
        {
            date = date.AddDays(-1);
            Console.Clear();
            Console.WriteLine(date);
        }

        Console.Clear();
        Console.WriteLine(date);
        foreach (Note item in notes)
        {
            if (item.firstnote == date)
            {
                Console.WriteLine(item.name);
            }
        }
        position = cursor(key, position);
        ConsoleKeyInfo key1 = Console.ReadKey();
        key = key1; ;
    } while (key.Key != ConsoleKey.Enter);

    Console.Clear();
    Console.WriteLine(notes[position].discript);
    Console.WriteLine(notes[position].finaldate);
    if (key.Key == ConsoleKey.Enter)
    {
        peremeshenie_po_datam();
    }
}





int cursor(ConsoleKeyInfo key, int position)
{

    if (key.Key == ConsoleKey.DownArrow)
    {
        position++;
    }
    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;
        if (position < 1)
        {
            position = 1;
        }
    }
    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");

    return position;
}





Note[] zametki()
{
    Note notename1 = new Note();
    notename1.name = "    История";
    notename1.discript = "Сделать историю";
    notename1.firstnote = new DateOnly(2022, 10, 18);
    notename1.finaldate = new DateOnly(2022, 10, 20);

    Note notename2 = new Note();
    notename2.name = "    БЖД";
    notename2.discript = "Нужно повторить БЖД";
    notename2.firstnote = new DateOnly(2022, 10, 20);
    notename2.finaldate = new DateOnly(2022, 10, 22);

    Note notename3 = new Note();
    notename3.name = "    С#";
    notename3.discript = "Сделать практическую по C#";
    notename3.firstnote = new DateOnly(2022, 10, 20);
    notename3.finaldate = new DateOnly(2022, 10, 23);

    Note notename4 = new Note();
    notename4.name = "    Python";
    notename4.discript = "Сделать практическую по Python";
    notename4.firstnote = new DateOnly(2022, 10, 17);
    notename4.finaldate = new DateOnly(2022, 10, 19);

    Note notename5 = new Note();
    notename5.name = "    ААС";
    notename5.discript = "Выучить лекцию";
    notename5.firstnote = new DateOnly(2022, 10, 16);
    notename5.finaldate = new DateOnly(2022, 10, 18);

    Note notename6 = new Note();
    notename6.name = "    Сети";
    notename6.discript = "Сделать лекцию и выучить ее";
    notename6.firstnote = new DateOnly(2022, 10, 15);
    notename6.finaldate = new DateOnly(2022, 10, 17);

    Note[] name = new Note[6];
    name[0] = notename1;
    name[1] = notename2;
    name[2] = notename3;
    name[3] = notename4;
    name[4] = notename5;
    name[5] = notename6;

    return name;
}

/*using практическая_работа__4;
peremeshenie_po_datam();
Console.CursorVisible = false;
void peremeshenie_po_datam()
{
    DateOnly date = new DateOnly(2022, 10, 19);
    Note[] notes = zametki();
    int position = 1;
    ConsoleKeyInfo key = Console.ReadKey();
    do
    {
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.RightArrow)
        {
            date = date.AddDays(1);
            Console.Clear();
            Console.WriteLine(date);
        }
        else if (key.Key == ConsoleKey.LeftArrow)
        {
            date = date.AddDays(-1);
            Console.Clear();
            Console.WriteLine(date);
        }
        Console.Clear();
        Console.WriteLine(date);
        foreach (Note item in notes)
        {
            if (item.firstnote == date)
            {
                Console.WriteLine(item.name);
            }
        }
        position = cursor(key, position);
        ConsoleKeyInfo key1 = Console.ReadKey();
        key = key1;
 
    } while (key.Key != ConsoleKey.Enter);
    Console.Clear();
    Console.WriteLine(notes[position].discript);
    Console.WriteLine(notes[position].firstnote);
    
}
int cursor(ConsoleKeyInfo key, int position)
{
    if (key.Key == ConsoleKey.DownArrow)
    {
        position++;
    }
    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;
        if (position < 1)
        {
            position = 1;
        }
    }
    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");
    return position;
}
Note[] zametki()
{
    Note notename1 = new Note();
    notename1.name = "    История";
    notename1.discript = "Сделать историю";
    notename1.firstnote = new DateOnly(2022, 10, 18);
    Note notename2 = new Note();
    notename2.name = "    БЖД";
    notename2.discript = "Нужно повторить БЖД";
    notename2.firstnote = new DateOnly(2022, 10, 20);
    Note notename3 = new Note();
    notename3.name = "    С#";
    notename3.discript = "Сделать практическую по C#";
    notename3.firstnote = new DateOnly(2022, 10, 20);
    Note notename4 = new Note();
    notename4.name = "    Python";
    notename4.discript = "Сделать практическую по Python";
    notename4.firstnote = new DateOnly(2022, 10, 17);
    Note notename5 = new Note();
    notename5.name = "    ААС";
    notename5.discript = "Выучить лекцию";
    notename5.firstnote = new DateOnly(2022, 10, 16);
    Note notename6 = new Note();
    notename6.name = "    Сети";
    notename6.discript = "Сделать лекцию и выучить ее";
    notename6.firstnote = new DateOnly(2022, 10, 15);
    Note[] name = new Note[6];
    name[0] = notename1;
    name[1] = notename2;
    name[2] = notename3;
    name[3] = notename4;
    name[4] = notename5;
    name[5] = notename6;
    return name;
}*/