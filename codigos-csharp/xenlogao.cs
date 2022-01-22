using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int C = Convert.ToInt32(Console.ReadLine());
            int numDivisores;
            int resposta=0;
            
            while(C > 0){
            int N = Convert.ToInt32(Console.ReadLine());
                numDivisores =(int) Math.Sqrt(N);
                resposta = N - numDivisores;
                Console.WriteLine(resposta);
              C--;
            }
        }
    }
}
