using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class OrderLog
    {
        private OrderStatus status;
        private DateTime creationTimeStamp;


        public OrderLog(DateTime creationTime,OrderStatus status)
        {
            this.creationTimeStamp = creationTime;
            this.status = status;
        }



    }
}
