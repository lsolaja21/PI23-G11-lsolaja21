﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerG11 {
    public partial class frmLogin : Form {
        string username = "nastavnik";
        string password = "test";
        public frmLogin() {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtUsername.Text == "") {
                MessageBox.Show("Korisničko ime nije unešeno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text == "") {
                MessageBox.Show("Lozinka nije unešena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else { 
                if(txtUsername.Text == username && txtPassword.Text == password) {
                    MessageBox.Show("Dobro došli!", "Prijavljeni ste!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmStudent frmStudents = new frmStudent();
                    Hide(); 
                    frmStudents.ShowDialog();
                }

            }

        }
    }
}
