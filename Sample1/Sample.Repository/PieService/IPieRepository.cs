using System.Collections.Generic;

namespace Sample.Repository
{
    using DataModel;

    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
