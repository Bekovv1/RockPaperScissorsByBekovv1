const string Rock = "Rock";
const string Scissors = "Scissors";
const string Paper = "Paper";
Console.Write("Choose [r]rock, [p]paper or [s]scissors: ");
string Moove = Console.ReadLine();
if (Moove == "r" || Moove == "rock")
{
    Moove = Rock;
}
else if (Moove == "p" || Moove == "paper")
{
    Moove = Paper;
}
else if (Moove == "s" || Moove == "scissors")
{
    Moove = Scissors;
}
else
{
    Console.WriteLine("Invalid input. Try again...");

    return;
}
Random random = new Random();
int botRandNum = random.Next(1, 4);
string botMoove = "";
switch (botRandNum)
{

    case 1:

        botMoove = Rock;

        break;

    case 2:

        botMoove = Paper;

        break;

    case 3:

        botMoove = Scissors;

        break;
}
Console.WriteLine($"The computer choose {botMoove}.");
if ((Moove == Rock && botMoove == Scissors) ||

       (Moove == Paper && botMoove == Rock) ||

       (Moove == Scissors && botMoove == Paper))
{
    Console.WriteLine("You win");
}
else if ((Moove == Rock && botMoove == Paper) ||

    (Moove == Paper && botMoove == Scissors) ||

    (Moove == Scissors && botMoove == Rock))
{


    Console.WriteLine("You lose.");


}
else
{



    Console.WriteLine("Ths game was a draw.");


}