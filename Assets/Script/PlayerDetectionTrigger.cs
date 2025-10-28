using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NPC ��ȣ�ۿ� ���� �÷��̾� Ž�� Ŭ����
public class PlayerDetectionTrigger : MonoBehaviour
{
    private TopDownController controler;
    [SerializeField] private RectTransform interactionIcon; 
    [SerializeField] private Vector3 interactionIconPosition; 

    private bool isPlayerInside = true; 
    private void Start()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision) // NPC ��ȣ�ۿ� Ȱ��ȭ
    {
        if (!collision.CompareTag("Player")) // �÷��̾ �ƴ϶�� return
        {
            return;
        }

        isPlayerInside = true;
        StartCoroutine(InteractionIconPositionUpdater());
        interactionIcon.gameObject.SetActive(true);

    }
    private void OnTriggerExit2D(Collider2D collision) // NPC ��ȣ�ۿ� ��Ȱ��ȭ
    {
        if (!collision.CompareTag("Player")) // �÷��̾ �ƴ϶�� return
        {
            return;
        }

        isPlayerInside = false;
        interactionIcon.gameObject.SetActive(false);
    }

    private IEnumerator InteractionIconPositionUpdater() // ��ȣ�ۿ� UI ��ġ�� NPC ���� ǥ��
    {
        while (isPlayerInside)
        {
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            interactionIcon.position = screenPosition + interactionIconPosition;

            yield return null;
        }
    }
}