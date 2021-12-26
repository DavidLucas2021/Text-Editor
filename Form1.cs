using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //ENTRADA E SAÍDA DE ARQUIVOS

namespace Editor_de_Textos
{
    public partial class Form1 : Form
    {
        //USADO PARA FAZER LEITURA DO ARQUIVO DE TEXTO 
        StringReader leitura = null;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }


        //FUNÇÃO PARA NOVO DOCUMENTO
        private void Func_Novo()
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Clear();
                richTextBox1.Focus();
            }
            else
            {
                if (MessageBox.Show("Deseja salvar o arquivo?", "Salvar arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //CASO O OK SEJA MARCADO, É GERADO O ARQUIVO PELO OBJETO DO TIPO "FILESTREAM"
                        //QUE PEDE O NOME DO ARQUIVO(SAVEFILEDIALOG1.FILENAME), O MODOLO - ABRIR/CRIAR(FILE.MODE.OPENORCREATE)
                        //E O TIPO DE ACESSO - ESCRITA/LEITURA (FILEACESS.WRITE)
                        //------CRIA O ARQUIVO 
                        FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        //TRECHO PARA GRAVAR O TEXTO ESCRITO EM ARQUIVO
                        //------CRIA A FORMA DE GRAVAR EM ARQUIVO
                        StreamWriter gravartexto = new StreamWriter(arquivo);
                        //TRECHO PARA LIMPAR O BUFFER DE GRAVAÇÃO
                        //------LIMPAR O BUFFER DE GRAVAÇÃO
                        gravartexto.Flush();
                        //TRECHO QUE DETERMINA APARTI DE QUE PONTO GRAVAR
                        //------DETERMA O PONTO DE PARTIDA DE GRAVAÇÃO
                        gravartexto.BaseStream.Seek(0, SeekOrigin.Begin);
                        //------ESCREVE OQUE ESTA EM RICHTEXTBOX1 NO GRAVADOR
                        gravartexto.Write(this.richTextBox1.Text);
                        //------LIMPAR O BUFFER DE GRAVAÇÃO
                        gravartexto.Flush();
                        //FECHA O GRAVADOR 
                        gravartexto.Close();
                    }
                    else 
                    {
                        richTextBox1.Clear();
                        richTextBox1.Focus();
                    }
                }else
                {
                    richTextBox1.Clear();
                    richTextBox1.Focus();
                }
            }
        }
        //BOTÃO NOVO
        private void bt_novo_Click(object sender, EventArgs e)
        {
            Func_Novo();
        }
        //MENU - NOVO
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func_Novo();
        }


        //FUNÇÃO PARA SAVAR DOCUMENTO 
        private void Func_Salvar()
        {
            try
            {
                //VERIFICA SE O COMPONENTE DE SALVAR RECEBEU OK
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //CASO O OK SEJA MARCADO, É GERADO O ARQUIVO PELO OBJETO DO TIPO "FILESTREAM"
                    //QUE PEDE O NOME DO ARQUIVO(SAVEFILEDIALOG1.FILENAME), O MODOLO - ABRIR/CRIAR(FILE.MODE.OPENORCREATE)
                    //E O TIPO DE ACESSO - ESCRITA/LEITURA (FILEACESS.WRITE)
                    //------CRIA O ARQUIVO 
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName,FileMode.OpenOrCreate,FileAccess.Write);
                    //TRECHO PARA GRAVAR O TEXTO ESCRITO EM ARQUIVO
                    //------CRIA A FORMA DE GRAVAR EM ARQUIVO
                    StreamWriter gravartexto = new StreamWriter(arquivo);
                    //TRECHO PARA LIMPAR O BUFFER DE GRAVAÇÃO
                    //------LIMPAR O BUFFER DE GRAVAÇÃO
                    gravartexto.Flush();
                    //TRECHO QUE DETERMINA APARTI DE QUE PONTO GRAVAR
                    //------DETERMA O PONTO DE PARTIDA DE GRAVAÇÃO
                    gravartexto.BaseStream.Seek(0,SeekOrigin.Begin);
                    //------ESCREVE OQUE ESTA EM RICHTEXTBOX1 NO GRAVADOR
                    gravartexto.Write(this.richTextBox1.Text);
                    //------LIMPAR O BUFFER DE GRAVAÇÃO
                    gravartexto.Flush();
                    //FECHA O GRAVADOR 
                    gravartexto.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error ao salvar o arquivo: " + ex.Message,"Erro ao salvar",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //BOTÃO SALVAR 
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Func_Salvar();
        }
        //MENU - SALVAR
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func_Salvar();
        }

        //FUNÇÃO DE ABRIR ARQUIVO 
        private void Fun_Abrir()
        {
            //DETERMINA QUE NÃO SERA POSSIVEL SELECIONAR MAIS DE UM ARQUIVO
            this.openFileDialog1.Multiselect = false;
            //DETERMINA O TITULO DA JANELA DE ABERTURA 
            this.openFileDialog1.Title = "Abrir Arquivo";
            //DETERMINA O DIRETÓRIO INICIAL DA JANELA DE ABERTURA 
            openFileDialog1.InitialDirectory = @"C:\Users\SMART AUTOMAÇÃO\Desktop";
            //DETERMINA O FILTRO DE ARQUIVOS A SEREM ABERTOS
            //ESTE FILTRO TAMBÉM PODE SER IMPLEMENTADO NA FUNÇÃO SALVAR  
            openFileDialog1.Filter = "(*.TXT)|*.TXT";
            //VERIFICA SE O OK DA JANELA DE ABERTURA FOI ACIONADO
            //PODE SER USADO ESSE TRECHO DE CÓDIGO OU O TRECHO DE CÓDIGO 
            //QUE FOI USADO NA FUNÇÃO SALVAR PARA VERIFICAÇÃO - OS DOIS 
            //FORNECEM O MESMO RESULTADO
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                    StreamReader leitor = new StreamReader(arquivo);
                    leitor.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha_prenchida = leitor.ReadLine();
                    while(linha_prenchida != null)
                    {
                        this.richTextBox1.Text += linha_prenchida + Environment.NewLine;
                        linha_prenchida = leitor.ReadLine();
                    }
                    leitor.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error ao abrir o arquivo: " + ex.Message, "Erro ao Abrir o Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //BOTÃO DE ABRIR 
        private void bt_abrir_Click(object sender, EventArgs e)
        {
            Fun_Abrir();
        }
        //MENU - ABRIR 
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_Abrir();
        }


        //FUNÇÃO DE COPIAR 
        private void Fun_Copiar()
        {
            if(richTextBox1.SelectionLength <= 0)
            {
                MessageBox.Show("Não foram selecionados textos para serem copiados!", "Arquivo vazio",MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Focus();
            }
            else
            {
                richTextBox1.Copy();
            }
        }
        //BOTÃO COPIAR
        private void bt_copiar_Click(object sender, EventArgs e)
        {
            Fun_Copiar();
        }
        //MENU - COPIAR
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_Copiar();
        }


        //FUNÇÃO PARA COLAR 
        private void Fun_colar()
        {
            richTextBox1.Paste();
        }
        //BOTÃO PARA COLAR 
        private void bt_colar_Click(object sender, EventArgs e)
        {
            Fun_colar();
        }
        //MENU - COLAR 
        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_colar();
        }


        //FUNÇÃO PARA DEIXAR O TEXTO EM NEGRITO
        private void Fun_Negrito()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                string nome_font = null;
                float tamanho_fonte = 0.0f;
                bool n,i,s = false;

                nome_font = richTextBox1.Font.Name;
                tamanho_fonte = richTextBox1.Font.Size;
                n= richTextBox1.SelectionFont.Bold;
                i = richTextBox1.SelectionFont.Italic;
                s = richTextBox1.SelectionFont.Underline;

                richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Regular);

                if (n == false)
                {
                    if(i == true & s == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    }
                    else if(i == false & s == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold | FontStyle.Underline);
                    }
                    else if(i == true & s == false)
                    {
                        richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold | FontStyle.Italic);
                    }
                    else if(i == false & s == false)
                    {
                        richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold);
                    }
                }else
                {
                    if (i == true & s == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Italic | FontStyle.Underline);
                    }
                    else if (i == false & s == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Underline);
                    }
                    else if (i == true & s == false)
                    {
                        richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Italic);
                    }
                }
            }
        }
        //BOTÃO DE NEGRITO 
        private void bt_negrito_Click(object sender, EventArgs e)
        {
            Fun_Negrito();
        }
        //MENU - NEGRITO
        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_Negrito();
        }

        //FUNÇÃO PARA DEIXAR O TEXTO ITALICO 
        private void Fun_Italico()
        {
            string nome_font = null;
            float tamanho_fonte = 0.0f;
            bool n, i, s = false;

            nome_font = richTextBox1.Font.Name;
            tamanho_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Regular);

            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Italic | FontStyle.Bold);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Italic);
                }
            }
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold);
                }
            }
        }
        //BOTÃO PARA DEIXAR O TEXTO EM ITALICO 
        private void bt_itálico_Click(object sender, EventArgs e)
        {
            Fun_Italico();
        }
        //MENU - ITALICO
        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_Italico();
        }

        //FUNÇÃO PARA DEIXAR O TEXTO SUBLINHADO
        private void Fun_Sublinhado()
        {
            string nome_font = null;
            float tamanho_fonte = 0.0f;
            bool n, i, s = false;

            nome_font = richTextBox1.Font.Name;
            tamanho_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Regular);

            if (s == false)
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Underline);
                }
            }
            else
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_font, tamanho_fonte, FontStyle.Bold);
                }
            }

        }
        //BOTÃO PARA DEIXAR O TEXTO SUBLINHADO
        private void bt_sublinhado_Click(object sender, EventArgs e)
        {
            Fun_Sublinhado();
        }
        //MENU - SUBLINHAR
        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_Sublinhado();
        }

        //FUNÇÃO DE ALINHAMENTO A ESQUERDA
        private void Fun_alinha_esquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        //BOTÃO DE ALINHAMENTO A ESQUERDA
        private void bt_alinha_esq_Click(object sender, EventArgs e)
        {
            Fun_alinha_esquerda();
        }
        //MENU - ALINHAMENTO A ESQUERDA
        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_alinha_esquerda();
        }

        //FUNÇÃO DE ALINHAMENTO A DIREITA
        private void Fun_alinha_direita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        //BOTÃO DE ALINHAMENTO A DIREITA
        private void bt_alinha_dire_Click(object sender, EventArgs e)
        {
            Fun_alinha_direita();
        }
        //MENU - ALINHAMENTO A DIREITA 
        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_alinha_direita();
        }

        //FUNÇÃO DE ALINHAMENTO CENTRALIZADO
        private void Fun_alinha_centralizado()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        //BOTÃO DE CENTRALIZAR 
        private void bt_centralizar_Click(object sender, EventArgs e)
        {
            Fun_alinha_centralizado();
        }
        //MENU - CENTRALIZAR 
        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_alinha_centralizado();
        }


        //FUNÇÃO DE IMPRIMIR
        private void Fun_imprimir()
        {
            //PRINTDIALOG == JANELA DE IMPRESSÃO 
            //PRINTDOCUMENT == CONFIGURAÇÃO DE IMPRESSÃO
            printDialog1.Document = printDocument1;
            string texto = richTextBox1.Text;
            leitura = new StringReader(texto);
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhas_pg = 0;
            float posY = 0;
            int cont = 0;
            string linha = null;
            float marge_esquerda = e.MarginBounds.Left - 50;
            float marge_superior = e.MarginBounds.Top - 50;

            Font font = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);


            if(marge_esquerda < 5)
            {
                marge_esquerda = 20;
            }
            if(marge_superior < 5)
            {
                marge_superior = 20;
            }

            //CALCULA O NUMERO DE LINHA POR PÁGINA COM REFERÊNCIA NO TAMANHO DA FONTE
            linhas_pg = e.MarginBounds.Height / font.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while(cont < linhas_pg)
            {
                //CALCULA A POSIÇÃO Y PELO TAMANHO DA FONTE 
                posY = (marge_superior + (cont * font.GetHeight(e.Graphics)));
                //RESPONSÁVEL POR DESENHAR AS LINHAS NA IMPRESSÃO
                e.Graphics.DrawString(linha, font, pincel, marge_esquerda, posY, new StringFormat());
                cont += 1;
                linha = leitura.ReadLine();
            }
            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fun_imprimir();
        }
    }
}
