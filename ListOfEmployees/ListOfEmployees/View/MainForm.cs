namespace ListOfEmployees
{
    public partial class MainForm : Form
    {
        private Model.EmployeesInfo[] _employees;
        private Model.EmployeesInfo _currentEmploye;

        public MainForm()
        {
            InitializeComponent();
            InitializeEmployees();
        }

        private void InitializeEmployees()
        {
            Random random = new Random();
            _employees = new Model.EmployeesInfo[3];

            _employees[0] = new Model.EmployeesInfo("Беков Антон Алексеевич", "Сварщик", new DateTime(2025, 05, 15), random.Next(10000, 50000));
            _employees[1] = new Model.EmployeesInfo("Смирнов Алексей Витальевич", "Менеджер", new DateTime(2023, 01, 23), random.Next(30000, 50000));
            _employees[2] = new Model.EmployeesInfo("Крылова Августина Денисовна", "Секретарь", new DateTime(2024, 07, 03), random.Next(10000, 50000));

            RefreshEmployeesListBox();
        }

        private void UpdateEmployeInfo(Model.EmployeesInfo employee)
        {
            if (employee == null) return;

            FullNameEmployeTextBox.Text = employee.FullName;
            PositionEmployeTextBox.Text = employee.Position;
            DateOfEmploymentDateTimePicker.Text = employee.DateOfEmployment.ToString();
            SalaryEmployeTextBox.Text = employee.Salary.ToString("F2");

            FullNameEmployeTextBox.BackColor = System.Drawing.Color.White;
            PositionEmployeTextBox.BackColor = System.Drawing.Color.White;
            DateOfEmploymentDateTimePicker.BackColor = System.Drawing.Color.White;
            SalaryEmployeTextBox.BackColor = System.Drawing.Color.White;
        }

        private void ClearEmployeInfo()
        {
            FullNameEmployeTextBox.Text = string.Empty;
            PositionEmployeTextBox.Text = string.Empty;
            DateOfEmploymentDateTimePicker.Text = string.Empty;
            SalaryEmployeTextBox.Text = string.Empty;

            FullNameEmployeTextBox.BackColor = System.Drawing.Color.White;
            PositionEmployeTextBox.BackColor = System.Drawing.Color.White;
            DateOfEmploymentDateTimePicker.BackColor = System.Drawing.Color.White;
            SalaryEmployeTextBox.BackColor = System.Drawing.Color.White;
        }

        private void RefreshEmployeesListBox()
        {
            EmployeesListBox.Items.Clear();
            foreach (var employe in _employees)
            {
                EmployeesListBox.Items.Add(employe.FullName);
            }
            if (_employees.Length > 0)
            {
                EmployeesListBox.SelectedIndex = 0;
            }

            _currentEmploye = _employees[0];
        }

        private void EmployeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeesListBox.SelectedIndex == -1 && EmployeesListBox.SelectedIndex >= _employees.Length)
            {
                ClearEmployeInfo();
                return;
            }

            _currentEmploye = _employees[EmployeesListBox.SelectedIndex];
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
    }
}
