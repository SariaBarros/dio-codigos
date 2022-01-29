public abstract class Conta {
    private static final int AGENCIA_PADRAO = 1;
    private static int SEQUENCIAL = 1;
    
    // Atributos
    protected int agencia;
    protected int numero;
    protected double saldo;
    protected Cliente cliente;

    public Conta(Cliente cliente){
        this.agencia = AGENCIA_PADRAO;
        this.numero = SEQUENCIAL++;
        this.saldo = 0.0;
        this.cliente = cliente;
    }

    // Métodos
    public void sacar(double valor){
        if(valor < saldo){
            setSaldo(saldo - valor);
        }
        else{
            System.out.println("Saldo indispovível!");
        }
    }
    public void depositar(double valor){
        setSaldo(saldo + valor);
    }
    public void transferir(double valor, Conta contaDestino){
        this.sacar(valor);
        contaDestino.depositar(valor);
    }

    // Getters e Setters
    public int getAgencia() {
        return agencia;
    }
    public int getNumero() {
        return numero;
    }
    public double getSaldo() {
        return saldo;
    }
    private void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public void gerarExtrato(){

    }

    @Override
    public String toString() {
        // TODO Auto-generated method stub
        String texto;
        texto = "Titular: "+ this.cliente.getNome()+"\n" + "Agencia: " + this.agencia + "\n" + 
        "Numero: " + this.numero + "\n"+ "Saldo: " + this.saldo + "\n";
        return texto;
    }
}
