using UnityEngine;
using UnityEngine.UI;

public class compareText : MonoBehaviour
{
    // Public variables to hold the text objects and the object to display
    public Text firstText;
    public Text secondText;
    public GameObject objectToDisplay;

    // Start is called before the first frame update
    void Start()
    {
        objectToDisplay.SetActive(false);
        // Compare the text values and display the object if the condition is true
        if (firstText.text.CompareTo(secondText.text) > 0)
        {
            objectToDisplay.SetActive(true);
        }
        else
        {
            objectToDisplay.SetActive(false);
        }
    }
}
