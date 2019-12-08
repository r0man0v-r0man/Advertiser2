using Application;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Persistance
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly Advertiser2DbContext _context;
        private bool _disposed = false;

        public async Task<int> Complite()
        {
            int result = await _context.SaveChangesAsync().ConfigureAwait(false);
            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }
    }
}
