using UnityEngine;
using TMPro;
using System;

public class NpcDialogueHandler : MonoBehaviour
{
    [SerializeField] private DialogueData dialogueData; // NPC ��ȭ ����
    [SerializeField] private GameObject dialougeUI; // ��ȭ â UI
    [SerializeField] private TextMeshProUGUI dialougeText; // ��ȭ â UI

    public object EntityDataManager { get; private set; }

    public void DialogueEvent() // ��ȭ �̺�Ʈ
    {
        if (dialogueData.DialogueComplete()) // ��ȭ�� �������� Ȯ��
        {
            // �����ٸ� ��ȭ ���� �� �ʱ�ȭ
            ControlDialogueInterface(false);
            dialogueData.ResetDialogue();
            return;
        }

        if (!dialougeUI.gameObject.activeSelf) // ��ȭ â�� �������� �ʴٸ� ��ȭ ����
        {
            ControlDialogueInterface(true);
        }

        //// ��ȭ â �ؽ�Ʈ�� ��ȭ ����
        //string playerName = EntityDataManager.Instance.PlayerData.Name;
        //text.Replace("\'@\'", $"\'{playerName}\'"); // Player �̸� ġȯ
        //dialougeText.text = dialogueData.GetDialogue();
    }

    private void ControlDialogueInterface(bool isTrue) // ��ȭ â Ȱ��ȭ/��Ȱ��ȭ
    {
        dialougeUI.gameObject.SetActive(isTrue);
    }
}

internal class DialogueData
{
    internal bool DialogueComplete()
    {
        throw new NotImplementedException();
    }

    internal string GetDialogue()
    {
        throw new NotImplementedException();
    }

    internal void ResetDialogue()
    {
        throw new NotImplementedException();
    }
}