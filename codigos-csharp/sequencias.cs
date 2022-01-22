using System; 

class DIO {

    static void Main(string[] args) { 

      double a, c, S= 0;
            for (int i = 1; i <=100; i++)
            {
                c = (double)1/(double)i;  //coloque a sua lógica nos espaços em branco
                S = S + c;
            }
            var x=Math.Round(S,2);
            Console.WriteLine(x);

    }

}
