﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class changeSceneController : MonoBehaviour
{
	public String sceneToLoad;

		public void change(){
			SceneManager.LoadScene(sceneToLoad);
		}
			public void change(String sceneName){
				SceneManager.LoadScene(sceneName);
			}
					public void reload(){
						change(SceneManager.GetActiveScene().name);
					}
}
