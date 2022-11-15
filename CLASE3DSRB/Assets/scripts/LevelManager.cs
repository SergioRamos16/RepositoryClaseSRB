using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public void NextLevel()
	{
		int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
		if (nextScene >= SceneManager.sceneCountInBuildSettings)
		{
			nextScene = 0;
		}
		Cursor.lockState = CursorLockMode.None;
		SceneManager.LoadScene(nextScene);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}