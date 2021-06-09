using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterCon : MonoBehaviour
{
    public GameObject letterObj;
    public GameObject keywordsObj;
    public Text freeText;
    private Text[] keywords;
    public string[] chosenWords;
    private int keywordCount;
    public Button sendButton;
    private BoxCollider2D letterCol;

    // Start is called before the first frame update
    void Start()
    {
        letterObj.SetActive(false);
        letterCol = GetComponent<BoxCollider2D>();
        letterCol.size = new Vector2(Display.main.systemWidth, letterCol.size.y);
        keywords = keywordsObj.GetComponentsInChildren<Text>();
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if keywords are being used 
        for (int i = 0; i < keywords.Length; i++)
        {
            if (freeText.text.Contains(keywords[i].text))
            {
                keywordCount++;
                keywords[i].GetComponent<Text>().color = Color.green;  
            }
            else
            {
                keywordCount = 0;
                keywords[i].GetComponent<Text>().color = Color.black;
            }
        }

        //enable send button when all keywords are in use
        if (keywordCount >= 3)
        {
            sendButton.enabled = true;
        }
        else
        {
            sendButton.enabled = false;
        }

        //append every keyboard input to the letter. If user presses backspace, delete last character
        if (Input.anyKey && !Input.GetKey(KeyCode.Backspace) && letterObj.activeSelf)
        {
            freeText.text += Input.inputString;
        }
        else if (Input.GetKeyDown(KeyCode.Backspace) && freeText.text.Length > 0)
        {
            freeText.text = freeText.text.Substring(0, freeText.text.Length - 1);
        }

        //seting the keywords to the chosen words and enabling the letter object
        if (enabled && Time.timeScale == 0)
        {
            letterObj.SetActive(true);

            for (int i = 0; i < chosenWords.Length; i++)
            {
                keywords[i].text = chosenWords[i];
            }
        }
    }

    //click event for whenever user clicks the "Send" - button
    public void OnSendClicked()
    {
        //change color state depending on the type of letter sent
        if (enabled)
        {
            if (gameObject.name == "Letter - Sky")
            {
                ColorCon.instance.colorState = ColorCon.colors.blueSky;

            }
            else if (gameObject.name == "Letter - Ocean")
            {
                ColorCon.instance.colorState = ColorCon.colors.ocean;
            }
            else if (gameObject.name == "Letter - NightForest")
            {
                ColorCon.instance.colorState = ColorCon.colors.nightForest;
            }
            else if (gameObject.name == "Letter - End")
            {
                ColorCon.instance.colorState = ColorCon.colors.end;
            }

            //reset the letter and disable it. Remove the letter collider object
            letterObj.SetActive(false);
            freeText.text = "";
            Cursor.visible = false;
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //turn on the script when colliding with player model
        if (other.name == "Player")
        {
            enabled = true;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
}
