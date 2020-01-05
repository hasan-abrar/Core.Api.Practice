using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XX.Practice.CoreApi.Model.V1
{
    public class PagingResult<T>
    {
        public int PageSize { get; set; }
        public int TotalResults { get; set; }
        public string FirstPage { get; set; }
        public string LastPage { get; set; }
        public string NextPage { get; set; }
        public string PreviousPage { get; set; }
        public List<T> Results { get; set; }
    }
}
