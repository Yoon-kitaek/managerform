﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerForm
{
    public partial class ManagerLoginform : Form
{
    public ManagerLoginform()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text == "1234")
            {
                MessageBox.Show("로그인 되었습니다.");
                Close();
                               
                                        
            }
        else
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
            }
    }
}
}
