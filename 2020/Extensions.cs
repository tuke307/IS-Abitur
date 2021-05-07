using System.Drawing;

namespace ISVORABI
{
    public static class Extensions
    {
        public static Color BoolToColor(this bool value)
        {
            if (value)
            {
                return Color.Red;
            }
            else
            {
                return Color.Transparent;
            }
        }
    }
}
