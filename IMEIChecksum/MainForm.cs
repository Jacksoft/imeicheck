/* IMEI Checksum Checker + Fixer
 * This simple tool calculate and fix the checksum of any 15-digit IMEI you'll input
 * This could be usefull for research purposes and on how an IMEI checksum is being calculated
 * Anyway I'll not assume any responsability about the use you'll do with this tool and any damage you could cause to your devices
 * 
 * Copyright (c) 2019 by Jacksoft
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMEIChecksum {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        public void IMEICheck(string imei) {
            // If it's 15 digit it removes the last one to recalculate the checksum
            if (imei.Length == 15) {
                imei = imei.Remove(14, 1);
            }

            // Initialize all variables
            int imeipart1 = 0;
            int imeipart2 = 0;
            int imeisum = 0;
            int imeichecksum = 0;
            int digit = 0;

            // First block: extract odd values and sum them
            for (int i = 0; i < imei.Length; i++) {
                if (i % 2 == 0) {
                    imeipart1 += int.Parse(imei[i].ToString());
                }
            }

            // Second block: extract pair values and shift to match the checksum table
            // 0=>0, 1=>2, 2=>4, 3=>6, 4=>8, 5=>1, 6=>3, 7=>5, 8=>7, 9=>9
            for (int i = 0; i < imei.Length; i++) {
                if (i % 2 == 1) {
                    digit = int.Parse(imei[i].ToString());
                    if (digit >= 5) {
                        digit = ((digit * 2) % 10) + 1;
                    }
                    else {
                        digit = digit * 2;
                    }
                    imeipart2 += digit;
                }
            }

            // Sum the two results
            imeisum = imeipart1 + imeipart2;

            // The checksum is the difference from the sum to the next round value
            for (int i = 1; (imeisum % 10) != 0; i++) {
                imeisum++;
                imeichecksum = i;
            }

            IMEIBox.Text = imei + imeichecksum;
            IMEIBox.ForeColor = Color.Green;
            IMEILabel.Text = "IMEI correctly checked and fixed!";
        }

        private void IMEIButton_Click(object sender, EventArgs e) {
            // Some checks before starting calculations
            double n = 0;
            bool isNumeric = double.TryParse(IMEIBox.Text, out n);
            int imeilenght = IMEIBox.Text.Length;
            if (imeilenght == 0) {
                IMEILabel.Text = "Please write a valid IMEI first.";
                IMEIBox.ForeColor = Color.Red;
            }
            else if (isNumeric) {
                if (imeilenght < 14) {
                    IMEILabel.Text = "IMEI must be 14 or 15 digits.";
                    IMEIBox.ForeColor = Color.Red;
                }
                else if (imeilenght > 15) {
                    IMEILabel.Text = "IMEI is too long. Max lenght is 15 digits.";
                    IMEIBox.ForeColor = Color.Red;
                }
                else if (imeilenght == 14 || imeilenght == 15) {
                    IMEICheck(IMEIBox.Text);
                }
            }
            else {
                IMEILabel.Text = "Please input numbers ONLY!";
                IMEIBox.ForeColor = Color.Red;
            }
        }

        private void BlogLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://blog.jacksoftlabs.com");
        }
    }
}
