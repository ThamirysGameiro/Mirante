using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Csl
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneroRepositorio repoGenero = new GeneroRepositorio();
            TipoContatoRepositorio repoTipoContato = new TipoContatoRepositorio();
            ContatoRepositorio repoContato = new ContatoRepositorio(repoTipoContato.TabelaTipoContato);
            CargoRepositorio repoCargo = new CargoRepositorio();

            repoCargo.Alterar(1, "Thamy", "Gameiro");
        }
    }
}
