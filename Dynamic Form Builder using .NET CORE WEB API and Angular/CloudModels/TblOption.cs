using System;
using System.Collections.Generic;

namespace Dynamic_Form_Builder_using_.NET_CORE_WEB_API_and_Angular.CloudModels
{
    public partial class TblOption
    {
        public long OptionId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public long? ItemId { get; set; }
    }
}
