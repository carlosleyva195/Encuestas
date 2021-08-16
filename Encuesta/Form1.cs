using MaterialSkin;
using MaterialSkin.Controls;
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

namespace Encuesta
{
    public partial class Form1 : MaterialForm
    {
        SqlConnection ConectionAmsa = new SqlConnection(@"Data Source=192.168.1.127\COMPAC;Initial Catalog=ReportesAmsa;Persist Security Info=True;User ID=sa;Password=AdminSql7639!");
        SqlConnection ConectionCompac = new SqlConnection(@"Data Source=192.168.1.127\COMPAC;Initial Catalog=adAMSACONTPAQi;Persist Security Info=True;User ID=sa;Password=AdminSql7639!");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        DataTable dt = new DataTable();

        //public static string IdPasa { get; set; }
        public static string IDocumento { get; set; }
        public static string NombreCliente { get; set; }
        public static string NSucursal { get; set; }
        public static string Phone1 { get; set; }
        public static string Phone2 { get; set; }
        public static string SerieDocumento { get; set; }
        public static string CFolio { get; set; }
        public static string CIdAlmacen { get; set; }
        public static string CodigoCliente { get; set; }
        public static string CFecha { get; set; }

        public Form1()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            LlenaCombo();

            //VERDE
            btn_Seleccionar.BackColor = ColorTranslator.FromHtml("#76CA62");

            //ROJO
            btn_salir.BackColor = ColorTranslator.FromHtml("#D66F6F");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cargarGrid();
        }

        private void cargarGrid()
        {
            //SqlCommand cmd = new SqlCommand(@"SELECT doc.CIDDOCUMENTO, doc.CSERIEDOCUMENTO, doc.CFOLIO, doc.CFECHA, doc.CRAZONSOCIAL, 
            //                                    dom.ctelefono1, dom.ctelefono2, mov.cidalmacen, folio.sucnom, cli.CCODIGOCLIENTE
            //                                    from admDocumentos as doc
            //                                    INNER JOIN admDomicilios as dom ON doc.CIDDOCUMENTO = dom.CIDCATALOGO
            //                                    INNER JOIN admMovimientos as mov ON doc.CIDDOCUMENTO = mov.cidDocumento
            //                                    INNER JOIN ReportesAMSA.dbo.folios as folio ON mov.CIDALMACEN = folio.idalmacen
            //                                    INNER JOIN admClientes as cli ON  doc.CIDCLIENTEPROVEEDOR = cli.CIDCLIENTEPROVEEDOR
            //                                    where doc.CIDDOCUMENTODE = 4 and dom.ctipocatalogo = 3 and dom.CTIPODIRECCION = 0 and doc.ccancelado = 0
            //                                    and len(CTELEFONO1)! = 0
            //                                    and doc.CFECHA = cast(DATEADD(DAY, -1, GETDATE()) as date)
            //                                    group by doc.CIDDOCUMENTO, doc.CSERIEDOCUMENTO, doc.CFOLIO, doc.CFECHA, doc.CRAZONSOCIAL,
            //                                    dom.ctelefono1, dom.ctelefono2, mov.cidalmacen, folio.sucnom, cli.CCODIGOCLIENTE", ConectionCompac);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //ConectionCompac.Close();
        }

        private void LlenaCombo()
        {
            ConectionAmsa.Open();
            SqlCommand sc = new SqlCommand("Select idalmacen, sucnom from folios where idalmacen NOT IN (19, 16, 18, 0, 17)", ConectionAmsa);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("sucursal", typeof(string));

            dt.Load(reader);

            metroComboBox1.ValueMember = "idalmacen";
            metroComboBox1.DisplayMember = "sucnom";
            metroComboBox1.DataSource = dt;

            ConectionAmsa.Close();

        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            //IdPasa = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value.ToString();
            IDocumento = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IdDocumento"].Value.ToString();
            NombreCliente = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Nombre"].Value.ToString();
            NSucursal = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Sucursal"].Value.ToString();
            Phone1 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Telefono1"].Value.ToString();
            Phone2 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Telefono2"].Value.ToString();
            SerieDocumento = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Documento"].Value.ToString();
            CFolio = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Folio"].Value.ToString();
            CIdAlmacen = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Almacen"].Value.ToString();
            CodigoCliente = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["CodCliente"].Value.ToString();
            CFecha = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Fecha"].Value.ToString();

            this.Hide();
            using (Encuesta.Preguntas EA = new Encuesta.Preguntas())
            {
                EA.ShowDialog();
            }
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();

            //SqlCommand cmd = new SqlCommand(@"SELECT doc.CIDDOCUMENTO, doc.CSERIEDOCUMENTO, doc.CFOLIO, doc.CFECHA, doc.CRAZONSOCIAL, 
            //                                    dom.ctelefono1, dom.ctelefono2, mov.cidalmacen, folio.sucnom, cli.CCODIGOCLIENTE
            //                                    from admDocumentos as doc
            //                                    INNER JOIN admDomicilios as dom ON doc.CIDDOCUMENTO = dom.CIDCATALOGO
            //                                    INNER JOIN admMovimientos as mov ON doc.CIDDOCUMENTO = mov.cidDocumento
            //                                    INNER JOIN ReportesAMSA.dbo.folios as folio ON mov.CIDALMACEN = folio.idalmacen
            //                                    INNER JOIN admClientes as cli ON  doc.CIDCLIENTEPROVEEDOR = cli.CIDCLIENTEPROVEEDOR
            //                                    where doc.CIDDOCUMENTODE = 4 and dom.ctipocatalogo = 3 and dom.CTIPODIRECCION = 0 and doc.ccancelado = 0
            //                                    and len(CTELEFONO1)! = 0
            //                                    and doc.CFECHA = cast(DATEADD(DAY, -1, GETDATE()) as date)
            //                                    and idalmacen = '" + metroComboBox1.SelectedValue.ToString() + @"'
            //                                    group by doc.CIDDOCUMENTO, doc.CSERIEDOCUMENTO, doc.CFOLIO, doc.CFECHA, doc.CRAZONSOCIAL,
            //                                    dom.ctelefono1, dom.ctelefono2, mov.cidalmacen, folio.sucnom, cli.CCODIGOCLIENTE", ConectionCompac);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlCommand cmd = new SqlCommand(@"select doc.CIDDOCUMENTO, doc.CSERIEDOCUMENTO, doc.CFOLIO, doc.CFECHA, doc.CRAZONSOCIAL, 
                                                dom.ctelefono1, dom.ctelefono2, mov.cidalmacen, folio.sucnom, cli.CCODIGOCLIENTE
                                                from admDocumentos as doc
                                                INNER JOIN admDomicilios as dom ON doc.CIDDOCUMENTO = dom.CIDCATALOGO
                                                INNER JOIN admMovimientos as mov ON doc.CIDDOCUMENTO = mov.cidDocumento
                                                INNER JOIN ReportesAMSA.dbo.folios as folio ON mov.CIDALMACEN = folio.idalmacen
                                                INNER JOIN admClientes as cli ON  doc.CIDCLIENTEPROVEEDOR = cli.CIDCLIENTEPROVEEDOR
                                                where doc.CIDDOCUMENTODE = 4 and dom.ctipocatalogo = 3 and dom.CTIPODIRECCION = 0 and doc.ccancelado = 0
                                                and len (CTELEFONO1)! = 0
                                                and doc.CFECHA = cast(DATEADD(DAY,-3,GETDATE())as date)
                                                and idalmacen = '" + metroComboBox1.SelectedValue.ToString() + @"'
                                                and doc.CIDCLIENTEPROVEEDOR NOT IN (SELECT DOC.CIDCLIENTEPROVEEDOR FROM ReportesAmsa.dbo.ENCUESTAS 
                                                INNER JOIN ADAMSACONTPAQI.DBO.ADMDOCUMENTOS AS DOC
                                                ON ENCUESTAS.IDDOCUMENTO = DOC.CIDDOCUMENTO
                                                WHERE FECHA >= CAST(DATEADD(DAY, -90, GETDATE()) AS DATE))
                                                group by doc.CIDDOCUMENTO, doc.CSERIEDOCUMENTO, doc.CFOLIO, doc.CFECHA, doc.CRAZONSOCIAL, 
                                                dom.ctelefono1, dom.ctelefono2, mov.cidalmacen, folio.sucnom, cli.CCODIGOCLIENTE", ConectionCompac);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            ConectionCompac.Close();
        }

        private void metroComboBox1_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDocumento = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IdDocumento"].Value.ToString();
            NombreCliente = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Nombre"].Value.ToString();
            NSucursal = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Sucursal"].Value.ToString();
            Phone1 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Telefono1"].Value.ToString();
            Phone2 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Telefono2"].Value.ToString();
            SerieDocumento = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Documento"].Value.ToString();
            CFolio = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Folio"].Value.ToString();
            CIdAlmacen = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Almacen"].Value.ToString();
            CodigoCliente = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["CodCliente"].Value.ToString();
            CFecha = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Fecha"].Value.ToString();
        }
    }
}
