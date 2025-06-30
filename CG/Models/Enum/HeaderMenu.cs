using System.ComponentModel;

namespace CG.Models.Enum
{
    public enum HeaderMenu
    {
        [Description("home/about")]
        About,
        [Description("courses")]
        Courses,
        [Description("home/trainers")]
        Trainers,
        [Description("webinars")]
        Webinars,
        [Description("home/pricing")]
        Pricing,
        [Description("home/faq")]
        FAQ,
        [Description("home/contact")]
        Contact
    }
}
