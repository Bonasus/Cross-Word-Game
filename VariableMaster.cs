using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableMaster : MonoBehaviour {

	#region Variabeln
	public GameObject letter;
	public GameObject searchLetter;
	public GameObject searchBase;
	#endregion

	public void CheckVariables(){
		Debug.LogError("Start check:");
		Debug.LogError(this.letter);
		Debug.LogError(this.searchLetter);
		Debug.LogError(this.searchBase);
		Debug.LogError("Check endet.");
	}

	public GameObject GetLetter(){
		if(this.letter != null){ return this.letter; }
		else{ return null; }
	}

	public GameObject GetSearchLetter(){
		if(this.searchLetter != null){ return this.searchLetter; }
		else{ return null; }
	}

	public GameObject GetSearchBase(){
		if(this.searchBase != null){ return this.searchBase; }
		else{ return null; }
	}
}
