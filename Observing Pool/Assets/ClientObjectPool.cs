using UnityEngine;

public class ClientObjectPool : MonoBehaviour
{
    private DroneObjectPool _pool;
    private BikeController _bikeController;

    void Start()
    {
        _pool = gameObject.AddComponent<DroneObjectPool>();
        _bikeController = (BikeController) FindObjectOfType(typeof(BikeController));
    }

    void OnGUI()
    {
        if (GUILayout.Button("Spawn Drones"))
            _pool.Spawn();
            
        if (GUILayout.Button("Damage Bike"))
            if (_bikeController) 
                _bikeController.TakeDamage(15.0f);

        if (GUILayout.Button("Toggle Turbo"))
            if (_bikeController) 
                _bikeController.ToggleTurbo();
    }
}
