﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace MCSoft.Domain.Models
{
    /// <summary>
    /// 团长
    /// </summary>
    public sealed partial class Head : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        public string Phone { get; set; }

        public string WxNumber { get; set; }

        /// <summary>
        /// 小区名
        /// </summary>
        public string CellName { get; set; }

        public string Remark { get; set; }

        public string Location { get; set; }

        public Status HeadStatus { get; set; } = Status.Enable;


        public int BrowseCount { get; set; } = 0;

        public User User { get; set; }
    }

    public sealed partial class Head
    {
        private Head() { }

        public Head(User user, string name, string phone, string wxNumber, string cellName)
        {
           User = user;
           Name = name;
           Phone = phone;
           WxNumber = wxNumber;
           CellName = cellName;
        }

        public void ChangeStatus(Status headStatus)
        {
            HeadStatus = headStatus;
        }

        public void AddBrowseCount()
        {
            BrowseCount += 1;
        }
    }
}
