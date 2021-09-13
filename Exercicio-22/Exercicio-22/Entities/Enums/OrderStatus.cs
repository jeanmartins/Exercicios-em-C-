using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_22.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
