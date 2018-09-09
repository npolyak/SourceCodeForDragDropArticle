using NP.Utilities;
using System.ComponentModel;

namespace NP.Tests.DragDropFromListToPanelTest
{
    public class NumberVmWithPostion : NumberVm, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        Point2D _position = new Point2D();
        public Point2D Position
        {
            get => _position;

            set
            {
                if (_position.Equals(value))
                    return;

                _position = value;

                OnPropertyChanged(nameof(Position));
            }
        }

        public NumberVmWithPostion(int n, string str, Point2D position) : base(n, str)
        {
            Position = position;
        }

    }
}
