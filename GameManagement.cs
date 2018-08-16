using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManagement : MonoBehaviour {

	#region Global Variabel Master
	public GameObject letter;
	public GameObject searchLetter;
	public GameObject searchBase;
	public GameObject VM;
	#endregion

	#region Local Variabels
	public int GAMEMODE;
	#endregion


	void Awake () {
		if(this.GAMEMODE == 0){ this.ShowLevel(); }
	}

	private void ShowLevel(){
		//List<string> usedChars = this.GetUniqueLetters();
		//this.ShowSearchWordBox(usedChars);

		VariableMaster master = new VariableMaster();
		master.CheckVariables();
		Debug.LogError(master.GetLetter());
		Debug.LogError(master.GetSearchLetter());
		Debug.LogError(master.GetSearchBase());
	}

	private void ShowSearchWordBox(List<string> usedChars){
		WordSearchBox wordBox = gameObject.AddComponent<WordSearchBox>();
		wordBox.InsertLetters(usedChars);
		wordBox.InsertSearchBaseGO(this.searchBase);
		//wordBox.InsertLetterGO(this.searchLetter);
		wordBox.DrawBase();
	}

	private List<string> GetUniqueLetters(){
		CrossWordField field = this.LoadCrossWordField();
		return field.GetUniqueLetters();
	}

	private CrossWordField LoadCrossWordField(){
		string[] words = {"Belinda", "Leib", "Bein", "Alien", "Nie"};
		Dictionary<string, int> wordDirections = new Dictionary<string, int>(){
			{words[0], 0},
			{words[1], 1},
			{words[2], 1},
			{words[3], 1},
			{words[4], 1}
		};
		Dictionary<string, int> wordIndexesOnBase = new Dictionary<string, int>(){
			{words[0], -1},
			{words[1], 2},
			{words[2], 4},
			{words[3], 6},
			{words[4], 1}
		};
		Dictionary<string, string> wordBaseWord = new Dictionary<string, string>(){
			{words[0], ""},
			{words[1], words[0]},
			{words[2], words[0]},
			{words[3], words[0]},
			{words[4], words[0]}
		};
		Dictionary<string, Vector2> wordStartingCoordinations = new Dictionary<string, Vector2>(){
			{words[0], new Vector2(5,7)},
			{words[1], new Vector2(5,9)},
			{words[2], new Vector2(2,11)},
			{words[3], new Vector2(5,13)},
			{words[4], new Vector2(3,8)}
		};


		CrossWordField field = gameObject.AddComponent<CrossWordField>();
		field.FillData(words, wordDirections, wordIndexesOnBase,
								   wordBaseWord, wordStartingCoordinations);
		field.SetLetter(this.letter);

		field.ShowEverything();
		//field.ShowNothing();

		return field;
	}
}