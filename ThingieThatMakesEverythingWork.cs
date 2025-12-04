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
//I hope this code makes it to Github

    void Start()
    {
        goldNumber.text = gold.ToString();
    }

    void Update()
    {
        
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
}
