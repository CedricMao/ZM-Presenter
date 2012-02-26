using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.ZikMe.BusinessLayer;

namespace org.ZikMe.UI.Presenter
{
    public class Library
    {
        private BusinessLayer.BusinessReferential _br = null;

        public Library()
        {
            _br = BusinessReferential.Instance;
        }
    }
}
