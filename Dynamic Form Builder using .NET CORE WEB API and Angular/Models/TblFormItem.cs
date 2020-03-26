using System;
using System.Collections.Generic;

namespace Dynamic_Form_Builder_using_.NET_CORE_WEB_API_and_Angular.Models
{
    public partial class TblFormItem
    {
        public long ItemId { get; set; }
        public string Label { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string Message { get; set; }
        public string Placeholder { get; set; }
        public string Value { get; set; }
        public string OptionId { get; set; }
        public bool? Required { get; set; }
    }
}
