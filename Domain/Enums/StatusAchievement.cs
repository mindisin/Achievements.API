using System.ComponentModel;

namespace Domain.Enums;

public enum Status
{
    [Description("Не начато")]
    NotStarted = 1,

    [Description("В процессе")]
    InProgress = 2,

    [Description("Выполнено успешно")]
    Completed = 3,

    [Description("Провалено")]
    Failed = 4
}