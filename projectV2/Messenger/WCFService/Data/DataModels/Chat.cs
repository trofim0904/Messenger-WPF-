using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WCFService.Data.DataModels
{
    /// <summary>
    /// DataBase table chat
    /// </summary>
    public class Chat
    {
        [Key]
        public int ChatId { get; set; }
        public string ChatType { get; set; }
        public string ChatStatus { get; set; }
        public int? ChatAdminId { get; set; }
        public string ChatImg { get; set; }
        public string ChatName { get; set; }

        #pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        public virtual ICollection<UserInChat> UserInChats { get; set; }
        #pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    }
}
