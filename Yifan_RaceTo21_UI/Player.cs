using System;
using System.Collections.Generic;

namespace RaceTo21
{
	public class Player
	{
		public string name;//The name of the player
		public List<Card> cards = new List<Card>();//Player's hand
		public PlayerStatus status = PlayerStatus.active;//intialize the player's status to ensure that they are active at the beginning
		public int score;//the player's score
		public int point;//the player's points
		public int NumOfCard;

		public Player(string n)
		{
			name = n;
        }

		
		public void Introduce(int playerNum)
		{
			Console.WriteLine("Hello, my name is " + name + " and I am player #" + playerNum);
		}
		
		public void ShowPoint()
		{
			Console.WriteLine(name+":"+point+" coins");
		}

	}
}

