namespace PoleCiselVcTestu.Tests
{
    public class UnitTest1
    {
        PoleCisel mojePoleCisel = new PoleCisel();
        double vysledek = 0;

        [Fact]
        public void TestVratNejvyssiCislo()
        {
            int[] PoleCisel1 = { 2, 5, 4, 9, 6 };
            vysledek = mojePoleCisel.VratNejvyssiCislo(PoleCisel1);
            Assert.Equal(9, vysledek);

            int[] PoleCisel2 = { 10, 3, 2, 8, 4, 0, 12 };
            vysledek = mojePoleCisel.VratNejvyssiCislo(PoleCisel2);
            Assert.Equal(12, vysledek);

            int[] PoleCisel3 = { -2, 7, -5, 1, 8, 0, 10 };
            vysledek = mojePoleCisel.VratNejvyssiCislo(PoleCisel3);
            Assert.Equal(10, vysledek);
        }

        [Fact]
        public void TestVratNejnizsiCislo()
        {
            int[] PoleCisel1 = { 2, 5, 4, 9, 6 };
            vysledek = mojePoleCisel.VratNejnizsiCislo(PoleCisel1);
            Assert.Equal(2, vysledek);

            int[] PoleCisel2 = { 10, 3, 2, 8, 4, 0, 12 };
            vysledek = mojePoleCisel.VratNejnizsiCislo(PoleCisel2);
            Assert.Equal(0, vysledek);

            int[] PoleCisel3 = { -2, 7, -5, 1, 8, 0, 10 };
            vysledek = mojePoleCisel.VratNejnizsiCislo(PoleCisel3);
            Assert.Equal(-5, vysledek);
        }

        [Fact]
        public void TestVratPrumer()
        {
            int[] PoleCisel1 = { 2, 5, 4, 9, 6 };
            vysledek = mojePoleCisel.VratPrumer(PoleCisel1);
            Assert.Equal(5, vysledek);

            int[] PoleCisel2 = { 10, 3, 2, 8, 4, 0, 12 };
            vysledek = mojePoleCisel.VratPrumer(PoleCisel2);
            Assert.Equal(5, vysledek);

            int[] PoleCisel3 = { -2, 7, -5, 1, 8, 0, 10 };
            vysledek = mojePoleCisel.VratPrumer(PoleCisel3);
            Assert.Equal(2, vysledek);
        }
    }
}