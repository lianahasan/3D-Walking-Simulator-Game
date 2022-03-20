using UnityEngine;

public class RainbowColor : MonoBehaviour
{
    MeshRenderer cubeMeshRenderer;
    [SerializeField] [Range(0f, 1f)] float colorTime;
    [SerializeField] Color[] myColors;

    int cIndex = 0;
    float t = 0f;
    int len;

    // Start is called before the first frame update
    void Start()
    {
        cubeMeshRenderer = GetComponent<MeshRenderer>();
        len = myColors.Length;
    }

    // Update is called once per frame
    void Update()
    {
        cubeMeshRenderer.material.color = Color.Lerp(cubeMeshRenderer.material.color, myColors[cIndex], colorTime*Time.deltaTime);
        t = Mathf.Lerp(t, 1f, colorTime*Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            cIndex++;
            cIndex = (cIndex >= len) ? 0 : cIndex; //resets index
        }
    }
}
