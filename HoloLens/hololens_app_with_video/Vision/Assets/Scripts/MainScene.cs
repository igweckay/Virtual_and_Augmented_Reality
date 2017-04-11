using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour {

	// Use this for initialization
	public void ChangeScene (string sceneName) {
        SceneManager.LoadScene(sceneName);
	}
	

}
