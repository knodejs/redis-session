using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisSession.Models
{
    [Serializable]
    public class TestSessionModel
    {
        public int Id { get; set; }
        public string TestName { get; set; }    
    }
}
