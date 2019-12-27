using System;

namespace TechDebtTags
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = true)]
    public class HardcodedValueAttribute : BaseTechnicalDebtAttribute
    {
        public string Value { get; private set; }

        protected HardcodedValueAttribute(string value)
        {
            Value = value;
        }
    }
}