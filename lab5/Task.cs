using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace lab5
{
    internal class Task
    {
        public DateTime TermLimit { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public Task(DateTime TermLimit, string Title, string Description, string Priority) 
        {
            this.TermLimit = TermLimit;
            this.Title = Title;
            this.Description = Description;
            this.Priority = Priority;
        }
        public override string ToString()
        {
            return $"{Title}, {TermLimit}, {Priority}, {Description};";
        }
    }
}
