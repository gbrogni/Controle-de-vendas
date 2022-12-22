using OrcamentoDeCustos.Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace OrcamentoDeCustos
{
    public partial class Orcamento : Form
    {
        public Orcamento()
        {
            InitializeComponent();
        }

    private void AdicionaLinha(SqlDataReader dr)
    {
      double valorTotal = 0;
      DataGridViewRow row = dgvOrcamento.Rows[dgvOrcamento.Rows.Add()];
      row.Cells["codProduto"].Value = dr["codProduto"] + "";
      row.Cells["nomeProduto"].Value = dr["nomeProduto"] + "";
      row.Cells["custoUni"].Value = dr["custoUni"] + "";
      row.Cells["janeiro"].Value = dr["1"] + "";
      valorTotal += getDoubleValue(dr["1"]);
      row.Cells["fevereiro"].Value = dr["2"] + "";
      valorTotal += getDoubleValue(dr["2"]);
      row.Cells["marco"].Value = dr["3"] + "";
      valorTotal += getDoubleValue(dr["3"]);
      row.Cells["abril"].Value = dr["4"] + "";
      valorTotal += getDoubleValue(dr["4"]);
      row.Cells["maio"].Value = dr["5"] + "";
      valorTotal += getDoubleValue(dr["5"]);
      row.Cells["junho"].Value = dr["6"] + "";
      valorTotal += getDoubleValue(dr["6"]);
      row.Cells["julho"].Value = dr["7"] + "";
      valorTotal += getDoubleValue(dr["7"]);
      row.Cells["agosto"].Value = dr["8"] + "";
      valorTotal += getDoubleValue(dr["8"]);
      row.Cells["setembro"].Value = dr["9"] + "";
      valorTotal += getDoubleValue(dr["9"]);
      row.Cells["outubro"].Value = dr["10"] + "";
      valorTotal += getDoubleValue(dr["10"]);
      row.Cells["novembro"].Value = dr["11"] + "";
      valorTotal += getDoubleValue(dr["11"]);
      row.Cells["dezembro"].Value = dr["12"] + "";
      valorTotal += getDoubleValue(dr["12"]);
      row.Cells["total"].Value = valorTotal;
    }

    private void AdicionaLinhaTodos(SqlDataReader dr)
    {
      double valorTotal = 0;
      double totalCusto = 0;
      DataGridViewRow row = dgvOrcamento.Rows[dgvOrcamento.Rows.Add()];
      row.Cells["codProduto"].Value = dr["codProduto"] + "";
      row.Cells["nomeProduto"].Value = dr["nomeProduto"] + "";
      row.Cells["custoUni"].Value = dr["custoUni"] + "";
      row.Cells["janeiro"].Value = dr["1"] + "";
      valorTotal += getDoubleValue(dr["1"]);
      row.Cells["janCusto"].Value = dr["1c"] + "";
      totalCusto += getDoubleValue(dr["1c"]);
      row.Cells["fevereiro"].Value = dr["2"] + "";
      valorTotal += getDoubleValue(dr["2"]);
      row.Cells["fevCusto"].Value = dr["2c"] + "";
      totalCusto += getDoubleValue(dr["2c"]);
      row.Cells["marco"].Value = dr["3"] + "";
      valorTotal += getDoubleValue(dr["3"]);
      row.Cells["marCusto"].Value = dr["3c"] + "";
      totalCusto += getDoubleValue(dr["3c"]);
      row.Cells["abril"].Value = dr["4"] + "";
      valorTotal += getDoubleValue(dr["4"]);
      row.Cells["abrilCusto"].Value = dr["4c"] + "";
      totalCusto += getDoubleValue(dr["4c"]);
      row.Cells["maio"].Value = dr["5"] + "";
      valorTotal += getDoubleValue(dr["5"]);
      row.Cells["maioCusto"].Value = dr["5c"] + "";
      totalCusto += getDoubleValue(dr["5c"]);
      row.Cells["junho"].Value = dr["6"] + "";
      valorTotal += getDoubleValue(dr["6"]);
      row.Cells["junCusto"].Value = dr["6c"] + "";
      totalCusto += getDoubleValue(dr["6c"]);
      row.Cells["julho"].Value = dr["7"] + "";
      valorTotal += getDoubleValue(dr["7"]);
      row.Cells["julCusto"].Value = dr["7c"] + "";
      totalCusto += getDoubleValue(dr["7c"]);
      row.Cells["agosto"].Value = dr["8"] + "";
      valorTotal += getDoubleValue(dr["8"]);
      row.Cells["agoCusto"].Value = dr["8c"] + "";
      totalCusto += getDoubleValue(dr["8c"]);
      row.Cells["setembro"].Value = dr["9"] + "";
      valorTotal += getDoubleValue(dr["9"]);
      row.Cells["setCusto"].Value = dr["9c"] + "";
      totalCusto += getDoubleValue(dr["9c"]);
      row.Cells["outubro"].Value = dr["10"] + "";
      valorTotal += getDoubleValue(dr["10"]);
      row.Cells["outCusto"].Value = dr["10c"] + "";
      totalCusto += getDoubleValue(dr["10c"]);
      row.Cells["novembro"].Value = dr["11"] + "";
      valorTotal += getDoubleValue(dr["11"]);
      row.Cells["novCusto"].Value = dr["11c"] + "";
      totalCusto += getDoubleValue(dr["11c"]);
      row.Cells["dezembro"].Value = dr["12"] + "";
      valorTotal += getDoubleValue(dr["12"]);
      row.Cells["dezCusto"].Value = dr["12c"] + "";
      totalCusto += getDoubleValue(dr["12c"]);
      row.Cells["total"].Value = valorTotal;
      row.Cells["totalCusto"].Value = totalCusto;
    }

    private double getDoubleValue(object obj)
    {
      if (obj == DBNull.Value)
      {
        return 0;
      }

      return double.Parse(obj.ToString());
    }

    private void ExibirDados()
    {
      try
      {
        using (SqlConnection cn = new SqlConnection(Conn.StrCon))
        {
          cn.Open();

          StringBuilder sql = new StringBuilder();
          sql.AppendLine($@"select top 100 * from (select  codProduto, month(data) as mes, convert(varchar, month(data)) + 'c' as mesc,
          nomeProduto, custoUni,sum(valorVenda) as Total, sum(custoTotal) as Custo from MvtVendasEstruturaConsultaMes where year(data) ='" + comboAno.Text + "' " +
          "group by codProduto, nomeProduto, custoUni, data) as p Pivot(Sum(Total)for mes in ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12]) ) as tabPivot" +
          "  Pivot(Sum(Custo)for mesc in ([1c], [2c], [3c], [4c], [5c], [6c], [7c], [8c], [9c], [10c], [11c], [12c]) ) as tabPivott");

          SqlCommand sqlCommand = cn.CreateCommand();
          sqlCommand.CommandText = sql.ToString();
          using (SqlDataReader dr = sqlCommand.ExecuteReader())
          {
            dgvOrcamento.Rows.Clear();
            while (dr.Read())
            {
              AdicionaLinha(dr);
            }
          }


        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    private void Consultar_Click(object sender, EventArgs e)
    {
      ExibirDados();
    }

    private void Calcular_Click(object sender, EventArgs e)
    {
      try
      {
        using (SqlConnection cn = new SqlConnection(Conn.StrCon))
        {
          cn.Open();

          StringBuilder sql = new StringBuilder();
          sql.AppendLine($@"select top 100 * from (select  codProduto, month(data) as mes, convert(varchar, month(data)) + 'c' as mesc, nomeProduto, custoUni,sum(valorVenda) as Total, sum(custoTotal) as Custo from MvtVendasEstruturaConsultaMes where year(data) ='" + comboAno.Text + "' group by codProduto, nomeProduto, custoUni, data) as p Pivot(Sum(Total)for mes in ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12]) ) as tabPivot  Pivot(Sum(Custo)for mesc in ([1c], [2c], [3c], [4c], [5c], [6c], [7c], [8c], [9c], [10c], [11c], [12c]) ) as tabPivott");

          SqlCommand sqlCommand = cn.CreateCommand();
          sqlCommand.CommandText = sql.ToString();
          using (SqlDataReader dr = sqlCommand.ExecuteReader())
          {
            dgvOrcamento.Rows.Clear();
            while (dr.Read())
            {
              AdicionaLinhaTodos(dr);
            }
          }


        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    private void checkCusto_CheckedChanged(object sender, EventArgs e)
    {
      if (checkCusto.Checked)
      {
        dgvOrcamento.Columns["janCusto"].Visible = false;
        dgvOrcamento.Columns["fevCusto"].Visible = false;
        dgvOrcamento.Columns["abrilCusto"].Visible = false;
        dgvOrcamento.Columns["marCusto"].Visible = false;
        dgvOrcamento.Columns["abrilCusto"].Visible = false;
        dgvOrcamento.Columns["maioCusto"].Visible = false;
        dgvOrcamento.Columns["junCusto"].Visible = false;
        dgvOrcamento.Columns["julCusto"].Visible = false;
        dgvOrcamento.Columns["agoCusto"].Visible = false;
        dgvOrcamento.Columns["setCusto"].Visible = false;
        dgvOrcamento.Columns["outCusto"].Visible = false;
        dgvOrcamento.Columns["novCusto"].Visible = false;
        dgvOrcamento.Columns["dezCusto"].Visible = false;
      }
      else
      {
        dgvOrcamento.Columns["janCusto"].Visible = true;
        dgvOrcamento.Columns["fevCusto"].Visible = true;
        dgvOrcamento.Columns["abrilCusto"].Visible = true;
        dgvOrcamento.Columns["marCusto"].Visible = true;
        dgvOrcamento.Columns["abrilCusto"].Visible = true;
        dgvOrcamento.Columns["maioCusto"].Visible = true;
        dgvOrcamento.Columns["junCusto"].Visible = true;
        dgvOrcamento.Columns["julCusto"].Visible = true;
        dgvOrcamento.Columns["agoCusto"].Visible = true;
        dgvOrcamento.Columns["setCusto"].Visible = true;
        dgvOrcamento.Columns["outCusto"].Visible = true;
        dgvOrcamento.Columns["novCusto"].Visible = true;
        dgvOrcamento.Columns["dezCusto"].Visible = true;
      }
    }

    private void checkTotalVenda_CheckedChanged(object sender, EventArgs e)
    {
      if (checkTotalVenda.Checked)
      {
        dgvOrcamento.Columns["total"].Visible = false;
      }
      else
      {
        dgvOrcamento.Columns["total"].Visible = true;
      }
    }

    private void checkVenda_CheckedChanged(object sender, EventArgs e)
    {
      if (checkVenda.Checked)
      {
        dgvOrcamento.Columns["janeiro"].Visible = false;
        dgvOrcamento.Columns["fevereiro"].Visible = false;
        dgvOrcamento.Columns["abril"].Visible = false;
        dgvOrcamento.Columns["marco"].Visible = false;
        dgvOrcamento.Columns["abril"].Visible = false;
        dgvOrcamento.Columns["maio"].Visible = false;
        dgvOrcamento.Columns["junho"].Visible = false;
        dgvOrcamento.Columns["julho"].Visible = false;
        dgvOrcamento.Columns["agosto"].Visible = false;
        dgvOrcamento.Columns["setembro"].Visible = false;
        dgvOrcamento.Columns["outubro"].Visible = false;
        dgvOrcamento.Columns["novembro"].Visible = false;
        dgvOrcamento.Columns["Dezembro"].Visible = false;
      }
      else
      {
        dgvOrcamento.Columns["janeiro"].Visible = true;
        dgvOrcamento.Columns["fevereiro"].Visible = true;
        dgvOrcamento.Columns["abril"].Visible = true;
        dgvOrcamento.Columns["marco"].Visible = true;
        dgvOrcamento.Columns["abril"].Visible = true;
        dgvOrcamento.Columns["maio"].Visible = true;
        dgvOrcamento.Columns["junho"].Visible = true;
        dgvOrcamento.Columns["julho"].Visible = true;
        dgvOrcamento.Columns["agosto"].Visible = true;
        dgvOrcamento.Columns["setembro"].Visible = true;
        dgvOrcamento.Columns["outubro"].Visible = true;
        dgvOrcamento.Columns["novembro"].Visible = true;
        dgvOrcamento.Columns["Dezembro"].Visible = true;
      }
    }

    private void checkTotalCusto_CheckedChanged(object sender, EventArgs e)
    {
      if (checkTotalCusto.Checked)
      {
        dgvOrcamento.Columns["totalCusto"].Visible = false;
      }
      else
      {
        dgvOrcamento.Columns["totalCusto"].Visible = true;
      }
    }
  }
}
