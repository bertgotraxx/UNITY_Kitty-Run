using Unity.VisualScripting;
using UnityEngine;

public class ParallaxEffectV2 : MonoBehaviour
{
    public float speed = 1.0f;
    public Renderer _render;
    void Update()
    {
        _render.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
