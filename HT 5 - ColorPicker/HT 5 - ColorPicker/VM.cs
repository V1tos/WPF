using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HT_5___ColorPicker
{
    public class VM : INotifyPropertyChanged
    {
        public ObservableCollection<CustomColor> colors { get; set; } = new ObservableCollection<CustomColor>();
        public CustomColor customColor { get; set; } = new CustomColor();

        public bool checkExist = true;

        public bool CheckExist
        {
            get => checkExist;
            set
            {
                checkExist = value;
                OnNotify();
            }
        }

        public bool checkExistColorInCollection()
        {
            foreach (var item in colors)
            {
                if (customColor.NewColor.ToString() == item.NewColor.ToString())
                    return false;
            }

            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnNotify([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
