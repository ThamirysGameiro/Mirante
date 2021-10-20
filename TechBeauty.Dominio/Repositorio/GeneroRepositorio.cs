using System.Collections.Generic;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class GeneroRepositorio
    {
        public List<Genero> TabelaGenero { get; private set; } = new List<Genero>();

        public GeneroRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(Genero genero)
        {
            TabelaGenero.Add(genero);            
        }

        private void PreencherDados()
        {
            Genero genero1 = Genero.Criar(1, "Feminino");
            Incluir(genero1);

            Genero genero2 = Genero.Criar(2, "Masculino");
            Incluir(genero2);

            Genero genero3 = Genero.Criar(3, "Mulher Trans");
            Incluir(genero3);
        }
    }
}
