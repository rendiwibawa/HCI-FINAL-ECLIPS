using UnityEngine;
using UnityEngine.UI;

public class ChangeImages : MonoBehaviour
{
    // Public array variable to hold the images to be changed
    public Image[] imagesToChange;

    // Public array variable to hold the new images
    public Sprite[] newImages;

    // Private variable to keep track of the current image index
    private int currentImageIndex = 0;

    // Method to change the image
    public void ChangeImage()
    {
        // Check if the current image index is less than the number of new images
        if (currentImageIndex < newImages.Length)
        {
            // Loop through the array of images to be changed
            for (int i = 0; i < imagesToChange.Length; i++)
            {
                // Change the sprite of the image to the new image
                imagesToChange[i].sprite = newImages[i];
            }

            // Increment the current image index
            currentImageIndex++;
        }
    }
}
