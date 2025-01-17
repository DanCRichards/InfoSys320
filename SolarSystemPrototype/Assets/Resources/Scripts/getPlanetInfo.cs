﻿using UnityEngine;
using ApiManager;
using APIObjects;
using TMPro;

public class getPlanetInfo : MonoBehaviour
{
    public string planet;
    public TextMeshPro planetTitle;
    public TextMeshPro latinName;
    public TextMeshPro discoveredBy;
    public TextMeshPro discoveryDate;
    public TextMeshPro generalInfo;
    public GameObject planetObject;
    public GameObject hammer;
    public GameObject hammerText;

    void Start()
       {
        Body bd = APIManager.getPlanetInfo(planet);
        // Earth information here. 
        Debug.Log(bd.EnglishName);
        planetTitle.text = bd.EnglishName;
        latinName.text = bd.Name;
        long aphelion = bd.Aphelion;
        long perihelion = bd.Perihelion;
        
        discoveredBy.text = aphelion.ToString() + " m" ;
        discoveryDate.text = perihelion.ToString() + " m";
        hammerText.GetComponent<TextMeshPro>().text = bd.EnglishName;

<<<<<<< HEAD
        float force = -10 * ((float)bd.Gravity / 9.8f);
        float diameter = 2 * (float)bd.MeanRadius;
        float size;
        if(bd.Name == "Saturn")
        {
             size = diameter / (6371.00840f * 2 * 12);
        }
        else
        {
             size = diameter / (6371.00840f * 2);
        }
       


        Debug.Log(bd.EnglishName + " Has a gravity of " + force.ToString());
        hammer.GetComponent<ConstantForce>().force = new Vector3(0f, force, 0f);
        planetObject.transform.localScale = new Vector3(size, size, size);


        // IMPLEMENT SOMETHING WHERE IT CAN CHANGE THE INFO OF A THE PLANET. A LOT OF PLANET'S DON'T HAVE INFO ON THEM 
=======
// IMPLEMENT SOMETHING WHERE IT CAN CHANGE THE INFO OF A THE PLANET. A LOT OF PLANET'S DON'T HAVE INFO ON THEM 
>>>>>>> 26f476ea808f6fa722d8ca3de94917b82421c7f3
        if (discoveredBy.text == "")
        {
            discoveredBy.text = "Undocumented";
        }
        if (discoveryDate.text == "")
        {
            discoveryDate.text = "Undocumented";
        }
        bool firstCollumn = true;
        int count = 0;
        foreach(Moon mn in bd.Moons)
        {
            count++;
            if (count == 31) break; 
            if (firstCollumn)
            {
            generalInfo.text = generalInfo.text + "\n-" + mn.MoonMoon;
                firstCollumn = !firstCollumn;
            }
            else
            {
            generalInfo.text = generalInfo.text + "\t\t-" + mn.MoonMoon;
                firstCollumn = !firstCollumn;
            }
        }

      
        // Earth Radius = 6371.00840


                 
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
