using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� �Է¿� ���� �÷��̾� ĳ���͸� �����̴� ��ũ��Ʈ
public class PlayerMovement : MonoBehaviour
{
    float time2 = 0;

    public float moveSpeed = 5f; // �յ� �������� �ӵ�
    public float rotateSpeed = 180f; // �¿� ȸ�� �ӵ�

    private PlayerInput playerInput; // �÷��̾� �Է��� �˷��ִ� ������Ʈ

    [SerializeField] private Rigidbody playerRigidbody; // �÷��̾� ĳ������ ������ٵ�
    private Animator playerAnimator; // �÷��̾� ĳ������ �ִϸ�����

    private void Start() // ����� ������Ʈ���� ���� ��������
    {
        playerInput = GetComponent<PlayerInput>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    // FixedUpdata�� ���� ���� �ֱ⿡ ���� �����
    private void FixedUpdate()
    {
        // ���� ���� �ֱ⸶�� ������, ȸ��, �ִϸ��̼� ó�� ����

        // ȸ�� ����
        Rotate();
        // ������ ����
        Move();

        // �Է°��� ���� �ִϸ������� Move �Ķ���Ͱ� ����
        playerAnimator.SetFloat("Move", playerInput.move);
    }

    private void Move() // �Է°��� ���� ĳ���͸� �յڷ� ������
    {
        // ��������� �̵��� �Ÿ� ���
        Vector3 moveDistance = playerInput.move * 
            transform.forward * moveSpeed * Time.deltaTime;
        // ������ٵ� �̿��� ���� ������Ʈ ��ġ ����
        playerRigidbody.MovePosition
            (playerRigidbody.position + moveDistance);
    }

    private void Rotate() // �Է°��� ���� ĳ���͸� �¿�� ȸ��
    {
        // ��������� ȸ���� ��ġ ���
        float turn = playerInput.rotate * 
            rotateSpeed * Time.deltaTime;
        // ������ٵ� �̿��� ���� ������Ʈ ȸ�� ����
        playerRigidbody.rotation = playerRigidbody.rotation *
            Quaternion.Euler(0, turn, 0);
    }
}
