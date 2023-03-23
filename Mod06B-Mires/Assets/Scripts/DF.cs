using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DF : MonoBehaviour
{
    Shader shader;
    Texture texture;
    Color color;


    public Material mat;
    public float waitTime = 1.0f;
    public float time = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //mat = this.GetComponent<Material>();
        mat = new Material(shader);
        mat.mainTexture= texture;
        mat.color = color;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time < Time.time)
        {
            //Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            //mat.SetColor("_Color", newColor);
            mat.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            time = waitTime + Time.time;
        }
    }
}
