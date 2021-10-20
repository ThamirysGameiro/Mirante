using System.Collections.Generic;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class TipoContatoRepositorio
    {
        public List<TipoContato> TabelaTipoContato { get; set; } = new List<TipoContato>();

        public TipoContatoRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(TipoContato tipo)
        {
            TabelaTipoContato.Add(tipo);            
        }

        private void PreencherDados()
        {
            Incluir(TipoContato.Criar(1, "Telefone"));
            Incluir(TipoContato.Criar(2, "Instagram"));
            Incluir(TipoContato.Criar(1, "Tiktok"));
        }
    }
}
