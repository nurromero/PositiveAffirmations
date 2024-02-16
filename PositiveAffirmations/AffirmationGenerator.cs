using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveAffirmations
{
    public class AffirmationGenerator
    {

        private readonly List<string> _affirmations = new List<string>
        {
            "You are a smart programmer",
            "You are doing great",
            "You are amazing",
            "You solve problems creatively",
            "Your dedication to coding is inspiring :3"
        };

        public string GenerateAffirmation()
        {
            Random rnd = new Random();
            int index = rnd.Next(_affirmations.Count);
            return _affirmations[index];
        }
    }
}
