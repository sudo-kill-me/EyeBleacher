# EyeBleacher
For when you've had too much internet for the day

You press the buttons at the bottom of the window and the program will randomly select a subreddit to pull JSON data from.
From the JSON data, it will filter out any posts that aren't .jpg images. Then it will clean the arrays of any null elements,
and choose a random post to show you.

![alt text](https://github.com/rytrotter/EyeBleacher/blob/master/Eyebleacher_MainStart.png)


From this porject, I learned a lot about how Reddit specifically handles it's post/subreddit data. This is also my first non-tutorial project
with C# and WinForms.

## Issues
The only issue I've found as of right now is sometimes when pressing the "Something Wholesome" or "Something Cool" buttons, an 
unhandled exception will be thrown. The unhandled exception is **Newtonsoft.Json.JsonSerializationException** which gets thrown
because all the JSON data from the last button press returns no .jpg files so they all get filtered out and the arrays are all left null.

Putting a Try{} Catch (Newtonsoft.Json.JsonSerializationException) {} block around the code for these two buttons does stop this
from occuring, but it makes the program run slowly.
