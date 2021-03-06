﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    //위에서 아래로 떨어지기만 한다 (똥피하기 느낌)
    //충돌처리 (에너미랑 플레이어, 에너미랑 플레이어 총알)
    public float speed = 10.0f;
    public GameObject fxFactory;

    // Update is called once per frame
    void Update()
    {
        //아래로 이동해라
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //자기자신도 없애고
        //충돌된 오브젝트도 없앤다
        //Destroy(gameObject, 1.0f);    //1초후에 사라진다.
        if (collision.gameObject.name.Contains("Bullet2"))
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            Destroy(gameObject);

            ShowEffect();

            ScoreManager.instance.EnemyKill();
        }
    }

    void ShowEffect()
    {
        GameObject fx = Instantiate(fxFactory);
        fx.transform.position = transform.position;
    }
}
