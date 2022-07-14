using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    public void LoadNextLevel()                                                        // 바로 다음 스테이지로 넘어가는 치트키
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;       // GetActiveScene 함수를 통해서 현재 씬 번호를 받아옴
        int nextSceneIndex = currentSceneIndex + 1;                             // 현재 씬에 + 1 해준 값을 다음 씬으로 저장
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)           // 다음 씬이 마지막 씬이 된다면
        {
            nextSceneIndex = 0;                                                 // 다음 씬을 0으로 설정하여 처음으로 되돌아가게함 
        }
        SceneManager.LoadScene(nextSceneIndex);                                 // 'nextSceneIndex' 번째 씬을 출력하라
    }

}
