using UnityEngine;
using UnityEngine.XR;

//---------------------------------------------------------------------------------
// Description	: This will check which HMD is available. If not try to use Simulator.
//---------------------------------------------------------------------------------
public class newHMDInfoManager : MonoBehaviour
{
    //===================
    // Private Variables
    //===================
    [SerializeField] GameObject mockSimulator;

    //---------------------------------------------------------------------------------
    // Start is when Script is active
    //---------------------------------------------------------------------------------
    protected void Start()
    {
        Debug.Log("Is Device Active: " + XRSettings.isDeviceActive);
        Debug.Log("Device Name is : " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headset plugged in");
            mockSimulator.SetActive(true);
        }
        else if (XRSettings.isDeviceActive && XRSettings.loadedDeviceName == "MockHMD Display")
        {
            Debug.Log("Using Mock HMD");
            mockSimulator.SetActive(true);
        }
        else
        {
            Debug.Log("We Have a Headset " + XRSettings.loadedDeviceName);
            mockSimulator.SetActive(false);
        }
        // Lock Mouse Cursor at center of Game Window and hide it. Press ESC to see cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

}
