using OrcamentoDeCustos.Connection;
using System;
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
            ExibirDados();
        }

    private void AdicionaLinha(SqlDataReader dr)
    {
      double valorTotal = 0;
      DataGridViewRow row = dgvOrcamento.Rows[dgvOrcamento.Rows.Add()];
      row.Cells["codProduto"].Value = dr["codProduto"] + "";
      row.Cells["nomeProduto"].Value = dr["nomeProduto"] + "";
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
          sql.AppendLine($@"select * from (select top 1000 codProduto, month(data) as mes, nomeProduto,
                                      sum(valorVenda) as Total 
                                      from MvtVendasEstruturaConsultaMes
                                      where valorVenda != 0 
                                      group by grouping sets (
                                      (codProduto ,month(data), nomeProduto),
                                      (month(data))))
                                      as tab_resumo
                                      Pivot(
                                      Sum(Total)
                                      for mes in ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12])
                                      ) as tabPivot ");

          SqlCommand sqlCommand = cn.CreateCommand();
          sqlCommand.CommandText = sql.ToString();
          using (SqlDataReader dr = sqlCommand.ExecuteReader())
          {
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

    private void Orcamento_Load(object sender, EventArgs e)
    {
      
    }
  }
}
