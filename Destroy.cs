using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Эта функция вызывается один раз в начале игры
    void Start()
    {
        // Уничтожает объект, к которому прикреплен этот скрипт
        Destroy(gameObject);
    }
}


