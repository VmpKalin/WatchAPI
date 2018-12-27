using System;
using System.Collections.Generic;
using System.Text;

namespace WatchAPI.Data.Interfaces
{
    public interface IEntity<TK>
    {
        TK Id { get; set; }
    }
}
