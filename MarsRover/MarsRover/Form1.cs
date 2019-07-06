using MarsRover.Core;
using MarsRover.Core.Abstract;
using MarsRover.Core.Concrete;
using MarsRover.Core.Enums;
using MarsRover.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        #region StartMove
        private void StartBttn_Click(object sender, EventArgs e)
        {
            var process = new ProcessManager();
            var result = process.StartMoveOrientation(new CoordinateModel
            {
                XCoord = (int)XCoordNmrBx.Value,
                YCoord = (int)YCoordNmrBx.Value
            }, MoveTxtBx.Text.Replace(" ","").ToUpper(), new PlateauModel { Width = (int)PlateauNmrBxW.Value, Height = (int)PlateauNmrBxH.Value }, SelectedDirection());

            if (!result.Success)
            {
                MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(result.Result, "Succes Process",MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        #endregion

        #region MyExtends
        /// <summary>
        /// Selected Direction 
        /// </summary>
        /// <returns>DirectionEnum</returns>
        public DirectionEnum SelectedDirection()
        {
            if (NDirectionRadioBttn.Checked)
                return DirectionEnum.N;
            else if (SDirectionRadioBttn.Checked)
                return DirectionEnum.S;
            else if (WDirectionRadioBttn.Checked)
                return DirectionEnum.W;
            else
                return DirectionEnum.E;
        }

        #endregion

    }
}
