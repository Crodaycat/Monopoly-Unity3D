using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
	public static GameController singleton;

	public PlayerNumberController playerNumControl;
	public CreatePlayerController createPlayerControl;
	public GameInterfazController gameInterfazControl;

	public GameObject playerPrefab;

	public Square startSquare;

	public List<Player> players;
	public List<Square> squares;
	public PublicService water;
	public PublicService electricity;
    public List<Station> stations;
    public List<Tax> taxes;

	int playersNumber;
	public int turnCount = 0;

	void Awake ()
	{
		singleton = this;
		StartCoroutine ("PlayGame");
	}

	IEnumerator PlayGame()
	{
		playerNumControl.ShowDialog ();
		yield return new WaitUntil (() => playerNumControl.isChosen);
		playersNumber = playerNumControl.number;
		for (int i = 1; i <= playersNumber; i++)
		{
			createPlayerControl.ShowDialog (i);
			yield return new WaitUntil (() => createPlayerControl.isChosen);
			players.Add(CreatePlayer (createPlayerControl.playerName));
		}

		gameInterfazControl.ShowGameInterface ();
		while (players.Count > 1)
		{
			turnCount++;
			foreach (Player player in players) 
			{
				if (!player.isInPrison)
				{
					gameInterfazControl.ShowDiceThrower (player);
					yield return new WaitUntil (() => gameInterfazControl.hasThrowDices);
					int move = gameInterfazControl.dice1 + gameInterfazControl.dice2;
					yield return new WaitForSeconds (2f);
					gameInterfazControl.HideDiceThrower ();
					StartCoroutine(player.Walk (move));
					yield return new WaitUntil (() => !player.isMoving);
					if (squares [player.square].squareType == Square.SquareType.Property) 
					{
						Property property = (Property)squares [player.square];
						if (property.owner == null) 
						{
							if(Random.Range(0,2) == 1)
							{
								print ("El jugador compra la propiedad");
							} else
							{
								print ("Subastar");
							}
						}
					}
				} else 
					player.LoseTurn ();
			}
		}
	}

	private Player CreatePlayer (string name)
	{
		GameObject piece = Instantiate (playerPrefab, startSquare.transform.position, Quaternion.identity);
		piece.AddComponent<Player>();

		Player player = piece.GetComponent<Player>();
		player.playerName = name;
		player.money = 200;
		return player;
	}
}
