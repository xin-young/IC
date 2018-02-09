﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IC.Core.Entity.CloudLink.DB
{
    public class FlowPackageRecord : HasId
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 流量卡Id
        /// </summary>
        public Guid CardId { get; set; }

        /// <summary>
        /// 套餐Id
        /// </summary>
        public Guid PackageId { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpiryDate { get; set; }
    }
}
