using System.ComponentModel;

namespace CG.Models.Enum
{
    public enum FooterMenu
    {
        [Description("home/about")]
        About,
        [Description("home/offerta")]
        Offerta,
        [Description("home/plan")]
        Plan,
        [Description("home/privacy")]
        Privacy,
        [Description("home/licenzion")]
        Licenzion        
    }
    public enum ServiceMenu
    {
        [Description("courses")]
        Courses,
        [Description("webinars")]
        Webinars,
        [Description("practics")]
        Practics,
        [Description("tariffs/individual")]
        Individual,
        [Description("tariffs/group")]
        Group
    }
}
