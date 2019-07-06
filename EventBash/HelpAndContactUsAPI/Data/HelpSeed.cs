using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpAndContactUsAPI.Domain;

namespace HelpAndContactUsAPI.Data
{
    public class HelpSeed
    {
        public static void Seed(HelpContext context)
        {
            if (!context.Helps.Any())
            {
                context.Helps
                    .AddRange(GetPreConfiguredHelps());

                context.SaveChanges();
            }
        }

        private static IEnumerable<Help> GetPreConfiguredHelps()
        {
            return new List<Help>()
            {
            };

           
        }
    }
}
