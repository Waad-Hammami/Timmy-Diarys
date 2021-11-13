using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ColorActivity : MonoBehaviour
{
    
  public Button theButton;
    public ColorBlock theColor;

    void Awake()
    {
        theButton = GetComponent<Button>();
        theColor = GetComponent<Button>().colors;

    }


    public void ButtonTransitionColors()
    {

        theColor.normalColor = Color.blue;
        theColor.pressedColor = Color.red;

        theButton.colors = theColor;
        print("Cliked");
    }
}

