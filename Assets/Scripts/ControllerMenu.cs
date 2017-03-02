﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ControllerMenu : MonoBehaviour {

	public GameObject basketball;
	private int ballCount;
	public VRTK_InteractGrab grabbingController;


	// Use this for initialization
	void Start () {
		ballCount = 0;
	}

	// Update is called once per frame
	void Update () {

	}

	public void SpawnBall () {
		if (ballCount != 500) {
		GameObject newBall = Instantiate(basketball, grabbingController.transform.position, Quaternion.identity) as GameObject;
		newBall.transform.parent = null;
		newBall.name = "BasketballClone";
		grabbingController.GetComponent<VRTK_InteractTouch>().ForceTouch(newBall);
		grabbingController.AttemptGrab();
		ballCount += 1;
		}
	}
}