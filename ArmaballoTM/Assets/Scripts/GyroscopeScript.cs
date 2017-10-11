// iOS gyroscope example
//
// Create a cube with camera vector names on the faces.
// Allow the iPhone to show named faces as it is oriented.

using UnityEngine;
using UnityEngine.iOS;

public class ExampleScript : MonoBehaviour
{

    // Textures for each quad, should be +X, +Y etc
    // with appropriate colors, red, green, blue, etc
    public Texture[] labels;

    void Start()
    {
        // make camera solid colour and based at the origin
        GetComponent<Camera>().backgroundColor = new Color(49.0f / 255.0f, 77.0f / 255.0f, 121.0f / 255.0f);
        GetComponent<Camera>().transform.position = new Vector3(0, 0, 0);
        GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
    }

    protected void Update()
    {
        GyroModifyCamera();
    }

    protected void OnGUI()
    {
        GUI.skin.label.fontSize = Screen.width / 40;

        GUILayout.Label("Orientation: " + Screen.orientation);
        GUILayout.Label("input.gyro.attitude: " + Input.gyro.attitude);
        GUILayout.Label("iphone width/font: " + Screen.width + " : " + GUI.skin.label.fontSize);
    }

    /********************************************/

    // The Gyroscope is right-handed.  Unity is left handed.
    // Make the necessary change to the camera.
    void GyroModifyCamera()
    {
        transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}