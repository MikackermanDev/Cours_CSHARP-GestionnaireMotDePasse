using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikaSafePass.Entity
{
    public class Config
    {
        private string derniereEntree="";
        public string DerniereEntree
        {
            get => derniereEntree;
            set => derniereEntree = value;  
        }

    }
}
