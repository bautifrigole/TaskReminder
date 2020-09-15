using System.Reflection;
using System.Windows.Media;
using FontAwesome.Sharp;

namespace TestWpf.MaterialDesign
{
    internal static class MaterialDesignFont
    {
        internal static readonly FontFamily FontFamily =
            Assembly.GetExecutingAssembly().LoadFont("fonts", "Material Design Icons");
    }
}
