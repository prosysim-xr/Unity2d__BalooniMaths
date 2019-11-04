using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerLimiter : MonoBehaviour
{
    //private int life = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="AnswerArea")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(1);
            //if (life > 0) { life--; }
            
            //if (life < 0)
            //{
            //    SceneManager.LoadScene(3);
            //}

        }
    }
}
