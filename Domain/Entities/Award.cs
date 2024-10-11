using Domain.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Награда
    /// </summary>
    public class Award : IAuditableEntity
    {
        /// <inheritdoc cref="IAuditableEntity"/>
        [Key]
        public Guid Id { get; set; }

        /// <inheritdoc cref="IAuditableEntity"/>
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        /// <summary>
        /// Название награды
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание награды
        /// </summary>
        public string Description { get; set; }

        /*
        /// <summary>
        /// ID достижения
        /// </summary>
        public Guid? AchievementId { get; set; }

        
        /// <summary>
        /// Базовое достижение
        /// </summary>
        public Achievement? Achievement { get; set; }
        */

        /// <inheritdoc cref="IAuditableEntity"/>
        public DateTime CreateDate { get; set; }

        /// <inheritdoc cref="IAuditableEntity"/>
        public DateTime UpdateDate { get; set; }
    }
}
