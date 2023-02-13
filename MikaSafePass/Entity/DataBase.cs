using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikaSafePass.Entity
{
    public class DataBase
    {
        private string hash;
        public string Hash
        {
            get { return hash; }
            set { hash = value; }
        }

        private BindingList<Entry> listEntree;

        public BindingList<Entry> ListEntree
        {
            get => listEntree;
            set => listEntree = value;
        }

        public DataBase()
        {
            listEntree = new BindingList<Entry>();
        }

    }
}
