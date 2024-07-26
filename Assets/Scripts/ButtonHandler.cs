using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    
public string planetName;
    public void OnPlanetButtonClick()
    {
        
        SceneManager.LoadScene("Solar System");

        
        PlayerPrefs.SetString("SelectedPlanet", planetName);
    }
}
