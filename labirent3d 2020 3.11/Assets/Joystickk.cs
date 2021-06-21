
using UnityEngine;
using UnityEngine.UI;
public class Joystickk : MonoBehaviour
{
    public Text debug;
    Quaternion quatMap;
    Quaternion quatMult = new Quaternion(0, 0, 1, 0);
    Gyroscope gyro;
    void Start()
    {
        gyro = Input.gyro;
        gyro.enabled = true;
    }
    void Update()
    {
        quatMap = new Quaternion(gyro.attitude.x, gyro.attitude.y, gyro.attitude.z, gyro.attitude.w);
        Quaternion qt = quatMap;
        transform.localRotation = qt;
    }
}