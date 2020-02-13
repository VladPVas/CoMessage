using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Model.Common.OperationResults
{
    public enum OperationCode
    {
        Unknown = 0,
        Success,
        E_Unknown,

        /// <summary> Ошибка: нелья отправлять самому себе. </summary>
        E_SendToYourself,
        
        /// <summary> Такой логин не найден. </summary>
        E_LoginNotFound,

        E_LoginOrPasswordNotFound,

        E_LoginAlreadyExist,

        /// <summary> Пользователь с заданным ID не найден. </summary>
        E_UserNotFound,
        
        /// <summary> Контакт с заданным ID не найден. </summary>
        E_ContactNotFound,

        E_ChatNotFound,

        E_ChatHasNoUsers,

        /// <summary> Сессия не существует. </summary>
        E_NoSession,

        E_RequiredDataIsNull,

        E_MessageNotFound,
        E_MessageAlreadyExist,
    }
}
