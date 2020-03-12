using NumberBoxTest.Models;
using Windows.Globalization.NumberFormatting;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NumberBoxTest {
    public sealed partial class MainPage : Page {

        public MainPage() {
            this.InitializeComponent();
        }

        private DecimalFormatter DutchDecimalFormatter { get; } = new DecimalFormatter(new[] { "nl-NL" }, "NL") {
            IsGrouped = true,
            FractionDigits = 2,
            NumberRounder = new IncrementNumberRounder {
                Increment = 0.01,
                RoundingAlgorithm = RoundingAlgorithm.RoundHalfUp,
            }
        };

        private DecimalFormatter IntFormatter { get; } = new DecimalFormatter(new[] { "nl-NL" }, "NL") {
            IsGrouped = false,
            FractionDigits = 0,
            NumberRounder = new IncrementNumberRounder(),
        };

        internal Employee Employee { get; } = new Employee {
            Name = "Fons",
            Salary = 2000,
            Bonus = 100,
            Age = 50
        };

        internal Product Product { get; } = new Product {
            ProductName = "Surface Pro",
            UnitPrice = 1299,
            UnitsInStock = 50
        };

        

    }
}
