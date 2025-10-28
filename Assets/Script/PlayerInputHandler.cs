using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public bool isJumpPressed = false;  // ���� Ű�� ���� �ִ� ���¸� ����

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpPressed = true;    // �����̽��� ������ �� true
            Debug.Log("���� Ű ����");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumpPressed = false;   // �����̽��� ���� �� false
            Debug.Log("���� Ű ����");
        }

        if (isJumpPressed)
        {
            // �����̽��� ������ �ִ� ���� ����
            HandleJump();
        }
        float axisX = Input.GetAxis("Horizontal");     // �ε巴�� ����
        float rawX = Input.GetAxisRaw("Horizontal");   // ��� -1, 0, 1

       // Debug.Log($"Axis: {axisX}, Raw: {rawX}");
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 move = new Vector2(moveX, moveY).normalized;
        rb.velocity = move * speed;
    }
    void HandleJump()
    {
        Debug.Log("���� ó�� ��...");
        // ���� ����, �ν�Ʈ, ���� �غ� �� ó��
    }

    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
