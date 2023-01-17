using System;

namespace GettingMetaDataInfo.CustomAttribute
{
[AttributeUsage(AttributeTargets.Class |  AttributeTargets.All)]
    public class DescriptionAttribute : Attribute
    {

        public string Description { get; set; }

        public DescriptionAttribute(string description)
        {
            Description = description;
        }

    }
}
