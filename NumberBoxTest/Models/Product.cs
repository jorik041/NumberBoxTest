using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBoxTest.Models {

    class Product : INotifyPropertyChanged {
        
        private string _productName;
        private double _unitPrice;
        private int _unitsInStock;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string ProductName {
            get => _productName;
            set {
                if (value != _productName) {
                    _productName = value;
                    OnPropertyChanged(nameof(this.ProductName));
                }
            }
        }


        public double UnitPrice {
            get { return _unitPrice; }
            set {
                if (_unitPrice != value) {
                    //_unitPrice = double.IsNaN(value) ? 0 : value;
                    _unitPrice = value;
                    OnPropertyChanged(nameof(UnitPrice));
                }
            }
        }

        public int UnitsInStock {
            get { return _unitsInStock; }
            set {
                if (_unitsInStock != value) {
                    _unitsInStock = value;
                    OnPropertyChanged(nameof(UnitsInStock));
                }
            }
        }
    }
}
