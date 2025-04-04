namespace DigitalPoetry.LibraryManager.Service.Infra.Data.Dispose
{
    using DigitalPoetry.LibraryManager.Service.Infra.Data.Context;
    using DigitalPoetry.LibraryManager.Service.Infra.Data.Repositories;

    /// <summary>Dispose Data</summary>
    public abstract class DisposeDatabase : IDisposeDatabase
    {
        /// <summary>Application Database Context</summary>
        private readonly ApplicationDbContext _context;

        /// <summary>Disposed Data</summary>
        private bool isDisposed = false;

        /// <summary>Dispose Data Method</summary>
        /// <param name="isDisposing">Data Is Disposing</param>
        public void DisposedData(bool isDisposing)
        {
            if (!this.isDisposed)
            {
                if (isDisposing)
                {
                    _context.Dispose();
                }
            }
            this.isDisposed = true;
        }
    }
}
