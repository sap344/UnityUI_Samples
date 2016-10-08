using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour {

	private Text myText;
	float elapsedTime = 0f;

	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime;
		myText.text = "Time: " + Mathf.Round(elapsedTime);
	}

	public void ResetTimer() {
		elapsedTime = 0f;
	}
}
