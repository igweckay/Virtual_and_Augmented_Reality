using UnityEngine;
using System.Collections;

public class ButtonBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnSelect()
    {
        Debug.Log("on select");
    }

    public void OnGazeEnter()
    {
        Debug.Log("on gaze enter");
    }

    public void OnGazeLeave()
    {
        Debug.Log("on gaze leave");
    }
}
