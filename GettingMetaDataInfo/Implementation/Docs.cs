using GettingMetaDataInfo.CustomAttribute;
using System;
using System.Collections.Generic;

namespace GettingMetaDataInfo.Implementation
{
    public class Docs
    {
        [Description("This is the id of user.")]
         public string? ID { get; set; }

        [Description("This properties is the Name of user.")]
        public string? Name { get; set; }

        [Description("This properties is the Address of user")]
        public string? Address { get; set; }

        [Description("This properties is the gender of user")]
        public string? Gender { get; set; }

        [Description("This properties is the country where the user comes from")]
        public string? Religion { get; set; }


        public Docs()
        {

        }
        public Docs(string iD, string name, string address, string gender, string religion)
        {
            ID = iD;
            Name = name;
            Address = address;
            Gender = gender;
            Religion = religion;
        }

       public static List<Docs> users = new List<Docs>();

        [Description("This method adds the new user to the list and also display the user on the console.")]
        public void DisplayUser()
        {
            users.Add(new Docs("1", "Kelechi Amos", "Nsukka Enugu state, Nigeria", "Male", "Christainity"));

            foreach(var user in users)
            {
                Console.WriteLine($"{user.ID} | {user.Name} | {user.Gender} | {user.Address} | {user.Religion}");
            }
        }
    }
}
