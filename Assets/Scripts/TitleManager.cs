﻿using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//スタートボタンを押した
	public void PushStartButton () {
		//ステージ選択シーンへ
		SceneManager.LoadScene ("StageSelectScene");
	}
}
