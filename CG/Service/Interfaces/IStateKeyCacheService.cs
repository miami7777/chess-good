using Newtonsoft.Json.Linq;

namespace CG.Interfaces;

/// <summary>
/// Интерфейс взаимодействия с кэшем маркеров сеанса.
/// </summary>
public interface IStateKeyCacheService
{
    /// <summary>
    /// Добавить/Переустановить маркер в кэш.
    /// </summary>
    /// <param name="provider">Поставщик, префикс ключа.</param>
    /// <param name="state">Маркер.</param>
    public Task UpsertStateKey(string provider,string code_verifier, string state);

    /// <summary>
    /// Добавить/Переустановить маркер Lichess в кэш.
    /// </summary>
    /// <param name="state"></param>
    /// <returns></returns>
    public Task UpsertLichessStateKey(string code_verifier, string state);
        
    /// <summary>
    /// Проверить маркер сеанса.
    /// </summary>
    /// <param name="provider">Поставщик, префикс ключа.</param>
    /// <param name="state">Маркер.</param>
    /// <returns>true - маркер актуален, иначе - false.</returns>
    public Task<bool> CheckStateKey(string provider, string state);

    /// <summary>
    /// Проверить маркер сеанса Lichess.
    /// </summary>
    /// <param name="state">Маркер.</param>
    /// <returns>true - маркер актуален, иначе - false.</returns>
    public Task<bool> CheckLichessStateKey(string state);
    /// <summary>
    /// Получить code_verifier
    /// </summary>
    /// <param name="state"></param>
    /// <returns></returns>
    public string GetCodeVerifier(string state);
    public Task UpsertLichessUserToken(string userName, string token);
    public string GetUserToken(string userName);

}