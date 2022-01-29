public class ContaCorrente extends Conta{
    
    public ContaCorrente(Cliente cliente){
        super(cliente);
    }

    @Override
    public void gerarExtrato(){
        System.out.println("==== Extrato Conta Corrente ====");
        System.out.println(this);
    }

}
