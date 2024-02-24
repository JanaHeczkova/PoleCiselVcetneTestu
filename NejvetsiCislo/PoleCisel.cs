using System.Runtime.Serialization.Formatters;

namespace PoleCiselVcTestu
{
    public class PoleCisel
    {
        public int VratNejvyssiCislo(int[] PoleCisel)
        {
            return PoleCisel.Max();
        }
        public int VratNejnizsiCislo(int[] PoleCisel)
        {
            return PoleCisel.Min();
        }

        public int VratPrumer(int[] PoleCisel)
        {
            return (int)PoleCisel.Average();
        }
    }

}