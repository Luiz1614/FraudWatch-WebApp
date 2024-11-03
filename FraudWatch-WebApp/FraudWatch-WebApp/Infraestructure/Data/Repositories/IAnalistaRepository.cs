using FraudWatch.Domain.Entities;

namespace FraudWatch.Infraestructure.Data.Repositories;

public interface IAnalistaRepository
{
    IEnumerable<AnalistaEntity> GetAllAnalistas();
    AnalistaEntity GetAnalistaById(int id);
    AnalistaEntity GetAnalistaByDepartamento(string departamento);
    AnalistaEntity AddAnalista(AnalistaEntity entity);
    AnalistaEntity UpdateAnalistaByID(int id, AnalistaEntity entity);
    AnalistaEntity DeleteAnalistaById(int id);
}
