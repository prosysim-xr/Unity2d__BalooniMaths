using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DestroyAnswerArea : MonoBehaviour
{

    public int score = 0;

    private TextMeshProUGUI scoreTMP;
    // Start is called before the first frame update
    void Start()
    {
        //scoreTMPgameObject.GetComponent<TextMeshProUGUI>().CompareTag
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        score++;
        SceneManager.LoadScene(1);
    }
    
}
