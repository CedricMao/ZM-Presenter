using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CedricMao.Collections;
using org.ZikMe.BusinessEntities;
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


        #region Properties

        public ViList<ITrack> Tracks
        {
            get
            {
                if (_br != null)
                    return _br.Tracks;

                return null;
            }
        }

        #endregion Properties

    }
}
