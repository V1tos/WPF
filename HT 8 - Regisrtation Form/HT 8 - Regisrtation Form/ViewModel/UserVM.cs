using HT_8___Regisrtation_Form.Model;
using HT_8___Regisrtation_Form.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HT_8___Regisrtation_Form.ViewModel
{
    public class UserVM : INotifyPropertyChanged
    {

        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

        public RegistrationCommand RegistrationCommand;

        string answer;
        public string Answer
        {
            get => answer;
            set
            {
                answer = value;
                OnNotify();
            }
        }


        public User user;
        public User User
        {
            get => user;
            set
            {
                user = value;
                OnNotify();
            }
        }

        public UserVM()
        {
            User = new User();
            RegistrationCommand = new RegistrationCommand(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnNotify([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


        public void AddUsers()
        {

            Users.Add(new User { FirstName = User.FirstName, LastName = User.LastName, Email = User.Email, Phone = User.Phone, Birthday = User.Birthday, Gender = User.Gender, Password = User.Password });
            Answer = "We have this User !!!!";
        }

    }
}
