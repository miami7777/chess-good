namespace CG.Dto.Token
{
    public class LichessTokenDto
    {
        public string token_type {  get; set; }
        public string access_token { get; set; }
        public long expires_in { get; set; }
    }
}
