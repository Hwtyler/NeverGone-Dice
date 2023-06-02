using System;

namespace NevergoneDice.Views;


public partial class DiceBox : ContentPage
{
    private Random _random = new Random(); // Random number generator



    public DiceBox()
	{
		InitializeComponent();
	}



    private void Roll20(object sender, EventArgs e)
    {
        int diceRoll = _random.Next(1, 21); // Generate random number between 1 and 20
        lblD20.Text = $"You rolled a {diceRoll}";
    }
    private void Roll12(object sender, EventArgs e)
    {
        int diceRoll = _random.Next(1, 13); // Generate random number between 1 and 12
        lblD12.Text = $"You rolled a {diceRoll}";
    }
    private void Roll10(object sender, EventArgs e)
    {
        int diceRoll = _random.Next(1, 11); // Generate random number between 1 and 10
        lblD10.Text = $"You rolled a {diceRoll}";
    }
    private void Roll8(object sender, EventArgs e)
    {
        int diceRoll = _random.Next(1, 9); // Generate random number between 1 and 8
        lblD8.Text = $"You rolled a {diceRoll}";
    }
    private void Roll6(object sender, EventArgs e)
    {
        int diceRoll = _random.Next(1, 7); // Generate random number between 1 and 6
        lblD6.Text = $"You rolled a {diceRoll}";
    }
    private void Roll4(object sender, EventArgs e)
    {
        int diceRoll = _random.Next(1, 5); // Generate random number between 1 and 4
        lblD4.Text = $"You rolled a {diceRoll}";
    }
    private void Roll100(object sender, EventArgs e)
    {
        int diceRoll = _random.Next(1, 101); // Generate random number between 1 and 100
        lblD100.Text = $"You rolled a {diceRoll}";
    }
}