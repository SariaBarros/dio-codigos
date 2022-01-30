package br.com.dio.desafio;

public class Curso extends Conteudo{
    // Atributos

    private int cargaHoraria;
    
    public Curso(){

    }
    // Getters e setters

    public int getCargaHoraria() {
        return cargaHoraria;
    }
    public void setCargaHoraria(int cargaHoraria) {
        this.cargaHoraria = cargaHoraria;
    }

    // Métodos
    @Override
    public double calcularXP(){
        return XP_PADRAO * cargaHoraria;
    }
    @Override
    public String toString() {
        return "Curso{" +
                "titulo= '" + getTitulo() + '\'' +
                ", descricao='" + getDescricao() + '\''+
                ", cargaHoraria=" + cargaHoraria + '}';
    }

}
