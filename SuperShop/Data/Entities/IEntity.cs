namespace SuperShop.Data.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }

        // public bool WasDeleted { get; set; } // Can be used to mark an item as deleted, but not on the DB, allowing to retrieve it / cancel the deletion
    }
}
