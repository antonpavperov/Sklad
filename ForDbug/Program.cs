using Mapster;
using Sklad2.Core;
using Sklad2.Core.OutputModels;
using Sklad2.DAL;
namespace ForDbug

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext data = new DataContext();

            ApplicationRepository repository = new ApplicationRepository(data);

            var a = repository.GetAll();

            var b = a[1].Adapt<ApplicationOutputModel>(); 
        }
    }
}
