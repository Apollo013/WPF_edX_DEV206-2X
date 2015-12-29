using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converters
{
    public class MainPageViewModel
    {
        private bool isactive = false;
        public bool IsActive
        {
            get
            {
                return isactive;
            }

            set
            {
                if(value != isactive)
                {
                    isactive = value;
                }
            }
        }
    }
}
