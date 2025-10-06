# Lab-4-Madlibs-1

Step 1: Understand the Overview
In this lab you will play the game "Mad Libs". You will use a provided story (or one you'd like to make up) and ask the user to help fill in the blanks of the story to hopefully produce a funny version of the story when you are done. 

Here is an example of how your code should look when it runs:

This is Mad Libs. When you are dong providing the requested words
I will build them into a funny story for you
Enter the requested word types

Please give me a/an adjective: ugly
Please give me a/an adjective: metallic
Please give me a/an noun: window
Please give me a/an noun: junkyard
Please give me a/an plural noun: noodles
Please give me a/an game: Uno
Please give me a/an plural noun: sneakers
Please give me a/an verb ending in "ing": swimming
Please give me a/an verb ending in "ing": driving
Please give me a/an plural noun: candy bars
Please give me a/an verb ending in "ing": showering
Please give me a/an noun: dog
Please give me a/an plant: fern
Please give me a/an part of the body: chest
Please give me a/an place: London
Please give me a/an verb ending in "ing": gardening
Please give me a/an adjective: tall
Please give me a/an number: 412
Please give me a/an plural noun: musical notes

A vacation is when you take a trip to some ugly place with your metallic family. Usually, you go to some place that is near a/an
window or up on a/an junkyard. A good vacation place is one where you can ride noodles or play Uno or go hunting for sneakers. I 
like to spend my time swimming or driving. When parents go on a vacation, they spend their time eating three candy bars a day, and 
fathers play golf, mothers sit around showering. Last summer, my little brother fell in a/an dog and got poison fern all over his 
chest. My family is going to go to London and I will practice gardening. Parents need vacations more than kids because parents are 
always very tall and because they have to work 412 hours every day all year making musical notes to pay for the vacation.

Step 2: Environment Setup
Accept the GitHub Classroom AssignmentLinks to an external site..
Open a terminal.
If you don't have a code directory already:
Run mkdir my-code-dir to make a new directory named 'my-code-dir'.
Navigate to your code directory (hint: cd my-code-dir).
Run git clone {yourUrl} to make a local copy of your repository. (hint: don't include the curly braces in your command---those are just there to indicate that you should replace {yourUrl} with your actual repository url.)
Run code {nameOfYourRepo} to open that directory in VS Code.
Open the integrated terminal in VS Code (Ctrl+`, or the Terminal menu -> New Terminal).
Run dotnet new console to create a new project in the current folder.
Run dotnet run to compile and execute your code.
Step 3: Programming
Incrementally add the following functionality to your game. After each step, make sure that you can still compile/run and that the program behaves as expected; then commit a checkpoint to your git repository (using git add . and git commit -m "write a description of the step here").

comment Add a comment to the top of your source code with your name, the date, and the name of the lab. (Remember to run, add, and commit your code.)
greeting Print a greeting and description of the program to the user. (Remember to run, add, and commit.)
taking the string apart Here is a code snippet to load the story into a single string:
string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";
You may use this madlibs example or make up your own
string[] storyWords = originalStory.Split(' '); // This should hopefully split original story into words
analyze each word- look at each word and consider the first character.
If it not a parenthesis add it to the 'newStory' along with a space
If it is a parenthesis, ask the user to provide you with an example of the word type in the parenthesis and add that word to the 'newStory' along with a space
display the new story- Print it out when you're done
(Optional) Make your code consider these factors:
The word (adjective) has parenthesis around it, can you have your code ask "Please give me a/an adjective" rather than "Please give me a/an (adjective)" (+5 extra credit)
"a/an" looks silly. Can you have your code recognize vowels and ask "Please give me an adjective" and "Please give me a noun" (+5 extra credit)
Some words have punctuation for example (noun). When you rebuild the story can you make it print "frog." with the period when it prints out the story at the end? (+5 extra credit)
