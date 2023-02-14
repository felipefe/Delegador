// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;

public class Delegador
{
    public List<int> Inteiros = new List<int> { 1, 2, 3, 4 };
    public bool ExistsTwo => FindInteiros(2);
    public bool ExistsFive => FindInteiros(5);

    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // if (IsValid()) Console.WriteLine("Quadrado");

        var d = new Delegador();
        // Console.WriteLine(d.ExistsTwo);
        // Console.WriteLine(d.ExistsFive);
        d.Teste();
    }

    public bool FindInteiros(int value) => Inteiros != null && Inteiros.Count > 0 ? Inteiros.Any(x => x == value) : false;

    public static bool IsValid() => Math.Pow(2, 2) == 4;

    public void Teste()
    {
        // Func<int, bool> Exists = FindInteiros;

        // Console.WriteLine(Exists(5));
        // Console.WriteLine(Exists(4));
        // Console.WriteLine(Exists(7));

        // Func<int, bool> IsPar = value => value % 2 == 0;
        // Console.WriteLine(IsPar(4));

        // Func<long, long, bool> Retangular = (ladoA, ladoB) => ladoA > 0 && ladoB > 0 && ladoA != ladoB;
        // Console.WriteLine(Retangular(4,8));

        var d = new Delegador();
        Func<int, string> ParOuImpar = d.IsImpar;
        var n1 = ParOuImpar;
        var n2 = ParOuImpar;
        Console.WriteLine(n1(4));
        Console.WriteLine(n2(7));

    }

    public string IsImpar(int value) => value % 2 == 1 ? "Impar" : "Par";
}
