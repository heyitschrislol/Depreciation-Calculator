using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depreciation_Calculator__v1._5_
{
	public partial class frmDepreciate : Form
	{
		public frmDepreciate()
		{
			InitializeComponent();
		}

		DataRow row;

		private void GetStraightLine(double dblC, double dblS)
		{

			//---------------------------------------------------------------------------------------------------------------------------
			//-
			//- DataTable
			//-
			//---------------------------------------------------------------------------------------------------------------------------
			int intLife = int.Parse(txtLife.Text);
			double dblDC = dblC - dblS;
			double dblARoD = 1.0 / intLife;
			double dblDE = (dblC - dblS) / intLife;
			double dblAccDep = 0;
			double dblBookValue = dblC;

			for (int index = 1; index <= intLife; index++)
			{
				dblAccDep += dblDE;
				dblBookValue = dblBookValue - dblDE;
				row = dBDepreciationDataSet.Depreciation.NewRow();
				row["Year"] = index;
				row["Method"] = "Straight-Line";
				row["Cost"] = dblDC.ToString("C");
				row["RateOf"] = dblARoD.ToString("P0");
				row["Expense"] = dblDE.ToString("C");
				row["Accumulated"] = dblAccDep.ToString("C");
				row["BookValue"] = dblBookValue.ToString("C");
				dBDepreciationDataSet.Depreciation.Rows.Add(row);

			}
		}
		private void GetDoubleDeclining(double dblC, double dblS, double dblR)
		{

			//---------------------------------------------------------------------------------------------------------------------------
			//-
			//- DataTable
			//-
			//---------------------------------------------------------------------------------------------------------------------------
			int intLife = int.Parse(txtLife.Text);
			double dblDE = 0;
			double dblAccDep = 0;
			double dblBookValue = 0;


			for (int index = 1; index <= intLife; index++)
			{
				dblDE = dblC * dblR;
				dblAccDep += dblDE;
				dblBookValue = dblC - dblDE;
				row = dBDepreciationDataSet.Depreciation.NewRow();
				row["Year"] = index;
				row["Method"] = "Double-Declining";
				row["Cost"] = dblC.ToString("C");
				row["RateOf"] = dblR.ToString("P0");
				row["Expense"] = dblDE.ToString("C");
				row["Accumulated"] = dblAccDep.ToString("C");
				row["BookValue"] = dblBookValue.ToString("C");
				dBDepreciationDataSet.Depreciation.Rows.Add(row);
				dblC -= dblDE;

			}
		}

		private void btnSLDE_Click(object sender, EventArgs e)
		{
			// Have to clear values so that the primary key (aka Year) stays unique
			dBDepreciationDataSet.Depreciation.Rows.Clear();

			double dblCost = double.Parse(txtCost.Text);
			double dblSvg = double.Parse(txtSvg.Text);

			GetStraightLine(dblCost, dblSvg);
		}

		private void btnDDDE_Click(object sender, EventArgs e)
		{
			// Have to clear values so that the primary key (aka Year) stays unique
			dBDepreciationDataSet.Depreciation.Rows.Clear();

			double dblCost = double.Parse(txtCost.Text);
			double dblSvg = double.Parse(txtSvg.Text);
			double dblRate;
			if (double.TryParse(txtRate.Text, out dblRate) && dblRate > 0)
			{
				dblRate = double.Parse(txtRate.Text);
				GetDoubleDeclining(dblCost, dblSvg, dblRate);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtCost.Clear();
			txtSvg.Clear();
			txtLife.Clear();
			txtRate.Clear();
			dBDepreciationDataSet.Depreciation.Rows.Clear();
			txtCost.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSaveToFile_Click(object sender, EventArgs e)
		{

		}

		private void depreciationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.depreciationBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dBDepreciationDataSet);

		}

		private void frmDepreciate_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dBDepreciationDataSet.Depreciation' table. You can move, or remove it, as needed.
			this.depreciationTableAdapter.Fill(this.dBDepreciationDataSet.Depreciation);

		}
	}
}
