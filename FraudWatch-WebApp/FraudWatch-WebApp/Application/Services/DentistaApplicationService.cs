using FraudWatch.Application.DTOs;
using FraudWatch.Application.Interfaces;
using FraudWatch.Domain.Entities;
using FraudWatch.Infraestructure.Data.Repositories;

namespace FraudWatch.Application.Services;


public class DentistaApplicationService : IDentistaApplicationService
{
    private readonly IDentistaRepository _dentistaRepository;

    public DentistaApplicationService(IDentistaRepository dentistaRepository)
    {
        _dentistaRepository = dentistaRepository;
    }

    public DentistaEntity Add(DentistaDTO dentistaDTO)
    {
        return _dentistaRepository.AddDentista(new DentistaEntity
        {
            Nome = dentistaDTO.Nome,
            Email = dentistaDTO.Email,
            CPF = dentistaDTO.CPF,
            CRO = dentistaDTO.CRO
        });
    }

    public DentistaEntity DeleteById(int id)
    {
        return _dentistaRepository.DeleteDentistaById(id);
    }

    public IEnumerable<DentistaEntity> GetAll()
    {
        return _dentistaRepository.GetAllDentistas();
    }

    public DentistaEntity GetByCro(string cro)
    {
        return _dentistaRepository.GetDentistaByCro(cro);
    }

    public DentistaEntity GetById(int id)
    {
        return _dentistaRepository.GetDentistaById(id);
    }

    public DentistaEntity Update(int id, DentistaDTO dentistaDTO)
    {
        return _dentistaRepository.UpdateDentistaById(id, new DentistaEntity
        {
            Nome = dentistaDTO.Nome,
            Email = dentistaDTO.Email,
            CPF = dentistaDTO.CPF,
            CRO = dentistaDTO.CRO
        });
    }
}
