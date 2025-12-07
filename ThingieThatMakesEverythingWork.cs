using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 
using TMPro; 

public class ThingieThatMakesEverythingWork : MonoBehaviour
{
    private int uselessClick = 0;
    //this can be a secret achievement 
    private int dollars = 0;
    public string newSceneName;

    private int dayNumber = 1;
    [SerializeField] private TextMeshProUGUI uselessClickNumber;
    [SerializeField] private Image textBox;
    [SerializeField] private TextMeshProUGUI storyText;
    [SerializeField] private TextMeshProUGUI speakerName;

    [SerializeField] private TextMeshProUGUI choiceOne;
    [SerializeField] private TextMeshProUGUI choiceTwo;

    [SerializeField] private Button choiceOneButton;
    [SerializeField] private Button choiceTwoButton;
    [SerializeField] private Button nextButton;

    [SerializeField] private Button mainButton;
    [SerializeField] private TextMeshProUGUI mainButtonText;
    [SerializeField] private TextMeshProUGUI overheadText;

    // the following will be used as the newspaper article selection interface:
    [SerializeField] private Image newspaperBackground;
    [SerializeField] private Button TabloidAddSpace;
    [SerializeField] private Image TabloidAdImage;

    [SerializeField] private Button MainArticleSpace;
    [SerializeField] private Image MainArticleImage;

    [SerializeField] private Button SideStorySpace;
    [SerializeField] private Image SideStoryImage;

    private int spacesFilled = 0;

    private int storyLine = 0;
    private bool pauseStory = false;
    private string optionOne;
    private string optionTwo;

    private int buttonPress = 0;


//I hope this code makes it to Github
//THE CODE MADE IT TO GITHUBBBBBBBB!!!

    void Start()
    {   
        Debug.Log("The game has started.");
        uselessClickNumber.text = uselessClick.ToString();
        overheadText.gameObject.SetActive(true);
        overheadText.text = "As you sit at the coffee table, your phone buzzes. It's your boss.";
        mainButton.gameObject.SetActive(true);
        mainButtonText.text = "Pick it up.";
        buttonPress = 1;
    }

    public void MainButtonPressed()
    {
        Debug.Log("The button in the center of the center was pressed.");
        overheadText.gameObject.SetActive(false);
        mainButton.gameObject.SetActive(false);
        if(buttonPress == 1)
        {
            ContinueStory();
        }
        else if(buttonPress == 2)
        {
            newspaperBackground.SetActive(true);
        }
    }
    
    public void ChangeScene()
    {
        Debug.Log("The scene was changed to "+ newSceneName + ".");
        SceneManager.LoadScene(newSceneName);
    }
    public void ScreenClickedXD()
    {
        Debug.Log("The screen-not including any overlaying UI?-was clicked.");
        uselessClick = uselessClick + 1;
        uselessClickNumber.text = uselessClick.ToString();
        Debug.Log("The Player has clicked the screen!");
    }

    public void NextButtonPressed()
    {
        //THIS BUTTON MAKES UNITY CRASH OUT TOO :((((((
        Debug.Log("The next button was pressed.");
        if(pauseStory==false){
        storyLine = storyLine + 1;
        ContinueStory();
        }
    }

    void ContinueStory()
    {
        nextButton.gameObject.SetActive(true);
        textBox.gameObject.SetActive(true);
        Debug.Log("The story has started.");
        speakerName.gameObject.SetActive(true);
        //Do not use while-it is too chonk
            if(storyLine == 0)
            {
                speakerName.text = "Mr. Monopoli";
                storyText.text = "Good morning Tom!";
            }
            else if(storyLine == 1)
            {
                storyText.text = "Are you excited for your first day as the manager of the Facts!?";
                pauseStory = true;
                optionOne = "Yes Sir!!!";
                optionTwo = "Yes Sir!!!";
                showChoices();
            }
            else if(storyLine == 2)
            {
                storyText.text = "I'm glad to hear that you are just as excited as me!!!";
            }
            else if(storyLine == 3)
            {
                storyText.text = "There's nothing like passing your responsibilities off to someone else Hohoho!";
            }
            else if(storyLine == 4)
            {
                storyText.text = "Anyway, all you need to is to select which stories and advertisements will run in paper each month.";
            }
            else if(storyLine == 5)
            {
                storyText.text = "Just make sure nothing crude, offensive, or treasonous end up in the paper, or it'll be off with our heads! Hohoho.";
            }
            else if(storyLine == 6)
            {
                storyText.text = "Good luck my beloved little manager!";
            }
            else if(storyLine == 7)
            {
                storyText.text = "Oh ho ho! I almost forgot the most important part!";
            }
            else if(storyLine == 8)
            {
                storyText.text = "Make sure we make a profit this month.";
            }
            else if(storyLine == 9)
            {
                storyText.text = "I'm off on my vacation now! Hohoho!";
            }
            else if(storyText.text == 10)
            {
                speakerName.text="";
                storyText.text = "*bzzt The line goes dead";
            }
            else if(storyLine== 11)
            {
                textBox.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(false);
                startNewDay();
            }
            else
            {
                startNewDay();
            }
    }       

    void startNewDay()
    {
        //This is where the newspaper article selection begins
        Debug.Log("Day " + dayNumber + " has begun.");
        if (dayNumber == 1)
        {
            spacesFilled = 0;
            overheadText.gameObject.SetActive(true);
            overheadText.text = "December 18, XX83, You pull out a stack of proposed articles and get ready to distribute the front page space of next month's issue.";
            buttonPress = 2;
            mainButton.gameObject.SetActive(true);
        }
    
    }

    void showChoices()
    {
        Debug.Log("The choices are shown.");
        //This could be the issue-"while"
        while (pauseStory == true)
        {
            choiceOneButton.gameObject.SetActive(true);
            choiceTwoButton.gameObject.SetActive(true);
            choiceOne.text = optionOne;
            choiceTwo.text = optionTwo;
        }
    }
    public void choiceChosen()
    {
        Debug.Log("A choice was choosen.");
        choiceOneButton.gameObject.SetActive(false);
        choiceTwoButton.gameObject.SetActive(false);
        pauseStory = false;
    }
}
