using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVVM.Model
{
    public class PageItem
    {
        public PageItem(string title)
        {
            PageTitle = title;
        }
        public string PageTitle
        {
            get;
            set;
        }
    }
}
