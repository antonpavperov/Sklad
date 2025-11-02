using Sklad2.Core;
namespace ForDbug

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext data = new DataContext();

            data.Database.EnsureCreated();
        }
    }
}
