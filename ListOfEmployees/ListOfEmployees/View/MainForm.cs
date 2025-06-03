using ListOfEmployees.Model;
using System;

namespace ListOfEmployees
{
    public partial class MainForm : Form
    {
        private Model.EmployeesInfo[] _employees;
        private Model.EmployeesInfo _currentEmploye;

        public MainForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            _employees = EmployeeDataService.Load();
            RefreshEmployeesListBox();
        }

        private void UpdateEmployeInfo(Model.EmployeesInfo employee)
        {
            if (employee == null) return;

            FullNameEmployeTextBox.Text = employee.FullName;
            PositionEmployeTextBox.Text = employee.Position;
            DateOfEmploymentDateTimePicker.Value = employee.DateOfEmployment.Date;
            SalaryEmployeTextBox.Text = employee.Salary.ToString("F2");

            FullNameEmployeTextBox.BackColor = System.Drawing.Color.White;
            PositionEmployeTextBox.BackColor = System.Drawing.Color.White;
            SalaryEmployeTextBox.BackColor = System.Drawing.Color.White;
        }

        private void ClearEmployeInfo()
        {
            FullNameEmployeTextBox.Text = string.Empty;
            PositionEmployeTextBox.Text = string.Empty;
            DateOfEmploymentDateTimePicker.Value = DateTime.Today;
            SalaryEmployeTextBox.Text = string.Empty;

            FullNameEmployeTextBox.BackColor = System.Drawing.Color.White;
            PositionEmployeTextBox.BackColor = System.Drawing.Color.White;
            SalaryEmployeTextBox.BackColor = System.Drawing.Color.White;
        }

        private void RefreshEmployeesListBox()
        {
            _employees = _employees.OrderBy(emp => emp.FullName).ToArray();
            EmployeesListBox.Items.Clear();
            foreach (var employe in _employees)
            {
                EmployeesListBox.Items.Add(employe.FullName);
            }

            if (_currentEmploye != null)
            {
                for (int i = 0; i < _employees.Length; i++)
                {
                    if (_employees[i].FullName == _currentEmploye.FullName)
                    {
                        EmployeesListBox.SelectedIndex = i;
                        break;
                    }
                }
                UpdateEmployeInfo(_currentEmploye);
            }
            else
            {
                 EmployeesListBox.SelectedIndex = 0;
                _currentEmploye = _employees[EmployeesListBox.SelectedIndex];
                UpdateEmployeInfo(_currentEmploye);
            }
        }

        private void EmployeesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            var selectedIndex = EmployeesListBox.IndexFromPoint(e.Location);

            if (selectedIndex == -1 || selectedIndex >= _employees.Length)
            {
                ClearEmployeInfo();
                EmployeesListBox.SelectedIndex = -1;
                return;
            }

            _currentEmploye = _employees[selectedIndex];
            UpdateEmployeInfo(_currentEmploye);
        }

        private void FullNameEmployeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FullNameEmployeTextBox.Text))
                {
                    FullNameEmployeTextBox.BackColor = System.Drawing.Color.White;
                    return;
                }

                string fullName = FullNameEmployeTextBox.Text.Trim();
                Model.Validator.AssertStringContainsOnlyLetters(fullName, "ФИО сотрудника");
                Model.Validator.AssertStringContainsMaxLetters(fullName, 100, "ФИО сотрудника");

                FullNameEmployeTextBox.BackColor = System.Drawing.Color.White;

                if (EmployeesListBox.SelectedIndex != -1)
                {
                    _currentEmploye.FullName = fullName;
                    RefreshEmployeesListBox();
                }
            }
            catch (ArgumentException)
            {
                FullNameEmployeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void PositionEmployeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(PositionEmployeTextBox.Text))
                {
                    PositionEmployeTextBox.BackColor = System.Drawing.Color.White;
                    return;
                }
                string position = PositionEmployeTextBox.Text.Trim();
                Model.Validator.AssertStringContainsOnlyLetters(position, "Наименование должности");
                Model.Validator.AssertStringContainsMaxLetters(position, 50, "Наименование должности");
                PositionEmployeTextBox.BackColor = System.Drawing.Color.White;

                if (EmployeesListBox.SelectedIndex != -1)
                {
                    _currentEmploye.Position = position;
                }
            }
            catch (ArgumentException)
            {
                PositionEmployeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void DateOfEmploymentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dateEmployment = DateOfEmploymentDateTimePicker.Value.Date;
                Model.Validator.AssertDateNotLaterThanToday(dateEmployment, "Дата приема на работу");
                if (EmployeesListBox.SelectedIndex != -1)
                {
                    _currentEmploye.DateOfEmployment = dateEmployment;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SalaryEmployeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SalaryEmployeTextBox.Text))
                {
                    SalaryEmployeTextBox.BackColor = System.Drawing.Color.White;
                    return;
                }
                var salaryEmploye = double.Parse(SalaryEmployeTextBox.Text);
                Model.Validator.AssertValueInRange(salaryEmploye, 0, 50000, "Зарплата");
                SalaryEmployeTextBox.BackColor = System.Drawing.Color.White;

                if (EmployeesListBox.SelectedIndex != -1)
                {
                    _currentEmploye.Salary = salaryEmploye;
                }
            }
            catch (ArgumentException)
            {
                SalaryEmployeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (Exception)
            {
                SalaryEmployeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void AddEmployeButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FullNameEmployeTextBox.Text) ||
                    string.IsNullOrWhiteSpace(PositionEmployeTextBox.Text) ||
                    string.IsNullOrWhiteSpace(SalaryEmployeTextBox.Text))
                {
                    throw new ArgumentException("Одна или несколько строк пустые");
                }


                Model.EmployeesInfo[] newEmployees = new Model.EmployeesInfo[_employees.Length + 1];
                Model.EmployeesInfo newEmploye;
                for (int i = 0; i < _employees.Length; ++i)
                {
                    newEmployees[i] = _employees[i];
                }

                if (EmployeesListBox.SelectedIndex == -1 || EmployeesListBox.SelectedIndex >= _employees.Length)
                {
                    string fullName = FullNameEmployeTextBox.Text.Trim();
                    string position = PositionEmployeTextBox.Text.Trim();
                    DateTime dateTime = DateOfEmploymentDateTimePicker.Value.Date;
                    double salary = double.Parse(SalaryEmployeTextBox.Text.Trim());
                    newEmploye = new Model.EmployeesInfo(fullName, position, dateTime, salary);
                }
                else
                {
                    newEmploye = new Model.EmployeesInfo("Фамилия Имя Отчество", "Должность", new DateTime(DateTime.Now.Year, 01, 01), 10000);
                }


                newEmployees[_employees.Length] = newEmploye;
                _employees = newEmployees;
                _currentEmploye = _employees[_employees.Length - 1];
                RefreshEmployeesListBox();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteEmployeButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (EmployeesListBox.SelectedIndex == -1 || EmployeesListBox.SelectedIndex >= _employees.Length)
                {
                    throw new ArgumentException("Не выбран работник в списке!");
                }

                Model.EmployeesInfo[] newEmployees = new Model.EmployeesInfo[_employees.Length - 1];
                for (int i = 0, j = 0; i < _employees.Length; i++)
                {
                    if (i != EmployeesListBox.SelectedIndex)
                    {
                        newEmployees[j++] = _employees[i];
                    }
                }

                _employees = newEmployees;
                if (_employees.Length > 0)
                {
                    _currentEmploye = _employees[0];
                }
                RefreshEmployeesListBox();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveNewInfoEmployeButton_MouseClick(object sender, MouseEventArgs e)
        {
            EmployeeDataService.Save(_employees);
            MessageBox.Show("Данные успешно сохранены!");
        }
    }
}
