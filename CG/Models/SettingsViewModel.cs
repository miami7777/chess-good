namespace CG.Models
{
    public class SettingsViewModel
    {
        public Dictionary<string,string> settingsHeaders {  get; set; }
        public List<string> menu { get; set; }
        public List<string> footer_menu { get; set; }
        public List<string> service_menu { get; set; }

    }
}
