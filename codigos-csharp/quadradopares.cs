using System; 

class DIO {

    static void Main(string[] args) { 

      int n = int.Parse(Console.ReadLine());
            for(int i = 2; i <=n; i = i+2)
            {
                int b =  i  ;          //escreva o seu código nos espaços em branco
                b =    i*i      ;
                Console.WriteLine(i + "^2"+ " = " + b);
            }

    }

}

