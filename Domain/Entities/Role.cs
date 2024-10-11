
using Domain.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    /// <summary>
    /// Роль
    /// </summary>
    public class Role : IEntity
    {
        /// <summary>
        /// ID роли
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название роли
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список пользователей с этой ролью
        /// </summary>
        public List<User> Users { get; set; }
    }
}
