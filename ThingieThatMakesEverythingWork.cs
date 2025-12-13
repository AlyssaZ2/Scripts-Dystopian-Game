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
    [SerializeField] private TextMeshProUGUI dollarCounter;

    [SerializeField] private TextMeshProUGUI choiceOne;
    [SerializeField] private TextMeshProUGUI choiceTwo;

    [SerializeField] private Button choiceOneButton;
    [SerializeField] private Button choiceTwoButton;
    [SerializeField] private Button nextButton;

    [SerializeField] private Button mainButton;
    [SerializeField] private TextMeshProUGUI mainButtonText;
    [SerializeField] private TextMeshProUGUI overheadText;
    [SerializeField] private Button nextButtonButton;

    // the following will be used as the newspaper article selection interface:
    [SerializeField] private Image articleParent;
    [SerializeField] private Image newspaperBackground;
    [SerializeField] private Button TabloidAddSpace;
    [SerializeField] private Image TabloidAdImage;

    [SerializeField] private Button MainArticleSpace;
    [SerializeField] private Image MainArticleImage;
    [SerializeField] private Button SideStorySpace;
    [SerializeField] private Image SideStoryImage;

    [SerializeField] private Button StackOfMainArticles;
    [SerializeField] private Button StackOfSideArticles;
    [SerializeField] private Button StackOfTabloids;

    private int spacesFilled = 0;

    private int storyLine = 0;
    private bool pauseStory = false;
    private string optionOne;
    private string optionTwo;

    private int buttonPress = 0;
    
    private bool choiceOneSelected = false;
    private bool choiceTwoSelected = false;
    
    private bool mArticleChoosen = false;
    private bool sArticleChoosen = false;
    private bool tSelected = false;


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
            articleParent.gameObject.SetActive(true);
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
                choiceOneSelected = false;
                choiceTwoSelected = false;
                storyText.text = "I'm glad to hear that you are just as excited as me!!!";
            }
            else if(storyLine == 3)
            {
                storyText.text = "There's nothing like passing your responsibilities off to someone else Hohoho!";
            }
            else if(storyLine == 4)
            {
                storyText.text = "Anyways, all you need to do is to select which stories and advertisements will run in paper each month.";
            }
            else if(storyLine == 5)
            {
                storyText.text = "Just make sure nothing crude, offensive, or treasonous ends up in the paper, or it'll be off with our heads! Hohoho.";
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
            else if(storyLine == 10)
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
            mainButtonText.text = "Start Working.";
        }
    
    }

    void showChoices()
    {
        Debug.Log("The choices are shown.");
        if (pauseStory == true)
        {
            nextButtonButton.gameObject.SetActive(false);
            choiceOneButton.gameObject.SetActive(true);
            choiceTwoButton.gameObject.SetActive(true);
            choiceOne.text = optionOne;
            choiceTwo.text = optionTwo;
        }
    }
    public void choiceOneChosen()
    {
        Debug.Log("The first choice was choosen.");
        choiceOneButton.gameObject.SetActive(false);
        choiceTwoButton.gameObject.SetActive(false);
        pauseStory = false;
        choiceOneSelected = true;
        nextButtonButton.gameObject.SetActive(true);
        storyLine = storyLine + 1;
        ContinueStory();
    }
    public void choiceTwoChosen(){
        Debug.Log("The second choice was choosen.");
        choiceOneButton.gameObject.SetActive(false);
        choiceTwoButton.gameObject.SetActive(false);
        pauseStory = false;
        nextButtonButton.gameObject.SetActive(true);
        choiceTwoSelected = true;
        storyLine = storyLine + 1;
        ContinueStory();
    }

    //these are for the image buttons of available article slots
    public void mainArticleSelected(){
        overheadText.gameObject.SetActive(false);
        if(!mArticleChoosen){
            StackOfSideArticles.gameObject.SetActive(false);
            StackOfTabloids.gameObject.SetActive(false);
            StackOfMainArticles.gameObject.SetActive(true);
        }
        else{
            overheadText.gameObject.SetActive(true);
            overheadText.text = "This article has already been choosen.";
        }
    }
    public void secondaryArticleSelected(){
        overheadText.gameObject.SetActive(false);
        if(!sArticleChoosen){
            StackOfMainArticles.gameObject.SetActive(false);
            StackOfTabloids.gameObject.SetActive(false);
            StackOfSideArticles.gameObject.SetActive(true);
        }
        else{
            overheadText.gameObject.SetActive(true);
            overheadText.text = "This article has already been choosen.";
        }
    }
    public void tabloidSelected(){
        overheadText.gameObject.SetActive(false);
        if(!tSelected){
            StackOfMainArticles.gameObject.SetActive(false);
            StackOfSideArticles.gameObject.SetActive(false);
            StackOfTabloids.gameObject.SetActive(true);
        }
        else{
            overheadText.gameObject.SetActive(true);
            overheadText.text = "This article has already been choosen.";
        }
    }

    //this is the button to end the newspaper selection section 
    public void done(){
        if(mArticleChoosen && sArticleChoosen && tSelected){
            hideAllArticleStuff();
            ContinueStory();
        }
    }
    void hideAllArticleStuff(){
        articleParent.gameObject.SetActive(false);
    }
}
