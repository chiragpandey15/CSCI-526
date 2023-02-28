using UnityEngine;
using TMPro;

public class Deck : MonoBehaviour
{
    public int counter = 10;  // Initial value of counter
    private TextMesh textMesh;
    public Color highlightColor = Color.black;  // Color to use for highlight
    private Color originalColor;  // Original color of the game object
    private Renderer renderer;  // Renderer component of the game object
    public Slingshot script;
    public string platformType;
    public TextMeshProUGUI countVal;


    void Start()
    {
        if(countVal!= null){
           countVal.text =  counter.ToString();
        }
    }

    // void OnMouseDown()
    // {
    //     if(counter > 0)
    //     {   
    //         Debug.Log(platformType.ToString());
    //         script.selectedPlatform = platformType;
    //         script.CreatePlatformFromIndex();
    //     }
    // }

    public void checking(){
        if(counter > 0)
        {   
            Debug.Log(platformType.ToString());
            script.selectedPlatform = platformType;
            script.CreatePlatformFromIndex();
        }
    }

    public void DecreaseCount(){
            if(counter > 0){
                counter--;
                countVal.text = counter.ToString();
            }
            if (counter == 0){
                countVal.text = "X";
                script.StopPlatform(platformType);
            }
    }

    public void IncreaseCount(){
            counter++;
            countVal.text = counter.ToString();

    }



}
