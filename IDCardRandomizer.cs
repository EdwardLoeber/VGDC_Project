using UnityEngine;
using UnityEngine.UI;

public class IDCardRandomizer : MonoBehaviour
{
    public Text nameText;
    public Text descriptionText;

    // Arrays for randomizing names and descriptions
    public string[] firstNames = { "John", "Jane", "Alex", "Emma", "Chris", "Mia" };
    public string[] lastNames = { "Smith", "Doe", "Garcia", "Johnson", "Lee", "Brown" };
    public string[] descriptions = { "Friendly demeanor", "Shifty eyes", "Wears a hat", "Quiet", "Talkative", "Nervous" };

    public void RandomizeIDCard(bool isZombie)
    {
        // Randomly select a first name and last name
        string randomFirstName = firstNames[Random.Range(0, firstNames.Length)];
        string randomLastName = lastNames[Random.Range(0, lastNames.Length)];
        nameText.text = randomFirstName + " " + randomLastName;

        // Randomly select a description
        string randomDescription = descriptions[Random.Range(0, descriptions.Length)];
        descriptionText.text = randomDescription;

        // If the guest is a zombie, add a zombie hint to the description
        if (isZombie)
        {
            descriptionText.text += " - Has a strange odor";
        }
    }
}
