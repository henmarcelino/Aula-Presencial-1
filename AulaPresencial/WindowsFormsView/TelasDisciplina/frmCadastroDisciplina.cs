﻿using Controllers;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsView.TelasDisciplina
{
    public partial class FrmCadastroDisciplina : Form
    {
        public FrmCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtMateria.Text = string.Empty; //""
            txtCiclo.Text = string.Empty;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Disciplina novoDisciplina = new Disciplina();
            
            novoDisciplina.Materia = txtMateria.Text;
            novoDisciplina.Ciclo = int.Parse(txtCiclo.Text);
            

            DisciplinasController disciplinasController = new DisciplinasController();
            disciplinasController.Inserir(novoDisciplina);
        }
    }
}
