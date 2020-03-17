using Microsoft.UI.Xaml.Controls;
using Microsoft.Xaml.Interactivity;
using Windows.Globalization.NumberFormatting;

namespace NumberBoxTest.Behaviors {

    class IntNumberFormatterBehavior : Behavior<NumberBox> {

        private static DecimalFormatter IntFormatter { get; } =
            new DecimalFormatter(new[] { "nl-NL" }, "NL") {
                IsGrouped = false,
                FractionDigits = 0,
                NumberRounder = new IncrementNumberRounder(),
            };

        protected override void OnAttached() {
            base.OnAttached();
            this.AssociatedObject.NumberFormatter = IntFormatter;
        }
    }
}
