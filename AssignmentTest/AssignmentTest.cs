using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        /// <summary>
        /// Tests the constructor of the Pack class.
        /// </summary>
        [TestMethod]
        public void ConstructorTest()
        {
            // to fix: move class to public
            const int PackMaxItems = 10;
            const float PackMaxVolume = 20;
            const float PackMaxWeight = 30;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);

            Assert.AreEqual(pack.GetMaxCount(), PackMaxItems);
        }

        /// <summary>
        /// Tests the behavior of the Pack class when volume constraint is exceeded.
        /// </summary>
        [TestMethod]
        public void VolumeOverFlowTest()
        {
            const int PackMaxItems = 1000;
            const float PackMaxVolume = 5;
            const float PackMaxWeight = 3000;

            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.AreEqual(pack.Add(new Bow()), true);
        }

        /// <summary>
        /// Tests the behavior of the Pack class when weight constraint is exceeded.
        /// </summary>
        [TestMethod]
        public void WeightOverflowTest()
        {
            const int PackMaxItems = 1000;
            const float PackMaxVolume = 1000;
            const float PackMaxWeight = 10;

            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.IsFalse(pack.Add(new Sword()));
        }

        /// <summary>
        /// Tests the behavior of the Pack class when count constraint is exceeded.
        /// </summary>
        [TestMethod]
        public void CountOverflowTest()
        {
            const int PackMaxItems = 2;
            const float PackMaxVolume = 10;
            const float PackMaxWeight = 10;

            Pack pack = new Pack(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.IsTrue(pack.Add(new Arrow()));
            Assert.IsTrue(pack.Add(new Arrow()));
            Assert.IsFalse(pack.Add(new Arrow()));
        }

        /// <summary>
        /// Tests the behavior of the Pack class when volume and weight constraints are both zero.
        /// </summary>
        [TestMethod]
        public void ZeroVolumeAndWeightTest()
        {
            const int PackMaxItems = 100;
            const int PackMaxVolume = 0;
            const int PackMaxWeight = 0;

            Pack pack = new Pack(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.IsFalse(pack.Add(new Food()));
        }

        /// <summary>
        /// Tests the behavior of the Pack class when adding an item with negative weight and volume.
        /// Expects an ArgumentOutOfRangeException to be thrown.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void InvalidVolumeOrWeightTest()
        {
            const float NegativeWeight = -1.0f;
            const float NegativeVolume = -0.5f;

            const int PackMaxItems = 100;
            const float PackMaxVolume = 100;
            const float PackMaxWeight = 100;

            Pack pack = new Pack(PackMaxItems, PackMaxVolume, PackMaxWeight);
            pack.Add(new Arrow(NegativeWeight, NegativeVolume));
        }
    }
}
