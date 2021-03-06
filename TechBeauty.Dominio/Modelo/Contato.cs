namespace TechBeauty.Dominio.Modelo
{
    public class Contato
    {
        public int Id { get; private set; }
        public TipoContato Tipo { get; private set; }
        public string Valor { get; private set; }

        public static Contato Criar(int id, TipoContato tipo, string valor)
        {
            Contato contato = new Contato();
            contato.Id = id;
            contato.Tipo = tipo;
            contato.Valor = valor;

            return contato;
        }
    }
}
