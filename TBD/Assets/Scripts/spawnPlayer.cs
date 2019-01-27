using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
    public GameObject particles;
    public GameObject player;
    private IEnumerator coroutine;


    // Start is called before the first frame update
    void Start()
    {
        coroutine = spawnWait(0.5f);
        StartCoroutine(coroutine);
        player.SetActive(false);
        particles.transform.position = player.transform.position;
        particles.SetActive(true);
    }

    IEnumerator spawnWait(float time)
    {
        yield return new WaitForSeconds(time);
        player.SetActive(true);
    }
}
