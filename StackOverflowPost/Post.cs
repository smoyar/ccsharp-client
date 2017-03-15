using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Post
    {
        private string _title;
        private string _description;
        private TimeSpan _dateTime;
        private int _positiveVotes = 0;
        private int _negativeVotes = 0;


        public void UpVote()
        {
            _positiveVotes++;
            Console.WriteLine("My post was up voted");
        }
        public void DownVote()
        {
            _negativeVotes++;
            Console.WriteLine("My post was down voted");
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan DateTime { get; set; }
        public int PositiveVotes
        {
            get {return _positiveVotes; }
            private set {_positiveVotes=value; }
        }
        public int NegativeVotes
        {
            get { return _negativeVotes; }
            private set { _negativeVotes = value; }
        }
    }
}
