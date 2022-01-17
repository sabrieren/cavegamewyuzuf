// Unity3D Dersleri - 14.07.2017 https://www.youtube.com/Unity3DDersleri \\

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour {

	public Slider progressBar; //Gösterge

	public void Load(int level)
	{
		StartCoroutine (startLoading (level));
	}

	IEnumerator startLoading(int level)
	{
		AsyncOperation async = SceneManager.LoadSceneAsync (level);

		while (!async.isDone)
		{
			progressBar.value = async.progress;
			yield return null;
		}

	}



}