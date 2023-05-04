using UnityEngine;

public class hideAwal : MonoBehaviour
{
    // Public array variable to hold the objects to be hidden
    public GameObject[] objectsToHide;

    // Start is called before the first frame update
    void Start()
    {
        // Loop through the array of objects to be hidden
        for (int i = 0; i < objectsToHide.Length; i++)
        {
            // Set the object to inactive
            objectsToHide[i].SetActive(false);
        }
    }
}

