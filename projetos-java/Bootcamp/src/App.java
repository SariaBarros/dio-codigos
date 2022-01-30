import java.time.LocalDate;

import br.com.dio.desafio.Bootcamp;
import br.com.dio.desafio.Curso;
import br.com.dio.desafio.Dev;
import br.com.dio.desafio.Mentoria;

public class App {
    public static void main(String[] args) throws Exception {
        Curso curso1 = new Curso();
        Curso curso2 = new Curso();
        Mentoria mentoria1 = new Mentoria();
        Mentoria mentoria2 = new Mentoria();

        curso1.setTitulo("curso java");
        curso1.setDescricao("descricao");
        curso1.setCargaHoraria(8); 

        curso2.setTitulo("curso C");
        curso2.setDescricao("descricao curso C");
        curso2.setCargaHoraria(18); 

        mentoria1.setTitulo("mentoria java");
        mentoria1.setDescricao("descricao mentoria");
        mentoria1.setData(LocalDate.now());

        mentoria2.setTitulo("mentoria C");
        mentoria2.setDescricao("descricao mentoria C");
        mentoria2.setData(LocalDate.now());


        Bootcamp bootcamp = new Bootcamp();
        bootcamp.setNome("Bootcamp java");
        bootcamp.setDescricao("Descricao do bootcamp java");
        bootcamp.getConteudos().add(curso1);
        bootcamp.getConteudos().add(curso2);
        bootcamp.getConteudos().add(mentoria1);
        bootcamp.getConteudos().add(mentoria2);

        Dev devVitoria = new Dev();
        devVitoria.setNome("Vitoria");
        devVitoria.inscreverBootcamp(bootcamp);
        System.out.println("Conteudos Inscritos: " + devVitoria.getConteudosInscritos());
        devVitoria.progredir();
        System.out.println("XP: " + devVitoria.calcularTotalXP());
        devVitoria.progredir();
        System.out.println("Conteudos Concluidos: " + devVitoria.getConteudosConcluidos());
        System.out.println("XP: " + devVitoria.calcularTotalXP());


    }
}
