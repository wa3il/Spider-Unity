using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaySphere : MonoBehaviour
{
    public GameObject targetObject;
    public float legMoveSpeed = 4f;

    public float maxHeight = 2.0f;
    public float timeToPeak = 1f;

    private float totalTime;
    private Vector3 startPosition;

    public LayerMask layersADetecterSphere;

    Vector3 actualPos;
    // Start is called before the first frame update
    void Start()
    {
        totalTime = 0.0f;
        startPosition = transform.position;
        actualPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //tous ce que touche le raycast
        RaycastHit hit;

        // Définir la position de départ du Raycast
        Vector3 rayStart = transform.position;

        // Calculer la direction vers l'objet cible
        Vector3 rayDirection = targetObject.transform.position - rayStart;

        //On dessine le raycast
        Debug.DrawRay(transform.position, rayDirection * 2, Color.red);

        //transform.position = originalPosition;
        layersADetecterSphere = LayerMask.GetMask("sphereAim");

        // raycast 
        if ((Physics.Raycast(transform.position + new Vector3(0f, 0.1f, 0f), rayDirection , out hit, 2, layersADetecterSphere)) && (hit.distance >= 0.9f) && (hit.transform.name == targetObject.name))
        {

            //Debug.Log("Did Hit >= 0.9 : " + hit.transform.name +" "+);
            //actualPos = targetObject.transform.position;
            //Lerp(transform.position, targetObject.transform.position, Time.deltaTime * legMoveSpeed);
            //Debug.Log(targetObject.transform.position + " position transform.pos = " + actualPos);

            totalTime += Time.deltaTime;

            float height = maxHeight * (totalTime - timeToPeak) * (totalTime - timeToPeak) / (4.0f * timeToPeak * timeToPeak);
            float t = Mathf.Clamp01(totalTime / timeToPeak);
            Vector3 newPosition = Vector3.Lerp(startPosition, targetObject.transform.position, t) + new Vector3(0.0f, height, 0.0f);

            actualPos = newPosition;

        }

        transform.position = actualPos;
    }
}
