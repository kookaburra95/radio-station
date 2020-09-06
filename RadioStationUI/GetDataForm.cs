using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RadioStation.Model;

namespace RadioStation  
{
    public partial class GetDataForm : Form
    {
        private DataSet _ds;
        private SqlDataAdapter _adapter;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public GetDataForm()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var name = (mtbName.Text).TrimStart();
            var fname = (mtbFName.Text).TrimStart();    
            int.TryParse(cbPosition.SelectedValue.ToString(), out var positionId);
            var yearOfBirth = (int)numYear.Value;
            var salary = numSalary.Value;

            if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(fname))
            {
                Employee.Name = name;
                Employee.FName = fname;
                Employee.PositionId = positionId;
                Employee.YearOfBirth = yearOfBirth;
                Employee.Salary = salary;


                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите данные!","Ошибка");
            }
        }

        private void GetDataForm_Load(object sender, EventArgs e)
        {
            GetAllPositions();
            numYear.Maximum = DateTime.Now.Year;
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

                    cbPosition.DataSource = _ds.Tables[0];

                    cbPosition.ValueMember = "position_id";
                    cbPosition.DisplayMember = "position_name";
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
