using ContaDomain.Entities;

namespace ContaRepository.Interfaces
{
    public interface IContaRepository : IBaseRepository<ContaLuz>
    {
        ContaLuz GetMaiorConsumo();
        ContaLuz GetMenorConsumo();    
    }
}