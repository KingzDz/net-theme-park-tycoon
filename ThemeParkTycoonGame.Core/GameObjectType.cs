using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public enum GameObjectType
    {
        // TODO: Convert to bitwise flags?
        Guest = 1, // The park guest

        BuildableObject = 100, // A shop or ride
        Shop = 101, // Only shops
        Coaster = 102, // Only a coaster

        ObjectSpecific = 200, // A burger, fries or front-seat of a coaster
        ShopSpecific = 201, // Only a front- or back-seat
        CoasterSpecific = 202, // Only a burger and fries
    }
}
