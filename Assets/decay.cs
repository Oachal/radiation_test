using System.Collections;

using System.Collections.Generic;

using UnityEngine;

//using UnityEngine.InputSystem;



public class Decay : MonoBehaviour

{

    public GameObject nucleus;

    public int pNum;

    public int nNum;

    public int atomicWeight;

    public Material mat1;

    public Material mat2;

    public GameObject AlphaSpawn;

    public GameObject BetaSpawn;



    // Update is called once per frame

    void Update()

    {

        if (TiltFive.Input.TryGetButtonDown(TiltFive.Input.WandButton.One, out bool onePressed))

        {

            if (onePressed)

            {

                pNum -= 2;

                nNum -= 2;

                atomicWeight = pNum + nNum;

                GameObject newAlpha = Instantiate(AlphaSpawn, transform);
                newAlpha.transform.position = Vector3.zero;
                Rigidbody RAlpha = newAlpha.GetComponent<Rigidbody>();
                RAlpha.AddForce(0, 0, 100, ForceMode.Impulse);

                nucleus.GetComponent<MeshRenderer>().material = mat1;

                Debug.Log("Proton Number: " + pNum + " Neutron Number: " + nNum + " Atomic Weight: " + atomicWeight);



            }

        }

        if (TiltFive.Input.TryGetButtonDown(TiltFive.Input.WandButton.Two, out bool twoPressed))

        {

            if (twoPressed)

            {

                pNum -= 1;

                nNum += 1;

                atomicWeight = pNum + nNum;

                GameObject newBeta = Instantiate(BetaSpawn);
                GameObject newBetaa = Instantiate(BetaSpawn, transform);
                newBeta.transform.position = Vector3.zero;
                Rigidbody RBeta = newBeta.GetComponent<Rigidbody>();
                RBeta.AddForce(0, 0, 100, ForceMode.Impulse);

                nucleus.GetComponent<MeshRenderer>().material = mat2;

                Debug.Log("Proton Number: " + pNum + " Neutron Number: " + nNum + " Atomic Weight: " + atomicWeight);





            }

        }

    }

}