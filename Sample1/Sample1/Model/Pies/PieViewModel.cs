using System.Collections.Generic;

namespace Sample.Model.Pies
{
    using DataModel;

    public class PieViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
