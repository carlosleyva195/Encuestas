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
    public partial class Preguntas : MaterialForm
    {
        SqlConnection EncuestaConection = new SqlConnection(@"Data Source=192.168.1.127\COMPAC;Initial Catalog=ReportesAMSA;Persist Security Info=True;User ID=sa;Password=AdminSql7639!");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public Preguntas()
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

            label8.Text = Form1.NombreCliente;

            //VERDE
            btn_Guardar.BackColor = ColorTranslator.FromHtml("#76CA62");

            //ROJO
            btn_salir.BackColor = ColorTranslator.FromHtml("#D66F6F");

            //AZUL
            btn_Contestar.BackColor = ColorTranslator.FromHtml("#6DADA6");
        }

        private void Preguntas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            guardar();
            this.Close();
        }

        private void guardar()
        {
            try
            {
                string sql = "insert into encuestas ([IdDocumento],[Nombre],[Sucursal],[Telefono1],[Telefono2],[SerieDocumento],[Folio],[IdAlmacen],[CodCliente],[Fecha],[Pregunta1],[Pregunta2],[Pregunta3],[Pregunta4],[Pregunta5],[Comentario], [Llamada])" +
                                                    "values (@IdDocumento,@Nombre,@Sucursal,@Telefono1,@Telefono2,@SerieDocumento,@Folio,@IdAlmacen,@CodCliente,@Fecha,@Pregunta1,@Pregunta2,@Pregunta3,@Pregunta4,@Pregunta5,@Comentario,@Llamada)";
                SqlCommand cmd = new SqlCommand(sql, EncuestaConection);

                cmd.Parameters.AddWithValue("@IdDocumento", Form1.IDocumento);
                cmd.Parameters.AddWithValue("@Nombre", Form1.NombreCliente);
                cmd.Parameters.AddWithValue("@Sucursal", Form1.NSucursal);
                cmd.Parameters.AddWithValue("@Telefono1", Form1.Phone1);
                cmd.Parameters.AddWithValue("@Telefono2", Form1.Phone2);
                cmd.Parameters.AddWithValue("@SerieDocumento", Form1.SerieDocumento);
                cmd.Parameters.AddWithValue("@Folio", Form1.CFolio);
                cmd.Parameters.AddWithValue("@IdAlmacen", Form1.CIdAlmacen);
                cmd.Parameters.AddWithValue("@CodCliente", Form1.CodigoCliente);
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Parse(Form1.CFecha).ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@Pregunta1", Pregunta1.Text);
                cmd.Parameters.AddWithValue("@Pregunta2", Pregunta2.Text);
                cmd.Parameters.AddWithValue("@Pregunta3", Pregunta3.Text);
                cmd.Parameters.AddWithValue("@Pregunta4", Pregunta4.Text);
                cmd.Parameters.AddWithValue("@Pregunta5", Pregunta5.Text);
                cmd.Parameters.AddWithValue("@Comentario", Observacion.Text);
                cmd.Parameters.AddWithValue("@Llamada" , "Si");

                EncuestaConection.Open();
                cmd.ExecuteNonQuery();
                EncuestaConection.Close();
                MessageBox.Show("GUARDADO CON ÉXITO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                SqlError err = ex.Errors[0];
                string mensaje = string.Empty;
                MessageBox.Show(err.ToString(), "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EncuestaConection.Close();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Contestar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into encuestas ([IdDocumento],[Nombre],[Sucursal],[Telefono1],[Telefono2],[SerieDocumento],[Folio],[IdAlmacen],[CodCliente],[Fecha],[Pregunta1],[Pregunta2],[Pregunta3],[Pregunta4],[Pregunta5],[Comentario], [Contesto])" +
                                                    "values (@IdDocumento,@Nombre,@Sucursal,@Telefono1,@Telefono2,@SerieDocumento,@Folio,@IdAlmacen,@CodCliente,@Fecha,@Pregunta1,@Pregunta2,@Pregunta3,@Pregunta4,@Pregunta5,@Comentario,@Contesto)";
                SqlCommand cmd = new SqlCommand(sql, EncuestaConection);

                cmd.Parameters.AddWithValue("@IdDocumento", Form1.IDocumento);
                cmd.Parameters.AddWithValue("@Nombre", Form1.NombreCliente);
                cmd.Parameters.AddWithValue("@Sucursal", Form1.NSucursal);
                cmd.Parameters.AddWithValue("@Telefono1", Form1.Phone1);
                cmd.Parameters.AddWithValue("@Telefono2", Form1.Phone2);
                cmd.Parameters.AddWithValue("@SerieDocumento", Form1.SerieDocumento);
                cmd.Parameters.AddWithValue("@Folio", Form1.CFolio);
                cmd.Parameters.AddWithValue("@IdAlmacen", Form1.CIdAlmacen);
                cmd.Parameters.AddWithValue("@CodCliente", Form1.CodigoCliente);
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Parse(Form1.CFecha).ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@Pregunta1", "");
                cmd.Parameters.AddWithValue("@Pregunta2", "");
                cmd.Parameters.AddWithValue("@Pregunta3", "");
                cmd.Parameters.AddWithValue("@Pregunta4", "");
                cmd.Parameters.AddWithValue("@Pregunta5", "");
                cmd.Parameters.AddWithValue("@Comentario", "");
                cmd.Parameters.AddWithValue("@Contesto", "No");

                EncuestaConection.Open();
                cmd.ExecuteNonQuery();
                EncuestaConection.Close();
                MessageBox.Show("GUARDADO CON ÉXITO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                SqlError err = ex.Errors[0];
                string mensaje = string.Empty;
                MessageBox.Show(err.ToString(), "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EncuestaConection.Close();
            }

            this.Hide();
            using (Encuesta.Form1 EF = new Encuesta.Form1())
            {
                EF.ShowDialog();
            }
            this.Close();
        }
    }
}
