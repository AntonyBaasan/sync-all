
using SyncAll.Core.Models;

namespace SyncAll.Core.Services
{
    public class SynchronizerManager : ISynchronizerManager
    {
        public Task<IList<string>> AnalyzeAsync(Dir dir1, Dir dir2, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> SynchronizeAsync(Dir dir1, Dir dir2, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
