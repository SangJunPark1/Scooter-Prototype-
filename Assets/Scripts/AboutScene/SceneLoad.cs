using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    public void LoadNextLevel()                                                        // �ٷ� ���� ���������� �Ѿ�� ġƮŰ
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;       // GetActiveScene �Լ��� ���ؼ� ���� �� ��ȣ�� �޾ƿ�
        int nextSceneIndex = currentSceneIndex + 1;                             // ���� ���� + 1 ���� ���� ���� ������ ����
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)           // ���� ���� ������ ���� �ȴٸ�
        {
            nextSceneIndex = 0;                                                 // ���� ���� 0���� �����Ͽ� ó������ �ǵ��ư����� 
        }
        SceneManager.LoadScene(nextSceneIndex);                                 // 'nextSceneIndex' ��° ���� ����϶�
    }

}
