using System;

namespace VarAndConsts
{
  class Program
  {
    static void Main(string[] argumentos)
    {
      const string constante = "uma constante que não muda";

      if (argumentos.Length == 0)
      {
        Console.WriteLine("Favor informar um numero");
        return;
      }
      int inteiro;
      bool teste = int.TryParse(argumentos[0], out inteiro);

      if (teste == false)
      {
        Console.WriteLine("O argumento informado não é um inteiro");
        return;
      }

      Console.WriteLine(constante);
      Console.WriteLine("O número informado foi: " + inteiro);
    }
  }
}
