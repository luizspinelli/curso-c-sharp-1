using System;

namespace ListaDeConvidados
{
  class Program
  {
    private static string[] ListaDeConvidados = {
          "Daniel",
          "Evandro",
          "Amanda",
          "Felipe",
          "Luiz"
      };
    static void Main(string[] args)
    {
      Console.WriteLine("Informe o nome do convidado");
      var nome = Console.ReadLine();

      if (nome == null || string.IsNullOrEmpty(nome))
      {
        Console.WriteLine("Nome não informado para seguir com execução");
        return;
      }

      Console.WriteLine("Informe a idade do convidado");
      var idadeStr = Console.ReadLine();
      int idade;

      bool idadeInformada = int.TryParse(idadeStr, out idade);

      if (!idadeInformada)
      {
        Console.WriteLine("Idade informada não é valida");
        return;
      }

      bool estaConvidado;
      switch (nome)
      {
        case "Daniel":
          estaConvidado = true;
          break;
        case "Evandro":
          estaConvidado = true;
          break;
        case "Amanda":
          estaConvidado = true;
          break;
        case "Felipe":
          estaConvidado = true;
          break;
        case "Luiz":
          estaConvidado = true;
          break;
        default:
          estaConvidado = false;
          break;
      }

      if (estaConvidado && idade > 18)
      {
        Console.WriteLine("Parabens seja bem vindo a festa");
      }
      else if (!estaConvidado)
      {
        Console.WriteLine(nome + " não foi convidado(a) para a festa");
      }
      else
      {
        Console.WriteLine("Você não tem 18 anos para entrar na festa");
      }
    }
  }
}
