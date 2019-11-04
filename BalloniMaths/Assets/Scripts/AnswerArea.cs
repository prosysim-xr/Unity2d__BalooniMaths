using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AnswerArea : MonoBehaviour
{
    //todo Non repeating randomness
    //public List<string> answersList = new List<string>();

    //public QuestionArea q;

    //private List<string> copyAnswersList;
    //private List<string> randomList; //= new List<string>(3);



    //public TextMeshProUGUI ansTextBlue;
    //public TextMeshProUGUI ansTextGreen;
    //public TextMeshProUGUI ansTextPurple;

    public float speed = 10;
    public Rigidbody2D answerArea;

    //private void Awake()
    //{
    //    //Debug.Log(q.num1);
    //    Debug.Log(q.randomList[0]);
    //    //Debug.Log(q.wrongAnsSum2);
    //}

    void Start()
    {
        //ansTextBlue.gameObject.GetComponent<TextMeshProUGUI>().CompareTag("AnsBlue");
        //ansTextGreen.gameObject.GetComponent<TextMeshProUGUI>().CompareTag("AnsGreen");
        //ansTextPurple.gameObject.GetComponent<TextMeshProUGUI>().CompareTag("AnsPurple");
        
        //answersList.Add(q.ansSum.ToString());
        //answersList.Add(q.wrongAnsSum1.ToString());
        //answersList.Add(q.wrongAnsSum2.ToString());
        //copyAnswersList = new List<string>(q.answersList);
       
        //ShuffleList(copyAnswersList);
        //ansTextBlue.text = randomList[0];
        //ansTextGreen.text = randomList[1];
        //ansTextPurple.text = randomList[2];
        //ansTextBlue.text = q.randomList[0];
        //ansTextGreen.text = q.randomList[1];
        //ansTextPurple.text = q.randomList[2];
    }
    void Update()
    {
        answerArea.velocity = new Vector2(0f, -1 *Time.deltaTime* speed);
    }



    //public void ShuffleList(List<string> answerList)
    //{


    //    System.Random r = new System.Random();
    //    int randomIndex = 0;
    //    while (answerList.Count > 0)
    //    {
    //        randomIndex = r.Next(0, answerList.Count); //Choose a random object in the list
    //        randomList.Add(answerList[randomIndex]); //add it to the new, random list
    //        answerList.RemoveAt(randomIndex); //remove to avoid duplicates
    //    }
    //}
    //public List<string> ShuffleList(List<string> answerList)
    //{


    //    System.Random r = new System.Random();
    //    int randomIndex = 0;
    //    while (answerList.Count > 0)
    //    {
    //        randomIndex = r.Next(0, answerList.Count); //Choose a random object in the list
    //        randomList.Add(answerList[randomIndex]); //add it to the new, random list
    //        answerList.RemoveAt(randomIndex); //remove to avoid duplicates
    //    }

    //    return randomList; //return the new random list
    //}

}
