using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAndMove : MonoBehaviour
{
    //PlayerMoveStuff
    public float moveSpeed = 5f; 
    private Rigidbody rb; 
    private Camera cam;
    
    
    [SerializeField] GameObject[] pointsLights;
    [SerializeField] GameObject player;
    [SerializeField] float maxDistance = 10f;
    [SerializeField] float maxIntensity = 5f;
    [SerializeField] Color startColor = Color.red;
    [SerializeField] Color endColor = Color.green;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        cam = Camera.main;
        pointsLights = GameObject.FindGameObjectsWithTag("PointLight");
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

       
        Vector3 camForward = cam.transform.forward; // Richtungsvektor der Kamera
        Vector3 camRight = cam.transform.right; // Vektor nach rechts von der Kamera
        camForward.y = 0f; // Ignoriere die y-Komponente
        camRight.y = 0f; // Ignoriere die y-Komponente
        camForward = camForward.normalized; // Normalisiere den Vektor
        camRight = camRight.normalized; // Normalisiere den Vektor

        
        float horizontalInput = Input.GetAxis("Horizontal"); // Eingabe von der Tastatur
        float verticalInput = Input.GetAxis("Vertical"); // Eingabe von der Tastatur
        Vector3 moveDirection = (camForward * verticalInput + camRight * horizontalInput) * moveSpeed;

        Vector3 newVelocity = rb.velocity;
        newVelocity.x = moveDirection.x;
        newVelocity.z = moveDirection.z;
        rb.velocity = newVelocity;
        //move stuff

        //light Stuff
        foreach(GameObject light in pointsLights)
        {
            Light pointLight = light.GetComponent<Light>();
            UpdateLightProperties(pointLight);
        }


    }
    private void UpdateLightProperties(Light pointLight)
    {
        float distance = Vector3.Distance(player.transform.position, pointLight.transform.position);
        
        if(distance < maxDistance)
        {
            //intensity change
            float intensity = (1 - (distance / maxDistance)) * maxIntensity;
            pointLight.intensity = intensity;

            //Color change
            float colorRatio = (1 - (distance / maxDistance));
            pointLight.color = Color.Lerp(startColor, endColor, colorRatio);


        }
        else
        {
            pointLight.intensity = 0f;
            pointLight.color = startColor;
        }
    }
}
