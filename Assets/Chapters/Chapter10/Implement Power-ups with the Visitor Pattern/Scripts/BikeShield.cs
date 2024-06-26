using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pattern.Visitor
{
    public class BikeShield : MonoBehaviour, IBikeElement
    {
        public float health = 50f;
        public float Damage(float damage)
        {
            health -= damage;
            return health;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        void OnGUI()
        {
            GUI.color = Color.green;
            GUI.Label(new Rect(125, 0, 200, 20), 
            "Shield Health: " + health);
        }
    }
}

