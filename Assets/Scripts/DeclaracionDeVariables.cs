﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int cantidadAlumnos;
    float magnitudTerremoto;
    string nombreAlumno;
    bool compuHabilitada;

    // Start is called before the first frame update
    void Start()
    {
        canntidadAlumnos = 24;
        magnitudTerremoto = 9.3f;
        nombreAlumno = "Jeronimo";
            compuHabilitada = false;

        Debug.Log(cantidadAlumnos);
        Debug.log(magnitudTerremoto)       
        Debug.log(nombreAlumno)        
        Debug.log(compuHabilitada)


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
