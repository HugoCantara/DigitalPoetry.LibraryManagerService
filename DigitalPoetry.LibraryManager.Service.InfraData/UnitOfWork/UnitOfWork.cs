namespace DigitalPoetry.LibraryManager.Service.Infra.Data.UnitOfWork
{
    using DigitalPoetry.LibraryManager.Service.Infra.Data.Interfaces.UnitOfWork;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
