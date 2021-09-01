using System;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace ClassLibrary1
{
    public sealed class Class1
    {
        public void Test(object arg1)
        {
            var iis = (WinRT.IInspectable)arg1;

            var name = iis.GetRuntimeClassName();

            var list = iis.As<IObservableVector<int>>();
        }
    }
}
