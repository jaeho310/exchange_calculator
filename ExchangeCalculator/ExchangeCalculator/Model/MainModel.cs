using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeCalculator.Model
{
    class MainModel
    {
        private string dollar;
        public string Dollar
        {
            get
            {
                return dollar;
            }
            set
            {
                dollar = value;
            }
        }

        private string won;
        public string Won
        {
            get
            {
                return won;
            }
            set
            {
                won = value;
            }
        }
    }
}
