using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePosition;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    public float timer;
    public float timeBetweenFiring;
    private void Start()
    {
        mainCam = Camera.main;
    }
    private void Update()
    {
        mousePosition = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePosition - transform.position;
        float rotz = Mathf.Atan2(rotation.y, rotation.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,rotz);
        if (!canFire)
        {
            timer += Time.deltaTime;
            if(timer> timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
        }
        if (Input.GetMouseButtonDown(0) && canFire)
        {
            canFire = false;
            GameObject bullet1 = Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }
    }
}
