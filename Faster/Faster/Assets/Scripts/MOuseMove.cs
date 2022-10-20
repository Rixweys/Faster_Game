
using UnityEngine;

public class MOuseMove : MonoCache
{
    float x_Rot;
    float y_Rot;
    float x_RotCur;
    float y_RotCur;
    public Camera Hero;
    public GameObject HeroGame;
    public float sensivity = 5f;
    public float SmoothTime = 0.1f;
    float CurentVelocityX;
    float CurentVelocityY;

    void MouseMove()
    {
        x_Rot += Input.GetAxis("Mouse X") * sensivity;
        y_Rot += Input.GetAxis("Mouse Y") * sensivity;

        x_RotCur = Mathf.SmoothDamp(x_RotCur, x_Rot, ref CurentVelocityX, SmoothTime);
        y_RotCur = Mathf.SmoothDamp(y_RotCur, y_Rot, ref CurentVelocityY, SmoothTime);

        Hero.transform.localRotation = Quaternion.Euler(-y_RotCur, 0f, 0f);
        HeroGame.transform.rotation = Quaternion.Euler(0f, x_RotCur, 0f);
    }




    public override void OnTick()
    {
        MouseMove();
    }
}
