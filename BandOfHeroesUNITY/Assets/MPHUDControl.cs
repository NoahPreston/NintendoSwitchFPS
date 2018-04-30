using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MPHUDControl : MonoBehaviour {


    public Text blueScore;
    public Text redScore;
    public Text timeLeft;

 
    string GetFormattedTime(float t)
    {

        t = Mathf.Max(0, t);
        int hours = ((int)t) / 3600;
        int minutes = (((int)t) - (hours * 3600)) / 60;
        int seconds = ((int)t) % 60;
        string s = "";
        s += (hours > 0) ? hours.ToString() + ":" : "";
        s += ((minutes > 0) ? (minutes < 10) ? "0" + minutes + ":" : minutes + ":" : "");
        s += (seconds < 10) ? "0" + seconds : seconds.ToString();
        return s;

    }

    // Use this for initialization
    void Start () {

        timeLeft.text = (GetFormattedTime(vp_MPClock.TimeLeft));

    }
	
	// Update is called once per frame
	void Update () {
        timeLeft.text = (GetFormattedTime(vp_MPClock.TimeLeft));
    }
}
