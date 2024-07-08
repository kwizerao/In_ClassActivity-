using UnityEngine;
using UnityEngine.UI;

public class DataDisplay : MonoBehaviour
{
    public DataSO[] dataObjects; // Array to hold references to your ScriptableObjects
    public Text titleText; // Text UI element to display dataText
    public Image objectIcon; // Image UI element to display dataImage

    void Start()
    {
        // Check if dataObjects array is assigned in the inspector
        if (dataObjects.Length == 0)
        {
            Debug.LogError("Please assign DataSO objects in the inspector!");
            return;
        }

        // Loop through each DataSO and display its text and image
        for (int i = 0; i < dataObjects.Length; i++)
        {
            titleText.text = dataObjects[i].dataText;
            objectIcon.sprite = dataObjects[i].dataImage;

            // Optionally, display on separate UI elements for each object
            // (You'll need additional UI elements like multiple Text and Image)

            // ... (code to display data for each object)
        }
    }
}
