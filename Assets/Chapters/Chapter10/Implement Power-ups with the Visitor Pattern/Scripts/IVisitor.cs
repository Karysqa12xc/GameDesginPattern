using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pattern.Visitor
{
    public interface IVisitor
    {
        void Visit(BikeShield bikeShield);
        void Visit(BikeEngine bikeEngine);
        void Visit(BikeWeapon bikeWeapon);
    }
}

