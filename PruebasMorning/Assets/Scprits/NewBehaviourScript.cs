using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] int lifes;
    [SerializeField] float energy = 200f;
    float impact;
    bool alive;
    string message;



    // Start is called before the first frame update
    void Start()
    {
        energy = 100f;
        alive = true;

        Impacto();
    }

    void Impacto()
    {
        impact = Random.Range(10f, 80f);

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
                //int n = lifes;

                for (int n = lifes; n > 0; n--)
                {
                    print("Estoy animando la vida " + n);
                }



                //Restablezco la energía
                energy = 100f;
                Invoke("Impacto", 2f);

            }

        }
        else
        {
            energy -= impact;
            message = "Cuidado! Solo te queda " + energy + " de escudo";
            Invoke("Impacto", 2f);
        }

        print(message);

        /*
        //BUCLES
        int n = 0;

        while (n < 10)
        {
            n++;
        }
        

        for(int n = 4; n > 0; n--)
        {

        }
        */





    }










}
