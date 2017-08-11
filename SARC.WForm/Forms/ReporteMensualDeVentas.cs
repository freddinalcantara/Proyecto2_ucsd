using SARC.WForm.Domain.EFRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARC.WForm.Forms
{
    public partial class ReporteMensualDeVentas : MetroFramework.Forms.MetroForm
    {
        private EFContext _dbContext = new EFContext();
        public ReporteMensualDeVentas()
        {
            InitializeComponent();
            Llenartabla();
        }

        public void Llenartabla()
        {
            string conexionStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SARC.WForm.Domain.EFRepository.EFContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            using (var conexion = new SqlConnection(conexionStr))
            {
                conexion.Open();

                var query = "select d.item as Articulo,d.itemprice as Precio,CONVERT(VARCHAR(3),o.createdat,100) as Mes,CONCAT(c.Name,' ',c.LastName) as Cliente from ordendetails d , orders o,Clientes c where d.id = o.id and o.Cliente_Id = c.Id and MONTH(o.CreatedAt) = MONTH(GETDATE()) order by DAY(o.CreatedAt)";
                var dataAdapter = new SqlDataAdapter(query, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgvReporte.ReadOnly = true;
                dgvReporte.DataSource = ds.Tables[0];

            }
        }
    }
}
