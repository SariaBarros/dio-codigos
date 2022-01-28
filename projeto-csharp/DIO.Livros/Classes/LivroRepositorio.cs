using System;
using System.Collections.Generic;
using DIO.Livros.Interfaces;

namespace DIO.Livros
{
    public class LivroRepositorio : IRepositorio<Livros>
    {
        private List<Livros> listaLivro = new List<Livros>();
        public void Atualiza(int id, Livros objeto)
        {
            listaLivro[id] = objeto;
        }
        public void Exclui(int id)
        {
            listaLivro[id].Exclui();
        }

        public void Insere(Livros entidade)
        {
            listaLivro.Add(entidade);
        }

        public List<Livros> Lista()
        {
            return listaLivro;
        }

        public int Proximoid()
        {
            return listaLivro.Count;
        }

        public Livros retornaPorId(int id)
        {
            return listaLivro[id];
        }
    }
}