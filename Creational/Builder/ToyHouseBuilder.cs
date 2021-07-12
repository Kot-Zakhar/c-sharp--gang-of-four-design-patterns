using System;

namespace Builder {
    public class ToyHouseBuilder : IHouseBuilder {
        ToyHouse house;

        int currentFloor = 0;

        public ToyHouseBuilder() {
            this.Reset();
        }
        public void Reset() {
            this.house = new ToyHouse();
            this.house.Description = "Cutting huge piece of paper and coloring it with grass-green.";
        }

        public IHouseBuilder BuildFoundation() {
            this.house.Description += "\nMarking the boundaries of the house with pencil.";
            return this;
        }

        public IHouseBuilder BuildCeiling() {
            this.house.Description += $"\nCutting a piece of paper and sticking to the walls of {++this.currentFloor} floor.";
            return this;
        }

        public IHouseBuilder BuildWalls(int wallsAmount) {
            this.house.Description += $"\nGluing {wallsAmount} paper walls of {this.currentFloor} floor.";
            return this;
        }

        public IHouseBuilder BuildWindows(int amount) {
            this.house.Description += $"\nCutting {amount} windows at {this.currentFloor} floor.";
            return this;
        }

        public IHouseBuilder BuildRoof() {
            this.house.Description += $"\nGuing paper roof.";
            return this;
        }

        public IHouseBuilder BuildGarage(int capacity) {
            this.house.Description += $"\nCrafting paper box for {capacity} toy cars.";
            return this;
        }

        public IHouseBuilder BuildGarden() {
            this.house.Description += $"\nSticking toy trees to the groud paper.";
            return this;
        }

        public IHouseBuilder BuildSwimmingPool() {
            this.house.Description += $"\nCutting a hole in ground paper.";
            return this;
        }

        public ToyHouse GetResult() {
            return this.house;
        }
    }
}