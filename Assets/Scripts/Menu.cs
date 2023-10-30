using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public string input;
    public TextMeshProUGUI titleText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputYourName(string name)
    {
        MainManager1.instance.input = name;
        Debug.Log(MainManager1.instance.input);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeTitle()
    {
        titleText.text = "Best Score: " + MainManager1.instance.input + ": "+MainManager1.instance.bestScore;
    }
}
