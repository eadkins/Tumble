﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class play_controller : MonoBehaviour {

	private int level = 0;

	public void Load(){
		if (GetFaded() == 1f){
			Time.timeScale = 1;
			Application.LoadLevel(level);
		}
	}

	float GetFaded(){
		return gameObject.GetComponent<Image>().color.a;
	}

	void SetFaded(){
		Color temp = new Color(1f, 1f, 1f, .5f);
		gameObject.GetComponent<Image>().color = temp;
	}

	void SetFull(){
		Color temp = new Color(1f, 1f, 1f, 1f);
		gameObject.GetComponent<Image>().color = temp;
	}

	public void checkLevel(int temp){
		if (isPlayable(temp)){
			SetFull();
			level = temp;
		}
		else{
			SetFaded();
		}
	}

	bool isPlayable(int levelnum){
		if (levelnum < Application.levelCount){
			return true;
		}
		else{
			return false;
		}
	}

	public void loadLatest(){
		for (int i = 101; i > 0; i--){
			if (isPlayable(i)){
				Application.LoadLevel(i);
				return;
			}
		}
	}

	public void loadFirst(){
		Application.LoadLevel(1);
	}
}
