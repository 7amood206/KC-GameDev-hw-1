using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    int boost = 10;
    int health = 100;
    int damage = 20;

    // Start is called before the first frame update
    void Start()
    {
        print("health "+ health);
        health = damaged();
        print("health after damage"+ health);
        health = boosted();
        print("health after boost "+ health);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    int damaged(){
        return health - damage;
    }

    int boosted(){
        return health + boost;
    }

}
