
int parsuj(string a)
{
    if (int.TryParse(a, out int wynik))
    {
        return wynik;
    }
    else
        return 99;
}

double p_prostokonta(double a, double b)
{
    return a * b;
}

double p_trojkata(double a, double h)
{
    return (a*h)/2;
}

double p_kwadratu(double a)
{
    return a * a;
}

double p_kola(double r)
{
    return 3.14 * r * r;
}

int silnia(int n)
{
    if (n == 1)
    {
        return n;
    }
    else
        return n * silnia(n - 1);
}

double parsuj_double(string a)
{
    if (double.TryParse(a.Replace('.',','), out double wynik))
    {
        return wynik;
    }
    else
        return 99;
}




while (true)
{
    Console.WriteLine("\n");
    Console.Write("Wybierz:\n0 jeżeli chcesz zakończyć program\n1 jeżeli chcesz wykonać silnię\n2 jeżeli chcesz obliczyć pole prostokonta\n3 jeżeli chcesz obliczyć pole kawadratu\n4 jeżeli chcesz obliczyć pole trójkąta\n5 jeżeli chcesz obliczyć pole koła\n");
    string wybor = Console.ReadLine();
    int p_wybor = parsuj(wybor);
    if (p_wybor == 0)
    {
        break;
    }
    else if (p_wybor == 1) 
    {
        Console.Write("Podaj liczbę do silni: ");
        string w_s = Console.ReadLine();
        int p_w_s = parsuj(w_s);
        if (p_w_s != 99)
        {
            int wynik_silni = silnia(p_w_s);
            Console.WriteLine("Silnia wynosi: " + wynik_silni);
        }
        else
            Console.WriteLine("Niepoprawna liczba"); 
    }
    else if (p_wybor == 2)
    {
        Console.Write("Wpisz a prostokonta: ");
        string a = Console.ReadLine();
        double p_a = parsuj_double(a);
        Console.Write("Wpisz b prostokonta: ");
        string b = Console.ReadLine();
        double p_b = parsuj_double(b);

        if (p_a == 99 || p_b == 99)
        {
            Console.WriteLine("Niepoprawne dane");
        }
        else
            Console.WriteLine("Pole wynosi: " + p_prostokonta(p_a, p_b));
    }
    else if (p_wybor == 3)
    {
        Console.Write("Wpisz a kwadratu: ");
        string a = Console.ReadLine();
        double p_a = parsuj_double(a);

        if (p_a == 99)
        {
            Console.WriteLine("Niepoprawne dane");
        }
        else
            Console.WriteLine("Pole wynosi: " + p_kwadratu(p_a));
    }
    else if (p_wybor == 4)
    {
        Console.Write("Wpisz a trójkąta: ");
        string a = Console.ReadLine();
        double p_a = parsuj_double(a);
        Console.Write("Wpisz h trójkąta: ");
        string h = Console.ReadLine();
        double p_h = parsuj_double(h);

        if (p_a == 99 || p_h == 99)
        {
            Console.WriteLine("Niepoprawne dane");
        }
        else
            Console.WriteLine("Pole wynosi: " + p_trojkata(p_a,p_h));
    }
    else if (p_wybor == 5)
    {
        Console.Write("Wpisz r koła: ");
        string r = Console.ReadLine();
        double r_a = parsuj_double(r);

        if (r_a == 99)
        {
            Console.WriteLine("Niepoprawne dane");
        }
        else
            Console.WriteLine("Pole wynosi: " + p_kola(r_a));
    }
    else
        Console.WriteLine("Nieznany wybor");



}
