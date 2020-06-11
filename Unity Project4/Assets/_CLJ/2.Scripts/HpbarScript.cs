using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpbarScript : MonoBehaviour
{
    [SerializeField] GameObject hpBarPrefab = null;

    List<Transform> objectList = new List<Transform>();
    List<GameObject> hpBarList = new List<GameObject>();

    Camera cam = null;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;

        GameObject[] objects = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < objects.Length; i++)
        {
            objectList.Add(objects[i].transform);
            GameObject hpBar = Instantiate(hpBarPrefab, objects[i].transform.position, Quaternion.identity, transform);
            hpBarList.Add(hpBar);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < objectList.Count; i++)
        {
            hpBarList[i].transform.position = cam.WorldToScreenPoint(objectList[i].position + new Vector3(0, 1.15f, 0));
        }
    }
}
