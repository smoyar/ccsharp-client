using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post myPost = new Post();
            myPost.UpVote();
            myPost.UpVote();
            myPost.UpVote();
            myPost.DownVote();
                        
            Console.WriteLine($"Negative votes: {myPost.NegativeVotes}; Positive votes: {myPost.PositiveVotes}");
        }
    }
}
