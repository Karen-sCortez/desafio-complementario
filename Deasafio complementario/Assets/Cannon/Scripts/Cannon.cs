using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject bala;
    public Transform SalidaDeBala;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
		{
			Shoot();
		}
    }
	
	private void Shoot()
	{
		Debug.Log("The Cannon has been shoot!");
        Instantiate(objetoAInstanciar, posicionAInstanciar, transform.rotation);
    }
}
