using OrcamentoDeCustos.Connection;
using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace OrcamentoDeCustos
{
  public partial class Orcamento : Form
  {
    double totalVenda = 0;
    double valorTotalCusto = 0;
    double jan = 0; double janC = 0;
    double fev = 0; double fevC = 0;
    double mar = 0; double marC = 0;
    double abr = 0; double abrC = 0;
    double mai = 0; double maiC = 0;
    double jun = 0; double junC = 0;
    double jul = 0; double julC = 0;
    double ago = 0; double agoC = 0;
    double set = 0; double setC = 0;
    double oct = 0; double octC = 0;
    double nov = 0; double novC = 0;
    double dez = 0; double dezC = 0;

    double media = 0;
    double Av = 0;
    double Lucros = 0;

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
      row.Cells["venda1"].Value = dr["1"] + "";
      valorTotal += getDoubleValue(dr["1"]);
      row.Cells["venda2"].Value = dr["2"] + "";
      valorTotal += getDoubleValue(dr["2"]);
      row.Cells["venda3"].Value = dr["3"] + "";
      valorTotal += getDoubleValue(dr["3"]);
      row.Cells["venda4"].Value = dr["4"] + "";
      valorTotal += getDoubleValue(dr["4"]);
      row.Cells["venda5"].Value = dr["5"] + "";
      valorTotal += getDoubleValue(dr["5"]);
      row.Cells["venda6"].Value = dr["6"] + "";
      valorTotal += getDoubleValue(dr["6"]);
      row.Cells["venda7"].Value = dr["7"] + "";
      valorTotal += getDoubleValue(dr["7"]);
      row.Cells["venda8"].Value = dr["8"] + "";
      valorTotal += getDoubleValue(dr["8"]);
      row.Cells["venda9"].Value = dr["9"] + "";
      valorTotal += getDoubleValue(dr["9"]);
      row.Cells["venda10"].Value = dr["10"] + "";
      valorTotal += getDoubleValue(dr["10"]);
      row.Cells["venda11"].Value = dr["11"] + "";
      valorTotal += getDoubleValue(dr["11"]);
      row.Cells["venda12"].Value = dr["12"] + "";
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
      row.Cells["venda1"].Value = dr["1"] + "";
      valorTotal += getDoubleValue(dr["1"]);
      row.Cells["custo1"].Value = dr["1c"] + "";
      totalCusto += getDoubleValue(dr["1c"]);
      row.Cells["venda2"].Value = dr["2"] + "";
      valorTotal += getDoubleValue(dr["2"]);
      row.Cells["custo2"].Value = dr["2c"] + "";
      totalCusto += getDoubleValue(dr["2c"]);
      row.Cells["venda3"].Value = dr["3"] + "";
      valorTotal += getDoubleValue(dr["3"]);
      row.Cells["custo3"].Value = dr["3c"] + "";
      totalCusto += getDoubleValue(dr["3c"]);
      row.Cells["venda4"].Value = dr["4"] + "";
      valorTotal += getDoubleValue(dr["4"]);
      row.Cells["custo4"].Value = dr["4c"] + "";
      totalCusto += getDoubleValue(dr["4c"]);
      row.Cells["venda5"].Value = dr["5"] + "";
      valorTotal += getDoubleValue(dr["5"]);
      row.Cells["custo5"].Value = dr["5c"] + "";
      totalCusto += getDoubleValue(dr["5c"]);
      row.Cells["venda6"].Value = dr["6"] + "";
      valorTotal += getDoubleValue(dr["6"]);
      row.Cells["custo6"].Value = dr["6c"] + "";
      totalCusto += getDoubleValue(dr["6c"]);
      row.Cells["venda7"].Value = dr["7"] + "";
      valorTotal += getDoubleValue(dr["7"]);
      row.Cells["custo7"].Value = dr["7c"] + "";
      totalCusto += getDoubleValue(dr["7c"]);
      row.Cells["venda8"].Value = dr["8"] + "";
      valorTotal += getDoubleValue(dr["8"]);
      row.Cells["custo8"].Value = dr["8c"] + "";
      totalCusto += getDoubleValue(dr["8c"]);
      row.Cells["venda9"].Value = dr["9"] + "";
      valorTotal += getDoubleValue(dr["9"]);
      row.Cells["custo9"].Value = dr["9c"] + "";
      totalCusto += getDoubleValue(dr["9c"]);
      row.Cells["venda10"].Value = dr["10"] + "";
      valorTotal += getDoubleValue(dr["10"]);
      row.Cells["custo10"].Value = dr["10c"] + "";
      totalCusto += getDoubleValue(dr["10c"]);
      row.Cells["venda11"].Value = dr["11"] + "";
      valorTotal += getDoubleValue(dr["11"]);
      row.Cells["custo11"].Value = dr["11c"] + "";
      totalCusto += getDoubleValue(dr["11c"]);
      row.Cells["venda12"].Value = dr["12"] + "";
      valorTotal += getDoubleValue(dr["12"]);
      row.Cells["custo12"].Value = dr["12c"] + "";
      totalCusto += getDoubleValue(dr["12c"]);
      row.Cells["total"].Value = valorTotal;
      row.Cells["totalCusto"].Value = totalCusto;

      jan += getDoubleValue(dr["1"]);
      fev += getDoubleValue(dr["2"]);
      mar += getDoubleValue(dr["3"]);
      abr += getDoubleValue(dr["4"]);
      mai += getDoubleValue(dr["5"]);
      jun += getDoubleValue(dr["6"]);
      jul += getDoubleValue(dr["7"]);
      ago += getDoubleValue(dr["8"]);
      set += getDoubleValue(dr["9"]);
      oct += getDoubleValue(dr["10"]);
      nov += getDoubleValue(dr["11"]);
      dez += getDoubleValue(dr["12"]);
      totalVenda += valorTotal;

      janC += getDoubleValue(dr["1c"]);
      fevC += getDoubleValue(dr["2c"]);
      marC += getDoubleValue(dr["3c"]);
      abrC += getDoubleValue(dr["4c"]);
      maiC += getDoubleValue(dr["5c"]);
      junC += getDoubleValue(dr["6c"]);
      julC += getDoubleValue(dr["7c"]);
      agoC += getDoubleValue(dr["8c"]);
      setC += getDoubleValue(dr["9c"]);
      octC += getDoubleValue(dr["10c"]);
      novC += getDoubleValue(dr["11c"]);
      dezC += getDoubleValue(dr["12c"]);
      valorTotalCusto += totalCusto;
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
          sql.AppendLine($@"select top 100 * from (select codProduto, month(data) as mes, convert(varchar, month(data)) + 'c' as mesc,
          nomeProduto,sum(valorVenda) as Total, sum(custoTotal) as Custo from MvtVendasEstruturaConsultaMes where year(data) ='" + comboAno.Text + "' " +
          "group by codProduto, nomeProduto, data) as p Pivot(Sum(Total)for mes in ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12]) ) as tabPivot" +
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

          StringBuilder med = new StringBuilder();
          med.AppendLine($@"select AVG(custoUni) from MvtVendasEstruturaConsultaMes
                                       where custoTotal != 0 and tipo = 'F' and codEmpresa = 1 and YEAR(data) = '{comboAno.Text}'");

          SqlCommand cmd = cn.CreateCommand();
          cmd.CommandText = med.ToString();
          media = (double)cmd.ExecuteScalar();

          SqlCommand sqlCommand = cn.CreateCommand();
          sqlCommand.CommandText = sql.ToString();
          using (SqlDataReader dr = sqlCommand.ExecuteReader())
          {
            dgvOrcamento.Rows.Clear();
            while (dr.Read())
            {
              AdicionaLinhaTodos(dr);
            }

            DataGridViewRow row =
              dgvOrcamento.Rows[dgvOrcamento.Rows.Add()];
            row.Cells["venda1"].Value = jan;
            row.Cells["custo1"].Value = janC;
            row.Cells["venda2"].Value = fev;
            row.Cells["custo2"].Value = fevC;
            row.Cells["venda3"].Value = mar;
            row.Cells["custo3"].Value = marC;
            row.Cells["venda4"].Value = abr;
            row.Cells["custo4"].Value = abrC;
            row.Cells["venda5"].Value = mai;
            row.Cells["custo5"].Value = maiC;
            row.Cells["venda6"].Value = jun;
            row.Cells["custo6"].Value = junC;
            row.Cells["venda7"].Value = jul;
            row.Cells["custo7"].Value = julC;
            row.Cells["venda8"].Value = ago;
            row.Cells["custo8"].Value = agoC;
            row.Cells["venda9"].Value = set;
            row.Cells["custo9"].Value = setC;
            row.Cells["venda10"].Value = oct;
            row.Cells["custo10"].Value = octC;
            row.Cells["venda11"].Value = nov;
            row.Cells["custo11"].Value = novC;
            row.Cells["venda12"].Value = dez;
            row.Cells["custo12"].Value = dezC;
            row.Cells["total"].Value = totalVenda;
            row.Cells["custoUni"].Value = media;
            row.Cells["totalCusto"].Value = valorTotalCusto;
            row.Cells["codProduto"].Value = "Total";
          }
        }
      }
      catch (Exception)
      {

        throw;
      }

      count.Text = GetRecordCount(count.Text).ToString();

    }
    private int GetRecordCount(string myParameter)
    {
      using (SqlConnection cn = new SqlConnection(Conn.StrCon))
      {
        Int32 count = 0;
        string sql = "SELECT COUNT(distinct codProduto) FROM MvtVendasEstruturaConsultaMes WHERE codProduto = codProduto";
        using (SqlConnection conn = new SqlConnection(Conn.StrCon))
        {
          SqlCommand cmd = new SqlCommand(sql, conn);
          cmd.Parameters.Add("@codProduto", SqlDbType.VarChar);
          cmd.Parameters["@codProduto"].Value = myParameter;
          try
          {
            conn.Open();
            count = (Int32)cmd.ExecuteScalar();
          }
          catch (Exception ex)
          {

          }
        }
        return (int)count;
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

    private void checkAV_CheckedChanged(object sender, EventArgs e)
    {
      if (Av == 0)
      {
        List<string> lista = new List<string>();
        lista.Add("jan");
        lista.Add("fev");
        lista.Add("mar");
        lista.Add("abr");
        lista.Add("mai");
        lista.Add("jun");
        lista.Add("jul");
        lista.Add("ago");
        lista.Add("set");
        lista.Add("out");
        lista.Add("nov");
        lista.Add("dez");
        for (int i = 0; i < 12; i++)
        {

          int number = dgvOrcamento.Rows.Count;
          for (int linhas = 0; linhas < number; linhas++)
          {
            if (dgvOrcamento.Rows[linhas].Cells[$"venda{i + 1}"].Value.ToString().Length > 0)
            {
              decimal a = Convert.ToDecimal(dgvOrcamento.Rows[linhas].Cells[$"venda{i + 1}"].Value.ToString());
              decimal na = Convert.ToDecimal(dgvOrcamento.Rows[number - 1].Cells[$"venda{i + 1}"].Value.ToString());
              if (na != 0 && a != 0)
              {
                var resulta = (a * 100) / na;
                dgvOrcamento.Rows[linhas].Cells[$"{lista[i]}AvVenda"].Value = Math.Round(resulta, 2) + "%".ToString();
              }

              decimal b = Convert.ToDecimal(dgvOrcamento.Rows[linhas].Cells[$"Custo{i + 1}"].Value.ToString());
              decimal nb = Convert.ToDecimal(dgvOrcamento.Rows[number - 1].Cells[$"Custo{i + 1}"].Value.ToString());
              if (nb != 0 && b != 0)
              {
                var resultb = (b * 100) / nb;
                dgvOrcamento.Rows[linhas].Cells[$"{lista[i]}AvCusto"].Value = Math.Round(resultb, 2) + "%".ToString();
              }
            }
            if (i == 0)
            {
              decimal b = Convert.ToDecimal(dgvOrcamento.Rows[linhas].Cells[$"total"].Value.ToString());
              decimal nb = Convert.ToDecimal(dgvOrcamento.Rows[number - 1].Cells[$"total"].Value.ToString());
              var resultb = (b * 100) / nb;
              dgvOrcamento.Rows[linhas].Cells[$"totAvVenda"].Value = Math.Round(resultb, 2) + "%".ToString();

              decimal a = Convert.ToDecimal(dgvOrcamento.Rows[linhas].Cells[$"totalCusto"].Value.ToString());
              decimal na = Convert.ToDecimal(dgvOrcamento.Rows[number - 1].Cells[$"totalCusto"].Value.ToString());
              var resulta = (a * 100) / na;
              dgvOrcamento.Rows[linhas].Cells[$"totAvCusto"].Value = Math.Round(resulta, 2) + "%".ToString();
            }

          }
        }
      }
      if (dgvOrcamento.Columns["janAvVenda"].Visible == false)
      {
        dgvOrcamento.Columns["janAvVenda"].Visible = true;
        dgvOrcamento.Columns["fevAvVenda"].Visible = true;
        dgvOrcamento.Columns["marAvVenda"].Visible = true;
        dgvOrcamento.Columns["abrAvVenda"].Visible = true;
        dgvOrcamento.Columns["maiAvVenda"].Visible = true;
        dgvOrcamento.Columns["junAvVenda"].Visible = true;
        dgvOrcamento.Columns["julAvVenda"].Visible = true;
        dgvOrcamento.Columns["agoAvVenda"].Visible = true;
        dgvOrcamento.Columns["setAvVenda"].Visible = true;
        dgvOrcamento.Columns["outAvVenda"].Visible = true;
        dgvOrcamento.Columns["novAvVenda"].Visible = true;
        dgvOrcamento.Columns["dezAvVenda"].Visible = true;
        dgvOrcamento.Columns["totAvVenda"].Visible = true;


        dgvOrcamento.Columns["janAvCusto"].Visible = true;
        dgvOrcamento.Columns["fevAvCusto"].Visible = true;
        dgvOrcamento.Columns["marAvCusto"].Visible = true;
        dgvOrcamento.Columns["abrAvCusto"].Visible = true;
        dgvOrcamento.Columns["maiAvCusto"].Visible = true;
        dgvOrcamento.Columns["junAvCusto"].Visible = true;
        dgvOrcamento.Columns["julAvCusto"].Visible = true;
        dgvOrcamento.Columns["agoAvCusto"].Visible = true;
        dgvOrcamento.Columns["setAvCusto"].Visible = true;
        dgvOrcamento.Columns["outAvCusto"].Visible = true;
        dgvOrcamento.Columns["novAvCusto"].Visible = true;
        dgvOrcamento.Columns["dezAvCusto"].Visible = true;
        dgvOrcamento.Columns["totAvCusto"].Visible = true;
      }
      else
      {
        dgvOrcamento.Columns["janAvVenda"].Visible = false;
        dgvOrcamento.Columns["fevAvVenda"].Visible = false;
        dgvOrcamento.Columns["marAvVenda"].Visible = false;
        dgvOrcamento.Columns["abrAvVenda"].Visible = false;
        dgvOrcamento.Columns["maiAvVenda"].Visible = false;
        dgvOrcamento.Columns["junAvVenda"].Visible = false;
        dgvOrcamento.Columns["julAvVenda"].Visible = false;
        dgvOrcamento.Columns["agoAvVenda"].Visible = false;
        dgvOrcamento.Columns["setAvVenda"].Visible = false;
        dgvOrcamento.Columns["outAvVenda"].Visible = false;
        dgvOrcamento.Columns["novAvVenda"].Visible = false;
        dgvOrcamento.Columns["dezAvVenda"].Visible = false;
        dgvOrcamento.Columns["totAvVenda"].Visible = false;


        dgvOrcamento.Columns["janAvCusto"].Visible = false;
        dgvOrcamento.Columns["fevAvCusto"].Visible = false;
        dgvOrcamento.Columns["marAvCusto"].Visible = false;
        dgvOrcamento.Columns["abrAvCusto"].Visible = false;
        dgvOrcamento.Columns["maiAvCusto"].Visible = false;
        dgvOrcamento.Columns["junAvCusto"].Visible = false;
        dgvOrcamento.Columns["julAvCusto"].Visible = false;
        dgvOrcamento.Columns["agoAvCusto"].Visible = false;
        dgvOrcamento.Columns["setAvCusto"].Visible = false;
        dgvOrcamento.Columns["outAvCusto"].Visible = false;
        dgvOrcamento.Columns["novAvCusto"].Visible = false;
        dgvOrcamento.Columns["dezAvCusto"].Visible = false;
        dgvOrcamento.Columns["totAvCusto"].Visible = false;
      }
      Av = 1;
    }

    private void checkCustoXVenda_CheckedChanged(object sender, EventArgs e)
    {
      if (Lucros == 0)
      {
        List<string> lista = new List<string>();
        lista.Add("Jan");
        lista.Add("Fev");
        lista.Add("Mar");
        lista.Add("Abr");
        lista.Add("Mai");
        lista.Add("Jun");
        lista.Add("Jul");
        lista.Add("Ago");
        lista.Add("Set");
        lista.Add("Out");
        lista.Add("Nov");
        lista.Add("Dez");
        for (int i = 0; i < 12; i++)
        {

          int number = dgvOrcamento.Rows.Count;
          for (int linhas = 0; linhas < number; linhas++)
          {
            if (dgvOrcamento.Rows[linhas].Cells[$"venda{i + 1}"].Value.ToString().Length > 0)
            {
              decimal receita = Convert.ToDecimal(dgvOrcamento.Rows[linhas].Cells[$"venda{i + 1}"].Value.ToString());
              decimal custo = Convert.ToDecimal(dgvOrcamento.Rows[linhas].Cells[$"custo{i + 1}"].Value.ToString());
              if (receita != 0 && custo != 0)
              {
                var lucro = (receita - custo) / receita * 100;

                dgvOrcamento.Rows[linhas].Cells[$"lucro{lista[i]}"].Value = Math.Round(lucro, 2) + "%".ToString();
              }
            }
          }
        }
        if (dgvOrcamento.Columns["lucroJan"].Visible == false)
        {
          dgvOrcamento.Columns["lucroJan"].Visible = true;
          dgvOrcamento.Columns["lucroFev"].Visible = true;
          dgvOrcamento.Columns["lucroMar"].Visible = true;
          dgvOrcamento.Columns["lucroAbr"].Visible = true;
          dgvOrcamento.Columns["lucroMai"].Visible = true;
          dgvOrcamento.Columns["lucroJun"].Visible = true;
          dgvOrcamento.Columns["lucroJul"].Visible = true;
          dgvOrcamento.Columns["lucroAgo"].Visible = true;
          dgvOrcamento.Columns["lucroSet"].Visible = true;
          dgvOrcamento.Columns["lucroOut"].Visible = true;
          dgvOrcamento.Columns["lucroNov"].Visible = true;
          dgvOrcamento.Columns["lucroDez"].Visible = true;
        }
        else
        {
          dgvOrcamento.Columns["lucroJan"].Visible = false;
          dgvOrcamento.Columns["lucroFev"].Visible = false;
          dgvOrcamento.Columns["lucroMar"].Visible = false;
          dgvOrcamento.Columns["lucroAbr"].Visible = false;
          dgvOrcamento.Columns["lucroMai"].Visible = false;
          dgvOrcamento.Columns["lucroJun"].Visible = false;
          dgvOrcamento.Columns["lucroJul"].Visible = false;
          dgvOrcamento.Columns["lucroAgo"].Visible = false;
          dgvOrcamento.Columns["lucroSet"].Visible = false;
          dgvOrcamento.Columns["lucroOut"].Visible = false;
          dgvOrcamento.Columns["lucroNov"].Visible = false;
          dgvOrcamento.Columns["lucroDez"].Visible = false;
        }
        Lucros = 1;
      }
    }
  }
}
