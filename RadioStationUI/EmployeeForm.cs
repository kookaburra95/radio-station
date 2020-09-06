using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RadioStation.Model;

namespace RadioStation
{
    public partial class EmployeeForm : Form
    {
        private DataSet _ds;
        private SqlDataAdapter _adapter;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public EmployeeForm()
        {
            InitializeComponent();
        }       
            
        private void EmployeeForm_Load(object sender, EventArgs e)  
        {
            GetAllEmployees();  
            GetAllPositions();

            cbFilterPosition.Enabled = false;

            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Имя";
            dataGridView.Columns[2].HeaderText = "Фамилия";
            dataGridView.Columns[3].HeaderText = "Должность";
            dataGridView.Columns[4].HeaderText = "Год рождения";
            dataGridView.Columns[5].HeaderText = "Зарплата";
            dataGridView.Columns[5].DefaultCellStyle.Format = "n2";
        }   

        private void BtAddEmployee_Click(object sender, EventArgs e)
        {
            using (var getData = new GetDataForm())
            {
                if (getData.ShowDialog() == DialogResult.OK)
                {
                    AddEmployee(Employee.Name, Employee.FName, Employee.PositionId, Employee.YearOfBirth, Employee.Salary);

                    MessageBox.Show($"Сотрудник добавлен.","Добавление");
                }
                else
                {
                    MessageBox.Show("Операция отменена.","Добавление");
                }
            }

            GetAllEmployees();
            chIsFiltered.Checked = false;
        }

        private void BtDeleteEmployee_Click(object sender, EventArgs e)
        {
            var employeeId = (int)dataGridView.SelectedRows[0].Cells[0].Value;

            if (MessageBox.Show($"Вы действительно хотите удалить сотрудника с ID:{employeeId}?",
                "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteEmployee(employeeId);
                MessageBox.Show($"Удален сотрудник с ID:{employeeId}.", "Удаление");
                GetAllEmployees();
                chIsFiltered.Checked = false;
            }
        }

        private void СhIsFiltered_CheckedChanged(object sender, EventArgs e)
        {
            if (chIsFiltered.Checked)
            {
                cbFilterPosition.Enabled = true;
                GetFilteredEmployees();
            }   
            else
            {
                cbFilterPosition.Enabled = false;
                GetAllEmployees();
            }
        }

        private void СbFilterPosition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetFilteredEmployees();
        }

        private void GetAllPositions()
        {
            const string sqlExpression = "sp_GetAllPositions";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand(sqlExpression, connection) { CommandType = CommandType.StoredProcedure };

                    _adapter = new SqlDataAdapter(command);
                    _ds = new DataSet();
                    _adapter.Fill(_ds);

                    cbFilterPosition.DataSource = _ds.Tables[0];

                    cbFilterPosition.ValueMember = "position_id";
                    cbFilterPosition.DisplayMember = "position_name";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void GetAllEmployees()
        {
            const string sqlExpression = "sp_GetAllEmployees";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand(sqlExpression, connection) {CommandType = CommandType.StoredProcedure};

                    _adapter = new SqlDataAdapter(command);
                    _ds = new DataSet();
                    _adapter.Fill(_ds); 
                    dataGridView.DataSource = _ds.Tables[0];
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void GetFilteredEmployees()
        {
            const string sqlExpression = "sp_GetFilterPosEmployee";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand(sqlExpression, connection) { CommandType = CommandType.StoredProcedure };

                    var positionIdParam = new SqlParameter
                    {
                        ParameterName = "@position_id",
                        Value = cbFilterPosition.SelectedValue.ToString()
                    };
                    command.Parameters.Add(positionIdParam);    

                    command.ExecuteNonQuery();

                    _adapter = new SqlDataAdapter(command);
                    _ds = new DataSet();
                    _adapter.Fill(_ds);
                    dataGridView.DataSource = _ds.Tables[0];
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AddEmployee(string name, string fName, int positionId, int yearOfBirth, decimal salary)
        {
            const string sqlExpression = "sp_InsertEmployee";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand(sqlExpression, connection) { CommandType = CommandType.StoredProcedure };

                    #region InsertParam

                    //name
                    var nameParam = new SqlParameter
                    {
                        ParameterName = "@name",
                        Value = name
                    };
                    command.Parameters.Add(nameParam);

                    //fname
                    var fNameParam = new SqlParameter   
                    {   
                        ParameterName = "@fname",
                        Value = fName
                    };
                    command.Parameters.Add(fNameParam);

                    //position_id
                    var positionIdParam = new SqlParameter
                    {
                        ParameterName = "@position_id",
                        Value = positionId
                    };
                    command.Parameters.Add(positionIdParam);

                    //yearofbirth
                    var yearofbirthParam = new SqlParameter
                    {
                        ParameterName = "@yearofbirth",
                        Value = yearOfBirth
                    };
                    command.Parameters.Add(yearofbirthParam);

                    //salary
                    var salaryParam = new SqlParameter
                    {
                        ParameterName = "@salary",
                        Value = salary
                    };
                    command.Parameters.Add(salaryParam);

                    #endregion

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DeleteEmployee(int employeeId)
        {
            const string sqlExpression = "sp_DeleteEmployee";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand(sqlExpression, connection) { CommandType = CommandType.StoredProcedure };

                    //employee_id
                    var employeeIdParam = new SqlParameter
                    {
                        ParameterName = "@employee_id",
                        Value = employeeId
                    };
                    command.Parameters.Add(employeeIdParam);

                    command.ExecuteNonQuery();
                }
            }   
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btSalaryReport_Click(object sender, EventArgs e)
        {
            using (var report = new ReportForm())
            {
                report.ShowDialog();
            }
        }
    }
}
