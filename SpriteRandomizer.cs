using UnityEngine;

public class SpriteRandomizer : MonoBehaviour
{
    public SpriteRenderer bodyRenderer;
    public SpriteRenderer hairRenderer;
    public SpriteRenderer eyesRenderer;
    public SpriteRenderer noseMouthRenderer;
    public SpriteRenderer shirtRenderer;

    public Sprite[] bodySprites; // Array of body sprites
    public Sprite[] hairSprites; // Array of hair sprites
    public Sprite[] eyeSprites; // Array of eye sprites
    public Sprite[] noseMouthSprites; // Array of nose/mouth sprites
    public Sprite[] shirtSprites; // Array of shirt sprites

    public void RandomizeAppearance()
    {
        bodyRenderer.sprite = bodySprites[Random.Range(0, bodySprites.Length)];
        hairRenderer.sprite = hairSprites[Random.Range(0, hairSprites.Length)];
        eyesRenderer.sprite = eyeSprites[Random.Range(0, eyeSprites.Length)];
        noseMouthRenderer.sprite = noseMouthSprites[Random.Range(0, noseMouthSprites.Length)];
        shirtRenderer.sprite = shirtSprites[Random.Range(0, shirtSprites.Length)];

        Debug.Log("Appearance randomized!");
        Debug.Log("Body Sprite: " + bodyRenderer.sprite);
        Debug.Log("Hair Sprite: " + hairRenderer.sprite);
        Debug.Log("Eyes Sprite: " + eyesRenderer.sprite);
        Debug.Log("Nose/Mouth Sprite: " + noseMouthRenderer.sprite);
        Debug.Log("Shirt Sprite: " + shirtRenderer.sprite);
    }

}
