using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

	public void Load(int sceneIndex){
		SceneManager.LoadScene (sceneIndex);
	}
}
