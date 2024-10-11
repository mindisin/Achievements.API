

namespace Domain.BaseEntities
{
    /// <summary>
    /// Интерфейс для отслеживаемой сущности
    /// </summary>
    public interface IAuditableEntity : IEntity
    {
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Дата последнего изменения
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}