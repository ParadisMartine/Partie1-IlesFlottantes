using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuages : MonoBehaviour
{
    // Start is called before the first frame update

    private float _positionActuelleX;
    private float _positionActuelleY;
    private float _positionActuelleZ;

    private float _vitesse = 0.5f; // ------------pour étape 11



    void Start()
    {   //------------------------------------------Étape 1 
        _positionActuelleX = transform.position.x;
        _positionActuelleY = transform.position.y;
        _positionActuelleZ = transform.position.z;

        //------------------------------------------Étape 2
        //BougeUneFois();

        //------------------------------------------Étape 3
        //Invoke("BougeNuages",0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        //------------------------------------------Étape 4
        BougeNuages();
    }

    void BougeUneFois()
    {
        //transform.position = new Vector3(0,1,0);
        //transform.position = new Vector3(5,5,10);
    }


    void BougeNuages()
    {
        //------------------------------------------Étape 3 et 4
        /* float _nouvellePositionX = _positionActuelleZ + 1;
        transform.position = new Vector3(_nouvellePositionX,_positionActuelleY,_positionActuelleZ); */


        //------------------------------------------Étape 5
        /*  _positionActuelleX = _positionActuelleZ + 1;
         transform.position = new Vector3(_positionActuelleX,_positionActuelleY,_positionActuelleZ);*/

        //------------------------------------------Étape 6

       /*  _positionActuelleZ++;
        transform.position = new Vector3(_positionActuelleX, _positionActuelleY, _positionActuelleZ); */

         //------------------------------------------Étape 7


        //_positionActuelleZ = _positionActuelleZ + 1 * Time.deltaTime;
        //transform.position = new Vector3(_positionActuelleX, _positionActuelleY, _positionActuelleZ); 

       
         //------------------------------------------Étape 8


          //transform.Translate(Vector3.forward);


         //------------------------------------------Étape 9----------- 


         // transform.Translate(Vector3.forward * 2);


        //------------------------------------------Étape 10-----------

          //transform.Translate(Vector3.forward * Time.deltaTime * 2); 

        //------------------------------------------Étape 11----------- 
         
          transform.Translate(Vector3.forward * Time.deltaTime * _vitesse); 

        //------------------------------------------Étape 12 : tourner le nuage sur la scène à -70° 

    }

}
