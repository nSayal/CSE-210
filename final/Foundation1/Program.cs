using System;

class Program {
    static void Main(string[] args)
    {
        List<Video> videos  = new List<Video>{};
       
        AddSomeVideosToTheList();
        
        Console.Clear();
        foreach (Video v in videos){
            Console.WriteLine("--------------------------------------------------------------------");
            v.DisplayVideoDetails();
        }
        Console.WriteLine("---------------------------------------------------------------------");




        void AddSomeVideosToTheList(){

            Video v1 = new Video();
            v1._title = "Why Puppies Bred And Trained To Be Seeing Eye Dogs Are So Expensive | So Expensive";
            v1._author = "Business Insider";
            v1._lenghtInSeconds = 14.12;

            v1._comments.Add(new Comment { _personName = "aff77141 ", _textComment = "Can't you read the sign? Keep off the grass! 😂 😂 😂 😂" });
            v1._comments.Add(new Comment { _personName = "willcookmakeup ", _textComment = "These animals are amazing. One of my friends who has a guide dog showed me how well trained they are and how she won't let her go into the street or anywhere dangerous. It was just incredible to watch"});
            v1._comments.Add(new Comment { _personName = "MeianJu ", _textComment = "It's incridible the amount of work that goes into the guide dogs. Amazing video, warms the heart." });
            v1._comments.Add(new Comment { _personName = "scramblerbricks ", _textComment = "The people who need these companions are going to love watching this video" });
            videos.Add(v1);



            Video v2 = new Video();
            v2._title = "World's Smallest 4060 Gaming PC That You Can Build NOW";
            v2._author = "Devyn Johnston";
            v2._lenghtInSeconds = 11.20;

            v2._comments.Add(new Comment { _personName= "NukaOrQuantum... ", _textComment= "These mini-PCs are honestly my favorite. Small, clean, minimal, and relatively powerful. I should 3D print my own case sometime." });
            v2._comments.Add(new Comment { _personName= "Randomness662 " , _textComment= "I  was definitely looking at one of these last year, but that was before the LP 4060 came around. Glad to see it's now a viable option."  });
            v2._comments.Add(new Comment { _personName= "baths4carsraspberrypicomputer " , _textComment= "small as a couple hard drives but powerful as a beast" });
            v2._comments.Add(new Comment { _personName= "kizanko " , _textComment= "Hopefully they make a refreshed version of the case with a little bit more wiggle room for a extra fan and easy fit for the smaller 4060 rtx and better material against heat :)" });
            v2._comments.Add(new Comment { _personName= "Weepsy_ " , _textComment= "An actually proper looking HTPC" });


            videos.Add(v2);


            Video v3 = new Video();
            v3._title = "The coolest robot I've ever built!";
            v3._author = "Thomas Burns";
            v3._lenghtInSeconds = 19.39;

            v3._comments.Add(new Comment { _personName= "xenn4985 " , _textComment= "it wasn't just a world of computers, it was a world of computer creatures genuinely stunning" });
            v3._comments.Add(new Comment { _personName= "HazySkies ", _textComment= "I've seen many AI entities like Ameca that try their hardest to imitate the human form. But there's something about the simplicity and unusual-ness of this one that gives it so much character. Especially the oscilloscope mouth interface and exposed eyes." });
            v3._comments.Add(new Comment { _personName= "SachinJames89 ", _textComment= "Not only did you make a cool looking robot but also a high quality feature documentary about it... 🤖🤖" });
            
            videos.Add(v3);
        }


       
    }
} 