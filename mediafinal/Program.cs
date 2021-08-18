using System;

namespace Start {

  class Program {

    static void Main(string[] args) {

      double a, b, c, d,avg,mF;
      string[] values = Console.ReadLine().Split(' ');
      a = double.Parse(values[0]);
      b = double.Parse(values[1]);
      c = double.Parse(values[2]);
      d = double.Parse(values[3]);

      avg = (((a*2)+(b*3)+(c*4)+(d*1))/10);
      Console.WriteLine("Media: " +avg.ToString("0.0"));

      if ( avg >= 7.0 ) 
      {
       Console.WriteLine("Aluno aprovado.");
      }

      else if ( avg < 5.0 ) 
      {
       Console.WriteLine("Aluno reprovado.");
      }

      else if ( avg <= 6.9 && avg >= 5.0) 
      {
       Console.WriteLine("Aluno em exame.");

       double e = double.Parse(Console.ReadLine());
       Console.WriteLine("Nota do exame: {0}",e);

       mF = ( avg + e ) / 2;        
       if (mF >= 5.0 ) 
       {
        Console.WriteLine("Aluno aprovado.");
       } else if (mF < 5.0 ) {
        Console.WriteLine("Aluno reprovado");
       }
       Console.WriteLine("Media final: " +mF.ToString("0.0"));  
      }
      
    }
  }
}