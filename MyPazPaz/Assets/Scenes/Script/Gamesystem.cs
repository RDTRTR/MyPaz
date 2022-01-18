using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gamesystem : MonoBehaviour
{

	//�@�X�^�[�g�{�^��������������s����
	public void StartGame()
	{
		SceneManager.LoadScene("Main");
	}

	//�@�Q�[���I���{�^��������������s����
	public void EndGame()
	{
        #if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
        #else
		Application.Quit();
        #endif
	}


}