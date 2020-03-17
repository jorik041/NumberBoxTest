using Microsoft.UI.Xaml.Controls;
using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBoxTest.Behaviors {
    class NanToMinimumBehavior : Behavior<NumberBox> {

        protected override void OnAttached() {
            base.OnAttached();
            this.AssociatedObject.ValueChanged += AssociatedObject_ValueChanged;
        }

        protected override void OnDetaching() {
            base.OnDetaching();
            this.AssociatedObject.ValueChanged -= AssociatedObject_ValueChanged;
        }

        private void AssociatedObject_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args) {
            if (double.IsNaN(args.NewValue)) {
                sender.Value = sender.Minimum;
            }
        }
    }
}
