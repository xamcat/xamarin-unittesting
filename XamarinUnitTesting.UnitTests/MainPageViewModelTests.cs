using NUnit.Framework;
using XamarinUnitTesting.ViewModels;

namespace XamarinUnitTests.UnitTests
{
    public class MainPageViewModelTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DoTheJob1TestInvalidInput()
        {
            var vm = new MainPageViewModel();
            var result = vm.DoTheJob1Hander(-1);
            
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void DoTheJob1TestOdd()
        {
            var vm = new MainPageViewModel();
            var result = vm.DoTheJob1Hander(31);

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void DoTheJob1TestEven()
        {
            var vm = new MainPageViewModel();
            var result = vm.DoTheJob1Hander(64);

            Assert.AreEqual(result, 1);
        }
    }
}