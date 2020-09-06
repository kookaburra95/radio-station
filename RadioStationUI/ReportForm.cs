using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace RadioStation
{
    public partial class ReportForm : Form
    {
        private DataSet _ds;
        private SqlDataAdapter _adapter;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            const string sqlExpression = "sp_GetAvgSalary";

            reportViewer.ProcessingMode = ProcessingMode.Local;
            var localReport = reportViewer.LocalReport;
            localReport.ReportPath = @"Reports\avgSalary.rdl";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection) { CommandType = CommandType.StoredProcedure };

                _adapter = new SqlDataAdapter(command);
                _ds = new DataSet();
                _adapter.Fill(_ds);

                ReportDataSource rdsAvgSalary = new ReportDataSource("AvgSalary", _ds.Tables[0]);

                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(rdsAvgSalary);
                this.reportViewer.LocalReport.Refresh();
            }

            this.reportViewer.RefreshReport();
        }
    }
}
