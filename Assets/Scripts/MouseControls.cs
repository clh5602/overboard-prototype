using UnityEngine;

/* Andrew Black
 * 2/16
 * MouseControls deals with the Hover functionality (currently) for moving the mouse over a tile.
 * This highlights the tile to let the player know it's the currently selected one.
 * Future controls for jumping plan to be added
 */

public class HoverHighlight : MonoBehaviour
{
    private Renderer objRenderer;
    private Color originalColor;

    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        originalColor = objRenderer.material.color; 
    }

    void OnMouseEnter()
    {
        objRenderer.material.color = Color.yellow; 
    }

    void OnMouseExit()
    {
        objRenderer.material.color = originalColor;  
    }
}
