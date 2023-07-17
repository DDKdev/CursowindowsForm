﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(string caminhoImagem, string mensagem)
        {
            InitializeComponent();
            Image MyImage = (Image)global::WF1.Properties.Resources.ResourceManager.GetObject(caminhoImagem);
            Pic_pergunta.Image = MyImage;
            Lbl_Pergunta.Text = mensagem;

        }

        private void Btn_Sim_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Nao_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
