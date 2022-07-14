using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Collision : MonoBehaviour
{
    public static int count = 0;
    public static float speed = 0f;
    [SerializeField] TextMesh DisplaySpeed;

    Control1 control1;

    private void Awake() 
    {
        control1 = GameObject.Find("Kick22 (1)").GetComponent<Control1>();
    }

    private void Start()
    {
        DisplaySpeed.text = "0"; 
    }

    void Update()
    {
        Speed();
    }

    void Speed() 
    {
		speed = Mathf.Abs (control1.currentSpeed)/2.3f; // 최고속도에 대한 현재속도의 비
        speed = Mathf.Round(speed);
        Debug.Log(speed);
        DisplaySpeed.text = speed.ToString();
	}

}
