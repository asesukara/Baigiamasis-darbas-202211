using NUnit.Framework;

namespace BaigiamasisDarbas.Test
{
    public class MokiveziTest : BaseTest
    {
        [Test]
        public static void TestMokivezi()
        {
            page6.NavigateToPage();
            page6.AcceptCookies();
        }
    }
}
