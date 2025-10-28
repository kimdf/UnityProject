using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : TopDownController
{
    public void OnInteract(InputValue value)
    {
        if (value.isPressed) // ��ȣ�ۿ� Ű�� �����ٸ�
        {
            CallInteractEvent(); // ��ȣ�ۿ� �̺�Ʈ ���� �Լ� ȣ��
        }
    }

    private void CallInteractEvent()
    {
        throw new NotImplementedException();
    }
}

public class InputValue
{
    public bool isPressed { get; internal set; }
}

public class TopDownController
{
}