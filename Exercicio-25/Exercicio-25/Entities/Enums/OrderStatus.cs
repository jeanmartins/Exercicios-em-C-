using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_25.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
