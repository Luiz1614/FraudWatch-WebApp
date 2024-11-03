using FraudWatch.Application.DTOs;
using FraudWatch.Domain.Entities;

namespace FraudWatch.Application.Interfaces;

public interface IDentistaApplicationService
{
    IEnumerable<DentistaEntity> GetAll();
    DentistaEntity GetById(int id);
    DentistaEntity GetByCro(string cro);
    DentistaEntity Add(DentistaDTO dentistaDTO);
    DentistaEntity Update(int id, DentistaDTO dentistaDTO);
    DentistaEntity DeleteById(int id);
}
