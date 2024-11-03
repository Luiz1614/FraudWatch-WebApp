using FraudWatch.Application.DTOs;
using FraudWatch.Domain.Entities;

namespace FraudWatch.Application.Interfaces;

public interface IAnalistaApplicationService
{
    IEnumerable<AnalistaEntity> GetAll();
    AnalistaEntity GetById(int id);
    AnalistaEntity GetByDepartamento(string departamento);
    AnalistaEntity Add(AnalistaDTO analistaDTO);
    AnalistaEntity Update(int id, AnalistaDTO analistaDTO);
    AnalistaEntity DeleteById(int id);
}
