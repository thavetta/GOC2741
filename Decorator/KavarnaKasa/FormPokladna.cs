using Napoje;

namespace KavarnaKasa;

public partial class FormPokladna : Form
{
    private Napoj napoj;
    public FormPokladna()
    {
        InitializeComponent();
        btnTurek.Tag = typeof (Turek);
        btnBezKofein.Tag = typeof (BezKofein);
        btnEspresso.Tag = typeof (Espresso);
        btnCoko.Tag = typeof (Cokolada);
        btnMleko.Tag = typeof (Mleko);
        btnSlehacka.Tag = typeof (Slehacka);
        btnSoja.Tag = typeof (Soja);
    }


    #region Nepoužívané kódy, jen pro ukážku
    private void btnEspresso_Click(object sender, EventArgs e)
    {
        napoj = new Espresso();
        lstSeznam.Items.Clear();
        lstSeznam.Items.Add(napoj.Popis);
    }

    private void btnTurek_Click(object sender, EventArgs e)
    {
        napoj = new Turek();
        lstSeznam.Items.Clear();
        lstSeznam.Items.Add(napoj.Popis);
    }

    private void btnBezKofein_Click(object sender, EventArgs e)
    {
        napoj = new BezKofein();
        lstSeznam.Items.Clear();
        lstSeznam.Items.Add(napoj.Popis);
    }
    #endregion
    private void btnNapoj_Click(object sender, EventArgs e)
    {
        var button = sender as Button;
        napoj = Activator.CreateInstance((Type) button.Tag) as Napoj;
        lstSeznam.Items.Clear();
        lstSeznam.Items.Add(napoj.Popis);
    }
    #region Nepoužívané kódy, jen pro ukážku
    private void btnMleko_Click(object sender, EventArgs e)
    {
        napoj = new Mleko(napoj);
        lstSeznam.Items.Add(napoj.Popis);
    }

    private void btnSlehacka_Click(object sender, EventArgs e)
    {
        napoj = new Slehacka(napoj);
        lstSeznam.Items.Add(napoj.Popis);
    }

    private void btnSoja_Click(object sender, EventArgs e)
    {
        napoj = new Soja(napoj);
        lstSeznam.Items.Add(napoj.Popis);
    }

    private void btnCoko_Click(object sender, EventArgs e)
    {
        napoj = new Cokolada(napoj);
        lstSeznam.Items.Add(napoj.Popis);
    }
    #endregion
    private void btnPridavek_Click(object sender, EventArgs e)
    {
        var button = sender as Button;
        napoj = Activator.CreateInstance((Type)button.Tag,napoj) as Napoj;
        lstSeznam.Items.Add(napoj.Popis);
    }


    private void btnCena_Click(object sender, EventArgs e)
    {
        lblCena.Text = napoj.Cena().ToString("C");
    }

    
}