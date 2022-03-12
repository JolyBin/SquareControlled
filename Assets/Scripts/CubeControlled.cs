using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class CubeControlled : MonoBehaviour
{
    Camera _mainCamera;
    float _distance;

    private void Start()
    {
        _mainCamera = Camera.main;
        _distance = Vector3.Distance(_mainCamera.transform.position, transform.position);
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _distance); // ���������� ������������� ���������� ���� �� ���� � ������
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); // ���������� - ������� �������������� ���������� � ������������ ����
        transform.position = objPosition; // � ���������� ������� ������������� ����������
    }

    public void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy)
        {
            Score.Instance.SetScore(1);
            enemy.Die(); 
        }
    }
}
