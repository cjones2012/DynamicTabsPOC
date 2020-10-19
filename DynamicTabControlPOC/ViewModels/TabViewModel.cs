using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTabControlPOC.ViewModels
{
    public class TabViewModel
    {
        public TabHeaderViewModel Header { get; set; }
        public List<TabContentViewModel> Content { get; set; }
    }
}
