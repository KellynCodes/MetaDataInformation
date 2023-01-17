using System;

namespace GettingMetaDataInfo.CustomAttribute
{
[AttributeUsage(AttributeTargets.Class |  AttributeTargets.All)]
    public class DescriptionAttribute : Attribute
    {

        public string? Description { get; set; }
        public string? Input { get; set; }
        public string? Output { get; set; }

        public DescriptionAttribute(string description, string input = null, string output = null)
        {
            Description = description;
            Input = input;
            Output = output;
        }

    }
}
