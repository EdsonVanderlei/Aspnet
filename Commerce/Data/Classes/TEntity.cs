namespace Commerce.Data.Classes
{
    public abstract class TEntity
    {

        public TEntity() { 
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

    }
}
