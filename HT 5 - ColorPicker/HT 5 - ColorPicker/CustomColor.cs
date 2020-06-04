using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HT_5___ColorPicker
{
    public class CustomColor: INotifyPropertyChanged
    {
        byte alpha = 255;
        byte red;
        byte green;
        byte blue;

        public SolidColorBrush NewColor { get; set; } = new SolidColorBrush();

        public byte Alpha
        {
            get => alpha; set
            {
                alpha = value;
                NewColor = new SolidColorBrush(Color.FromArgb(alpha, red, green, blue));
                OnNotify();
            }
        }
        public byte Red
        {
            get => red; set
            {
                red = value;
                NewColor = new SolidColorBrush(Color.FromArgb(alpha, red, green, blue));
                OnNotify();
            }
        }
        public byte Green
        {
            get => green; set
            {
                green = value;
                NewColor = new SolidColorBrush(Color.FromArgb(alpha, red, green, blue));
                OnNotify();
            }
        }
        public byte Blue
        {
            get => blue; set
            {
                blue = value;
                NewColor = new SolidColorBrush(Color.FromArgb(alpha, red, green, blue));
                OnNotify();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnNotify([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
