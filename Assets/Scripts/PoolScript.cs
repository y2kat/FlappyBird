using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolScript : MonoBehaviour
{

    private List<GameObject> availableObjectList;
    private List<GameObject> activeObjectList;

    [SerializeField] private GameObject poolPrefab;
    [SerializeField] private int startingNumberOfObjects;

    private void Awake()
    {
        availableObjectList = new List<GameObject>();
        activeObjectList = new List<GameObject>();
    }

    void Start()
    {
        CreateObject(startingNumberOfObjects);
    }

    void Update()
    {
        
    }

    private void CreateObject(int numberOfObjects)
    {
        GameObject tempObject;
        for (int i = 0; i < numberOfObjects; i++)
        {
            tempObject = Instantiate(poolPrefab, Vector3.zero, Quaternion.identity, transform);
            tempObject.SetActive(false);
            availableObjectList.Add(tempObject);
        }
    }

    public GameObject RequestObject()
    {
        if (availableObjectList.Count != 0)
        {
            GameObject requestedObject = availableObjectList[0];
            availableObjectList.RemoveAt(0); //como ya está creado el objeto se tiene que eliminar
            activeObjectList.Add(requestedObject); //aquí se agrega a la lista de los objetos activos
            return requestedObject;
        }
        else
        {
            CreateObject(1);
            return RequestObject(); //esto es un ciclo de recursión, una estructura de datos
        }
    }

    public void DespawnObject(GameObject objectToDespawn)
    {
        objectToDespawn.SetActive(false);
        availableObjectList.Add(objectToDespawn);
        activeObjectList.Remove(objectToDespawn);
    }
}
