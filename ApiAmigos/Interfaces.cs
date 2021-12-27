using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiAmigos.Interfaces
{
        public interface IAmigoRepositories<T1> where T1: class
        {
                Task<IEnumerable<T1>> GetPage(int PageNumber, int RecsPerPage);
                Task<T1> CreateRow( T1 a);
                Task<T1> UpdateRow(T1 a);
                Task<string> DeleteRow(int rowId);
        }
}