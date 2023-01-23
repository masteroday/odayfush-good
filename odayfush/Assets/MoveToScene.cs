using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
    public string sceneName;
    public bool isNextScene = true;

    [SerializeField]
    public SceneInfo sceneInfo;
    public void OnTriggerEnter2D(Collider2D other)
    {
        sceneInfo.isNextScene = isNextScene;
        if(other.CompareTag("Player")&& !other.isTrigger)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
