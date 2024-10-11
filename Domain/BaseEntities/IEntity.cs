namespace Domain.BaseEntities
{
    /// <summary>
    /// Интерфейс для сущности
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Первичные и внешние ключи
        /// </summary>
        public Guid Id { get; set; }
    }
}
