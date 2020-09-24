using System;
using System.Collections.Generic;
using System.Text;

namespace Practical3ex2
{
    interface INews
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AverageRate { get; }
       public void Display();
    }
}
