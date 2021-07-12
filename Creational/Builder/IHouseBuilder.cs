using System;

namespace Builder {
    public interface IHouseBuilder {
        void Reset();
        IHouseBuilder BuildFoundation();
        IHouseBuilder BuildCeiling();
        IHouseBuilder BuildWalls( int wallsAmount);
        IHouseBuilder BuildWindows(int amount);
        IHouseBuilder BuildRoof();
        IHouseBuilder BuildGarage(int capacity);
        IHouseBuilder BuildGarden();
        IHouseBuilder BuildSwimmingPool();
    }
}