using System;

namespace Builder {
    public class RealHouseBuilder : IHouseBuilder {
        RealHouse house;

        int currentFloor = 0;

        public RealHouseBuilder() {
            this.Reset();
        }
        public void Reset() {
            this.house = new RealHouse();
            this.house.Description = "Clearing the area.";
        }

        public IHouseBuilder BuildFoundation() {
            this.house.Description += "\nBuilding the foundation with cement.";
            return this;
        }

        public IHouseBuilder BuildCeiling() {
            this.house.Description += $"\nBuilding the ceiling of {++this.currentFloor} floor.";
            return this;
        }

        public IHouseBuilder BuildWalls(int wallsAmount) {
            this.house.Description += $"\nBuilding {wallsAmount} walls of {this.currentFloor} floor.";
            return this;
        }

        public IHouseBuilder BuildWindows(int amount) {
            this.house.Description += $"\nDrilling {amount} windows at {this.currentFloor} floor.";
            return this;
        }

        public IHouseBuilder BuildRoof() {
            this.house.Description += $"\nSetting the roof.";
            return this;
        }

        public IHouseBuilder BuildGarage(int capacity) {
            this.house.Description += $"\nAdding a cement garage with {capacity} parking slots.";
            return this;
        }

        public IHouseBuilder BuildGarden() {
            this.house.Description += $"\nPlanting trees.";
            return this;
        }

        public IHouseBuilder BuildSwimmingPool() {
            this.house.Description += $"\nDigging the swimming pool.";
            return this;
        }

        public RealHouse GetResult() {
            return this.house;
        }
    }
}