﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication {

	public partial class Calculator : Form {

		bool recEquals;

		public Calculator() {
			InitializeComponent();
			recEquals = false;
		}

		private void Calculator_Load(object sender, EventArgs e) {

		}

		private void zeroButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "0";
				recEquals = false;
			} else {
				equationTextBox.Text += "0";
			}
		}

		private void oneButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "1";
				recEquals = false;
			} else {
				equationTextBox.Text += "1";
			}
		}

		private void twoButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "2";
				recEquals = false;
			} else {
				equationTextBox.Text += "2";
			}
		}

		private void threeButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "3";
				recEquals = false;
			} else {
				equationTextBox.Text += "3";
			}
		}

		private void fourButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "4";
				recEquals = false;
			} else {
				equationTextBox.Text += "4";
			}
		}

		private void fiveButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "5";
				recEquals = false;
			} else {
				equationTextBox.Text += "5";
			}
		}

		private void sixButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "6";
				recEquals = false;
			} else {
				equationTextBox.Text += "6";
			}
		}

		private void sevenButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "7";
				recEquals = false;
			} else {
				equationTextBox.Text += "7";
			}
		}

		private void eightButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "8";
				recEquals = false;
			} else {
				equationTextBox.Text += "8";
			}
		}

		private void nineButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "9";
				recEquals = false;
			} else {
				equationTextBox.Text += "9";
			}
		}

		private void decimalButton_MouseClick(object sender, MouseEventArgs e) {
			if (recEquals) {
				equationTextBox.Text = "0.";
				recEquals = false;
			} else {
				if (equationTextBox.Text == "") {
					equationTextBox.Text = "0.";
				} else {
					equationTextBox.Text += ".";
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
     		if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[\\d+()\\-+x/.\\b]+")) {
          		e.Handled = true;
     		}
		}

		private void clearButton_MouseClick(object sender, MouseEventArgs e) {
			equationTextBox.Text = "";
		}

		private void equalsButton_Click(object sender, EventArgs e) {
			equationTextBox.Text = "equals";
			recEquals = true;
		}

		private void backButton_Click(object sender, EventArgs e) {
			if (equationTextBox.Text != "") {
				equationTextBox.Text = equationTextBox.Text.Remove(equationTextBox.Text.Length-1);
			}
		}

		private void additionButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0+";
			} else {
				equationTextBox.Text += "+";
			}
			recEquals = false;
		}

		private void subtractButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0-";
			} else {
				equationTextBox.Text += "-";
			}
			recEquals = false;
		}

		private void multiplyButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0x";
			} else {
				equationTextBox.Text += "x";
			}
			recEquals = false;
		}

		private void divideButton_MouseClick(object sender, MouseEventArgs e) {
			if (equationTextBox.Text == "") {
				equationTextBox.Text += "0/";
			} else {
				equationTextBox.Text += "/";
			}
			recEquals = false;
		}

		private void wolframButton_MouseClick(object sender, MouseEventArgs e) {

		}

		private void button_MouseEnter(object sender, EventArgs e) {
			Button btn = sender as Button;
    		btn.BackColor = System.Drawing.Color.Red;
		}

		private void button_MouseLeave(object sender, EventArgs e) {
			Button btn = sender as Button;
    		btn.BackColor = System.Drawing.Color.Silver;
		}
	}
}
