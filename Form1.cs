using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchPredictionsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int points = int.Parse(numberOfPointsInput.Text);

            var aPoints = (int)aPointsInput.Value;
            var bPoints = (int)bPointsInput.Value;

            double aProbability = (double)aProbInput.Value / 100.0;
            double bProbability = 1 - aProbability;

            int aBet = CalculateBet(points, aPoints, bPoints, aProbability);
            int bBet = CalculateBet(points, bPoints, aPoints, bProbability);

            if (aBet > bBet)
            {
                betLabel.Text = $@"Bet {aBet} on Choice A";
            }
            else if (bBet > aBet)
            {
                betLabel.Text = $@"Bet {bBet} on Choice B";
            }
            else
            {
                betLabel.Text = @"Don't bet";
            }
        }

        /// <summary>
        /// Calculates the user's bet size for choice A if the user has <paramref name="w"/> points,
        /// there are <paramref name="a"/>  points on choice A,
        /// there are <paramref name="b"/>  points on choice B,
        /// and the success probability of choice A is <paramref name="p"/>.
        /// </summary>
        /// <param name="w">
        /// User's points
        /// </param>
        /// <param name="a">
        /// Points on choice A
        /// </param>
        /// <param name="b">
        /// Points on choice B
        /// </param>
        /// <param name="p">
        /// Success probability of choice B
        /// </param>
        /// <returns></returns>
        private static int CalculateBet(long w, long a, long b, double p)
        {
            if (p - 1 == 0)
            {
                return (int)w;
            }

            double x = 1 / (2 * (p - 1) * w * (b + w));
            double y = -Math.Sqrt(a * b * (a * b - 4 * a * p * p * w + 4 * a * p * w - 4 * b * p * p * w +
                4 * b * p * w - 4 * p * p * w * w + 4 * p * w * w));
            double z = a * b - 2 * a * p * w + 2 * a * w;
            double betProportion = x * (y + z);
            return (int)Math.Round(betProportion * w);
        }
    }
}