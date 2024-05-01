using UnityEngine;

public class WristMenu : MonoBehaviour
{
    public Transform controller; // 引用手柄的Transform组件
    public Vector3 offset = new Vector3(-0.3f, 0f, 1f); // 与手柄的相对偏移量
    public bool reverseY = true; // 是否反转Y轴方向

    void Update()
    {
        if (controller != null)
        {
            // 打印偏移量的值
            Debug.Log("Offset: " + offset);

            // 获取手柄的位置和旋转
            Vector3 controllerPos = controller.position;
            Quaternion controllerRot = controller.rotation;

            // 计算Canvas的位置，加上相对偏移量
            Vector3 canvasPos = controllerPos + controllerRot * offset;

            // 设置Canvas的位置
            transform.position = canvasPos;
            Debug.Log("Offset: " + canvasPos);
            // 获取手柄的旋转
            Quaternion rotation = controllerRot;

            // 如果需要反转Y轴方向
            if (reverseY)
            {
                // 创建一个Y轴旋转180度的四元数
                Quaternion y180 = Quaternion.Euler(0f, 180f, 0f);
                // 将手柄的旋转与Y轴旋转180度相乘
                rotation *= y180;
            }

            // 设置Canvas的旋转
            transform.rotation = rotation;
        }
    }
}
