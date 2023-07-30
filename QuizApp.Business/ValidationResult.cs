using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business
{
    public class ValidationResult
    {
        public bool IsValid
        {
            get
            {
                return !Messages.Any();
            }
        }
        public ICollection<string> Messages { get; } = new List<string>();
    }
}
