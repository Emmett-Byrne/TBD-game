using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleColour : MonoBehaviour
{
    public int minHeight;
    public int maxHeight;
    public Color startColour;
    public Color endColour;
    Color curruntColour;

    public Rigidbody other;

    Renderer m_rend;
    // Start is called before the first frame update
    void Start()
    {
        m_rend = GetComponent<Renderer>();
        curruntColour = startColour;
    }

    // Update is called once per frame
    void Update()
    {
        float scaler = other.position.y / (maxHeight - minHeight);

        curruntColour = startColour + ((endColour - startColour) * scaler);

        m_rend.material.SetColor("_Color", curruntColour);
    }
}
