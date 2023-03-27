using UnityEngine;
using System.Collections;

public class Player 
{
	public const string TAG = "Player:";
	string name = "";

		public Player(string name)
		{
			this.name = name;
			Debug.Log(TAG + "name is " + name);
		}
}	

