using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        DesactivarTodosLosVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Resetarvhiculo();
        }
    }
    void Resetarvhiculo()
    {
        DesactivarTodosLosVehiculos();
        vehiculos[Random.Range(0,6)].SetActive(true);

    }
    void DesactivarTodosLosVehiculos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }

    }
}
