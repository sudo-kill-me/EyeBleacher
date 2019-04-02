﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace EyeBleacher
{

    class CoolSubredditData
    {
        public static string[] GetRandomCoolURL()
        {
            WebClient client = new WebClient();
            Random random = new Random();
            string url = PickRandomCoolSubreddit();
            string coolSubredditJsonDataRAW = client.DownloadString(url);

            string[] imageLinks = new string[25];
            string[] imageTitle = new string[100];
            string[] postAuthor = new string[25];
            string[] subredditName = new string[25];
            float[] upvotes = new float[25];
            float[] downvotes = new float[25];
            string[] permaLink = new string[25];

            // This uses Newtonsoft.Json to deserialize the downloaded JSON data from reddit
            ParsableRedditJsonData.RootObject usableJsonData = JsonConvert.DeserializeObject<ParsableRedditJsonData.RootObject>(coolSubredditJsonDataRAW);

            // Go through the data from 
            for (int i = 0; i < 25; i++)
            {
                // Get's rid of any of the links that aren't .jpg files
                if (usableJsonData.data.children[i].data.url.EndsWith(".jpg"))
                {
                    imageTitle[i] = usableJsonData.data.children[i].data.title;
                    postAuthor[i] = usableJsonData.data.children[i].data.author;
                    imageLinks[i] = usableJsonData.data.children[i].data.url;
                    subredditName[i] = usableJsonData.data.children[i].data.subreddit_name_prefixed;
                    upvotes[i] = usableJsonData.data.children[i].data.ups;
                    downvotes[i] = usableJsonData.data.children[i].data.downs;
                    permaLink[i] = usableJsonData.data.children[i].data.permalink;

                }
                else
                {
                    imageTitle[i] = null;
                    postAuthor[i] = null;
                    imageLinks[i] = null;
                    permaLink[i] = null;
                }

            }

            // Clean arrays of any null elements
            imageLinks = imageLinks.Where(c => c != null).ToArray();
            imageTitle = imageTitle.Where(c => c != null).ToArray();
            postAuthor = postAuthor.Where(c => c != null).ToArray();
            subredditName = subredditName.Where(c => c != null).ToArray();
            permaLink = permaLink.Where(c => c != null).ToArray();

            int randInt = random.Next(0, imageLinks.Length);

            string fullLinkURL = "https://www.reddit.com" + permaLink[randInt];
            fullLinkURL = fullLinkURL.ToString();

            return new string[] { imageLinks[randInt], imageTitle[randInt], "u/" + postAuthor[randInt], subredditName[randInt], upvotes[randInt].ToString(), downvotes[randInt].ToString(), fullLinkURL };
        }

        public static string PickRandomCoolSubreddit()
        {
            Random random = new Random();
            // List of subreddits that can be used to choose pictures from, feel free to add on to them

            string[] coolSubredditList = {
                "https://www.reddit.com/r/astronomy/hot.json?sort=hot",
                "https://www.reddit.com/r/EarthPorn/hot.json?sort=hot",
                "https://www.reddit.com/r/MildlyInteresting/hot.json?sort=hot"
                // Append any further subreddits here
            };

            int randInt = random.Next(0, coolSubredditList.Length);

            return coolSubredditList[randInt];
        }
    }
}
