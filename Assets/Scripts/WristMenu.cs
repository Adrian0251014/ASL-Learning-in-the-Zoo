using UnityEngine;

public class WristMenu : MonoBehaviour
{
    public Transform controller; // �����ֱ���Transform���
    public Vector3 offset = new Vector3(-0.3f, 0f, 1f); // ���ֱ������ƫ����
    public bool reverseY = true; // �Ƿ�תY�᷽��

    void Update()
    {
        if (controller != null)
        {
            // ��ӡƫ������ֵ
            Debug.Log("Offset: " + offset);

            // ��ȡ�ֱ���λ�ú���ת
            Vector3 controllerPos = controller.position;
            Quaternion controllerRot = controller.rotation;

            // ����Canvas��λ�ã��������ƫ����
            Vector3 canvasPos = controllerPos + controllerRot * offset;

            // ����Canvas��λ��
            transform.position = canvasPos;
            Debug.Log("Offset: " + canvasPos);
            // ��ȡ�ֱ�����ת
            Quaternion rotation = controllerRot;

            // �����Ҫ��תY�᷽��
            if (reverseY)
            {
                // ����һ��Y����ת180�ȵ���Ԫ��
                Quaternion y180 = Quaternion.Euler(0f, 180f, 0f);
                // ���ֱ�����ת��Y����ת180�����
                rotation *= y180;
            }

            // ����Canvas����ת
            transform.rotation = rotation;
        }
    }
}
