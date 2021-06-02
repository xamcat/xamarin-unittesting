using System;
using System.Windows.Input;
using Microsoft.MobCAT.MVVM;
using Xamarin.Forms;

namespace XamarinUnitTesting.ViewModels
{
    public class MainPageViewModel : BaseNotifyPropertyChanged
    {
        private string _testProp;
        public string TestProp
        {
            get { return _testProp; }
            set { RaiseAndUpdate(ref _testProp, value); }
        }

        public ICommand DoTheJob1 { get; }

        public MainPageViewModel()
        {
            DoTheJob1 = new Command(o => this.DoTheJob1Hander(int.Parse((string)o)));
            TestProp = "My Test Prop 1";
        }

        public int DoTheJob1Hander(int input)
        {
            if (input <= 0)
                return -1;

            if (input % 2 == 0)
                return 1;

            return 0;
        }
    }
}
