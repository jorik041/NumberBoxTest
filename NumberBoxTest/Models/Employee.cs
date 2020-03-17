using System.ComponentModel;

namespace NumberBoxTest.Models {

    class Employee : INotifyPropertyChanged {

        private string _name;
        private decimal _salary;
        private double? _bonus;
        private int _age;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name {
            get => _name;
            set {
                if (value != _name) {
                    _name = value;
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }

        public decimal Salary {
            get => _salary;
            set {
                if (value != _salary) {
                    _salary = value;
                    OnPropertyChanged(nameof(this.Salary));
                }
            }
        }

        public double? Bonus {
            get => _bonus;
            set {
                if (value != _bonus) {
                    _bonus = value;
                    OnPropertyChanged(nameof(this.Bonus));
                }
            }
        }

        public int Age {
            get => _age;
            set {
                if (_age != value) {
                    _age = value;
                    OnPropertyChanged(nameof(Age));
                }
            }
        }

    }
}
