using Domain.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class User : IAuditableEntity
    {
        /// <summary>
        /// ID пользователя
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Хэш пароля пользователя
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Дата рождения пользователя
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Номер телефона пользователя
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Токен для обновления JWT токена
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Врнмя истечения действия RefreshToken'а
        /// </summary>
        public DateTime RefreshTokenExpiry { get; set; }

        /// <summary>
        /// Подтвержден ли номер телефона
        /// </summary>
        public bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// Подтверждена ли электронная почта
        /// </summary>
        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// Список наград пользователя
        /// </summary>
        public List<Award>? Awards { get; set; }

        /// <summary>
        /// Список друзей пользователя
        /// </summary>
        public List<User>? Friends { get; set; }

        [InverseProperty(nameof(Achievement.Users))]
        public List<Achievement>? Achievements { get; set; }

        [InverseProperty(nameof(Achievement.Creator))]
        public Achievement? CreatedAchievement { get; set; }

        /// <summary>
        /// Список сореваний в которых участвует пользователь
        /// </summary>
        [InverseProperty(nameof(Competition.Members))]
        public List<Competition>? Competitions { get; set; }

        /// <summary>
        /// Список сореваний, которые создал пользователь
        /// </summary>
        [InverseProperty(nameof(Competition.Creator))]
        public List<Competition>? CreatedCompetitions { get; set; }

        /// <summary>
        /// Список ролей данного пользователя
        /// </summary>
        public List<Role> Roles { get; set; }

        /// <inheritdoc cref="IAuditableEntity"/>
        public DateTime CreateDate { get; set; }

        /// <inheritdoc cref="IAuditableEntity"/>
        public DateTime UpdateDate { get; set; }
    }
}
