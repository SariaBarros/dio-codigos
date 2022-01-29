public class App {
    public static void main(String[] args) throws Exception {
        
        Cliente cliente1 = new Cliente("Vitória Barros", "123.456.789-00");
        Cliente cliente2 = new Cliente("Vitor Barros", "120.450.780-00");

        

        Conta cc1 = new ContaCorrente(cliente1);
        Conta cp1 = new ContaPoupanca(cliente1);

        Conta cc2 = new ContaCorrente(cliente2);
        Conta cp2 = new ContaPoupanca(cliente2);

        cc1.depositar(100);
        cc1.sacar(20);
        cc1.transferir(50, cp1);
        
        cc2.depositar(1000);
        cc2.sacar(250);
        cc2.transferir(500, cp2);
        
        
        cc1.gerarExtrato();
        cp1.gerarExtrato();
        cc2.gerarExtrato();
        cp2.gerarExtrato();

    }
}
