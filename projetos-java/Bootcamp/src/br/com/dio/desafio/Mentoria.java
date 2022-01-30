package br.com.dio.desafio;

import java.time.LocalDate;

public class Mentoria extends Conteudo{
    // Atributos
    
    private LocalDate data;

    public Mentoria(){

    }
    // getters e setters

    public LocalDate getData() {
        return data;
    }

    public void setData(LocalDate data) {
        this.data = data;
    }
    @Override
    public double calcularXP(){
        return XP_PADRAO + 20d;
    }

    @Override
    public String toString() {
        return "Mentoria{" +
                "titulo= '" + super.getTitulo() + '\'' +
                ", descricao='" + super.getDescricao() + '\''+
                ", data=" + data + '}';
    }
}
