using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Data.Repository.Definition;

namespace WordCounter.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IRepositoryReadingInstance ReadingInstance { get; set; }
        void Commit();
    }
}
