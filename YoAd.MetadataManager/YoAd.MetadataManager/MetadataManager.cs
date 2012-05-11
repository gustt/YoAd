using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoAd.MetadataManager
{
    public class MetadataManager
    {
        #region § construtor

        private static readonly MetadataManager instance = new MetadataManager();

        private MetadataManager() { }

        public static MetadataManager go
        {
            get { return instance; }
        } 

        #endregion
    }
}
