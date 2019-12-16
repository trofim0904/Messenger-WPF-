using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Logic.Models
{
    public class ChangeModel
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Img { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string RepeatPassword { get; set; }

        public string Token { get; set; }
    }
}
