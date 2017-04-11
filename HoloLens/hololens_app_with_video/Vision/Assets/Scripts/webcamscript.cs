using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class webcamscript : MonoBehaviour {

    public RawImage rawimage;

    float elapsedTime = 0.0f;
    float lastTime = 0;

    private Color backgroundColor = Color.white;
    private int channel = -1;

	// Use this for initialization
	void Start () {
        WebCamTexture webcamTexture = new WebCamTexture();
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();

        SetColorChannel(channel, 1.0f);
    }

    // Update is called once per frame
    void Update() {
        elapsedTime += Time.deltaTime;
        Debug.Log(elapsedTime);


        //Debug.Log(lastTime);

        if (elapsedTime >= 5.0f)
        {

            switch (channel)
            {
                case -1:
                    channel = 0;
                    break;
                case 0:
                    channel = 1;
                    break;
                case 1:
                    channel = 2;
                    break;
                case 2:
                    channel = 0;
                    break;
            }

            Debug.Log(channel);

            SetColorChannel(channel, 1.0f);

            elapsedTime = 0;
        }
    }

    private void SetColorChannel(int channel, float colorVal)
    {
        rawimage.material.SetInt("_Channel", channel);
        rawimage.material.SetFloat("_ColorValue", colorVal);
        //rawimage.material.shader
    }
	
	}

