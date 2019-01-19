﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsTools {
    public class DynamicAssetArray : DynamicAsset {
        string proto_name;
#if DEBUG
        public
#else
        internal
#endif
            DynamicAsset[] elems;

#if DEBUG
        public
#else
        internal
#endif
            DynamicAssetArray(int count, string protoname) {
            elems = new DynamicAsset[count];
            proto_name = protoname;
        }

        public DynamicAsset this[int index] => elems[index];
    }
}
