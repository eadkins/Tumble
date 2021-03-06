﻿#pragma strict

function OnEnable(){
	var player : player_controller = GameObject.Find("player").GetComponent(player_controller);
	var cubeCount : int = player.getCubes();
	var total : int = player.getCubesInLevel();
	var text = String.Format("{0} / {1} Cubes Collected", cubeCount, total);
	gameObject.GetComponent(UI.Text).text = text;
}