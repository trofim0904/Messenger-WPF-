﻿using Messenger.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Logic.Models
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }
        public string Author { get; set; }
        public string Img { get; set; }
    }
}