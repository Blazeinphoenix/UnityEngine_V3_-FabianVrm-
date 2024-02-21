using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> listOfCubes = new List<GameObject>();
    [SerializeField] private Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("MyCube");
        foreach (GameObject cube in cubes)
        {
            listOfCubes.Add(cube);
        }
    }

    private void StartLoops()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        for(int i = 0; i < listOfCubes.Count; i++)
        {
            listOfCubes[i].GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }

        ChangePosition();
    }

    private void ChangePosition()
    {
        foreach (GameObject cube in listOfCubes)
        {
            cube.transform.position += new Vector3(0, .5f, 0);
        }

        ScaleCube();
    }

    private void ScaleCube()
    {
        while (toggle.isOn)
        {
            foreach (GameObject cube in listOfCubes)
            {
                cube.transform.localScale -= new Vector3(.01f, .01f, .01f);
            }
        }
    }
}
