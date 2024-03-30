using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video {


        public string _title  = "";
        public string _author  = "";
        public double _lenghtInSeconds = 0 ;
        public List<Comment> _comments  = new List<Comment>{};


        public Video() {
            _comments = new List<Comment>();
        }
        public Video(string title, string author, double lenghtInSecods ,  List<Comment> comments) {
            _title= title;
            _author = author;
            _lenghtInSeconds = lenghtInSecods;
            _comments = comments ;
        }        


        public void DisplayVideoDetails(){
            int index = 1;
            Console.Write($"Video title: {_title.ToUpper()} ");
            Console.Write($"Length {_lenghtInSeconds} by {_author}");
            Console.WriteLine("");
            Console.WriteLine($"This video has {NumberOfComments()} COMMENTS:");
            Console.WriteLine("");
            foreach (Comment c in _comments){
                Console.WriteLine ($"[{index}] {c.DisplayComment()}");       
                index++;
            }
        }

        private int NumberOfComments(){
            return _comments.Count();
        }

        
}