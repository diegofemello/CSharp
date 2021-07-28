using System;
using System.Globalization;

namespace Curso
{
  class Produto
  {
    private string _nome;
    public double Preco { get; private set; }
    public int Quantidade { get; private set; }

    public Produto(string nome, double preco, int quantidade)
    {
      _nome = nome;
      Preco = preco;
      Quantidade = quantidade;
    }

    public Produto(string nome, double preco)
    {
      _nome = nome;
      Preco = preco;
      Quantidade = 0;
    }

    public Produto() { }

    public string Nome
    {
      get { return _nome; }
      set
      {
        if (value != null && value.Length > 1)
          _nome = value;
      }
    }

    public double ValorTotalEmEstoque()
    {
      return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
      Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
      Quantidade -= quantidade;
    }

    public override string ToString()
    {
      string muitos = Quantidade <= 1 ? "Unidade" : "Unidades";

      return $"{_nome}, Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade: {Quantidade} {muitos}, Total: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)} ";
    }

    public static void EstoqueProdutos()
    {
      Console.WriteLine("Entre com os dados do produto:");
      Console.Write("Nome: ");
      string nome = Console.ReadLine();
      Console.Write("Preco: ");
      double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Quantidade no estoque: ");
      int quantidade = int.Parse(Console.ReadLine());

      Produto p = new Produto(nome, preco, quantidade);

      Console.WriteLine("Dados do produto:" + p);

      Console.WriteLine();
      Console.Write("Digite o número de produtos a serem adicionados:");
      int qta = int.Parse(Console.ReadLine());
      p.AdicionarProdutos(qta);
      Console.WriteLine();
      Console.WriteLine("Dados atualizados:" + p);


      Console.Write("Digite o número de produtos a serem removidos:");
      int qtr = int.Parse(Console.ReadLine());
      p.RemoverProdutos(qtr);
      Console.WriteLine();
      Console.WriteLine("Dados atualizados:" + p);

    }

    public static void Encapsulamento()
    {
      Produto p = new Produto("TV", 500.10, 10);

      Console.WriteLine(p.Nome);

      p.Nome = "TV 4K";

      Console.WriteLine(p.Nome);

    }


  }
}
