﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification : IEntity
    {
        [Key]
        public int NotificationID { get; set; }

        public string NotificationType { get; set; }

        public string NotificationTypeSymbol { get; set; }

        public string NotificationDetails { get; set; }

        public bool NotificationStatus { get; set; }

        public string NotificationDate { get; set; }

        public string NotificationLink { get; set; }

        public string NotificationColor { get; set; }
    }
}
