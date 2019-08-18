using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : Bonus
{
    // Start is called before the first frame update
    public int level=1;
    public void UpgradeTank()
    {
        if (level < 3)
        {
            level++;
            if (level == 2)
            {
                //change appearance to level2Tank
                //upgrade canonball speed
            }
            else if (level == 3)
            {	
                //change appearance to level3Tank
                //2 canonball shots at any time
            }
        }
    }    
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Player>().UpgradeTank();
        Destroy(this.gameObject);
    }
}
