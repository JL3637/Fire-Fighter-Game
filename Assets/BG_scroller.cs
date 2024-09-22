using UnityEngine;

public class BG_scroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Material material;
    private float offset;
    void Start()
    {
        material = GetComponent<Renderer>().material;
        var tr = GetComponent<Renderer>();
        tr.sortingLayerName = "Background";
    }

    void Update()
    {
        offset += scrollSpeed * Time.deltaTime;
        material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
