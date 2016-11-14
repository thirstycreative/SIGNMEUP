using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace SignBot.Models
{
    public static class Words
    {
        private static StringDictionary wordVideos = new StringDictionary()
        {
            {"a","http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410391/csw8ggjwyeggagpxmiak.mp4"  },
            {"r", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410444/tb56udli4eol9w6rngeq.mp4" },
            {"e", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410481/kdxzn4zzwfypu1tpzwpx.mp4" },
            //letters above this line
            //words below this line
            {"you", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410532/evykhb1kk2osuzk7oxct.mp4" },
            {"Sarah", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410603/yse5x1qpldluz4cw3ss1.mp4" },
            {"ambulance", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559162/zm6tieaios2htcjkfdh4.mp4" }
        };

        public static string UrlForWord(string word)
        {
            string url = string.Empty;

            if (wordVideos.ContainsKey(word))
            {
                url = wordVideos[word];
            }
            return url;
        }
    }
}