public class ContaPoupanca extends Conta {
    
    public ContaPoupanca(Cliente cliente){
        super(cliente);
    }
    
    public void gerarExtrato(){
        System.out.println("==== Extrato Conta Poupança ====");
        System.out.println(this);
    }
}
