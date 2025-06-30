using Duende.IdentityServer.Models;
using Newtonsoft.Json.Serialization;
using SSO.Api.Dto.Token;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using CG.Domain.Entities;
using CG.Dto.RequestMessage;
using CG.Dto.ResponseMessage;
using CG.Helpers;
using CG.Interfaces;
using CG.Models.Lichess;
using CG.HttpServices.Interfaces;
using static SSO.Api.Extensions.UriExtensions;

namespace CG.HttpServices.Implementation;

/// <summary>
/// Http-сервис для взаимодействия с Lichess.
/// </summary>
public class LichessService : ILichessService
{ 
    private readonly IHttpHelper _httpHelper;

    public LichessService(IHttpHelper httpHelper)
    {
        _httpHelper = httpHelper;
    }

    public async Task<ResponseBulkPairing> CreateBulkPairing(RequestBulkPairing requestBulkPairing, string token)
    {
        var response = await _httpHelper.SendPostAsync($"/api/bulk-pairing", requestBulkPairing,token,"LichessClient");

        var bulkPairings = await HttpHelper.ParseHttpJsonResponseMessage<ResponseBulkPairing>(response,
                new SnakeCaseNamingStrategy());
        return bulkPairings;
    }

    public async Task<LichessAccountDto> GetLichessUser(string user,string token)
    {
        
        if (string.IsNullOrEmpty(user))
            throw new NullReferenceException("User was null or empty.");
       
        var response = await _httpHelper.SendGetAsync($"/api/account",token);

        var profile = await HttpHelper.ParseHttpJsonResponseMessage<LichessAccountDto>(response,
                new SnakeCaseNamingStrategy());
        return profile;
    }
}