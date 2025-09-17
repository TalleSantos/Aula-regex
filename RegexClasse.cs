using System;
using System.Text.RegularExpressions;



public class RegexClasse
{
    public void reconhecerCPF(string cpf)
    {
        Regex regex = new Regex(@"\d{3}\.\d{3}\.\d{3}-\d{2}");
        if (regex.IsMatch(cpf))
        {
            Console.WriteLine("CPF válido");
            foreach (Match match in regex.Matches(cpf))
            {

                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("CPF inválido");
        }
    }
    public void reconhecerNome(string nome)
    {
        Regex regex = new Regex(@"[A-Z][a-z]*");
        if (regex.IsMatch(nome))
        {
            Console.WriteLine("Nome válido");
            foreach (Match match in regex.Matches(nome))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
