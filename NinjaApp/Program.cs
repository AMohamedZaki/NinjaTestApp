using TestNinja.Mocking;

namespace NinjaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle();
        }
    }
}
