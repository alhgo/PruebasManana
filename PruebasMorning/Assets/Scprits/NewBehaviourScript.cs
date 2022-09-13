using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] int lifes;
    [SerializeField] float energy;
    float impact;
    bool alive;
    string message;



    // Start is called before the first frame update
    void Start()
    {
        lifes = 3;
        energy = 100f;
        alive = true;

        Impacto();

    }

    void Impacto()
    {
        impact = Random.Range(10f, 200f);

        if(impact >= energy)
        {
            lifes--;

            if(lifes <= 0)
            {
                message = "HAS MUERTO";
                alive = false;
            }
            else
            {
                message = "Has perdido una vida. Te quedan " + lifes;
                energy = 100f;
            }

        }
        else
        {
            energy -= impact;
        }

        print(message);
    }




}
