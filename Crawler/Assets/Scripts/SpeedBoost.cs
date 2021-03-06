﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")) {
            var pc = other.GetComponent<PlayerCharacter>();
            pc.GetSpeed();
            Destroy(gameObject);
        }
    }
}
