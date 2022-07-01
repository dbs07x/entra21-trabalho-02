﻿using Entra21_trabalho_02.Ninjas;

namespace Entra21_trabalho_02.Equipes
{
    public partial class EquipeForm : Form
    {
        private EquipeServico equipeServico;

        private NinjaServico ninjaServico;

        public EquipeForm()
        {
            InitializeComponent();

            equipeServico = new EquipeServico();

            ninjaServico = new NinjaServico();

            PreencherDataGridViewComEquipes();

            PreencherComboBoxComOsNomesDosNinjas();

            LimparCampos();
        }

        private void EquipeForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEquipes();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var nomeEquipe = textBoxNomeEquipe.Text;
            var lider = Convert.ToString(comboBoxLider.SelectedItem);
            var membro1 = Convert.ToString(comboBoxMembro1.SelectedItem);
            var membro2 = Convert.ToString(comboBoxMembro2.SelectedItem);
            var membro3 = Convert.ToString(comboBoxMembro3.SelectedItem);
            var dataFormacao = Convert.ToDateTime(dateTimePickerDataFormacao.Value);
            var dataProximaMissao = Convert.ToDateTime(maskedTextBoxDataProximaMissao.Text);
            string situacao;

            if ((checkBoxEmMissao.Checked == true) && (checkBoxNaAldeia.Checked == false) && (checkBoxTemporariamenteInativa.Checked == false))
            {
                situacao = "A equipe está: Em missão";
            }
            else if ((checkBoxEmMissao.Checked == true) && (checkBoxNaAldeia.Checked == true) && (checkBoxTemporariamenteInativa.Checked == false))
            {
                situacao = "A equipe está: Em missão / Na aldeia";
            }
            else if ((checkBoxEmMissao.Checked == true) && (checkBoxNaAldeia.Checked == false) && (checkBoxTemporariamenteInativa.Checked == true))
            {
                situacao = "A equipe está: Em missão / Temporariamente Inativa";
            }
            else if ((checkBoxEmMissao.Checked == false) && (checkBoxNaAldeia.Checked == true) && (checkBoxTemporariamenteInativa.Checked == true))
            {
                situacao = "A equipe está: Na aldeia / Temporariamente Inativa";
            }
            else if ((checkBoxEmMissao.Checked == false) && (checkBoxNaAldeia.Checked == true) && (checkBoxTemporariamenteInativa.Checked == false))
            {
                situacao = "A equipe está: Na aldeia";
            }
            else if ((checkBoxEmMissao.Checked == false) && (checkBoxNaAldeia.Checked == false) && (checkBoxTemporariamenteInativa.Checked == true))
            {
                situacao = "A equipe está: Temporariamente Inativa";
            }
            else
            {
                situacao = "A equipe está: Em missão / Na aldeia / Temporariamente Inativa";
            }

            var dadosValidos = ValidarDados();

            if (dadosValidos == false)
            {
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                CadastrarEquipe(nomeEquipe, lider, membro1, membro2, membro3, dataFormacao, dataProximaMissao, situacao);
            }
            else
            {
                EditarEquipe(nomeEquipe, lider, membro1, membro2, membro3, dataFormacao, dataProximaMissao, situacao);
            }

            PreencherDataGridViewComEquipes();

            LimparCampos();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar o endereço?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa, teu registro está ali salvo!", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var equipe = equipeServico.ObterPorId(codigo);

            equipeServico.Apagar(equipe);

            PreencherDataGridViewComEquipes();

            dataGridView1.ClearSelection();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void PreencherDataGridViewComEquipes()
        {
            var equipes = equipeServico.ListarTodos();

            dataGridView1.Rows.Clear();

            for (var i = 0; i < equipes.Count; i++)
            {
                var equipe = equipes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    equipe.Id,
                    equipe.Nome,
                    equipe.Lider,
                    equipe.Membro1,
                    equipe.Membro2,
                    equipe.Membro3,
                    equipe.Formacao,
                    equipe.InicioProximaMissao,
                    equipe.Situacao

                });
            }

            dataGridView1.ClearSelection();
        }

        private void PreencherComboBoxComOsNomesDosNinjas()
        {
            var ninjas = ninjaServico.ListarTodos();

            for (var i = 0; i < ninjas.Count; i++)
            {
                var ninja = ninjas[i];
                comboBoxLider.Items.Add(ninja.Nome);
                comboBoxMembro1.Items.Add(ninja.Nome);
                comboBoxMembro2.Items.Add(ninja.Nome);
                comboBoxMembro3.Items.Add(ninja.Nome);
            }
        }

        private void LimparCampos()
        {
            var hoje= DateTime.Today;

            textBoxNomeEquipe.Clear();
            comboBoxLider.SelectedIndex = -1;
            comboBoxMembro1.SelectedIndex = -1;
            comboBoxMembro2.SelectedIndex = -1;
            comboBoxMembro3.SelectedIndex = -1;
            dateTimePickerDataFormacao.Value = hoje;
            maskedTextBoxDataProximaMissao.Clear();
            checkBoxEmMissao.Checked = false;
            checkBoxNaAldeia.Checked = false;
            checkBoxTemporariamenteInativa.Checked = false;
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um chakra para editar", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var equipe = equipeServico.ObterPorId(codigo);

            textBoxNomeEquipe.Text = equipe.Nome;
            comboBoxLider.SelectedItem = equipe.Lider;
            comboBoxMembro1.SelectedItem = equipe.Membro1;
            comboBoxMembro2.SelectedItem = equipe.Membro2;
            comboBoxMembro3.SelectedItem = equipe.Membro3;
            dateTimePickerDataFormacao.Value = equipe.Formacao;
            maskedTextBoxDataProximaMissao.Text = Convert.ToString(equipe.InicioProximaMissao);

            if (equipe.Situacao == "A equipe está: Em missão")

            {
                checkBoxEmMissao.Checked = true;
                checkBoxNaAldeia.Checked = false;
                checkBoxTemporariamenteInativa.Checked = false;
            }
            else if (equipe.Situacao == "A equipe está: Em missão / Na aldeia")
            {
                checkBoxEmMissao.Checked = true;
                checkBoxNaAldeia.Checked = true;
                checkBoxTemporariamenteInativa.Checked = false;
            }
            else if (equipe.Situacao == "A equipe está: Em missão / Temporariamente Inativa")
            {
                checkBoxEmMissao.Checked = true;
                checkBoxNaAldeia.Checked = false;
                checkBoxTemporariamenteInativa.Checked = true;
            }
            else if (equipe.Situacao == "A equipe está: Na aldeia / Temporariamente Inativa")
            {
                checkBoxEmMissao.Checked = false;
                checkBoxNaAldeia.Checked = true;
                checkBoxTemporariamenteInativa.Checked = true;
            }
            else if (equipe.Situacao == "A equipe está: Na aldeia")
            {
                checkBoxEmMissao.Checked = false;
                checkBoxNaAldeia.Checked = true;
                checkBoxTemporariamenteInativa.Checked = false;
            }
            else if (equipe.Situacao == "A equipe está: Temporariamente Inativa")
            {
                checkBoxEmMissao.Checked = false;
                checkBoxNaAldeia.Checked = false;
                checkBoxTemporariamenteInativa.Checked = true;
            }
            else
            {
                checkBoxEmMissao.Checked = true;
                checkBoxNaAldeia.Checked = true;
                checkBoxTemporariamenteInativa.Checked = true;
            }
        }

        private bool ValidarDados()
        {
           var hoje = DateTime.Today;

            if (textBoxNomeEquipe.Text == string.Empty)
            {
                MessageBox.Show("Digite um nome para a equipe", "Aviso", MessageBoxButtons.OK);

                textBoxNomeEquipe.Focus();

                return false;
            }

            if (comboBoxLider.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um líder", "Aviso", MessageBoxButtons.OK);

                comboBoxLider.DroppedDown = true;

                return false;
            }

            if (comboBoxMembro1.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um líder", "Aviso", MessageBoxButtons.OK);

                comboBoxMembro1.DroppedDown = true;

                return false;
            }

            if (comboBoxMembro2.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um líder", "Aviso", MessageBoxButtons.OK);

                comboBoxMembro2.DroppedDown = true;

                return false;
            }

            if (comboBoxMembro3.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um líder", "Aviso", MessageBoxButtons.OK);

                comboBoxMembro3.DroppedDown = true;

                return false;
            }

            if (dateTimePickerDataFormacao.Value > DateTime.Today)
            {
                MessageBox.Show("Informe a data de formação da equipe", "Aviso", MessageBoxButtons.OK);

                dateTimePickerDataFormacao.Select();
                SendKeys.Send("%{DOWN}");

                return false;
            }

            if (maskedTextBoxDataProximaMissao.Text == string.Empty)
            {
                MessageBox.Show("Informe a data da próxima missão da equipe", "Aviso", MessageBoxButtons.OK);

                maskedTextBoxDataProximaMissao.Focus();

                return false;
            }


            return true;
        }

        private void CadastrarEquipe(string nomeEquipe, string lider, string membro1, string membro2, string membro3, DateTime dataFormacao, DateTime dataProximaMissao, string situacao)
        {
            var equipe = new Equipe();
            equipe.Id = equipeServico.ObterUltimoId() + 1;
            equipe.Nome = nomeEquipe;
            equipe.Lider = ninjaServico.ObterPorNomeNinja(lider);
            equipe.Membro1 = ninjaServico.ObterPorNomeNinja(membro1);
            equipe.Membro2 = ninjaServico.ObterPorNomeNinja(membro2);
            equipe.Membro3 = ninjaServico.ObterPorNomeNinja(membro3);
            equipe.Formacao = dataFormacao;
            equipe.InicioProximaMissao = dataProximaMissao;
            equipe.Situacao = situacao;

            equipeServico.Adicionar(equipe);
        }

        private void EditarEquipe(string nomeEquipe, string lider, string membro1, string membro2, string membro3, DateTime dataFormacao, DateTime dataProximaMissao, string situacao)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var equipe = new Equipe();
            equipe.Id = codigoSelecionado;
            equipe.Nome = nomeEquipe;
            equipe.Lider = ninjaServico.ObterPorNomeNinja(lider);
            equipe.Membro1 = ninjaServico.ObterPorNomeNinja(membro1);
            equipe.Membro2 = ninjaServico.ObterPorNomeNinja(membro2);
            equipe.Membro3 = ninjaServico.ObterPorNomeNinja(membro3);
            equipe.Formacao = dataFormacao;
            equipe.InicioProximaMissao = dataProximaMissao;
            equipe.Situacao = situacao;

            equipeServico.Editar(equipe);
        }
    }
}
