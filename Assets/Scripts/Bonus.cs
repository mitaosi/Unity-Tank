using UnityEngine;

public abstract class Bonus : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer sprite;
    protected virtual void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        InvokeRepeating("Blink",0,0.1f);
    }

    // Update is called once per frame
    void Blink()
    {
        sprite.enabled =!sprite.enabled;
    }
}
