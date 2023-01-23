using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEntrance : MonoBehaviour
{
    public GameObject entrance;
    public GameObject exit;

    [SerializeField]
    public SceneInfo sceneInfo;

    public Vector3 offsetEntrance = new Vector3(1, 0.5f, 0);
    public Vector3 offsetExit = new Vector3(-1, 0.5f, 0);
    private Rigidbody2D body;
    void Awake()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        GameObject target = sceneInfo.isNextScene ? entrance : exit;
        Vector3 offset = sceneInfo.isNextScene ? offsetEntrance : offsetExit;
        body.position = target.transform.position + offset;
    }
}
