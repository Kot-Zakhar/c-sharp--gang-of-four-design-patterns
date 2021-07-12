using System;

namespace Builder {
    // Houses are not derived from common parent on purpose
    public class RealHouse {
        public string Description;

        public override string ToString()
        {
            return Description;
        }
    }
}