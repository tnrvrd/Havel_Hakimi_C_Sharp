using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Havel_Hakimi
{
    public partial class Form1 : Form
    {
        DataTable dtVertices;

        List<int> listVertices;


        public Form1()
        {
            InitializeComponent();
        }

        private void tbNumberOfVertices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnCreateVertices_Click(object sender, EventArgs e)
        {
            if (tbNumberOfVertices.Text.Trim().Length != 0)
            {
                int numberOfVertices = Convert.ToInt16(tbNumberOfVertices.Text);


                dtVertices = new DataTable();
                dtVertices.Columns.Add("Vertices", typeof(int));

                for (int i = 0; i < numberOfVertices; i++)
                {
                    dtVertices.Rows.Add(0);
                }

                dgvVertices.DataSource = dtVertices;

                btnCalculateResult.Enabled = true;
            }
            else
            {
                MessageBox.Show("You must enter at least 1 vertices");
            }
            
            
        }

        private void btnCalculateResult_Click(object sender, EventArgs e)
        {
            listVertices = new List<int>();

            listVertices = dtVertices.Rows.OfType<DataRow>().Select(dr => dr.Field<int>("Vertices")).ToList();

            lbStepByStep.Items.Clear();

            bool result = HavelHakimi(listVertices);

            if (result)
            {
                lbStepByStep.Items.Add(result.ToString().ToUpper() + ". This is a graph.");
            }
            else
            {
                lbStepByStep.Items.Add(result.ToString().ToUpper() + ". This is not a graph.");
            }
            
        }

        private bool HavelHakimi(List<int> _listVertices)
        {
            string strSortedVertices = "";
            foreach (int vertice in _listVertices)
            {
                strSortedVertices += vertice.ToString() + ", ";
            }
            lbStepByStep.Items.Add(strSortedVertices);

            int numberOfVertices = _listVertices.Count;

            // Fist Step
            foreach (int vertice in _listVertices)
            {
                if (vertice >= numberOfVertices)
                {
                    lbStepByStep.Items.Add("# " + vertice.ToString() + " is bigger than or equal to number of all vertices, " + numberOfVertices.ToString());
                    return false;
                }
            }

            // Second Step
            int totalOddNumbers = 0;
            foreach (int vertice in _listVertices)
            {
                if (vertice % 2 == 1)
                {
                    totalOddNumbers++;
                }
            }
            if (totalOddNumbers % 2 == 1)
            {
                lbStepByStep.Items.Add("# Total odd number of vertices is odd number, " + totalOddNumbers.ToString());
                return false;
            }

            while (true)
            {

                // Third Step 
                foreach (int vertice in _listVertices)
                {
                    if (vertice < 0)
                    {
                        lbStepByStep.Items.Add("# There is a vertice smaller than 0");
                        return false;
                    }
                }

                // Forth Step
                bool isAllVerticesZero = true;
                foreach (int vertice in _listVertices)
                {
                    if (vertice != 0)
                    {
                        isAllVerticesZero = false;
                        break;
                    }
                }
                if (isAllVerticesZero)
                {
                    lbStepByStep.Items.Add("# All vertices are 0");
                    return true;
                }

                // Fifth Step
                _listVertices = SelectionSort(_listVertices);

                lbStepByStep.Items.Add("# After sorting");
                strSortedVertices = "";
                foreach (int vertice in _listVertices)
                {
                    strSortedVertices += vertice.ToString() + ", ";
                }
                lbStepByStep.Items.Add(strSortedVertices);

                // Sixth Step
                int k = _listVertices[0];

                // Seventh Step
                lbStepByStep.Items.Add("# Remove " + _listVertices[0].ToString() + " and subract 1 from " + k.ToString() + " times remaining of the new sequence");
                _listVertices.RemoveAt(0);

                // Eight Step
                for (int i = 0; i < k; i++)
                {
                    _listVertices[i]--;
                }

                strSortedVertices = "";
                foreach (int vertice in _listVertices)
                {
                    strSortedVertices += vertice.ToString() + ", ";
                }
                lbStepByStep.Items.Add(strSortedVertices);
            }

        }


        private List<int> SelectionSort(List<int> _listVertices)
        {
            int biggest;
            int temp;

            for (int i = 0; i < _listVertices.Count - 1; i++)
            {
                biggest = i;
                for (int j = i + 1; j < _listVertices.Count; j++)
                {
                    if (_listVertices[j] > _listVertices[biggest])
                    {
                        biggest = j;
                    }
                }
                if (biggest != i)
                {
                    temp = _listVertices[i];
                    _listVertices[i] = _listVertices[biggest];
                    _listVertices[biggest] = temp;
                }
            }
            return _listVertices;
        }

        private void havelHakimiAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHavelHakimiAlgorithm frmHavelHakimiAlgorithm = new FrmHavelHakimiAlgorithm();
            frmHavelHakimiAlgorithm.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
