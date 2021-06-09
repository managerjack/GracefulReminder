using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimCon : MonoBehaviour
{
    public List<Transform> aPaths;
    public List<Transform> bPaths;
    public GameObject[] seacreatures;

    // Start is called before the first frame update
    void Start()
    {
        setPaths(true, null);
    }

    // Update is called once per frame
    void Update()
    {
        swimOnPath();
    }

    void setPaths(bool setStartPaths, GameObject seacreature)
    {
        //set initial path for all seacreatures
        if (setStartPaths)
        {
            for (int i = 0; i < seacreatures.Length; i++)
            {
                int randNum = Random.Range(0, aPaths.Count);
                int randDir = Random.Range(0, 2);

                if (randDir == 0)
                {
                    seacreatures[i].transform.position = aPaths[randNum].position;
                    seacreatures[i].transform.rotation = Quaternion.Euler(Vector3.zero);
                    seacreatures[i].name = bPaths[randNum].position.x.ToString() + ";" + bPaths[randNum].position.y.ToString() + ";"
                        + bPaths[randNum].position.z.ToString();
                }
                else
                {
                    seacreatures[i].transform.position = bPaths[randNum].position;
                    seacreatures[i].transform.rotation = Quaternion.Euler(0, 180, 0);
                    seacreatures[i].name = aPaths[randNum].position.x.ToString() + ";" + aPaths[randNum].position.y.ToString() + ";"
                        + aPaths[randNum].position.z.ToString();
                }
            }

            setStartPaths = false;
        }

        //set new path for all seacreatures
        if (seacreature != null)
        {
            int randNum = Random.Range(0, aPaths.Count);
            int randDir = Random.Range(0, 2);

            if (randDir == 0)
            {
                seacreature.transform.position = aPaths[randNum].position;
                seacreature.transform.rotation = Quaternion.Euler(Vector3.zero);
                seacreature.name = bPaths[randNum].position.x.ToString() + ";" + bPaths[randNum].position.y.ToString() + ";"
                    + bPaths[randNum].position.z.ToString();
            }
            else
            {
                seacreature.transform.position = bPaths[randNum].position;
                seacreature.transform.rotation = Quaternion.Euler(0, 180, 0);
                seacreature.name = aPaths[randNum].position.x.ToString() + ";" + aPaths[randNum].position.y.ToString() + ";"
                    + aPaths[randNum].position.z.ToString();
            }
        }

    }

    void swimOnPath()
    {
        //makes all seacreatures move towards their destination within their path
        for (int i = 0; i < seacreatures.Length; i++)
        {
            if (seacreatures[i].name.Contains(";"))
            {
                Vector3 target = new Vector3(float.Parse(seacreatures[i].name.Split(';')[0]), float.Parse(seacreatures[i].name.Split(';')[1])
                    , float.Parse(seacreatures[i].name.Split(';')[2]));
                seacreatures[i].transform.position = Vector3.MoveTowards(seacreatures[i].transform.position, target, 0.2f);

                if (seacreatures[i].transform.position == target)
                {
                    seacreatures[i].name = "FinalDest";
                    setPaths(false, seacreatures[i]);
                }
            }
        }
    }
}
