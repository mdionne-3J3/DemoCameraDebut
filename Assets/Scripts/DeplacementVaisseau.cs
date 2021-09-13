using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeplacementVaisseau : MonoBehaviour
{
    public float vitesseTourne;
    public float vitesseMonte;

    public float vitesseAvant;
    public float vitesseAvantMax;
    public float forceAcceleration;


  

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
           
            float forceRotation = Input.GetAxis("Horizontal") * vitesseTourne * Time.deltaTime;
            float forceMontee = Input.GetAxis("Vertical") * vitesseMonte * Time.deltaTime;

            if (Input.GetKey(KeyCode.E) && vitesseAvant < vitesseAvantMax) // pour accélérer
            {
                vitesseAvant += forceAcceleration;

            }

            if (Input.GetKey(KeyCode.Q) && vitesseAvant > 0f) // pour ralentir
            {

                vitesseAvant -= forceAcceleration;
            }
            
            GetComponent<Rigidbody>().AddRelativeForce(0f, forceMontee, vitesseAvant);
            GetComponent<Rigidbody>().AddRelativeTorque(0f, forceRotation, 0f);


            //correction au niveau de la rotation X et Z
            transform.localEulerAngles = new Vector3(0f, transform.localEulerAngles.y, 0f);

            
        





    }
}
