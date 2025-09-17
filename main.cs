using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Usando Regex");
        RegexClasse rg = new RegexClasse();

        rg.reconhecerCPF("123.456.789-00");
        rg.reconhecerCPF("12345678900");
        rg.reconhecerCPF("Jão");
    }
}