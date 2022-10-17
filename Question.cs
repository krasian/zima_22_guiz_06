using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zima_22_guiz_06
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Category { get; set; }
        public Answer Answer1 { get; set; }
        public Answer Answer2 { get; set; }
        public Answer Answer3 { get; set; }
        public Answer Answer4 { get; set; }
    }
}
