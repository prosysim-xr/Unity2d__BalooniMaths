using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QuestionArea : MonoBehaviour
{

    private List<int> wrongAnsList = new List<int>();
    private List<string> answersList = new List<string>();

    private List<string> copyAnswersList;
    private List<int> copyWrongAnsList;
    public List<string> randomList; //= new List<string>(3);

    public List<int> randomList2; //= new List<string>(3);


    System.Random ran = new System.Random();
    private int num1;
    private int num2;
    private int ansSum;
    private int wrongAnsSum1;
    private int wrongAnsSum2;

    private string ques;

    public TextMeshProUGUI QuesText;

    //answerarea things
    public TextMeshProUGUI ansTextBlue;
    public TextMeshProUGUI ansTextGreen;
    public TextMeshProUGUI ansTextPurple;
    

    public void Awake()
    {
    }
    public void Start() 
    {
        //answer area things
        ansTextBlue.gameObject.GetComponent<TextMeshProUGUI>().CompareTag("AnsBlue");
        ansTextGreen.gameObject.GetComponent<TextMeshProUGUI>().CompareTag("AnsGreen");
        ansTextPurple.gameObject.GetComponent<TextMeshProUGUI>().CompareTag("AnsPurple");
        //quesarea things
        QuesText = gameObject.GetComponent<TextMeshProUGUI>();//Text name = GameObject.Find("Canvas/playerInformation/Name").GetComponent<Text>();
                                                              //name.text = "Bob";

        num1 = ran.Next(0, 20);
        num2 = ran.Next(0, 10);
        ansSum = num1 + num2;
        
        ques = num1.ToString() + " + " + num2.ToString();
        QuesText.text = ques;

        wrongAnsList.Add(-1);
        wrongAnsList.Add(-2);
        wrongAnsList.Add(1);
        wrongAnsList.Add(2);

        copyWrongAnsList = new List<int>(wrongAnsList);
        ShuffleList2(copyWrongAnsList);

        wrongAnsSum1 = ansSum + randomList2[0];
        wrongAnsSum2 = ansSum + randomList2[1];


        answersList.Add(ansSum.ToString());
        answersList.Add(wrongAnsSum1.ToString());
        answersList.Add(wrongAnsSum2.ToString());

        copyAnswersList = new List<string>(answersList);
        ShuffleList(copyAnswersList);
        ansTextBlue.text = randomList[0];
        ansTextGreen.text = randomList[1];
        ansTextPurple.text = randomList[2];

    }

    public void ShuffleList(List<string> answerList)
    {
        System.Random r = new System.Random();
        int randomIndex = 0;
        while (answerList.Count > 0)
        {
            randomIndex = r.Next(0, answerList.Count); //Choose a random object in the list
            randomList.Add(answerList[randomIndex]); //add it to the new, random list
            answerList.RemoveAt(randomIndex); //remove to avoid duplicates
        }
    }

    public void ShuffleList2(List<int> answerList)
    {
        System.Random r = new System.Random();
        int randomIndex = 0;
        while (answerList.Count > 0)
        {
            randomIndex = r.Next(0, answerList.Count); //Choose a random object in the list
            randomList2.Add(answerList[randomIndex]); //add it to the new, random list
            answerList.RemoveAt(randomIndex); //remove to avoid duplicates
        }
    }


}
