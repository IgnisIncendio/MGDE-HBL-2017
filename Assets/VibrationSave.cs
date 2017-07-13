using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VibrationSave : MonoBehaviour {
    private Toggle VibrationToggle;
    private string VibrationKey = "Vibration";

	// Use this for initialization
	void Start () {
        VibrationToggle = GetComponent<Toggle>();
        VibrationToggle.isOn = IntToBool(PlayerPrefs.GetInt(VibrationKey));
	}
	
	public void SaveVibration(bool newValue)
    {
        PlayerPrefs.SetInt(VibrationKey, BoolToInt(newValue));
    }

    private bool IntToBool(int val)
    {
        return val == 0 ? false : true;
    }

    private int BoolToInt(bool val)
    {
        return val ? 1 : 0;
    }
}
