using Microsoft.DotNet.Scaffolding.Shared;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.Extensions.Caching.Distributed;
using Mono.TextTemplating;
using Newtonsoft.Json.Linq;
using NuGet.ProjectModel;
using NuGet.Protocol;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using CG.Domain.Enum;
using CG.Helpers;
using CG.Interfaces;
using static CG.Helpers.CacheHelper;

namespace SSO.Api.CacheServices.Implementation;

/// <summary>
/// Кэш-сервис маркеров сеанса.
/// </summary>
public class StateKeyCacheService : IStateKeyCacheService
{
    private const string LichessKey = "LichessCache";
    private const string LichessToken = "LichessToken";

    /// <summary>
    /// Конструктор <see cref="StateKeyCacheService"/>.
    /// </summary>
    /// <param name="cache"></param>
    public StateKeyCacheService()
    {
        if (CacheHelper.GetFromCache(CacheType.LichessOAuth, "LichessCache") == null)
        {
            CacheHelper.AddToCache(CacheType.LichessOAuth, "LichessCache", null);
        }
    }

    /// <inheritdoc />
    public async Task UpsertStateKey(string provider, string code_verifier, string state)
    {
        if (string.IsNullOrEmpty(provider) || string.IsNullOrEmpty(code_verifier) || string.IsNullOrEmpty(state)) return;
        Dictionary<string,Dictionary<string,string>> parameters = new Dictionary<string,Dictionary<string,string>>();
        Dictionary<string,string> values = new Dictionary<string,string>();
        values.Add(state, code_verifier);
        parameters.Add("LichessCache"+state, values);        
        CacheHelper.RemoveFromCache(CacheType.LichessOAuth, "LichessCache");
        CacheHelper.AddToCache(CacheType.LichessOAuth, "LichessCache", parameters);
        var result = CacheHelper.GetFromCache(CacheType.LichessOAuth, "LichessCache");
    }

    /// <inheritdoc />
    public async Task UpsertLichessStateKey(string code_verifier, string state)
        => await UpsertStateKey(LichessKey, code_verifier, state);

  

    /// <inheritdoc />
    public async Task<bool> CheckStateKey(string provider,string state)
    {
        try
        {
            if (string.IsNullOrEmpty(provider) || string.IsNullOrEmpty(state)) return false;

            var result = CacheHelper.GetFromCache(CacheType.LichessOAuth, "LichessCache") is Dictionary<string,Dictionary<string,string>> value && value.ContainsKey("LichessCache" + state);
            if (!result) return false;           

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    /// <inheritdoc />
    public async Task<bool> CheckLichessStateKey(string state)
        => await CheckStateKey(LichessKey, state);

    public string GetCodeVerifier(string state)
    {
        
        if (string.IsNullOrEmpty(state)) return null;

        var result = CacheHelper.GetFromCache(CacheType.LichessOAuth, "LichessCache") is Dictionary<string, Dictionary<string,string>> value && value.ContainsKey("LichessCache" + state);
        if (!result) return null;
        var res = CacheHelper.GetFromCache(CacheType.LichessOAuth, "LichessCache").ToJToken();
        var token = res.SelectToken("LichessCache" + state)[state].ToString();        
        return token;        
    }
    public async Task UpsertLichessUserToken(string userName, string token)
    {       
        if (string.IsNullOrEmpty(LichessToken) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(token)) return;
        Dictionary<string, Dictionary<string, string>> parameters = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, string> values = new Dictionary<string, string>();
        values.Add(userName, token);
        parameters.Add("LichessCache" + userName, values);
        CacheHelper.RemoveFromCache(CacheType.LichessOAuth, "LichessCache");
        CacheHelper.AddToCache(CacheType.LichessOAuth, "LichessCache", parameters);
        var result = CacheHelper.GetFromCache(CacheType.LichessOAuth, "LichessCache");
    }

    public string GetUserToken(string userName)
    {
        if (string.IsNullOrEmpty(userName)) return null;

        var result = CacheHelper.GetFromCache(CacheType.LichessOAuth, "LichessCache") is Dictionary<string, Dictionary<string, string>> value && value.ContainsKey("LichessCache" + userName);
        if (!result) return null;
        var res = CacheHelper.GetFromCache(CacheType.LichessOAuth, "LichessCache").ToJToken();
        var token = res.SelectToken("LichessCache" + userName)[userName].ToString();
        return token;
    }
}