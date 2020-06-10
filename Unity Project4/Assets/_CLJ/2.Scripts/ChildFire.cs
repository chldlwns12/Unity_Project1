using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildFire : MonoBehaviour
{
    public GameObject bulletFatory;

    public GameObject bulletPoint;

    bool isStart = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isStart)
        {
            StartCoroutine("Fire");
        }
    }

    IEnumerator Fire()
    {
        isStart = false;

        GameObject bullet = Instantiate(bulletFatory);
        bullet.transform.position = bulletPoint.transform.position;

        yield return new WaitForSeconds(0.5f);

        isStart = true;
    }
}
