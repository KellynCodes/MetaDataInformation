using GettingMetaDataInfo.CustomAttribute;
using GettingMetaDataInfo.Interface;
using System;

namespace GettingMetaDataInfo.Implementation
{
    public class MetaData : IMetaData
    {
        [

            Description("This method return the all the description and information in the assemblies illustrated by the default attribute.")
        ]
        public void GetDocs()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    var members = type.GetMembers();
                    foreach (var member in members)
                    {
                        var attributes = member.GetCustomAttributes(typeof(DescriptionAttribute), false);
                        if (attributes.Length > 0)
                        {
                            Console.WriteLine("Member Type: {0}", member.MemberType);
                            Console.WriteLine("Name: {0}", member.Name);
                            Console.WriteLine($"Description: {((DescriptionAttribute)attributes[0]).Description}");
                            Console.WriteLine($"Input: {((DescriptionAttribute)attributes[0]).Input}");
                            Console.WriteLine($"Output: {((DescriptionAttribute)attributes[0]).Output}");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
