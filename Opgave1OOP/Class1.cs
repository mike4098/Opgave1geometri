using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1OOP
{
    class SetNget
    {
        private int Omkreds;
        public int omkreds
        {
            get
            {
                return this.Omkreds;
            }
            set
            {
                this.Omkreds = 5;
            }
        }
    }
  
}

