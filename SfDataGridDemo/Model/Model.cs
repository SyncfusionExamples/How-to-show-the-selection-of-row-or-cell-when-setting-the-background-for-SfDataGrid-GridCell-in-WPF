using System.ComponentModel;

namespace SfDataGridDemo
{
    public class BusinessObjects : INotifyPropertyChanged
    {
        private string _ename;

        public string EmployeeName
        {
            get { return _ename; }
            set
            {
                _ename = value;
                OnPropertyChanged("EmployeeName");
            }
        }

        private int _eage;

        public int EmployeeAge
        {
            get { return _eage; }
            set
            {
                _eage = value;
                OnPropertyChanged("EmployeeAge");
            }
        }

        private string _earea;

        public string EmployeeArea
        {
            get { return _earea; }
            set
            {
                _earea = value;
                OnPropertyChanged("EmployeeArea");
            }
        }

        private string _egender;

        public string EmployeeGender
        {
            get { return _egender; }
            set
            {
                _egender = value;
                OnPropertyChanged("EmployeeGender");
            }
        }

        private int _eExpInMonth;

        public int ExperienceInMonth
        {
            get { return _eExpInMonth; }
            set
            {
                _eExpInMonth = value;
                OnPropertyChanged("ExperienceInMonth");
            }
        }

        private double _esalary;

        public double EmployeeSalary
        {
            get { return _esalary; }
            set
            {
                _esalary = value;
                OnPropertyChanged("EmployeeSalary");
            }
        }

        public BusinessObjects()
        {
                
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}