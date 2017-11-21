using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float timer;
    public int strenght;
    private RaycastHit hit;

	void Start ()
    {
        StartCoroutine(Explode());
    }

    IEnumerator Explode ()
    {
        yield return new WaitForSeconds(timer);
        Explosion();
    }

    public void Explosion ()
    {
        StartCoroutine(Destroying());
        StartCoroutine(ExplosionLinger());
    }

    IEnumerator Destroying ()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();

            if (Physics.Raycast(transform.position, Vector3.forward, out hit, strenght))
            {
                if (hit.transform.tag == "Hit")
                    Destroy(hit.transform.gameObject);
            }
            if (Physics.Raycast(transform.position, Vector3.back, out hit, strenght))
            {
                if (hit.transform.tag == "Hit")
                    Destroy(hit.transform.gameObject);
            }
            if (Physics.Raycast(transform.position, Vector3.left, out hit, strenght))
            {
                if (hit.transform.tag == "Hit")
                    Destroy(hit.transform.gameObject);
            }
            if (Physics.Raycast(transform.position, Vector3.right, out hit, strenght))
            {
                if (hit.transform.tag == "Hit")
                    Destroy(hit.transform.gameObject);
            }
        }
    }

    IEnumerator ExplosionLinger ()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
