using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    public BoxCollider2D grid;

    private void Start() {
        RandomizePosition();
    }

    private void RandomizePosition () {

        Bounds bounds = this.grid.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);

    }

    private void OnTriggerEnter2D(Collider2D collider) {

        if(collider.tag == "Snake") {
            RandomizePosition();
        }      

    }

}
