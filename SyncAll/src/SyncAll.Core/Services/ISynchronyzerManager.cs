using SyncAll.Core.Models;

namespace SyncAll.Core.Services
{
    public interface ISynchronizerManager
    {
        Task<IList<string>> AnalyzeAsync(Dir dir1, Dir dir2, CancellationToken cancellationToken);
        Task<IList<string>> SynchronizeAsync(Dir dir1, Dir dir2, CancellationToken cancellationToken);
    }
}