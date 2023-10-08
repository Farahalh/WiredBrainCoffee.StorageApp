namespace WiredBrainCoffee.StorageApp.Repositories
{
    public static class RepositoryExtensions // static means that it can only contain static members
    {
        public static void AddBatch<T>(this IWriteRepository<T> repository, T[] items)
        {
            foreach (var item in items)
            {
                repository.Add(item);
            }
            repository.Save();
        }
    }
}
