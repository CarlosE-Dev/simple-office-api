using System.Collections.Generic;

namespace simple_office.Domain.Interfaces.Dapper
{
    public interface ISqlQueryHelper<T>
    {
        string keyfield { get; }
        string Insert();
        string Update(string idField = null, IList<string> columns = null);
        string Delete(string idField = null);
        string SelectById(string idField = null, IDictionary<string, string> columns = null);
        string SelectAll(IDictionary<string, string> columns = null);
    }
}
