using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossDamage : MonoBehaviour
{
    public Image hpBar;

    public float bossHp = 500.0f;
    float crrHp = 500.0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Bullet2"))
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
        }

        crrHp -= 6.0f;
        hpBar.fillAmount = crrHp / bossHp;

        if(crrHp < 0)
        {
            Destroy(gameObject);
            Debug.Log("Game Clear");
        }
    }
}
