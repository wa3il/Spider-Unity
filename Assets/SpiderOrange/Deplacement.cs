using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //perso qui bouge dans la direction avant
        Vector3 DirectionAvant = Vector3.forward;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(DirectionAvant *3* Time.deltaTime);
        }


        //perso qui bouge dans la direction avant
        Vector3 DirectionArriere = Vector3.back;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(DirectionArriere *3* Time.deltaTime);
        }


        //perso qui bouge dans la direction avant
        Vector3 DirectionGauche = Vector3.left;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(DirectionGauche *3* Time.deltaTime);
        }


        //perso qui bouge dans la direction avant
        Vector3 DirectionDroite = Vector3.right;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(DirectionDroite *3* Time.deltaTime);
        }

    }
}
