using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Extensions
{
    public class MoedaAttributeAdapter : AttributeAdapterBase<MoedaAttribute>
    {
        public MoedaAttributeAdapter(MoedaAttribute attribute, IStringLocalizer localizer) : base(attribute, localizer)
        {

        }

        public override void AddValidation(ClientModelValidationContext context)
        {
            if(context == null)
            {
                throw new NotImplementedException(nameof(context));
            }

            MergeAttribute(context.Attributes, "data-val", "true");
            MergeAttribute(context.Attributes, "data-val-moeda", GetErrorMessage(context));
            MergeAttribute(context.Attributes, "data-val-number", GetErrorMessage(context));
        }

        public override string GetErrorMessage(ModelValidationContextBase validationContext)
        {
            return "Moeda em formato inválido";
        }
    }
}
