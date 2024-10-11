using System.ComponentModel;

namespace Domain.Enums;
public enum AccessLevel
{
    [Description("Доступно для всех")]
    Public = 1,

    [Description("Доступно только для пользователя")]
    Private = 2,

    [Description("Доступно только для друзей")]
    ForFriends = 3,

    [Description("Доступно только для админов")]
    NoOne = 4
}