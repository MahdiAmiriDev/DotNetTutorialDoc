using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Abstract_Factory
{
    internal class WindowsUiFactory : UiAbstractFactory
    {
        public Button CreateButton()
        {
            return new WindowsButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
