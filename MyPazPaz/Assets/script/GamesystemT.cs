using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GamesystemT : MonoBehaviour
{

	//�@�X�^�[�g�{�^��������������s����
	public void StartGame()
	{
		//���s������O�b��ɃV�[���J��
		Invoke("Stageselect", 3);
		SceneManager.LoadScene("Stageselect");

	}

	//void LoadStageselect()
	//{
	//	SceneManager.LoadScene("Stageselect");
	//}

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