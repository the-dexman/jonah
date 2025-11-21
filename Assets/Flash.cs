using UnityEngine;

public class Flash : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] private float flashSpeed;

    internal bool flashActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flashActive)
        {
            spriteRenderer.enabled = Mathf.Sin(Time.time * flashSpeed * 2 * Mathf.PI) > 0 ? true : false;
        }
        
    }

    public void ToggleFlash()
    {
        flashActive = !flashActive;
        spriteRenderer.enabled = !flashActive;
    }
}
