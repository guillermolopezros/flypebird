﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreUp : MonoBehaviour {


	private Text texto;


	void Start(){
				texto = GameObject.Find ("TextoNivel").GetComponent<Text> ();

		}
	void OnTriggerEnter2D(Collider2D col) {
		GameControl.score = GameControl.score + 1;


		texto.text = "Level " + GameControl.score.ToString ();
	
	}

}
