namespace DigitalPoetry.LibraryManager.Service.Infra.Data.Interfaces.UnitOfWork
{
    /// <summary>Unit of Work Interface</summary>
    public interface IUnitOfWork
    {
        //IGenericRepository<T> GenericRepository<T>() where T : class;

        /// <summary>Save Changes in Database</summary>
        void Save();
    }
}
