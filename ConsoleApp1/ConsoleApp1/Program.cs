// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("q = zakończ program\n" +
                      "p = pozdrów\n");
    
    string inp = Console.ReadLine();
    
    if (inp == "q")
    {
        break;
    }
    
    if (inp == "p")
    {
        Console.WriteLine("Pozdrawiam!\n");
    }
    
}