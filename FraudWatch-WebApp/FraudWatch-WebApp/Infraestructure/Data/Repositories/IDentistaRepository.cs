using FraudWatch.Domain.Entities;

namespace FraudWatch.Infraestructure.Data.Repositories;

public interface IDentistaRepository
{
    IEnumerable<DentistaEntity> GetAllDentistas();
    DentistaEntity GetDentistaById(int id);
    DentistaEntity GetDentistaByCro(string cro);
    DentistaEntity AddDentista(DentistaEntity entity);
    DentistaEntity UpdateDentistaById(int id, DentistaEntity entity);
    DentistaEntity DeleteDentistaById(int id);
}
