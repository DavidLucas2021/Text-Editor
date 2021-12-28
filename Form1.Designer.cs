
namespace Editor_de_Textos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barra_ferram = new System.Windows.Forms.ToolStrip();
            this.bt_novo = new System.Windows.Forms.ToolStripButton();
            this.bt_abrir = new System.Windows.Forms.ToolStripButton();
            this.bt_salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_copiar = new System.Windows.Forms.ToolStripButton();
            this.bt_colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_negrito = new System.Windows.Forms.ToolStripButton();
            this.bt_itálico = new System.Windows.Forms.ToolStripButton();
            this.bt_sublinhado = new System.Windows.Forms.ToolStripButton();
            this.bt_fonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_alinha_esq = new System.Windows.Forms.ToolStripButton();
            this.bt_centralizar = new System.Windows.Forms.ToolStripButton();
            this.bt_alinha_dire = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menu.SuspendLayout();
            this.barra_ferram.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(470, 190);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(185, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquerdaToolStripMenuItem,
            this.centralizarToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // barra_ferram
            // 
            this.barra_ferram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barra_ferram.Dock = System.Windows.Forms.DockStyle.None;
            this.barra_ferram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_novo,
            this.bt_abrir,
            this.bt_salvar,
            this.toolStripSeparator1,
            this.bt_copiar,
            this.bt_colar,
            this.toolStripSeparator2,
            this.bt_negrito,
            this.bt_itálico,
            this.bt_sublinhado,
            this.bt_fonte,
            this.toolStripSeparator3,
            this.bt_alinha_esq,
            this.bt_centralizar,
            this.bt_alinha_dire});
            this.barra_ferram.Location = new System.Drawing.Point(0, 24);
            this.barra_ferram.Name = "barra_ferram";
            this.barra_ferram.Size = new System.Drawing.Size(306, 25);
            this.barra_ferram.TabIndex = 2;
            this.barra_ferram.Text = "toolStrip1";
            // 
            // bt_novo
            // 
            this.bt_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_novo.Image = global::Editor_de_Textos.Properties.Resources.novo;
            this.bt_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(23, 22);
            this.bt_novo.Text = "Novo";
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_abrir
            // 
            this.bt_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_abrir.Image = global::Editor_de_Textos.Properties.Resources.abrir;
            this.bt_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_abrir.Name = "bt_abrir";
            this.bt_abrir.Size = new System.Drawing.Size(23, 22);
            this.bt_abrir.Text = "Abrir";
            this.bt_abrir.Click += new System.EventHandler(this.bt_abrir_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_salvar.Image = global::Editor_de_Textos.Properties.Resources.salvar1;
            this.bt_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(23, 22);
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bt_copiar
            // 
            this.bt_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_copiar.Image = global::Editor_de_Textos.Properties.Resources.copiar;
            this.bt_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_copiar.Name = "bt_copiar";
            this.bt_copiar.Size = new System.Drawing.Size(23, 22);
            this.bt_copiar.Text = "Copiar";
            this.bt_copiar.Click += new System.EventHandler(this.bt_copiar_Click);
            // 
            // bt_colar
            // 
            this.bt_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_colar.Image = global::Editor_de_Textos.Properties.Resources.colar;
            this.bt_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_colar.Name = "bt_colar";
            this.bt_colar.Size = new System.Drawing.Size(23, 22);
            this.bt_colar.Text = "Colar";
            this.bt_colar.Click += new System.EventHandler(this.bt_colar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bt_negrito
            // 
            this.bt_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_negrito.Image = global::Editor_de_Textos.Properties.Resources.negrito;
            this.bt_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_negrito.Name = "bt_negrito";
            this.bt_negrito.Size = new System.Drawing.Size(23, 22);
            this.bt_negrito.Text = "Negrito";
            this.bt_negrito.Click += new System.EventHandler(this.bt_negrito_Click);
            // 
            // bt_itálico
            // 
            this.bt_itálico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_itálico.Image = ((System.Drawing.Image)(resources.GetObject("bt_itálico.Image")));
            this.bt_itálico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_itálico.Name = "bt_itálico";
            this.bt_itálico.Size = new System.Drawing.Size(23, 22);
            this.bt_itálico.Text = "Itálico";
            this.bt_itálico.Click += new System.EventHandler(this.bt_itálico_Click);
            // 
            // bt_sublinhado
            // 
            this.bt_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_sublinhado.Image = global::Editor_de_Textos.Properties.Resources.sublinhado;
            this.bt_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_sublinhado.Name = "bt_sublinhado";
            this.bt_sublinhado.Size = new System.Drawing.Size(23, 22);
            this.bt_sublinhado.Text = "Sublinhado";
            this.bt_sublinhado.Click += new System.EventHandler(this.bt_sublinhado_Click);
            // 
            // bt_fonte
            // 
            this.bt_fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_fonte.Image = global::Editor_de_Textos.Properties.Resources.fonte;
            this.bt_fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_fonte.Name = "bt_fonte";
            this.bt_fonte.Size = new System.Drawing.Size(23, 22);
            this.bt_fonte.Text = "Fonte";
            this.bt_fonte.Click += new System.EventHandler(this.bt_fonte_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bt_alinha_esq
            // 
            this.bt_alinha_esq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_alinha_esq.Image = global::Editor_de_Textos.Properties.Resources.alin_esquerda;
            this.bt_alinha_esq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_alinha_esq.Name = "bt_alinha_esq";
            this.bt_alinha_esq.Size = new System.Drawing.Size(23, 22);
            this.bt_alinha_esq.Text = "Esquerda";
            this.bt_alinha_esq.Click += new System.EventHandler(this.bt_alinha_esq_Click);
            // 
            // bt_centralizar
            // 
            this.bt_centralizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_centralizar.Image = global::Editor_de_Textos.Properties.Resources.centralizar;
            this.bt_centralizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_centralizar.Name = "bt_centralizar";
            this.bt_centralizar.Size = new System.Drawing.Size(23, 22);
            this.bt_centralizar.Text = "Centralizar";
            this.bt_centralizar.Click += new System.EventHandler(this.bt_centralizar_Click);
            // 
            // bt_alinha_dire
            // 
            this.bt_alinha_dire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_alinha_dire.Image = global::Editor_de_Textos.Properties.Resources.alin_direita;
            this.bt_alinha_dire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_alinha_dire.Name = "bt_alinha_dire";
            this.bt_alinha_dire.Size = new System.Drawing.Size(23, 22);
            this.bt_alinha_dire.Text = "Direita";
            this.bt_alinha_dire.Click += new System.EventHandler(this.bt_alinha_dire_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 240);
            this.Controls.Add(this.barra_ferram);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Editor de Textos ";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.barra_ferram.ResumeLayout(false);
            this.barra_ferram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barra_ferram;
        private System.Windows.Forms.ToolStripButton bt_novo;
        private System.Windows.Forms.ToolStripButton bt_abrir;
        private System.Windows.Forms.ToolStripButton bt_salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bt_copiar;
        private System.Windows.Forms.ToolStripButton bt_colar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bt_negrito;
        private System.Windows.Forms.ToolStripButton bt_itálico;
        private System.Windows.Forms.ToolStripButton bt_sublinhado;
        private System.Windows.Forms.ToolStripButton bt_fonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton bt_alinha_esq;
        private System.Windows.Forms.ToolStripButton bt_centralizar;
        private System.Windows.Forms.ToolStripButton bt_alinha_dire;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

