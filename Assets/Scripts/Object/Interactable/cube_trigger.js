﻿#pragma strict

var local: boolean = false;

function OnTriggerEnter (other : Collider) {
	if (other.gameObject.tag == "Player"){
		if (local) other.gameObject.GetComponent(player_controller).changeSpawn(transform.localPosition);
		else other.gameObject.GetComponent(player_controller).changeSpawn(transform.position);
		gameObject.SetActive(false);
	}
}