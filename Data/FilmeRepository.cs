using Asp_mvc.Models;

namespace Asp_mvc.Data
{
    public class FilmeRepository : IFilmeRepository
    {
        public Filme ObterFilme()
        {
            return new Filme();
        }
    }
}
