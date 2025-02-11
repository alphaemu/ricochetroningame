using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LaserAim : MonoBehaviour
{

    private LineRenderer lineRenderer;
    private GameObject target;
    private Transform shotSpawn;

    public Color laserColor;
    public int numAlphaSteps = 3;


    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.material.color = laserColor;
        target = GameObject.FindGameObjectWithTag("Player");
        shotSpawn = transform.GetChild(1);
    }

    private void Update()
    {
        if (!Physics2D.Linecast(shotSpawn.position, target.transform.position, 1 << 8))
        {
            lineRenderer.gameObject.SetActive(true);
            lineRenderer.SetPosition(0, shotSpawn.position);
            lineRenderer.SetPosition(1, target.transform.position);
        }
        //Remove the laser when the Ronin is behind a wall
        else
        {
            lineRenderer.SetPosition(0, shotSpawn.position);
            lineRenderer.SetPosition(1, shotSpawn.position);
        }

    }


    //Fades the alpha of the laser with the specified duration
    public IEnumerator AlphaFade(float duration)
    {
        float timeElapsed = 0;
        while (timeElapsed < duration)
        {
            Color tempColor = laserColor;
            tempColor.a = 0f;
            lineRenderer.material.color = Color.Lerp(tempColor, laserColor, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        lineRenderer.material.color = laserColor;
    }

    //Adjusts the alpha of the laser according to the specified duration and numAlphaSteps. Not a smooth fade like AlphaFade
    public IEnumerator AlphaStep(float duration)
    {
        float timeElapsed = 0;
        float timeSteps = duration / numAlphaSteps;
        float currTimeStep = timeSteps;
        float alphaSteps = 1.0f / numAlphaSteps;
        float currAlphaStep = alphaSteps;

        Color tempColor = laserColor;
        tempColor.a = currAlphaStep;
        lineRenderer.material.color = tempColor;

        while (timeElapsed < duration)
        {
            if (timeElapsed >= currTimeStep)
            {
                currTimeStep += timeSteps;
                currAlphaStep += alphaSteps;
                tempColor = laserColor;
                tempColor.a = currAlphaStep;
                lineRenderer.material.color = tempColor;
            }

            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

    
}
