using Domain.BaseEntities;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Карточка достижения
    /// </summary>
    public class Achievement : IAuditableEntity
    {
        /// <inheritdoc cref="IAuditableEntity"/>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название достижения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание достижения 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Дата, до которой ожидается выполнить достижение
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Дата фактического выполнения достижения
        /// </summary>
        public DateTime? CompletionDay { get; set; }

        /// <summary>
        /// Статус достижения
        /// </summary>
        public Status Status { get; set; }

        /// <inheritdoc cref="IAuditableEntity"/>
        public Guid UserId { get; set; }

        /// <summary>
        /// Создатель достижения
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public User Creator { get; set; }

        /// <summary>
        /// Список людей, у которых есть это достижение
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// Список соревнований, в которых есть это достижение
        /// </summary>
        public List<Competition>? Competitions { get; set; }

        /// <summary>
        /// Нынешний прогресс
        /// </summary>
        public uint Progress { get; set; }

        /// <summary>
        /// Кто может видеть информацию о достижении
        /// </summary>
        public AccessLevel AccessLevel { get; set; }

        /// <inheritdoc cref="IAuditableEntity"/>
        public DateTime CreateDate { get; set; }

        /// <inheritdoc cref="IAuditableEntity"/>
        public DateTime UpdateDate { get; set; }
    }
}
