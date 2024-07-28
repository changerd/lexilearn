using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiLearn.Shared.Models
{
    public class VocabularySet
    {
        public string Name { get; set; }

        public string Level { get; set; }

        public string Theme { get; set; }

        public List<Vocabulary> Words { get; set; }
    }
}
