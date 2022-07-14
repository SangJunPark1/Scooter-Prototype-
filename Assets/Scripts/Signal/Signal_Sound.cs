using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signal_Sound : MonoBehaviour
{
    // 오디오소스 선언
    AudioSource audioSource;

    // 오디오 클립
    [SerializeField] AudioClip SignalAudio1;  // 좌회전
    [SerializeField] AudioClip SignalAudio2;  // 우회전
    [SerializeField] AudioClip SignalAudio3;  // 직진
    [SerializeField] AudioClip SignalAudio4;  // U턴

    [SerializeField] public GameObject UI_imageAndText1;  // 좌회전
    [SerializeField] public GameObject UI_imageAndText2;  // 우회전
    [SerializeField] public GameObject UI_imageAndText3;  // 직진
    [SerializeField] public GameObject UI_imageAndText4;  // U턴

    void Start()
    {
        // 오디오소스 컴포넌트
        audioSource = GetComponent<AudioSource>();

        // UI를 처음엔 비활성화
        UI_imageAndText1.SetActive(false);
        UI_imageAndText2.SetActive(false);
        UI_imageAndText3.SetActive(false);
        UI_imageAndText4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // signal 스크립트에서 player와 오브젝트가 부딪힌다면
        // signal이 true로 변하게 됨
        // true일때 UI 활성화 및 오디오 재생 그리고 5초후 UI 끄기

        if (Signal.Signal_Left == true)
        {
            UI_imageAndText1.SetActive(true);
            audioSource.PlayOneShot(SignalAudio1);
            Signal.Signal_Left = false;
            Debug.Log("l2");
            Invoke("ImageOff", 5f);
        }
        else if (Signal.Signal_Right == true)
        {
            UI_imageAndText2.SetActive(true);
            audioSource.PlayOneShot(SignalAudio2);
            Signal.Signal_Right = false;
            Debug.Log("r2");
            Invoke("ImageOff", 5f);
        }
        else if(Signal.Signal_Straight == true)
        {
            UI_imageAndText3.SetActive(true);
            audioSource.PlayOneShot(SignalAudio3);
            Signal.Signal_Straight = false;
            Debug.Log("s2");
            Invoke("ImageOff", 5f);
        }
        else if(Signal.Signal_Uturn == true)
        {
            UI_imageAndText4.SetActive(true);
            audioSource.PlayOneShot(SignalAudio4);
            Signal.Signal_Uturn = false;
            Debug.Log("u2");
            Invoke("ImageOff", 5f);
        }
    }

    // 인보크 함수를 쓰기위해서 비활성화를 함수화 시킴
    void ImageOff()
    {
        UI_imageAndText1.SetActive(false);
        UI_imageAndText2.SetActive(false);
        UI_imageAndText3.SetActive(false);
        UI_imageAndText4.SetActive(false);
    }
}
