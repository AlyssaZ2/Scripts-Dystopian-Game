using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 
using TMPro; 

public class ThingieThatMakesEverythingWork : MonoBehaviour
{
    private int gold = 0;
    public string newSceneName;
    [SerializeField] private TextMeshProUGUI goldNumber;
    [SerializeField] private TextmeshProUGUI storyText;

    [SerializeField] private TextmeshProUGUI choiceOne;
    [SerializeField] private TextmeshProUGUI choiceTwo;

    [SerializeField] private Button choiceOneButton;
    [SerializeField] private Button choiceTwoButton;

    [SerializeField] private Button mainButton;
    [SerializeField] private TextmeshproUGUI mainButtonText;

    private int storyLine = 0;
    private bool pauseStory = false;
    private string optionOne;
    private string optiontwo;

    private int buttonPress = 0;


//I hope this code makes it to Github
//THE CODE MADE IT TO GITHUBBBBBBBB!!!

    void Start()
    {   
        choiceOneButton.SetActive(false);
        choiceTwoButton.SetActive(false);
        goldNumber.text = gold.ToString();
        overheadText.text = "As you sit at the coffee table, your phone buzzes. It's your daily greeting from the administration.";
        mainButton.SetActive(true);
        mainButtonText.text = "Pick it up.";
        buttonPress = 1;
    }

    public void MainButtonPressed()
    {
        overheadText.SetActive(false);
        mainButton.SetActive(false);
        if(buttonPress == 1)
        {
            BeginStory;
        }
    }
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(newSceneName);
    }
    public void ScreenClickedXD()
    {
        gold = gold + 1;
        goldNumber.text = gold.ToString();
        Debug.Log("The Player has clicked the screen!");
    }

    public void NextButtonPressed()
    {
        if(pauseStory==false){
        storyLine = storyLine + 1;
        }
    }

    void BeginStory()
    {
        while(storyLine < 7)
        {
            storyText.SetActive(true);
            if(storyLine == 0)
            {
                storyText.text = "Good morning valued citizen!";
            }
            else if(storyLine == 1)
            {
                storyText.text = "Are you ready for another day of wonderful work?";
                pauseStory = true;
                optionOne = "Yes!!!";
                optiontwo = "Yes!!!";
                showChoices();
            }
            else if(storyLine == 2)
            {
                storyText.text = "I'm glad to hear that you are just as excited as me to begin the day!!!";
            }
            else if(storyLine == 3)
            {
                storyText.text = "Now, remember, you are in charge of very important work.";
            }
            else if(storyLine == 4)
            {
                storyText.text = "The administration is elated to watch your performance.";
            }
            else if(storyLine == 5)
            {
                storyText.text = "There are eyes everywhere.";
            }
            else if(storyLine == 6)
            {
                storyText.text = "Good luck my beloved little citizen!";
            }
        }
        storyText.SetActive(false);
    }

    void showChoices()
    {
        while (pauseStory == true)
        {
            choiceOneButton.SetActive(true);
            choiceTwoButton.SetActive(true);
            choiceOne.text = optionOne;
            choiceTwo.text = optionTwo;
        }
    }
    public void choiceChosen()
    {
        choiceOneButton.SetActive(false);
        choiceTwoButton.SetActive(false);
        pauseStory = false;
    }
}
