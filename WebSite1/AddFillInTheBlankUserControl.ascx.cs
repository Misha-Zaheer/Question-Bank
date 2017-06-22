using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddFillInTheBlankUserControl : System.Web.UI.UserControl
{
    //public FITB f = new FITB();
    //public List<FITB> list= new List<FITB>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Button2.Visible = true; // add
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Button1.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

        QuestionBankEntities qb = new QuestionBankEntities();
        QUESTION qt = new QUESTION();

        if (TextBox1.Text != null)
        {
            qt.QUESTIONTEXT = TextBox1.Text;
            TextBox1.Text = "";
        }

        qb.QUESTIONS.Add(qt);
        qb.SaveChanges();
        int id = qt.ID;
        ViewState["data"] = id;
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        QuestionBankEntities qb = new QuestionBankEntities();
        FILLINTHEBLANK ft = new FILLINTHEBLANK();

        int id = (int)(ViewState["data"]);
        if (TextBox2.Text != null)

        {
            ft.ANSWER = TextBox2.Text;
            TextBox2.Text = "";
        }

        ft.QUESTIONS = id;
        qb.FILLINTHEBLANKs.Add(ft);

        qb.SaveChanges();


        TextBox1.Visible = false;
        TextBox2.Visible = false;
        Label1.Visible = true;
        Label2.Visible = true;
        Label3.Visible = false;
        Label4.Visible = false;
    }

    protected void Label1_Load(object sender, EventArgs e)
    {
            Label1.Visible = true;     
    }

    protected void Label2_Load(object sender, EventArgs e)
    {
            Label2.Visible = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        QuestionBankEntities db = new QuestionBankEntities();
        FILLINTHEBLANK ft = new FILLINTHEBLANK();
        QUESTION qt = new QUESTION();

        Label1.Text = qt.QUESTIONTEXT;
        Label2.Text = ft.ANSWER;

       // db.QUESTIONS.Where(w => w.ID ).First();
        //List<Question> lst = db.Questions.Where(w => w.id > 1 && w.id < 10).ToList();
        //Question questiontoFetch = db.Questions.Where(w => w.id == 5).First();

        // submit
        //Label1.Text = f.Question;
        //Label2.Text = f.Answer;
        //if (Session["data"] != null)
        //{
        //    list = (List<FITB>)Session["data"];
        //}
        //if (f.Question != null && f.Answer != null)
        //{
        //    list.Add(f);
        //}
        //Session["data"] =list;

        Button1.Visible = false;
    }

    protected void Label4_Load(object sender, EventArgs e)
    {

    }

    protected void Label3_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //add
        TextBox1.Visible = true;
        TextBox2.Visible = true;
        Label3.Visible = true;
        Label4.Visible = true;
        Button1.Visible = true;
        Label1.Text = "";
        Label2.Text = "";
    }
}