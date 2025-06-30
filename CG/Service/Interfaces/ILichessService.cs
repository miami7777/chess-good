
using CG.Dto.RequestMessage;
using CG.Dto.ResponseMessage;
using CG.Models.Lichess;

namespace CG.HttpServices.Interfaces;

/// <summary>
/// Интерфейс взаимодействия с Lichess.
/// </summary>
public interface ILichessService
{
    public Task<LichessAccountDto> GetLichessUser(string user,string token);
    public Task<ResponseBulkPairing> CreateBulkPairing(RequestBulkPairing user, string token);
}