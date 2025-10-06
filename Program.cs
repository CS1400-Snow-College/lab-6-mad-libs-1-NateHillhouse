Console.Clear();

Console.WriteLine(@"This is Mad Libs. When you are dong providing the requested words
I will build them into a funny story for you
Please enter the requested word types.");


string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";

string[] splitStory = originalStory.Split(" ");
List<string> story = new List<string>();


for (int item = 0; item < splitStory.Length; item++)
{
    string word = "";
    if (splitStory[item].Contains('('))
    {
        //splitStory[item].Remove(')');
        while (!splitStory[item].Contains(')'))
        {
            word += splitStory[item] + " ";
            //splitStory[item].Remove(')');
            item++;
        }
        word += splitStory[item];

        Console.WriteLine(word);
    }
    else word = splitStory[item];
    story.Add(word);
}
foreach (string item in story) Console.WriteLine(item);