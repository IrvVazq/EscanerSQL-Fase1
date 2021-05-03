using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace fase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Para palabras reservadas
        string[,] palabrasReser = { {"SELECT","10"}, { "FROM" ,"11"}, { "WHERE" , "12"}, { "IN","13"}, { "AND","14"}, { "OR","15" },
            { "CREATE" , "16"}, {"TABLE","17" }, {"CHAR","18" }, {"NUMERIC","19" }, {"NOT","20" }, {"NULL","21" }, {"CONSTRAINT" ,"22"},
            { "KEY" ,"23"}, {"PRIMARY", "24" }, {"FOREIGN" , "25"},{ "REFERENCES" ,"26"}, {"INSERT" ,"27"}, {"INTO","28" }, {"VALUES","29" } };
        string[,] relacionales = { { ">", "81" }, { "<", "82" }, { "=", "83" }, { ">=", "84" }, { "<=", "85" } };
        string[,] delimi = { { ",", "50" }, { ".", "51" }, { "(", "52" }, { ")", "53" }, { "'", "54" } };
        string[,] operadores = { { "+", "70" }, { "-", "71" }, { "*", "72" }, { "/", "73" } };

        int cont = 0;
        int valor = 400;
        int valorConstante = 599;
        int linea = 1;

        private void btnTablaLexica_Click(object sender, EventArgs e)
        {
            panelT_Lexica.Visible = true;
            panelT_Dinamica.Visible = false;
        }

        private void btnTablaDinamica_Click(object sender, EventArgs e)
        {
            panelT_Lexica.Visible = false;
            panelT_Dinamica.Visible = true;
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            dataGVLexica.Rows.Clear();
            dataGVIdentificadores.Rows.Clear();
            dataGVConstantes.Rows.Clear();

            cont = 0;
            valor = 399;
            valorConstante = 599;
            linea = 1;
            lblError.Text = "";

            string entrada = txtEntrada.Text.ToString();

            errores(entrada);
            if (lblError.Text == "")
            {
                linea = 1;
                string expMadre = @"['|’|‘]([\s]*[\w]+[\s]*)+['|’|‘]|[0-9]+|\w+#?|[=+.,-]|[(]|[)]|\n";
                MatchCollection ms = Regex.Matches(entrada, expMadre, RegexOptions.Compiled);
                //Para palabras reservadas
                for (int x = 0; x < ms.Count; x++)
                {
                    escaner(x, ms);
                }
                lblError.Text = "Análisis léxico finalizado";
            }

            
        }
        public void errores(string entrada)
        {
            string expError = @"(\w+|'|‘|’|)*[^\w+#?\d\s=.,<’‘'>+*-[()]](\w+|'|‘|’|)*|\n";//Todos los caracteres que arrojaran un error
            MatchCollection msE = Regex.Matches(entrada, expError, RegexOptions.IgnoreCase);//Busca
            linea = 1;
            for (int x = 0; x < msE.Count; x++)
            {
                if (Regex.IsMatch(msE[x].Value.ToString(), @"(\w+|'|‘|’)*[^\w=.,<’‘>+*\n-](\w+|'|‘|’)*", RegexOptions.Compiled))//Para Reservadas
                {
                    lblError.Text += "Error: " + msE[x].Value.ToString() + " linea: " + linea + " tipo: léxico,           ";
                }
                else
                {
                    linea++;
                }
            }
        }

        public void escaner(int x, MatchCollection ms)
        {
            //lineas
            if (Regex.IsMatch(ms[x].Value.ToString(), @"[\n]", RegexOptions.Compiled))//Para Reservadas
            {
                linea++;
            }

            string expaux = @"(?<![\w])[0-9]+(?![\w])+";//Para saber si son numeros o no

            int c = 0;
            string cadena; //Cadena a mostrar en la tabla
            if (Regex.IsMatch(ms[x].Value.ToString(), @"[A-Z]+", RegexOptions.Compiled))//Para Reservadas
            {
                for (int y = 0; y < 20; y++)
                {
                    if (ms[x].Value.ToString() == palabrasReser[y, 0])
                    {
                        cont++;
                        cadena = ms[x].Value.ToString();
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGVLexica);
                        fila.Cells[0].Value = cont.ToString();
                        fila.Cells[1].Value = linea;
                        fila.Cells[2].Value = cadena;
                        fila.Cells[3].Value = "1";
                        fila.Cells[4].Value = palabrasReser[y, 1];
                        dataGVLexica.Rows.Add(fila);
                    }
                }
            }
            if (Regex.IsMatch(ms[x].Value.ToString(), @"[)(,.']", RegexOptions.Compiled))//Para Delimtiadores
            {
                cont++;
                cadena = ms[x].Value.ToString();
                Match match = Regex.Match(cadena, @"'");
                if (Regex.IsMatch(cadena,@"'",RegexOptions.IgnoreCase)) {
                    cadena = match.Value.ToString();
                }
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGVLexica);
                fila.Cells[0].Value = cadena;
                fila.Cells[0].Value = cont.ToString();
                fila.Cells[1].Value = linea;
                fila.Cells[2].Value = cadena;
                fila.Cells[3].Value = "5";
                for (int z = 0; z < 5; z++)
                {
                    if (cadena.ToString() == delimi[z, 0])
                    {
                        fila.Cells[4].Value = delimi[z, 1];
                    }
                }

                dataGVLexica.Rows.Add(fila);
            }
            if (Regex.IsMatch(ms[x].Value.ToString(), @"[*|+|-|/]", RegexOptions.Compiled))//Para Operadores
            {
                cont++;
                cadena = ms[x].Value.ToString();
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGVLexica);
                fila.Cells[0].Value = cont.ToString();
                fila.Cells[1].Value = linea;
                fila.Cells[2].Value = cadena;
                fila.Cells[3].Value = "Operadores";
                for (int z = 0; z < 4; z++)
                {
                    if (cadena.ToString() == operadores[z, 0])
                    {
                        fila.Cells[4].Value = operadores[z, 1];
                    }
                }
                dataGVLexica.Rows.Add(fila);
            }
            if (Regex.IsMatch(ms[x].Value.ToString(), @"[<>=]+", RegexOptions.Compiled))//Para Relacionales
            {
                cont++;
                cadena = ms[x].Value.ToString();
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGVLexica);

                fila.Cells[0].Value = cont.ToString();
                fila.Cells[1].Value = linea;
                fila.Cells[2].Value = cadena;
                fila.Cells[3].Value = "8";

                for (int z = 0; z < 5; z++)
                {
                    if (cadena.ToString() == relacionales[z, 0])
                    {
                        fila.Cells[4].Value = relacionales[z, 1];
                    }
                }
            }

            if (Regex.IsMatch(ms[x].Value.ToString(), @"((?<![\w'|‘|’])(([A-Z]+[#]?)+)(?![[\w]'|‘|’]))", RegexOptions.Compiled))//Para identificadores
            {
                for (int y = 0; y < 20; y++)
                {
                    if (ms[x].Value.ToString() == palabrasReser[y, 0])
                    {
                        c++;
                    }

                }
                if (c == 0)
                {
                    cont++;
                    valor++;
                    cadena = ms[x].Value.ToString();

                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGVLexica);
                    fila.Cells[0].Value = cont.ToString();
                    fila.Cells[1].Value = linea;
                    fila.Cells[2].Value = cadena;
                    fila.Cells[3].Value = 4;
                    fila.Cells[4].Value = valor;
                    dataGVLexica.Rows.Add(fila);
                    bool bandera = true;

                    if (dataGVIdentificadores.Rows.Count - 1 == 0)
                    {
                        bandera = true;

                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGVIdentificadores.Rows)
                        {
                            if (row.Cells["Identificador"].Value != null)
                            {
                                if (cadena == row.Cells["Identificador"].Value.ToString())
                                {
                                    row.Cells["Línea"].Value += ", " + linea;
                                    bandera = false;
                                }
                            }
                        }
                    }
                    if (bandera)
                    {
                        DataGridViewRow fila2 = new DataGridViewRow();
                        fila2.CreateCells(dataGVIdentificadores);
                        fila2.Cells[0].Value = cadena;
                        fila2.Cells[1].Value = valor;
                        fila2.Cells[2].Value = linea;
                        dataGVIdentificadores.Rows.Add(fila2);
                    }
                    c = 0;
                }
            }
            if (Regex.IsMatch(ms[x].Value.ToString(), @"(['|’|‘]([\s]*[\w]+[\s]*)+['|’|‘])|(0-9)+", RegexOptions.Compiled))//Para Constantes
            {
                valorConstante++;
                cadena = ms[x].Value.ToString();
                cont++;
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGVLexica);
                fila.Cells[0].Value = cont.ToString();
                fila.Cells[1].Value = linea;
                fila.Cells[2].Value = "Constante";
                fila.Cells[3].Value = "6";
                fila.Cells[4].Value = valorConstante;
                dataGVLexica.Rows.Add(fila);

                DataGridViewRow fila2 = new DataGridViewRow();
                fila2.CreateCells(dataGVConstantes);
                fila2.Cells[0].Value = cont.ToString();
                fila2.Cells[1].Value = cadena;
                if (Regex.IsMatch(cadena, expaux) == true)
                {
                    fila2.Cells[2].Value = "61";
                }
                else
                {
                    fila2.Cells[2].Value = "62";
                }
                fila2.Cells[3].Value = valorConstante;
                dataGVConstantes.Rows.Add(fila2);
            }
            if (Regex.IsMatch(ms[x].Value.ToString(), @"\b[']", RegexOptions.Compiled))//Para comillas (Si hay una comilla al final de una constante)
            {
                Match match = Regex.Match(ms[x].Value.ToString(), @"\b[']");
                cadena = match.Value.ToString();
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGVLexica);
                fila.Cells[0].Value = cadena;
                fila.Cells[0].Value = cont.ToString();
                fila.Cells[1].Value = linea;
                fila.Cells[2].Value = cadena;
                fila.Cells[3].Value = "5";
                for (int z = 0; z < 5; z++)
                {
                    if (cadena.ToString() == delimi[z, 0])
                    {
                        fila.Cells[4].Value = delimi[z, 1];
                    }
                }

                dataGVLexica.Rows.Add(fila);

            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dataGVLexica.Columns.Add("No.", "No.");
            dataGVLexica.Columns.Add("Línea", "Línea");
            dataGVLexica.Columns.Add("Token", "Token");
            dataGVLexica.Columns.Add("Tipo", "Tipo");
            dataGVLexica.Columns.Add("Código", "Código");

            dataGVIdentificadores.Columns.Add("Identificador", "Identificador");
            dataGVIdentificadores.Columns.Add("Valor", "Valor");
            dataGVIdentificadores.Columns.Add("Línea", "Línea");

            dataGVConstantes.Columns.Add("No.", "No.");
            dataGVConstantes.Columns.Add("Constante", "Constante");
            dataGVConstantes.Columns.Add("Tipo", "Tipo");
            dataGVConstantes.Columns.Add("Valor", "Valor");
        }
    }
}
