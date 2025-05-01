
namespace ScreenSoundDB.Banco
{
    public class DAL<T> where T : class
    {
        protected readonly ScreenSoundContext context;

        public DAL(ScreenSoundContext context)
        {
            this.context = context;
        }
        
        public IEnumerable<T> List()
        {
            return context.Set<T>().ToList();
        }

        public void Add(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Set<T>().Update(obj);
            context.SaveChanges();
        }

        public void Delete(T obj)
        {
            context.Set<T>().Remove(obj);
            context.SaveChanges();
        }
        
        public T? FindBy(Func<T, bool> condition)
        {
            return context.Set<T>().FirstOrDefault(condition);
        }
        
        public IEnumerable<T> ListBy(Func<T, bool> condition)
        {
            return context.Set<T>().Where(condition);
        }
    }
}