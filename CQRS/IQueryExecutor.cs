using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS
{
    public interface IQueryExecutor<in TQuery, out TResult> where TQuery : IQuery<TResult>
    {
        TResult Execute(TQuery query);
    }

    public class PagableEnumerable<T>
    {
        public int Page { get; private set; }
        public int Count { get; private set; }
        public int Total { get; private set; }
        public IEnumerable<T> Enumerable { get; private set; }

        public PagableEnumerable(int page, int count, int total, IEnumerable<T> enumerable)
        {
            Page = page;
            Count = count;
            Total = total;
            Enumerable = enumerable;
        }
    }
}
