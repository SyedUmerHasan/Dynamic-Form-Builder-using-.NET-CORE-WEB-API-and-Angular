using Dynamic_Form_Builder_using_.NET_CORE_WEB_API_and_Angular.CloudModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dynamic_Form_Builder_using_.NET_CORE_WEB_API_and_Angular.CloudViewModel
{
    public class CloudFormItemWithOptions
    {
        public TblFormItem formItem { get; set; }

        public TblOption options { get; set; }
    }
}
