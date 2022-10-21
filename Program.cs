//lerissa lazar
//10-19-22
//asking questions
//the user is asked questions and the computer will take those answers and input them into a sentence.

Console.Clear();

string name, time;
bool loop = true;

Console.WriteLine("Hello, I have a bunch of questions for you!");
while (loop)
{
    Console.WriteLine("What is your name?");
    name = Console.ReadLine();
    Console.WriteLine("What time did you wake up?");
    time = Console.ReadLine();

    Console.WriteLine($"This persons name is {name} and they woke up at {time} today!");

    Console.WriteLine("Do you want to go again? Yes or no?");

    bool validLoopInput = false;
    while (!validLoopInput)
    {
        string loopInput = Console.ReadLine().ToLower();

        if (loopInput == "yes")
        {
            validLoopInput = true;
        }
        else if (loopInput == "no")
        {
            validLoopInput = true;
            loop = false;
            Console.WriteLine("Well it was nice to meet you, bye now!");
        }
        else
        {
            Console.WriteLine("Invalid input. Enter Yes or No");
        }
    }
}