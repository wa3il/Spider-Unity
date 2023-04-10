using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDownSphere : MonoBehaviour
{
    
    public LayerMask layersADetecterSol;

    // Update is called once per frame
    void Update()
    {
        //Vecteur direction
        Vector3 Sdown = transform.TransformDirection(Vector3.down);
        Vector3 Sforward = transform.TransformDirection(Vector3.forward);
        layersADetecterSol = LayerMask.GetMask("Sol");

        //object touché par raycast
        RaycastHit hitD;
        //RaycastHit hitF;

        //visualisation du raycast
        Debug.DrawRay(transform.position + new Vector3(0f, 1f, 0f), Sdown * 10, Color.blue);

        if(Physics.Raycast(transform.position + new Vector3(0f, 1f, 0f), Sdown, out hitD, 10, layersADetecterSol))
        {
            transform.position = hitD.point;
            Debug.Log("Did Hit" + hitD.transform.name);
            
            
        }

      /*  Debug.DrawRay(transform.position + new Vector3(0f, 0.1f, 0f)*//*+ new Vector3(0f, 0.1f, 0f)*//*, Sforward * 10, Color.blue);

        while((Physics.Raycast(transform.position + new Vector3(0f, 0.1f, 0f), Sforward, out hitF, 10)) && (hitF.distance <= 0.1f))
        {
            monte_obstacle = true;
            transform.position = hitF.transform.position + new Vector3(0f, 0.1f, 0f);
            Debug.Log("Did Hit" + hitF.transform.name);
        }
        monte_obstacle = false;*/
    }
}
