using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Weapon : MonoBehaviour
{
    public float recoil = 1.0f;
    public Transform barrel = null;
    public GameObject projectilePrefab = null;

    private XRGrabInteractable _interactable = null;
    private Rigidbody _rigidBody = null;

    private void Awake()
    {
        _interactable = GetComponent<XRGrabInteractable>();
        _rigidBody = GetComponent<Rigidbody>();

    }

    private void OnEnable()
    {
        _interactable.onActivate.AddListener(Fire);
    }

    private void OnDisable()
    {
        _interactable.onActivate.RemoveListener(Fire);
    }

    private void Fire(XRBaseInteractor interactor)
    {
        CreateProjectile();
        ApplyRecoil();
    }

    private void CreateProjectile()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, barrel.position, barrel.rotation);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch();
    }

    private void ApplyRecoil()
    {
        _rigidBody.AddRelativeForce(Vector3.right * recoil, ForceMode.Impulse);
    }
}
