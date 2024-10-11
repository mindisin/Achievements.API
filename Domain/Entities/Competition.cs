using Domain.BaseEntities;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Соревнование в достижении
    /// </summary>
    public class Competition : IAuditableEntity
    {
        /// <inheritdoc cref="IAuditableEntity"/>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Пользователь, который создал соревновние
        /// </summary>
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User Creator { get; set; }

        /// <summary>
        /// Название сореванования
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата начала соревнования
        /// </summary>
        public DateTime DateStart { get; set; }

        /// <summary>
        /// Дата окончания соревнования
        /// </summary>
        public DateTime DateEnd { get; set; }

        /// <summary>
        /// Кто может видеть информацию о соревновании
        /// </summary>
        public AccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Достижения, по которым проводится соревнование
        /// </summary>
        [Required]
        public List<Achievement> Achievements { get; set; }

        /// <summary>
        /// Участники соревнования
        /// </summary>
        public List<User> Members { get; set; }

        /// <inheritdoc cref="IAuditableEntity"/>
        public DateTime CreateDate { get; set; }

        /// <inheritdoc cref="IAuditableEntity"/>
        public DateTime UpdateDate { get; set; }
    }
}
